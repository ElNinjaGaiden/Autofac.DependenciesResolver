using System.Configuration;

namespace Autofac.DependenciesResolver.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class ModuleConfig : ConfigurationElement
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("contracts", IsRequired = false)]
        public string Contracts
        {
            get
            {
                return (string)this["contracts"];
            }
            set
            {
                this["contracts"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("components", IsRequired = true)]
        public string Components
        {
            get
            {
                return (string)this["components"];
            }
            set
            {
                this["components"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("autoRegister", IsRequired = false, DefaultValue = true)]
        public bool AutoRegister
        {
            get
            {
                return (bool)this["autoRegister"];
            }
            set
            {
                this["autoRegister"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("singletons", IsRequired = false)]
        public bool Singletons
        {
            get
            {
                return (bool)this["singletons"];
            }
            set
            {
                this["singletons"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("instancePerLifetimeScope", IsRequired = false)]
        public bool InstancePerLifetimeScope
        {
            get
            {
                return (bool)this["instancePerLifetimeScope"];
            }
            set
            {
                this["instancePerLifetimeScope"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("ForEachComponent", IsRequired = false)]
        public ForEachComponent ForEachComponent
        {
            get
            {
                return (ForEachComponent)this["ForEachComponent"];
            }
            set
            {
                this["ForEachComponent"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("Ensure", IsRequired = false)]
        public Ensure Ensure
        {
            get
            {
                return (Ensure)this["Ensure"];
            }
            set
            {
                this["Ensure"] = value;
            }
        }
    }
}
