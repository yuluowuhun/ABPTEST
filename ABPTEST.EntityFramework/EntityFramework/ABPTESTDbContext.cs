using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using ABPTEST.Authorization.Roles;
using ABPTEST.Authorization.Users;
using ABPTEST.MultiTenancy;

namespace ABPTEST.EntityFramework
{
    public class ABPTESTDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPTESTDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPTESTDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPTESTDbContext since ABP automatically handles it.
         */
        public ABPTESTDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPTESTDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPTESTDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ABPNETCORE");
            base.OnModelCreating(modelBuilder);

        }
    }
}
