using ApiFacebook.ConsoleAut.EntityAutent;
using ApiFacebook.InfraData.Data;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFacebook.InfraData.Repository
{
    public class HotmartRepository: Conexao
    {

        public void LimparToken()
        {
            using (IDbConnection cn = Connection)
            {

                cn.Open();

                var listFriends = cn.Query<HotmartToken>("Select * From tblFriends").ToList();
                
            }
        }

    }
}
