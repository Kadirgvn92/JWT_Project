using JWT_Project.Models;

namespace JWT_Project.Interfaces;

public interface IAuthService
{
    public Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request);
}
