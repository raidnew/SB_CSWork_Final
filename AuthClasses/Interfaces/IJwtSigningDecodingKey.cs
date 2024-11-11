using Microsoft.IdentityModel.Tokens;

namespace CSFinal.Interfaces
{
    public interface IJwtSigningDecodingKey
    {
        SecurityKey GetKey();
    }
}
