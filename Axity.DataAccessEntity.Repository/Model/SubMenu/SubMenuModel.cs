
using Axity.DataAccessEntity.Entities.Model.Menu;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model.SubMenu
{
    [Table("SubMenu")]
    public class SubMenuModel : BaseModel
    {
        [Key]
        [Column("Pk_SubMenu")]
        public int Id { get; set; }

        [ForeignKey("Pk_Menu")]
        public int IdMenu { get; set; }

        public MenuModel Pk_Menu { get; set; }
    }
}
