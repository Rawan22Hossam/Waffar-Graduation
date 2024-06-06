using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Waffar.Models;

namespace Waffar.Helper
{
    public class HelperClass
    {
        public static string CreatePasswordHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {

                return hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)).ToString();
            }
        }

        //public static string CreateToken(User user, string secretKey)
        //{
        //    List<Claim> claims = new List<Claim>
        //    {
        //         new Claim("UserId", user.Id.ToString()),
        //        new Claim(ClaimTypes.Name, user.Name),
        //        new Claim(ClaimTypes.Role, user.Roles.RoleName)
        //    };

        //    var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(secretKey));

        //    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        //    var token = new JwtSecurityToken(
        //        claims: claims,
        //        expires: DateTime.Now.AddDays(1),
        //        signingCredentials: creds);

        //    var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        //    return jwt;
        //}
    }
}
