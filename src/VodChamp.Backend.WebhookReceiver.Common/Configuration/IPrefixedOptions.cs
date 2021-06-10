namespace VodChamp.Backend.WebhookReceiver.Common.Configuration
{
    /// <summary>
    /// Represents a keyed section of a configuration
    /// </summary>
    public interface IPrefixedOptions
    {
        /// <summary>
        /// The prefix of the section to treat as this class' root
        /// </summary>
        string ConfigSectionPrefix { get; }
    }
}
