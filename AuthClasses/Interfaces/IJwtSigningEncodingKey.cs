using Microsoft.IdentityModel.Tokens;

namespace CSFinal.Interfaces
{
    public interface IJwtSigningEncodingKey
    {
        string SigningAlgorithm { get; }

        SecurityKey GetKey();
    }
}
