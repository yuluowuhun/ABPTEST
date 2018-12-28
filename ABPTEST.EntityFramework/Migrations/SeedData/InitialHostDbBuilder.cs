using ABPTEST.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ABPTEST.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPTESTDbContext _context;

        public InitialHostDbBuilder(ABPTESTDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
