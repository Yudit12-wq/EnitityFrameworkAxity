
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model.Page
{
    [Table("Acciones")]
    public class ActionModel : BaseModel
    {
        [Key]
        [Column("Pk_Action")]
        public int Id { get; set; }
    }
}
