using Microsoft.Owin;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin.Security;
using Microsoft.IdentityModel.Tokens;
using Owin;
using System.Text;

[assembly: OwinStartup(typeof(WebApiJWT.Startup))]
namespace WebApiJWT
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var key = Encoding.UTF8.GetBytes("Tu_Clave_Secreta_SuperSegura");

            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
            {
                AuthenticationMode = AuthenticationMode.Active,
                TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "https://tuservidor.com",
                    ValidAudience = "https://tuservidor.com",
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                }
            });
        }
    }
}
