using System;
using System.Collections.Generic;
using Mono.GameMath;
using Trinity.Encore.Game.Entities;
using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.Partitioning
{
    class DynamicQuadTree : ISpacePartition
    {

        private Boolean isLeaf;

        // Dimensions of our partition
        private BoundingBox boundaries;
        private DynamicQuadTree[] childNodes;
        protected DynamicQuadTree parent;
        private Dictionary<EntityGuid, IWorldEntity> bucket;

        // Maximum number of entities before partition splits
        private int partitionThreshold = 35;

        // In order for node to rebalance, it's children 
        // have to have less than this entities.
        private int balanceThreshold = 20;

        public int NumEntities { get { return bucket.Count; } }
        public BoundingBox Boundaries { get { return boundaries; } }
        public float Length { get { return Boundaries.Max.X - Boundaries.Min.X; } }
        public float Width { get { return Boundaries.Max.Y - Boundaries.Min.Y; } }

        // Clockwise
        private const int NORTH_EAST = 0;
        private const int SOUTH_EAST = 1;
        private const int SOUTH_WEST = 2;
        private const int NORTH_WEST = 3;
        private const int CHILDREN_SIZE = 4;

        public DynamicQuadTree(BoundingBox bounds)
        {
            boundaries = bounds;
            isLeaf = true;
            bucket = new Dictionary<EntityGuid, IWorldEntity>();
        }


        // Returns child node that should contain entity,
        // BASED ON POSITION ONLY
        private DynamicQuadTree GetChildContaining(IWorldEntity e)
        {
            Contract.Requires(e != null);
            Contract.Ensures(Contract.Result<DynamicQuadTree>() != null);

            DynamicQuadTree node = null;
            foreach (var child in childNodes)
                if (child.Boundaries.Contains(e.Position).Equals(ContainmentType.Contains))
                    node = child;
            return node;
        }

        public bool AddEntity(IWorldEntity entity)
        {
            
            if (!isLeaf)
            {
                var node = GetChildContaining(entity);
                return node.AddEntity(entity);
            }

            if (bucket.Count < partitionThreshold)
            {
                bucket.Add(entity.Guid, entity);
                return true;
            }
            else
            {
                Partition();
                return AddEntity(entity);
            }
        }

        private void Partition()
        {
            Contract.Requires(isLeaf);

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

            var Max = Boundaries.Max;
            var Min = Boundaries.Min;
            float HalfX = Boundaries.Min.X + Length / 2;
            float HalfY = Boundaries.Min.Y + Width / 2;

            childNodes = new DynamicQuadTree[CHILDREN_SIZE];

            childNodes[NORTH_EAST] = new DynamicQuadTree(new BoundingBox(new Vector3(HalfX,HalfY,float.MinValue),
                                                                         new Vector3(Max.X,Max.Y,float.MaxValue)));

            childNodes[SOUTH_EAST] = new DynamicQuadTree(new BoundingBox(new Vector3(HalfX, Min.Y, float.MinValue),
                                                                         new Vector3(Max.X, HalfY, float.MaxValue)));

            childNodes[SOUTH_WEST] = new DynamicQuadTree(new BoundingBox(new Vector3(Min.X, Min.Y, float.MinValue),
                                                                         new Vector3(HalfX, HalfY, float.MaxValue)));

            childNodes[NORTH_WEST] = new DynamicQuadTree(new BoundingBox(new Vector3(Min.X, HalfY, float.MinValue),
                                                                         new Vector3(HalfX, Max.Y, float.MaxValue)));
            foreach (var n in childNodes)
                n.parent = this;

            isLeaf = false;

            var entities = bucket.Values;
            bucket = null;
            foreach (var e in entities)
                AddEntity(e);
        }

        public IEnumerable<IWorldEntity> FindEntities(Func<IWorldEntity, bool> criteria, BoundingBox searchArea, int maxCount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IWorldEntity> FindEntities(Func<IWorldEntity, bool> criteria, BoundingSphere searchArea, int maxCount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IWorldEntity> FindEntities(Func<IWorldEntity, bool> criteria, int maxCount)
        {
            throw new NotImplementedException();
        }

        public IWorldEntity FindEntity(Func<IWorldEntity, bool> criteria)
        {
            throw new NotImplementedException();
        }

        public IWorldEntity FindEntity(Func<IWorldEntity, bool> criteria, BoundingBox searchArea)
        {
            throw new NotImplementedException();
        }

        public IWorldEntity FindEntity(Func<IWorldEntity, bool> criteria, BoundingSphere searchArea)
        {
            throw new NotImplementedException();
        }

        public bool RemoveEntity(IWorldEntity entity)
        {

            if (isLeaf)
            {
                bucket.Remove(entity.Guid);
                entity.PostAsync(() => entity.Node = null);

                if (parent != null)
                    parent.BalanceIfNeeded();
                return true;
            }

            // Yeah, now we need to check if our children have it, and pass it on
            var node = GetChildContaining(entity);
            return node.RemoveEntity(entity);
        }

        public void BalanceIfNeeded()
        {

        }

    }
}
