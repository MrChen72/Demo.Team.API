using Demo3s.Model.Goods;
using Demo3s.Model.MyData;
using Demo3s.Model.RBAC;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Demo3s.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class Demo3sDbContext : 
        AbpDbContext<Demo3sDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */
        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion
        
        public Demo3sDbContext(DbContextOptions<Demo3sDbContext> options)
            : base(options)
        {

        }

        public DbSet<MyUserModel> MyUserModel { get; set; }

        public DbSet<RPowerModel> RPowerModel { get; set; }
        public DbSet<RPowerRoleModel> RPowerRoleModel { get; set; }
        public DbSet<RRoleModel> RRoleModel { get; set; }
        public DbSet<RTreeModel> RTreeModel { get; set; }
        public DbSet<RUserModel> RUserModel { get; set; }
        public DbSet<RUserRoleModel> RUserRoleModel { get; set; }


        public DbSet<MCategoryModel> MCategoryModel { get; set; }
        public DbSet<MCityModel> MCityModel { get; set; }
        public DbSet<MFileImg> MFileImg { get; set; }
        public DbSet<MGoodsModel> MGoodsModel { get; set; }
        public DbSet<MLogisticsModel> MLogisticsModel { get; set; }
        public DbSet<MOrderFormModel> MOrderFormModel { get; set; }
        public DbSet<MShoppingModel> MShoppingModel { get; set; }
        public DbSet<MSpecificationModel> MSpecificationModel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Demo3sConsts.DbTablePrefix + "YourEntities", Demo3sConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<MyUserModel>(x => { x.ToTable("MyUserModel"); });

            #region
            builder.Entity<RPowerModel>(o => { o.ToTable("RPowerModel"); });
            builder.Entity<RPowerRoleModel>(o => { o.ToTable("RPowerRoleModel"); });
            builder.Entity<RRoleModel>(o => { o.ToTable("RRoleModel"); });
            builder.Entity<RTreeModel>(o => { o.ToTable("RTreeModel"); });
            builder.Entity<RUserModel>(o => { o.ToTable("RUserModel"); });
            builder.Entity<RUserRoleModel>(o => { o.ToTable("RUserRoleModel"); });


            builder.Entity<MCategoryModel>(o => { o.ToTable("MCategoryModel"); });
            builder.Entity<MCityModel>(o => { o.ToTable("MCityModel"); });
            builder.Entity<MFileImg>(o => { o.ToTable("MFileImg"); });
            builder.Entity<MGoodsModel>(o => { o.ToTable("MGoodsModel"); });
            builder.Entity<MLogisticsModel>(o => { o.ToTable("MLogisticsModel"); });
            builder.Entity<MOrderFormModel>(o => { o.ToTable("MOrderFormModel"); });
            builder.Entity<MShoppingModel>(o => { o.ToTable("MShoppingModel"); });
            builder.Entity<MSpecificationModel>(o => { o.ToTable("MSpecificationModel"); });
            #endregion
        }
    }
}
