using IdentityTokenizer.Domain;
using System.Threading.Tasks;

namespace IdentityTokenizer.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationRequest> RegisterAsync(string email, string password);
        Task<AuthenticationRequest> LoginAsync(string email, string password);
        Task<AuthenticationRequest> RefreshTokenAsync(string token, string refreshToken);
    }
}