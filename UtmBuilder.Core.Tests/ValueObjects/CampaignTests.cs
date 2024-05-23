using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class CampaignTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidCampaignException))]
        [DataRow("", "", "")]
        [DataRow("newsletter", "", "")]
        [DataRow("", "Youtube", "")]
        [DataRow("", "", "Christmas Sale")]
        [DataRow("", "Youtube", "Christmas Sale")]
        [DataRow("newsletter", "Youtube", "")]
        [DataRow("newsletter", "", "Christmas Sale")]
        public void ShouldThrowInvalidCampaignExceptionWhenRequiredFieldsAreInvalid(string source, string medium, string name)
        {
            new Campaign(source, medium, name);
        }

        [TestMethod]
        [DataRow("newsletter", "Youtube", "Christmas Sale")]
        public void ShoulCreateCampaignWhenRequiredFieldsAreValid(string source, string medium, string name)
        {
            var campaign = new Campaign(source, medium, name);
            Assert.AreEqual(source, campaign.Source);
            Assert.AreEqual(medium, campaign.Medium);
            Assert.AreEqual(name, campaign.Name);
        }
    }
}