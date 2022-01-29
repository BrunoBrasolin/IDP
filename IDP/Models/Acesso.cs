using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IDP.Models
{
    [Table("acessos")]
    public class Acesso
    {
        public Acesso(int id, int sistemaId, int usuarioId)
        {
            Id = id;
            SistemaId = sistemaId;
            UsuarioId = usuarioId;
        }

        [Key]
        [Column("acso_id")]
        public int Id { get; set; }

        [Column("stms_id")]
        [Required(ErrorMessage = "Sistema obrigatório")]
        public int SistemaId { get; set; }

        [Column("usua_id")]
        [Required(ErrorMessage = "Usuário obrigatório")]
        [DataType(DataType.Password)]
        public int UsuarioId { get; set; }
    }
}
