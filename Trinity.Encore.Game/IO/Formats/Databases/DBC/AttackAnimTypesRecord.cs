using System.Diagnostics.Contracts;

namespace Trinity.Encore.Game.IO.Formats.Databases.DBC
{
    [ContractVerification(false)]
    public sealed class AttackAnimTypesRecord : IClientDbRecord
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
