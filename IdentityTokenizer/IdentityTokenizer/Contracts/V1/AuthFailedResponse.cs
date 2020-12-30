using System.Collections.Generic;

namespace IdentityTokenizer.Contracts.V1
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
