using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EF.DTO;
using EF.Helper;
using EF.Repositories.Interfaces;

namespace EF.Controllers
{
     [Route("api/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsDbRepository repository;

        public AccountsController(IAccountsDbRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto dto)
        {
            var result = await repository.RegisterAsync(dto);

            switch (result)
            {
                case DbAnswer.OK:
                    return Ok("Successfully registered!");
                case DbAnswer.PasswordLengthIsNotProper:
                    return BadRequest("Password should contain at least 6 characters!");
                case DbAnswer.UserIsAlreadyRegistered:
                    return BadRequest("User with the same login is alredy registered!");
                default:
                    return StatusCode(500);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto dto)
        {
            var result = await repository.LoginAsync(dto);

            switch (result.DbAnswer)
            {
                case DbAnswer.OK:
                    return Ok(result);
                case DbAnswer.BadPassword:
                    return Unauthorized("Entered password is wrong!");
                case DbAnswer.UserNotFound:
                    return Unauthorized("Entered login is not found!");
                default:
                    return Unauthorized();
            }
        }

        [HttpPost("updateAccessToken")]
        public async Task<IActionResult> UpdateAccessToken(RefreshTokenDto dto)
        {
            var result = await repository.UpdateAccessTokenAsync(dto);

            switch (result.DbAnswer)
            {
                case DbAnswer.OK:
                    return Ok(result);
                case DbAnswer.RefreshTokenIsExpired:
                    return BadRequest("Refresh token is expired!");
                case DbAnswer.UserNotFound:
                    return BadRequest("User is not found!");
                default:
                    return Unauthorized();
            }
        }
    }
}
