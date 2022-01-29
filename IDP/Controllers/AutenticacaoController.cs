﻿using Microsoft.AspNetCore.Http;
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
        public ObjectResult Login(string login, string senha)
        {
            var usuario = _context.Usuario.First(u => u.Login.Equals(login) && u.Senha.Equals(senha));


            if (usuario != null)
                return StatusCode(StatusCodes.Status200OK, "Sucesso ao fazer login");
            else
                return StatusCode(StatusCodes.Status401Unauthorized, "Erro ao fazer login");
        }

        // POST api/Autenticacao/ValidaToken
        [HttpPost("ValidaToken")]
        public string ValidaToken(string token)
        {
            return "";
        }
    }
}
