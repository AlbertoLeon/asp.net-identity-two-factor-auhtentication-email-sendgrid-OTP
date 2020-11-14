using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sso2.RazorPages
{
    public class Sso2Constants
    {
        public const string AuthorizationPolicy2Fa = "TwoFactorEnabled";
        /// <summary>
        /// Authentication Method Reference
        /// </summary>
        public const string AmrClaim = "amr";

        public class AmrOptions
        {
            /// <summary>
            /// Multi-Factor Authentication
            /// </summary>
            public const string Mfa = "mfa";

            /// <summary>
            /// Password Authentication
            /// </summary>
            public const string Pwd = "pwd";
        }

        public const string TokenName = "AuthenticatorKey";
    }
}
