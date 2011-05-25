using Trinity.Encore.Game.Entities;
using Mono.GameMath;

namespace Trinity.Encore.Tests.Game
{ 
    internal class MockEntity : WorldEntity
    {
        readonly Vector3 _position;

        public override Vector3 Position { get { return _position; } }

        public MockEntity(Vector3 pos)
        {
            _position = pos;
        }
    }
}
