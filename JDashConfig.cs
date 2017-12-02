using JDash.NetCore.Api;
using JDash.NetCore.Models;
using Microsoft.AspNetCore.Http;

namespace jdash.netcore.tutorial {
    public class JDashConfig : BaseJDashConfigurator
    {

        public JDashConfig(HttpContext context) : base(context)
        {
        }

        // Use this method to get current user for current request.
        public override JDashPrincipal GetPrincipal()
        {
            return new JDashPrincipal("user name");
        }

        // Jdash NetCore library calls this method 
        // to get a provider instance.
        public override IJDashProvider GetProvider()
        {
            // Ensure you have a valid database.

            //string msSqlConnStr = "Data Source=.;Initial Catalog=DemoJDash;Integrated Security=SSPI;";
            //return new JDash.NetCore.Provider.MsSQL.JSQLProvider(msSqlConnStr);

            // if you are using MySql uncomment below lines.
            string mySqlConnStr = "Server=127.0.0.1;Database=jdash;Uid=root;Pwd=1;";
            return new JDash.NetCore.Provider.MySQL.JMySQLProvider(mySqlConnStr);

        }
    }

}


