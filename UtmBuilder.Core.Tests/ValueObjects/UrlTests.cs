using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        [TestMethod]
        [TestCategory("URL Tests")]
        [ExpectedException(typeof(InvalidUrlException))]
        [DataRow("invalid-url")]
        [DataRow(" ")]
        [DataRow("http://invalid-url")]
        public void ShouldReturnInvalidUrlExceptionWhenUrlIsInvalid(string link)
        {
            new Url(link);
        }

        [TestMethod]
        [TestCategory("URL Tests")]
        [DataRow("http://invalid-url.com")]
        [DataRow("https://invalid-url.com")]
        [DataRow("http://google.com.br")]
        [DataRow("https://google.com.br")]
        [DataRow("https://balta.io")]
        [DataRow("https://www.google.com?utm_source=google&utm_medium=cpc&utm_campaign=spring_sale")]
        public void ShouldReturnExceptionWhenUrlIsValid(string link)
        {
            var url = new Url(link);
            Assert.AreEqual(link, url.Address);
        }
    }
}
