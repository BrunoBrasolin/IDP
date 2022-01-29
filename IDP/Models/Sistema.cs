using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IDP.Models
{
    [Table("sistemas")]
    public class Sistema
    {
        public Sistema(int id, string nomeSistema, string url)
        {
            Id = id;
            NomeSistema = nomeSistema;
            Url = url;
        }

        [Key]
        [Column("stms_id")]
        public int Id { get; set; }

        [Column("stms_sistema")]
        [Required(ErrorMessage = "Nome do sistema obrigatório")]
        public string NomeSistema { get; set; }

        [Column("stms_url")]
        [Required(ErrorMessage = "URL do sistema obrigatório")]
        public string Url { get; set; }
    }
}
