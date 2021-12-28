using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFacebook.InfraData.Data
{
    public class Conexao
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ApiFacebookConnection());
            }
        }


                public string ApiFacebookConnection()
        {
            string connectionString = "server=.;database=ApiFacebook;Integrated Security=True;";

            //  string connectionString = ConfigurationManager.ConnectionStrings["dtb_ApiFacebook"].ConnectionString;
                      
          
            return connectionString;
        }

    }

    

}
