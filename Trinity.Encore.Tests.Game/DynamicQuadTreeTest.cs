using System;
using System.Text;
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

        private DynamicQuadTree tree;
        private Random r;
        private List<IWorldEntity> mockEntities;

        [TestInitialize]
        public void TestInit()
        {
            tree = new DynamicQuadTree(new BoundingBox(new Vector3(0, 0, float.MinValue),
                                                       new Vector3(100000, 100000, float.MaxValue)));
            r = new Random();
            mockEntities = new List<IWorldEntity>();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            tree = null;
            r = null;
            mockEntities = null;
        }

        [TestMethod]
        public void Test_Partitioning()
        {
            AddMockEntities(tree.PartitionThreshold + 20);

            Assert.AreEqual(tree.IsLeaf, false, 
                            "After adding more than PartitionThreshold entities, tree should partition");
            CheckChildrenEntityCount(tree);
            AddMockEntities(100);
            CheckChildrenEntityCount(tree);
        }

        [TestMethod]
        public void Test_Entity_Amount_Tracking()
        {
            for (int i = 0; i < 200; i++)
            {
                AddMockEntities(200);
                CheckChildrenEntityCount(tree);
                RemoveMockEntities(20);
                CheckChildrenEntityCount(tree);
            }
        }

        [TestMethod]
        public void Test_Entity_Searching()
        {
            AddMockEntities(50000);
            var entityToFind = mockEntities.First();
            var pos = entityToFind.Position;
            var pointMin = new Vector3(pos.X - 100, pos.Y - 100, float.MinValue);
            var pointMax = new Vector3(pos.X + 100, pos.Y + 100, float.MaxValue);
            var searchbound = new BoundingBox(pointMin, pointMax);
            var res = tree.FindEntities(x => searchbound.Contains(x.Position) == ContainmentType.Contains, searchbound);
            Assert.AreEqual(true, res.Contains(entityToFind));
        }

        [TestMethod]
        public void Test_Tree_Rebalancing()
        {
            AddMockEntities(50000);
            CheckChildrenEntityCount(tree);
            RemoveMockEntities(49990);
            Assert.AreEqual(true, tree.IsLeaf);
        }

        private int CheckChildrenEntityCount(DynamicQuadTree node)
        {
            if(node.IsLeaf)
                return node.NumEntities;
            var reportedAmount = node.NumEntities;
            var calculatedAmount = 0;
            foreach (var c in node.Children)
                calculatedAmount += CheckChildrenEntityCount(c);

            Assert.AreEqual(reportedAmount, calculatedAmount);
            return calculatedAmount;
        }

        private void AddMockEntities(int amount)
        {
            var entities = ProduceMockEntities(amount);
            mockEntities.AddRange(entities);
            foreach (var e in entities)
                tree.AddEntity(e);
        }

        private void RemoveMockEntities(int amount)
        {
            var entitiesToRemove = new List<IWorldEntity>(mockEntities.Take<IWorldEntity>(amount));

            foreach (var e in entitiesToRemove)
            {
                tree.RemoveEntity(e);
                mockEntities.Remove(e);
            }
        }
        private IEnumerable<IWorldEntity> ProduceMockEntities(int amount)
        {
            return ProduceMockEntities(tree.Boundaries.Min, tree.Boundaries.Max, amount);
        }

        private IEnumerable<IWorldEntity> ProduceMockEntities(Vector3 min, Vector3 max, int amount)
        {
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
            float val =  (float)r.NextDouble();
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
            return RandVec3(tree.Boundaries.Min, tree.Boundaries.Max);
        }

    }
}
