using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPGNET
{
    public interface IAuthorize
    {
        bool Authorize(string login, string password);
    }
}
