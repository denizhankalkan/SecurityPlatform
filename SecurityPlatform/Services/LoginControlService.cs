using System;
using SecurityPlatform.Models;

namespace SecurityPlatform.Services
{
    public class LoginControlService : ILoginControlService
    {

        //private readonly ILoginControl loginControl;

        public LoginControlService()
        {
        }

        public Task<UserInfo> checkPassword(int userId)
        {
            var userPassword = 123;
            var userPasswordList = LockRecursionPolicy.get(parameters);

        
        }

        public void CalculateExprationTime(string code)
        {
            var expirationTime = DateTimeOffset.UtcNow.AddHours(-24);
            return authContext.getLogs.Where(x => x.code === code).FirstOrDefault();

        }
    }
}

