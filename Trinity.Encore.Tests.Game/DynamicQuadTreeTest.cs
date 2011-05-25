using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trinity.Encore.Game.Partitioning;
using Trinity.Encore.Game.Entities;
using Mono.GameMath;

namespace Trinity.Encore.Tests.Game
{
    [TestClass]
    public class DynamicQuadTreeTest
    {

        private DynamicQuadTree _tree;
        private Random _r;
        private List<IWorldEntity> _mockEntities;

        [TestInitialize]
        public void TestInit()
        {
            _tree = new DynamicQuadTree(new BoundingBox(new Vector3(0, 0, float.MinValue),
                                                       new Vector3(100000, 100000, float.MaxValue)));
            _r = new Random();
            _mockEntities = new List<IWorldEntity>();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _tree = null;
            _r = null;
            _mockEntities = null;
        }

        [TestMethod]
        public void TestPartitioning()
        {
            AddMockEntities(_tree.PartitionThreshold + 20);

            Assert.AreEqual(_tree.IsLeaf, false, 
                            "After adding more than PartitionThreshold entities, tree should partition");
            CheckChildrenEntityCount(_tree);
            AddMockEntities(100);
            CheckChildrenEntityCount(_tree);
        }

        [TestMethod]
        public void TestEntityAmountTracking()
        {
            for (int i = 0; i < 200; i++)
            {
                AddMockEntities(200);
                CheckChildrenEntityCount(_tree);
                RemoveMockEntities(20);
                CheckChildrenEntityCount(_tree);
            }
        }

        [TestMethod]
        public void TestEntitySearching()
        {
            AddMockEntities(50000);
            var entityToFind = _mockEntities.First();
            var pos = entityToFind.Position;
            var pointMin = new Vector3(pos.X - 100, pos.Y - 100, float.MinValue);
            var pointMax = new Vector3(pos.X + 100, pos.Y + 100, float.MaxValue);
            var searchbound = new BoundingBox(pointMin, pointMax);
            var res = _tree.FindEntities(x => searchbound.Contains(x.Position) == ContainmentType.Contains, searchbound);
            Assert.AreEqual(true, res.Contains(entityToFind));
        }

        [TestMethod]
        public void TestTreeRebalancing()
        {
            AddMockEntities(50000);
            CheckChildrenEntityCount(_tree);
            RemoveMockEntities(49990);
            Assert.AreEqual(true, _tree.IsLeaf);
        }

        private static int CheckChildrenEntityCount(DynamicQuadTree node)
        {
            if (!node.IsLeaf)
            {
                var reportedAmount = node.NumEntities;
                var calculatedAmount = node.Children.Sum(c => CheckChildrenEntityCount(c));
                Assert.AreEqual(reportedAmount, calculatedAmount);
                return calculatedAmount;
            }
            return node.NumEntities;
        }

        private void AddMockEntities(int amount)
        {
            var entities = ProduceMockEntities(amount);
            _mockEntities.AddRange(entities);
            foreach (var e in entities)
                _tree.AddEntity(e);
        }

        private void RemoveMockEntities(int amount)
        {
            var entitiesToRemove = new List<IWorldEntity>(_mockEntities.Take(amount));

            foreach (var e in entitiesToRemove)
            {
                _tree.RemoveEntity(e);
                _mockEntities.Remove(e);
            }
        }
        private IEnumerable<IWorldEntity> ProduceMockEntities(int amount)
        {
            return ProduceMockEntities(_tree.Boundaries.Min, _tree.Boundaries.Max, amount);
        }

        private IEnumerable<IWorldEntity> ProduceMockEntities(Vector3 min, Vector3 max, int amount)
        {
            // NOTE: Unused parameters min, max
            var ret = new List<IWorldEntity>();

            // The feared arrow operator
            while (amount --> 0)
            {
                var e = new MockEntity(RandVec3());
                ret.Add(e);
            }

            return ret;
        }

        private float Rand(float min, float max)
        {
            var val =  (float)_r.NextDouble();
            return (((max - min) * val) + min);
        }

        private Vector3 RandVec3(Vector3 min, Vector3 max)
        {
            float x = Rand(min.X, max.X);
            float y = Rand(min.Y, max.Y);
            float z = Rand(min.Z, max.Z);
            return new Vector3(x, y, z);
        }

        private Vector3 RandVec3()
        {
            return RandVec3(_tree.Boundaries.Min, _tree.Boundaries.Max);
        }

    }
}
