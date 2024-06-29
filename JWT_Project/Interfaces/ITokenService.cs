using JWT_Project.Models;

namespace JWT_Project.Interfaces;

public interface ITokenService
{
    public Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest request);
}
