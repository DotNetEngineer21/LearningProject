using CoreOSR.EntityFrameworkCore;

namespace CoreOSR.Test.Base.TestData
{
    public class TestDataBuilder
    {
        private readonly CoreOSRDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(CoreOSRDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();
            new TestEditionsBuilder(_context).Create();

            _context.SaveChanges();
        }
    }
}
