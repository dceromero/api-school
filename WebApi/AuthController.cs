using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using WebApiSchool.Requests;
using WebApiSchool.Services;

namespace WebApiSchool.WebApi
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        private readonly UsuarioService service;
        public AuthController(UsuarioService _service)
        {
            this.service = _service;
        }

        private string GenerateJwtToken(string username)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Tu_Clave_Secreta_SuperSegura"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: "https://tuservidor.com",
                audience: "https://tuservidor.com",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost]
        [Route("login")]
        public HttpResponseMessage login(ReqUser reqUser)
        {
            var status = this.service.GetUsuario(reqUser) == null ? HttpStatusCode.Unauthorized : HttpStatusCode.OK;
            if (status == HttpStatusCode.Unauthorized)
            {
                return Request.CreateResponse(status, "Credenciales inválidas");
            }
            var token = GenerateJwtToken(reqUser.nombreUsu);
            return Request.CreateResponse(status, new
            {
                usuario = this.service.GetUsuario(reqUser),
                token = token
            });
        }


    }
}

