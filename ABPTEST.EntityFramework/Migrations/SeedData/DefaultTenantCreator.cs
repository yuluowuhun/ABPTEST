using System.Linq;
using ABPTEST.EntityFramework;
using ABPTEST.MultiTenancy;

namespace ABPTEST.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly ABPTESTDbContext _context;

        public DefaultTenantCreator(ABPTESTDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
