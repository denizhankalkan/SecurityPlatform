
using System;
using SecurityPlatform.Models;

namespace SecurityPlatform.Services
{
    public interface ILoginControlService
    {
        Task<UserInfo> userInfo(int userId);

    }
}
