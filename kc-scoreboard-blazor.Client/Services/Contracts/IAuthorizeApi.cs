using kc_scoreboard_blazor.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kc_scoreboard_blazor.Client.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task Login(LoginParameters loginParameters);
        Task Logout();
        Task<UserInfo> GetUserInfo();
    }
}
