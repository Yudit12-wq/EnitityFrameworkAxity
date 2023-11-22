
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model.Menu
{
    [Table("Menu")]
    public class MenuModel : BaseModel
    {
        [Key]
        [Column("Pk_Menu")]
        public int Id { get; set; }
    }
}
