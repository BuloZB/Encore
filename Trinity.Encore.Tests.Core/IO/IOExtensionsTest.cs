using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trinity.Core.IO;
using Mono.GameMath;

namespace Trinity.Encore.Tests.Core.IO
{
    [TestClass]
    public sealed class IOExtensionsTest
    {
        private MemoryStream _stream;

        private BinaryReader _reader;

        private BinaryWriter _writer;

        private void Reset()
        {
            _stream.Position = 0;
        }

        [TestInitialize]
        public void Initialize()
        {
            _stream = new MemoryStream(new byte[4096]);
            _reader = new BinaryReader(_stream);
            _writer = new BinaryWriter(_stream);
        }

        [TestMethod]
        public void TestCString()
        {
            _writer.WriteCString("ENCR");
            _writer.WriteCString("ENCR", Encoding.UTF8);

            Reset();

            var newStr = _reader.ReadCString();
            var newUtfStr = _reader.ReadCString();

            Assert.AreEqual("ENCR", newStr);
            Assert.AreEqual("ENCR", newUtfStr);
        }

        [TestMethod]
        public void TestFourCC()
        {
            _writer.WriteFourCC("ENCR");

            Reset();

            var new4CC = _reader.ReadFourCC();

            Assert.AreEqual("ENCR", new4CC);
        }

        [TestMethod]
        public void TestIsRead()
        {
            _reader.ReadBytes(4096);
            var isRead = _reader.BaseStream.IsRead();

            Assert.IsTrue(isRead);
        }

        [TestMethod]
        public void TestBigEndian()
        {
            _writer.WriteBigEndian(short.MaxValue);
            _writer.WriteBigEndian(ushort.MaxValue);
            _writer.WriteBigEndian(int.MaxValue);
            _writer.WriteBigEndian(uint.MaxValue);
            _writer.WriteBigEndian(long.MaxValue);
            _writer.WriteBigEndian(ulong.MaxValue);

            Reset();

            var shortMax = _reader.ReadInt16BigEndian();
            var ushortMax = _reader.ReadUInt16BigEndian();
            var intMax = _reader.ReadInt32BigEndian();
            var uintMax = _reader.ReadUInt32BigEndian();
            var longMax = _reader.ReadInt64BigEndian();
            var ulongMax = _reader.ReadUInt64BigEndian();

            Assert.AreEqual(short.MaxValue, shortMax);
            Assert.AreEqual(ushort.MaxValue, ushortMax);
            Assert.AreEqual(int.MaxValue, intMax);
            Assert.AreEqual(uint.MaxValue, uintMax);
            Assert.AreEqual(long.MaxValue, longMax);
            Assert.AreEqual(ulong.MaxValue, ulongMax);
        }

        [TestMethod]
        public void TestVectors()
        {
            var vec2 = new Vector2(float.MaxValue, float.MinValue);
            var vec3 = new Vector3(float.MaxValue, float.MinValue, float.PositiveInfinity);
            var vec4 = new Vector4(float.MaxValue, float.MinValue, float.PositiveInfinity, float.NegativeInfinity);

            _writer.WriteVector2(vec2);
            _writer.WriteVector3(vec3);
            _writer.WriteVector4(vec4);

            Reset();

            var v2 = _reader.ReadVector2();
            var v3 = _reader.ReadVector3();
            var v4 = _reader.ReadVector4();

            Assert.AreEqual(vec2, v2);
            Assert.AreEqual(vec3, v3);
            Assert.AreEqual(vec4, v4);
        }
    }
}
