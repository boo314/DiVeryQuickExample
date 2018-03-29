using DIPGNET.Implementatios;
using DIPGNET.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPGNET
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();

            kernel.Bind<IAuthorize>().To<FacebookAuthenticationProvider>();
            kernel.Bind<IDbConnection>().To<DbConnection>();

            IAuthorize authorize = kernel.Get<IAuthorize>();

            var isAuthorized = authorize.Authorize("mojLogin", "mojeHaslo");
        }
    }
}
