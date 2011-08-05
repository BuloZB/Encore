using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class WowErrorStringsRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public string EnumString { get; set; }  // Looks like an enum definition

        public string Text { get; set; }        // The actual string, different for different locales
    }
}
