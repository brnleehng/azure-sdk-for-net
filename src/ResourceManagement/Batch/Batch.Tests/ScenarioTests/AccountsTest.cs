using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch.Tests.Helpers;
using Microsoft.Azure.Management.Batch;
using Microsoft.Azure.Management.Batch.Models;
using Microsoft.Rest;
using Xunit;

namespace Batch.Tests.ScenarioTests
{
    public class AccountsTest
    {
        [Fact]
        public void AccountCreateThrowsExceptions()
        {
            var handler = new RecordedDelegatingHandler();

            var client = BatchTestHelper.GetBatchManagementClient(handler);

            Assert.Throws<ValidationException>(() => client.Account.Create(null, "bar", new BatchAccountCreateParameters()));
        }
    }
}
