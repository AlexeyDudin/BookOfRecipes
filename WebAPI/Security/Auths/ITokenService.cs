using WebAPI.Dto;

namespace WebAPI.Security.Auths
{
    public interface ITokenService
    {
        string GenerateToken( UserLoginDto userLoginDto );
    }
}
