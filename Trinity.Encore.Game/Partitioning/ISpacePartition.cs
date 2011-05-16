using System;
using System.Collections.Generic;
using Mono.GameMath;
using Trinity.Encore.Game.Entities;


namespace Trinity.Encore.Game.Partitioning
{
    public interface ISpacePartition
    {
        bool AddEntity(IWorldEntity entity);
        IEnumerable<IWorldEntity> FindEntities(Func<IWorldEntity, bool> criteria, BoundingBox searchArea, int maxCount);
        IEnumerable<IWorldEntity> FindEntities(Func<IWorldEntity, bool> criteria, BoundingSphere searchArea, int maxCount);
        IEnumerable<IWorldEntity> FindEntities(Func<IWorldEntity, bool> criteria, int maxCount);
        IWorldEntity FindEntity(Func<IWorldEntity, bool> criteria);
        IWorldEntity FindEntity(Func<IWorldEntity, bool> criteria, BoundingBox searchArea);
        IWorldEntity FindEntity(Func<IWorldEntity, bool> criteria, BoundingSphere searchArea);
        bool RemoveEntity(IWorldEntity entity);
    }
}
