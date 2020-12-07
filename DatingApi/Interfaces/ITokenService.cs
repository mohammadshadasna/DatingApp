using API.Entities;

namespace DatingApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}