﻿using EF.Helper;

namespace EF.Helper
{
    public class LoginHelper
    {
        public DbAnswer DbAnswer { get; set; }
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }

        public LoginHelper() {}

        public LoginHelper(DbAnswer dbAnswer)
        {
            DbAnswer = dbAnswer;
        }

        public LoginHelper(DbAnswer dbAnswer, string accessToken, string refreshToken) : this(dbAnswer)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
    }
}