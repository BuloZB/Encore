using System;
using System.Globalization;
using System.Linq;
using Trinity.Core.Security;
using Trinity.Encore.Game.Commands;
using Trinity.Encore.Game.Security;

namespace Trinity.Encore.AccountService.Commands.Database
{
    [Command("CreateDb", "RecreateDb", "DbCreate", "DbRecreate")]
    public sealed class CreateDatabaseCommand : Command
    {
        public override string Description
        {
            get { return "Creates (or recreates) the database schema."; }
        }

        public override Type RequiredPermission
        {
            get { return typeof(ConsolePermission); }
        }

        public override void Execute(CommandArguments args, ICommandUser sender)
        {
            Console.WriteLine("Executing this command will permanently overwrite the entire database. Continue? (Y/N)");

            var answer = Console.ReadLine().ToUpper(CultureInfo.InvariantCulture).ToCharArray().FirstOrDefault();
            if (answer == 'Y')
                AccountApplication.Instance.AccountDbContext.PostAsync(x => x.Schema.Create());
        }
    }
}
