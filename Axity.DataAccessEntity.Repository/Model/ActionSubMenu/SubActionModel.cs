
using Axity.DataAccessEntity.Entities.Model.SubMenu;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model.Page
{
    [Table("AccPagSubMenu")]
    public class SubActionModel : BaseModel
    {
        [Key]
        [Column("Pk_SubAccion")]
        public int IdSubActin { get; set; }

        [ForeignKey("Pk_Page")]
        public int IdPage { get; set; }

        public PageModel Pk_Page { get; set; }

        [ForeignKey("Pk_SubMenu")]
        public int IdSubMenu { get; set; }

        public SubMenuModel Pk_SubMenu { get; set; }

        [ForeignKey("Pk_Action")]
        public int IdAction { get; set; }

        public ActionModel Pk_Action { get; set; }
    }
}
