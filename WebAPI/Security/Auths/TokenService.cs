using Application.Users;
using Domain.Models.Users;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.Dto;

namespace WebAPI.Security.Auths
{
    public class TokenService : ITokenService
    {
        private readonly IUserService _userService;

        public TokenService( IUserService userService )
        {
            _userService = userService;
        }

        public string GenerateToken( UserLoginDto userLoginDto )
        {
            if ( userLoginDto == null )
            {
                return string.Empty;
            }

            User user = _userService.GetUserInfo( userLoginDto.Login, userLoginDto.Password );

            if ( user == null )
            {
                return string.Empty;
            }

            List<Claim> authClaims = new()
            {
                new( "userName", user.UserName),
                new( "login", user.Login ),
                new( JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString() ),
                new( "role", UserRole.User )
            };

            JwtSecurityToken token = GetToken( authClaims );
            return new JwtSecurityTokenHandler().WriteToken( token );
        }

        private JwtSecurityToken GetToken( List<Claim> authClaims )
        {
            SymmetricSecurityKey authSigningKey = new( Encoding.UTF8.GetBytes( AuthOptions.KEY ) );
            JwtSecurityToken token = new(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                expires: DateTime.Now.AddHours( 3 ),
                claims: authClaims,
                signingCredentials: new( authSigningKey, SecurityAlgorithms.HmacSha256 ) );

            return token;
        }
    }
}
