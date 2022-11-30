using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static delegatedemo.Program;

namespace delegatedemo
{
    public static class DelegateClass
    {
        public static string RegularMethod(Group1sDelegateType1 x, int y, string z)
        {
            // MarksDel returns a string and has 2 params, a int and a string.
            return x(y, z);
        }


        public static void EnvokeDelRegularMethod(Person p, int x, string y, Group1sDelegateType2 jumblies)
        {
            jumblies(p, x, y);
        }

        public static string RegularMethod(Func<int, string, string> x, int y, string z)
        {
            // MarksDel returns a string and has 2 params, a int and a string.
            return x(y, z);
        }
    }
}