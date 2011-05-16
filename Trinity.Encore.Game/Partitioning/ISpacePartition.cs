using System;
namespace Trinity.Encore.Game.Partitioning
{
    interface ISpacePartition
    {
        bool AddEntity(Trinity.Encore.Game.Entities.IWorldEntity entity);
        System.Collections.Generic.IEnumerable<Trinity.Encore.Game.Entities.IWorldEntity> FindEntities(Func<Trinity.Encore.Game.Entities.IWorldEntity, bool> criteria, Mono.GameMath.BoundingBox searchArea, int maxCount = QuadTree.NoMaxCount);
        System.Collections.Generic.IEnumerable<Trinity.Encore.Game.Entities.IWorldEntity> FindEntities(Func<Trinity.Encore.Game.Entities.IWorldEntity, bool> criteria, Mono.GameMath.BoundingSphere searchArea, int maxCount = QuadTree.NoMaxCount);
        System.Collections.Generic.IEnumerable<Trinity.Encore.Game.Entities.IWorldEntity> FindEntities(Func<Trinity.Encore.Game.Entities.IWorldEntity, bool> criteria, int maxCount = QuadTree.NoMaxCount);
        Trinity.Encore.Game.Entities.IWorldEntity FindEntity(Func<Trinity.Encore.Game.Entities.IWorldEntity, bool> criteria);
        Trinity.Encore.Game.Entities.IWorldEntity FindEntity(Func<Trinity.Encore.Game.Entities.IWorldEntity, bool> criteria, Mono.GameMath.BoundingBox searchArea);
        Trinity.Encore.Game.Entities.IWorldEntity FindEntity(Func<Trinity.Encore.Game.Entities.IWorldEntity, bool> criteria, Mono.GameMath.BoundingSphere searchArea);
        bool RemoveEntity(Trinity.Encore.Game.Entities.IWorldEntity entity);
    }
}
