using GigAuth.Domain.Entities;

namespace GigAuth.Domain.Security.Tokens;

public interface ITokenProvider
{
    public string Generate(User user);
}