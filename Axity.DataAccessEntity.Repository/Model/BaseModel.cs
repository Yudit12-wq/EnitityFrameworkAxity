
using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model
{
    public class BaseModel
    {
        [Column("Codigo")]
        public string Code { get; set; }

        [Column("Icono")]
        public string Icon { get; set; }

        [Column("Nombre")]
        public string Name { get; set; }

        [Column("Estado")]
        public bool Status { get; set; }
    }
}
