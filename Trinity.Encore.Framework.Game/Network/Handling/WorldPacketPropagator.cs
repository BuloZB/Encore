using System;
using System.Diagnostics.Contracts;
using System.Net;
using Trinity.Encore.Framework.Core.Exceptions;
using Trinity.Encore.Framework.Core.Logging;
using Trinity.Encore.Framework.Game.Network.Transmission;
using Trinity.Encore.Framework.Network.Connectivity;
using Trinity.Encore.Framework.Network.Handling;

namespace Trinity.Encore.Framework.Game.Network.Handling
{
    public sealed class WorldPacketPropagator : PacketPropagatorBase<WorldPacketHandlerAttribute, IncomingWorldPacket>
    {
        public const int HeaderSize = 2 + 4; // Length and opcode.

        public override int HeaderLength
        {
            get { return HeaderSize;  }
        }

        public override PacketHeader HandleHeader(IClient client, byte[] header)
        {
            Contract.Assume(header.Length == HeaderSize);

            var length = IPAddress.NetworkToHostOrder(unchecked((short)BitConverter.ToUInt16(header, 0)));
            Contract.Assume(length >= 0);

            var opCode = (int)BitConverter.ToUInt32(header, 2);
            Contract.Assume(opCode >= 0);

            return new PacketHeader(length, opCode);
        }

        protected override IncomingWorldPacket CreatePacket(int opCode, byte[] payload, int length)
        {
            return new IncomingWorldPacket((WorldServerOpCodes)opCode, payload, length);
        }
    }
}
