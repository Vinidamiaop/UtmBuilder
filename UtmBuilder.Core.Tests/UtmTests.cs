using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests
{
    [TestClass]
    public class UtmTests
    {
        private const string _baseUrl = "https://www.google.com";
        private const string _url = "https://www.google.com?utm_source=google&utm_medium=cpc&utm_campaign=spring_sale";
        private const string _urlCompleta = "https://www.google.com?utm_source=google&utm_medium=cpc&utm_campaign=spring_sale&utm_id=123&utm_term=termo&utm_content=content";

        [TestMethod]
        [DataRow(_url, "google", "cpc", "spring_sale", null, null, null)]
        [DataRow(_urlCompleta, "google", "cpc", "spring_sale", "123", "termo", "content")]
        public void ShouldReturnUrlFromUtmWhenImplicitConversionIsUsed(string link, string source, string medium, string name, string? id, string? term, string? content)
        {
            var url = new Url(_baseUrl);
            var campaign = new Campaign(source, medium, name, id, term, content);
            var utm = new Utm(url, campaign);

            string utmUrl = utm;

            Assert.AreEqual(link, utmUrl);
        }

        [TestMethod]
        [DataRow(_url)]
        [DataRow(_urlCompleta)]
        public void ShouldReturnUtmFromUrlWhenImplicitConversionIsUsed(string link)
        {
            Utm utm = link;
            Assert.AreEqual(link, utm.ToString());
        }
    }
}