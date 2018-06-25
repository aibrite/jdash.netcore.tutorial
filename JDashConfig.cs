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
        public override JDashPrincipal GetPrincipal(string authorizationHeader)
        {
            return new JDashPrincipal("tutorial-user");
        }

        // Jdash NetCore library calls this method 
        // to get a provider instance.
        public override IJDashProvider GetProvider()
        {
            // Ensure you have a valid database.

            // *** TO USE MSSQL ** //
            //string msSqlConnStr = "Server=10.0.2.15;Database=JDashTutorial;User Id=sa;Password=1.";
            //return new JDash.NetCore.Provider.MsSQL.JSQLProvider(msSqlConnStr);

            // *** TO USE MYSQL ** //
            string mySqlConnStr = "Server=127.0.0.1;SslMode=none;Database=jdash;Uid=root;Pwd=1;";
            return new JDash.NetCore.Provider.MySQL.JMySQLProvider(mySqlConnStr);

        }
    }

}


