using EmployeeDB.Contexts;
using EmployeeDB.Options;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDB.ContextFactories
{
    public class ContextFactory : IContextFactory
    {
        private readonly DbContextOptions<Context> _options;

        public ContextFactory(OptionsDB options)
        {
            switch (options.DBType)
            {
                case DatabaseType.MSSQL:
                    _options = new DbContextOptionsBuilder<Context>().UseSqlServer(options.ConnectionString, opts =>
                        opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)).Options;
                    break;
                case DatabaseType.PostgreSQL:
                    _options = new DbContextOptionsBuilder<Context>().UseNpgsql(options.ConnectionString, opts =>
                        opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)).Options;
                    break;
                default:
                    throw new Exception($"Указанный '{nameof(options.DBType)}' - {options.DBType} не поддерживаеся!");

            }
        }

        public Context Create()
        {
            return new Context(_options);
        }
    }
}
