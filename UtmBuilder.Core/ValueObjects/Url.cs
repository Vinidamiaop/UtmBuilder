using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>
        public string Address { get; }

        /// <summary>
        /// Create a new url
        /// </summary>
        /// <param name="address">Address of URL (Website link)</param>
        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalid(address);
        }
    }
}
