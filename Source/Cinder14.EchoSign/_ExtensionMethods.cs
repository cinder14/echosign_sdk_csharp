using Cinder14.EchoSign.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinder14.EchoSign
{
    public static class _ExtensionMethods
    {
        public static string For(this Scope scope, Modifier modifier)
        {
            return EchoSignOAuth.GenerateScope(scope, modifier); ;
        }
    }
}
