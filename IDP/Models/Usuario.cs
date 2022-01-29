using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IDP.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public Usuario(int id, string login, string senha)
        {
            Id = id;
            Login = login;
            Senha = senha;
        }

        [Key]
        [Column("usua_id")]
        public int Id { get; set; }

        [Column("usua_login")]
        [Required(ErrorMessage = "Login obrigatório")]
        public string Login { get; set; }

        [Column("usua_senha")]
        [Required(ErrorMessage = "Senha obrigatória")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
