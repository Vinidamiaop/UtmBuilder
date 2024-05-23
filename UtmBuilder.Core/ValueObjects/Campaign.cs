using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign
    {

        /// <summary>
        /// The referrer (e.g. google, newsletter)
        /// </summary>
        public string Source { get; }
        /// <summary>
        /// Marketing medium (e.g. cpc, banner, email)
        /// </summary>
        public string Medium { get; }
        /// <summary>
        /// Product, promo code, or slogan (e.g. spring_sale)
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The ads campain id.
        /// </summary>
        public string? Id { get; }
        /// <summary>
        /// Identify the paid keywords
        /// </summary>
        public string? Term { get; }
        /// <summary>
        /// Use to differentiate ads
        /// </summary>
        public string? Content { get; }

        /// <summary>
        /// Generate a new campain for a URL
        /// </summary>
        /// <param name="source">The referrer (e.g. google, newsletter)</param>
        /// <param name="medium">Marketing medium (e.g. cpc, banner, email)</param>
        /// <param name="name">Product, promo code, or slogan (e.g. spring_sale)</param>
        /// <param name="id">The ads campain id.</param>
        /// <param name="term">Identify the paid keywords</param>
        /// <param name="content">Use to differentiate ads</param>
        public Campaign(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;

            InvalidCampaignException.ThrowIfNull(Source, "Source is invalid");
            InvalidCampaignException.ThrowIfNull(Medium, "Medium is invalid");
            InvalidCampaignException.ThrowIfNull(Name, "Name is invalid");
        }
    }
}
