using ApiFacebook.Domain.Entity;
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
    public class FriendRepository: Conexao
    {
        

        public IList<Friend> GetFriends()
        {
            using (IDbConnection cn = Connection)
            {

                cn.Open();

                var listFriends  = cn.Query<Friend>("Select * From tblFriends").ToList();
                 
                /*var listFriends = cn.Query<Friend>("spr_cobra_ler_num_banco_log_proces_bolet",
                            commandType: CommandType.StoredProcedure).ToList(); */

                return listFriends;
            }
        }

        public void InsertFriend(Friend friend)
        {
            using (IDbConnection cn = Connection)

            {

                cn.Execute("spr_ins_friend",
                               new
                               {
                                   FriendName = friend.FriendName,
                                   City = friend.City,
                                   PhoneNumber = friend.PhoneNumber

                               },
                               commandType: CommandType.StoredProcedure);
                
            }

           
        }


    }
}
