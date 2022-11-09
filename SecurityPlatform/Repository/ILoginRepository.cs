using System;
namespace SecurityPlatform.Repository
{
    public interface ILoginRepository
    {

        List<int> loginCodes(List<int> loginCodes);

        List<string> GetAllRoles();
    }
}

