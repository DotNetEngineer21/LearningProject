using CoreOSR.EntityFrameworkCore;

namespace CoreOSR.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly CoreOSRDbContext _context;

        public InitialHostDbBuilder(CoreOSRDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
