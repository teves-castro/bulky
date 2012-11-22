using NUnit.Framework;
using bulky.Tests.Fixtures;

namespace bulky.Tests
{
    [TestFixture]
    public class MySqlBulkCopyTests : MySqlFixture
    {
        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(10000)]
        [TestCase(100000)]
        public void Bulk_copy_n_records_directly(int trials)
        {
            BulkCopyFixture.BulkCopyUsers(trials);
            BulkCopyFixture.BulkCopyUsers(trials, trace: true);
        }

        [TestCase(100)]
        [TestCase(1000)]
        public void Bulk_copy_n_records_with_consumer(int trials)
        {
            BulkCopyFixture.BulkCopyUsersWithConsumer(trials);
            BulkCopyFixture.BulkCopyUsersWithConsumer(trials, trace: true);
        }
    }
}