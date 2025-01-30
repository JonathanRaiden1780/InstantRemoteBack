using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using InstantRemote.Core.Dtos.Common.Request;
using Microsoft.IdentityModel.Tokens;

namespace InstantRemote.Core.Helpers.Security
{
    public static class JwtConfig
    {
        public static TokenDto ObtenerToken(string emplid, string secretKey, int minutos)
        {

            string hashscudId = emplid.RandomSeed().Encrypt();
            var claims = new List<Claim>()
                {                    
                    new Claim("", hashscudId),
                    new Claim(Constants.Timespan, DateTime.Now.Ticks.ToString())
                };

            var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credenciales = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);
            var expiracion = DateTime.UtcNow.AddMinutes(minutos);

            var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiracion, signingCredentials: credenciales);
            var token = new JwtSecurityTokenHandler().WriteToken(securityToken);            

            return new TokenDto { Token = token };
        }
        //public static res.TokenDto ObtenerToken(string username, string secretKey, int minutos)
        //{

        //    string hashscudId = username.Encrypt();
        //    var claims = new List<Claim>()
        //        {
        //            new Claim(Constants.Username, hashscudId),
        //            new Claim(Constants.Timespan, DateTime.Now.Ticks.ToString())
        //        };

        //    var llave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        //    var credenciales = new SigningCredentials(llave, SecurityAlgorithms.HmacSha256);
        //    var expiracion = DateTime.UtcNow.AddMinutes(minutos);

        //    var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiracion, signingCredentials: credenciales);
        //    var token = new JwtSecurityTokenHandler().WriteToken(securityToken);

        //    return new res.TokenDto { Token = token };
        //}

        public static string DesencriptarToken(this string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token);
            var tokenS = jsonToken as JwtSecurityToken;

            var cudId = tokenS.Claims.ToList().SingleOrDefault(x => x.Type == "").Value.Decrypt().GetSeed();

            return cudId;
        }
    }
}
