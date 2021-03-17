using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTest
{
    [Flags]
    public enum Permissions
    {
        Read = 1,
        Edit = 2,
        Create = 4,
        Delete = 8

    }
}
