using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IDP.Models;

namespace IDP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IDPContext _context;

        public AutenticacaoController(IDPContext context)
        {
            _context = context;
        }

        // POST: api/Autenticacao/Login
        [HttpPost("Login")]
        public ObjectResult Login(string login, string senha, int id)
        {
            Usuario usuario = _context.Usuario.FirstOrDefault(u => u.Login.Equals(login) && u.Senha.Equals(senha));
            if (usuario == null)
                return StatusCode(StatusCodes.Status401Unauthorized, "Erro ao fazer login");

            Sistema sistema = _context.Sistema.FirstOrDefault(s => s.Id.Equals(id));
            if (sistema == null)
                return StatusCode(StatusCodes.Status404NotFound, "Erro ao encontrar sistema");

            Acesso acesso = _context.Acesso.FirstOrDefault(a => a.UsuarioId.Equals(usuario.Id) && a.SistemaId.Equals(sistema.Id));
            if (acesso == null)
                return StatusCode(StatusCodes.Status401Unauthorized, $"Usuário {usuario.Login} sem acesso ao sistema {sistema.NomeSistema}");
            
            return StatusCode(StatusCodes.Status200OK, $"Usuario: {usuario.Login} | Sistema: {sistema.NomeSistema}");
        }
    }
}
