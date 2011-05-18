using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trinity.Encore.Game.Entities;
using Mono.GameMath;

namespace Trinity.Encore.Tests.Game
{ 
    internal class MockEntity : WorldEntity
    {
        Vector3 position;

        public override Vector3 Position { get { return position; } }

        public MockEntity(Vector3 pos)
        {
            position = pos;
        }
    }
}
