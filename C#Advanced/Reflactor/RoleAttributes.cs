using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflactor
{
    public class RoleAttribute : Attribute
    {
        public string Roles { get; private set; }

        public RoleAttribute(string roles)
        {
            Roles = roles;
        }
    }
}
