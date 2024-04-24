using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExamen1.Models
{
    [Table("PERSONAJESSERIES")]
    public class PersonajeSeries
    {

        [Key]
        [Column("IDPERSONAJE")]
        public int IdPersonaje { get; set; }
        [Column("Nombre")]
        public string Nombre { get; set; }
        [Column("IMAGEN")]
        public string Imagen { get; set; }
        [Column("SERIE")]
        public string Serie { get; set; }
    }
}
