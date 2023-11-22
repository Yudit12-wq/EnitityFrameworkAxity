
using Axity.DataAccessEntity.Entities.Model.SubMenu;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model.Page
{
    [Table("Page")]
    public class PageModel : BaseModel
    {
        [Key]
        [Column("Pk_Page")]
        public int IdPage { get; set; }

        [ForeignKey("Pk_SubMenu")]
        public int IdSubMenu { get; set; }

        public SubMenuModel Pk_SubMenu { get; set; }
    }
}
