// <summary>
// <copyright file="IDatabaseContext.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessEntity.Entities.Context
{
    using Axity.DataAccessEntity.Entities.Model;
    using Axity.DataAccessEntity.Entities.Model.Menu;
    using Axity.DataAccessEntity.Entities.Model.Page;
    using Axity.DataAccessEntity.Entities.Model.Rols;
    using Axity.DataAccessEntity.Entities.Model.SubMenu;
    using Axity.DataAccessEntity.Entities.Model.User;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Interface IDataBaseContext.
    /// </summary>
    public interface IDatabaseContext
    {

        DbSet<UserModel> Users { get; set; }
        DbSet<RolModel> Rols { get; set; }
        DbSet<UserRolModel> UserRols { get; set; }

        DbSet<MenuModel> MenuModels { get; set; }
        DbSet<SubActionModel> SubActionModels { get; set; }
        DbSet<PageModel> PageModels { get; set; }
        DbSet<SubMenuModel> SubMenuModel { get; set; }
        DbSet<ActionModel> ActionModel { get; set; }
    }
}
