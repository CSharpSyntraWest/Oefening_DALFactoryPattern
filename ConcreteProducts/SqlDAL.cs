using Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConcreteProducts
{
    public class SqlDAL : DALBaseClass
    {
        public SqlDAL() { }
        public SqlDAL(string connectionString) {
            this.ConnectionString = "Data Source=.;Initial Catalog=master;Integrated Security=true";
        }
        public override IDbCommand GeDataProviderCommand()
        {
            return new SqlCommand();
        }

        public override IDbConnection GetDataProviderConnection()
        {
            return new SqlConnection();
        }

        public override IDbDataAdapter GetDataProviderDataAdapter()
        {
            return new SqlDataAdapter();
        }
    }
}
