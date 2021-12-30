using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFacebook.ConsoleAut.EntityAutent
{
    public class HotmartToken


    
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
        public string scope { get; set; }
        public string jti { get; set; }

    }
}
