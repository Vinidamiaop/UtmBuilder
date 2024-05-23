using System.Net;
using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public partial class InvalidUrlException : Exception
    {
        private const string DefaultErrorMessage = "Invalid URL";
        public InvalidUrlException(string? message = DefaultErrorMessage)
            : base(message)
        {

        }

        public static void ThrowIfInvalid(string url, string? message = DefaultErrorMessage)
        {
            if (string.IsNullOrEmpty(url))
                throw new InvalidUrlException(message);

            if (!UrlRegex().IsMatch(url))
                throw new InvalidUrlException(message);
        }


        [GeneratedRegex(@"^(http|https|ftp|ftps|sftp)://(([a-zA-Z0-9][a-zA-Z0-9\-]{1,61}[a-zA-Z0-9]\.)+[a-zA-Z]{2,6}|localhost|([0-9]{1,3}\.){3}[0-9]{1,3})(:[0-9]{1,5})?(/([a-zA-Z0-9\-\._\?\,\'/\\\+&%\$#\=~])*)?(\?[a-zA-Z0-9\-\._\?\,\'/\\\+&%\$#\=~]*)?$")]
        private static partial Regex UrlRegex();
    }
}
