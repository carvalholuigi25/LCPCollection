using LCPCollection.Server.Context;
using LCPCollection.Server.Interfaces.Auth;
using LCPCollection.Shared.Classes;
using LCPCollection.Shared.Classes.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LCPCollection.Server.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly DBContext _dbContext;
        private readonly ITokenService _tokenService;
        
        public TokenController(DBContext dbContext, ITokenService tokenService)
        {
            _dbContext = dbContext;
            _tokenService = tokenService;
        }

        /// <summary>
        /// This will refresh the token expired (or not).
        /// </summary>
        /// <param name="tokenApiModel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh(TokenApiModel tokenApiModel)
        {
            if (tokenApiModel is null)
                return BadRequest("Invalid client request");
            
            string accessToken = tokenApiModel.AccessToken!;
            string refreshToken = tokenApiModel.RefreshToken!;
            
            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
            var username = principal.Identity!.Name; //this is mapped to the Name claim by default
            var user = _dbContext.Users.SingleOrDefault(u => u.Username == username);

            if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                return BadRequest("Invalid client request");
            
            var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();
            
            user.CurrentToken = newAccessToken;
            user.RefreshToken = newRefreshToken;
            _dbContext.SaveChanges();
            
            return Ok(new AuthenticatedResponse()
            {
                Token = newAccessToken,
                RefreshToken = newRefreshToken
            });
        }

        /// <summary>
        /// This will revoke the current token generated.
        /// </summary>
        /// <returns></returns>
        [HttpPost, Authorize]
        [Route("revoke")]
        public IActionResult Revoke()
        {
            var username = User.Identity!.Name;
            var user = _dbContext.Users.SingleOrDefault(u => u.Username == username);

            if (user == null) return BadRequest();

            user.CurrentToken = null;
            user.RefreshToken = null;
            _dbContext.SaveChanges();
            
            return NoContent();
        }
    }
}
