using System;


namespace R5T.T0022
{
    /// <summary>
    /// Simple implementation of <see cref="IConfigurationSectionNames"/>.
    /// Non-static to allow use as an extension methods base.
    /// </summary>
    public class ConfigurationSectionNames : IConfigurationSectionNames
    {
        #region Static

        public static ConfigurationSectionNames Instance { get; } = new ConfigurationSectionNames();

        #endregion
    }
}
