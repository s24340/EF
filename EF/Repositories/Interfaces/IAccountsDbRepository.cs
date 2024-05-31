using System.Threading.Tasks;
using EF.DTO;
using EF.Helper;

namespace EF.Repositories.Interfaces
{
    public interface IAccountsDbRepository
    {
        public Task<DbAnswer> RegisterAsync(UserDto dto);
        public Task<LoginHelper> LoginAsync(UserDto dto);
        public Task<LoginHelper> UpdateAccessTokenAsync(RefreshTokenDto dto);
    }
}
