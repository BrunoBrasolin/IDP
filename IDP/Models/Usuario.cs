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
        [Required(ErrorMessage = "Login obrigatório")]
        [Column("usua_login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Senha obrigatória")]
        [Column("usua_senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
