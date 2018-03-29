using DIPGNET.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPGNET
{
    public class FacebookAuthenticationProvider : IAuthorize
    {
        private IDbConnection _dbConnection;

        public FacebookAuthenticationProvider(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool Authorize(string login, string password)
        {
            _dbConnection.Connect();
            return false;
        }
    }
}
