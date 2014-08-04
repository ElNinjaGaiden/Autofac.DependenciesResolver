using System.Configuration;

namespace Autofac.DependenciesResolver.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class DependenciesConfigurationSection : ConfigurationSection
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("Modules")]
        public ModulesConfigurationCollection Modules
        {
            get { return ((ModulesConfigurationCollection)(base["Modules"])); }
            set { base["Modules"] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("Components")]
        public ComponentsConfigurationCollection Components
        {
            get { return ((ComponentsConfigurationCollection)(base["Components"])); }
            set { base["Components"] = value; }
        }
    }
}
