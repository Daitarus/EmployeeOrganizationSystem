namespace EmployeeDB.Options
{
    public class OptionsDB
    {
        public DatabaseType DBType { get; set; }
        public string ConnectionString { get; set; }

        public OptionsDB(DatabaseType dBType, string connectionString)
        {
            DBType = dBType;
            ConnectionString = connectionString;
        }
    }

    public enum DatabaseType
    {
        MSSQL = 0,
        PostgreSQL = 1,
    }
}
