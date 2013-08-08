namespace StoneFinch.SmpMaintenance.Data
{
    public class DefaultConnectionStringProvider : IConnectionStringProvider
    {
        public DefaultConnectionStringProvider(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private string ConnectionString { get; set; }

        public string GetConnectionString()
        {
            return this.ConnectionString;
        }
    }
}