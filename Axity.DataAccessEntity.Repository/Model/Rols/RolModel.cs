﻿
using System.ComponentModel.DataAnnotations.Schema;

namespace Axity.DataAccessEntity.Entities.Model.Rols
{
    [Table("Roles")]
    public class RolModel
    {
        [Column("Pk_Rol")]
        public int Id { get; set; }

        [Column("Codigo")]
        public string Code { get; set; }

        [Column("Nombre")]
        public string Name { get; set; }

        [Column("Descripcion")]
        public string Description { get; set; }

        [Column("Estado")]
        public bool Status { get; set; }
       

        public int? UserId { get; set; }
    }
}
