﻿namespace IdentityTokenizer.Contracts.V1
{
    public class AuthSuccessResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
