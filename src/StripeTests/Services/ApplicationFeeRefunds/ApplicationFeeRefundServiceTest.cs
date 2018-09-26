namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class ApplicationFeeRefundServiceTest : BaseStripeTest
    {
        private const string ApplicationFeeId = "fee_123";
        private const string ApplicationFeeRefundId = "fr_123";

        private ApplicationFeeRefundService service;
        private ApplicationFeeRefundCreateOptions createOptions;
        private ApplicationFeeRefundUpdateOptions updateOptions;
        private ApplicationFeeRefundListOptions listOptions;

        public ApplicationFeeRefundServiceTest()
        {
            this.service = new ApplicationFeeRefundService();

            this.createOptions = new ApplicationFeeRefundCreateOptions
            {
                Amount = 123,
            };

            this.updateOptions = new ApplicationFeeRefundUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new ApplicationFeeRefundListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var applicationFeeRefund = this.service.Create(
                ApplicationFeeId,
                this.createOptions);
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var applicationFeeRefund = await this.service.CreateAsync(
                ApplicationFeeId,
                this.createOptions);
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public void Get()
        {
            var applicationFeeRefund = this.service.Get(ApplicationFeeId, ApplicationFeeRefundId);
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var applicationFeeRefund = await this.service.GetAsync(ApplicationFeeId, ApplicationFeeRefundId);
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public void List()
        {
            var applicationFeeRefunds = this.service.List(ApplicationFeeId, this.listOptions);
            Assert.NotNull(applicationFeeRefunds);
            Assert.Equal("list", applicationFeeRefunds.Object);
            Assert.Single(applicationFeeRefunds.Data);
            Assert.Equal("fee_refund", applicationFeeRefunds.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var applicationFeeRefunds = await this.service.ListAsync(ApplicationFeeId, this.listOptions);
            Assert.NotNull(applicationFeeRefunds);
            Assert.Equal("list", applicationFeeRefunds.Object);
            Assert.Single(applicationFeeRefunds.Data);
            Assert.Equal("fee_refund", applicationFeeRefunds.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var applicationFeeRefund = this.service.Update(
                ApplicationFeeId,
                ApplicationFeeRefundId,
                this.updateOptions);
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var applicationFeeRefund = await this.service.UpdateAsync(
                ApplicationFeeId,
                ApplicationFeeRefundId,
                this.updateOptions);
            Assert.NotNull(applicationFeeRefund);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }
    }
}