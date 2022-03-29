using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IDP.Models
{
    [Table("sistemas")]
    public class Sistema
    {
        public Sistema(int id, string nomeSistema, string dominio)
        {
            Id = id;
            NomeSistema = nomeSistema;
            Dominio = dominio;
        }

        [Key]
        [Column("stms_id")]
        public int Id { get; set; }

        [Column("stms_sistema")]
        [Required(ErrorMessage = "Nome do sistema obrigatório")]
        public string NomeSistema { get; set; }

        [Column("stms_dominio")]
        [Required(ErrorMessage = "Domínio do sistema obrigatório")]
        public string Dominio { get; set; }
    }
}
