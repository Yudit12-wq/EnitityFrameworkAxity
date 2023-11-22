// <summary>
// <copyright file="DatabaseContext.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessEntity.Entities.Context
{
    using Axity.DataAccessEntity.Entities.Data.Constraint;
    using Axity.DataAccessEntity.Entities.Model.Menu;
    using Axity.DataAccessEntity.Entities.Model.Page;
    using Axity.DataAccessEntity.Entities.Model.Rols;
    using Axity.DataAccessEntity.Entities.Model.SubMenu;
    using Axity.DataAccessEntity.Entities.Model.User;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Class DBcontext.
    /// </summary>
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseContext"/> class.
        /// </summary>
        /// <param name="options">Connection Options.</param>
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<RolModel> Rols { get; set; }
        public DbSet<UserRolModel> UserRols { get; set; }
        public DbSet<MenuModel> MenuModels { get; set; }
        public DbSet<SubActionModel> SubActionModels { get; set; }
        public DbSet<PageModel> PageModels { get; set; }
        public DbSet<SubMenuModel> SubMenuModel { get; set; }
        public DbSet<ActionModel> ActionModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserConstraint.Init(modelBuilder);
            RolConstraint.Init(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
