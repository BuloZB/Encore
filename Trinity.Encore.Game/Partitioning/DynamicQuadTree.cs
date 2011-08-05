using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Mono.GameMath;
using Trinity.Encore.Game.Entities;
using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.Partitioning
{
    public class DynamicQuadTree : ISpacePartition
    {
        private Boolean _isLeaf;

        // Dimensions of our partition
        private readonly BoundingBox _boundaries;
        private DynamicQuadTree[] _childNodes;
        protected DynamicQuadTree Parent;
        private List<IWorldEntity> _bucket;

        // Maximum number of entities before partition splits
        private readonly int _partitionThreshold = 35;

        // In order for node to rebalance, it's children 
        // have to have less than this entities.
        private readonly int _balanceThreshold = 20;
        private int _numEntities;

        public int NumEntities { get { return _isLeaf ? _bucket.Count : _numEntities; } }
        public BoundingBox Boundaries { get { return _boundaries; } }
        public float Length { get { return Boundaries.Max.X - Boundaries.Min.X; } }
        public float Width { get { return Boundaries.Max.Y - Boundaries.Min.Y; } }
        public List<IWorldEntity> Bucket { get { return _bucket; } }

        // These are only here for test suite, 
        // If you find yourself using them outside of tests you better have a good reason.
        public bool IsLeaf { get { return _isLeaf; } }
        public int PartitionThreshold { get { return _partitionThreshold; } }
        public int BalanceThreshold { get { return _balanceThreshold; } }
        public DynamicQuadTree[] Children { get { return _childNodes; } }
        public override String ToString()
        {
            return string.Format(CultureInfo.InvariantCulture,
                IsLeaf ? "Leaf, {0} entities in bucket" : "Not leaf, {0} entities in childnodes", NumEntities);
        }

        // Clockwise
        private const int NorthEast = 0;
        private const int SouthEast = 1;
        private const int SouthWest = 2;
        private const int NorthWest = 3;
        private const int ChildrenSize = 4;

        public DynamicQuadTree(BoundingBox bounds)
        {
            _boundaries = bounds;
            _isLeaf = true;
            _bucket = new List<IWorldEntity>();
            _numEntities = 0;
        }


        // Returns child node that should contain entity,
        // BASED ON POSITION ONLY
        private DynamicQuadTree GetChildContaining(IWorldEntity e)
        {
            Contract.Requires(e != null);
            Contract.Ensures(Contract.Result<DynamicQuadTree>() != null);

            DynamicQuadTree node = null;
            foreach (var child in _childNodes)
// ReSharper disable PossibleNullReferenceException
                if (child.Boundaries.Contains(e.Position).Equals(ContainmentType.Contains))
// ReSharper restore PossibleNullReferenceException
                    node = child;
            return node;
        }

        public bool AddEntity(IWorldEntity entity)
        {
            
            if (!_isLeaf)
            {
                var node = GetChildContaining(entity);
                _numEntities++;
                return node.AddEntity(entity);
            }

            if (_bucket.Count < _partitionThreshold)
            {
                _bucket.Add(entity);
                entity.PostAsync(() => entity.Node = this);
                return true;
            }

            Partition();
            return AddEntity(entity);
        }

        private void Partition()
        {
            Contract.Requires(_isLeaf);

            /* 
             * 
             * Min.X  HalfX Max.X
             * +------------+ Max.Y
             * |      |     |
             * |      |     |
             * |------------| HalfY
             * |      |     |
             * |      |     |
             * +------------+ Min.Y
             * 
             * Since we are using 3d bounding boxes,
             * but Quadtree itself is 2d, let's just
             * use float.MinValue and float.MaxValue
             * so our Contains() check are true for 
             * whatever height entity is in.
             * 
             * My mother always told me i can't be an artist,
             * i think she was right.
             */

            var max = Boundaries.Max;
            var min = Boundaries.Min;
            float halfX = Boundaries.Min.X + Length / 2;
            float halfY = Boundaries.Min.Y + Width / 2;

            _childNodes = new DynamicQuadTree[ChildrenSize];

            _childNodes[NorthEast] = new DynamicQuadTree(new BoundingBox(new Vector3(halfX,halfY,float.MinValue),
                                                                         new Vector3(max.X,max.Y,float.MaxValue)));

            _childNodes[SouthEast] = new DynamicQuadTree(new BoundingBox(new Vector3(halfX, min.Y, float.MinValue),
                                                                         new Vector3(max.X, halfY, float.MaxValue)));

            _childNodes[SouthWest] = new DynamicQuadTree(new BoundingBox(new Vector3(min.X, min.Y, float.MinValue),
                                                                         new Vector3(halfX, halfY, float.MaxValue)));

            _childNodes[NorthWest] = new DynamicQuadTree(new BoundingBox(new Vector3(min.X, halfY, float.MinValue),
                                                                         new Vector3(halfX, max.Y, float.MaxValue)));
            foreach (var n in _childNodes)
                n.Parent = this;

            _isLeaf = false;

            foreach (var e in _bucket)
                AddEntity(e);
            
            _bucket = null;

            _numEntities = 0;
            foreach (var c in _childNodes)
                _numEntities += c.NumEntities;
        }

        public IEnumerable<IWorldEntity> FindEntities(Func<IWorldEntity, bool> criteria, BoundingBox searchArea, int maxCount = -1)
        {
            var ret = new List<IWorldEntity>();
            Search(criteria, ret, x =>  x.Boundaries.Contains(searchArea) != ContainmentType.Disjoint);
            return ret;
        }

        public IEnumerable<IWorldEntity> FindEntities(Func<IWorldEntity, bool> criteria, BoundingSphere searchArea, int maxCount = -1)
        {
            var ret = new List<IWorldEntity>();
            Search(criteria, ret, x => x.Boundaries.Contains(searchArea) != ContainmentType.Disjoint);
            return ret;
        }

        public IWorldEntity FindEntity(Func<IWorldEntity, bool> criteria, BoundingBox searchArea)
        {
            return FindEntities(criteria, searchArea, 1).SingleOrDefault();
        }

        public IWorldEntity FindEntity(Func<IWorldEntity, bool> criteria, BoundingSphere searchArea)
        {
            return FindEntities(criteria, searchArea, 1).SingleOrDefault();
        }

        public bool RemoveEntity(IWorldEntity entity)
        {

            if (_isLeaf)
            {
                _bucket.Remove(entity);
                entity.PostAsync(() => entity.Node = null);

                if (Parent != null)
                    Parent.BalanceIfNeeded();
                return true;
            }

            // Yeah, now we need to check if our children have it, and pass it on
            var node = GetChildContaining(entity);
            _numEntities--;
            return node.RemoveEntity(entity);
        }

        public void BalanceIfNeeded()
        {

            if (NumEntities > _balanceThreshold)
                return;

            var ent = new List<IWorldEntity>();
            foreach (var c in _childNodes)
                ent.AddRange(c.Bucket);
            _childNodes = null;
            _isLeaf = true;
            _bucket = ent;
            _numEntities = 0;
        }

        public void Search(Func<IWorldEntity, bool> criteria, 
                            List<IWorldEntity> result, 
                            Func<DynamicQuadTree, bool> inclusionTest,
                            int maxCount = -1)
        {
            Contract.Requires(criteria != null);
            Contract.Requires(result != null);

            if (_isLeaf)
            {
// ReSharper disable PossibleNullReferenceException
// ReSharper disable AssignNullToNotNullAttribute
                result.AddRange(_bucket.Where(criteria));
// ReSharper restore AssignNullToNotNullAttribute
// ReSharper restore PossibleNullReferenceException
            }
            else
            {
                foreach (var n in _childNodes)
                    if (inclusionTest(n))
                        n.Search(criteria, result, inclusionTest);
            }
        }

    }
}
