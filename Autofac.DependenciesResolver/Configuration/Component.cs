using System.Configuration;

namespace Autofac.DependenciesResolver.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class Component : ConfigurationElement
    {
        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("type", IsRequired = false)]
        public string Type
        {
            get
            {
                return (string)this["type"];
            }
            set
            {
                this["type"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("contract", IsRequired = false)]
        public string Contract
        {
            get
            {
                return (string)this["contract"];
            }
            set
            {
                this["contract"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("contractName", IsRequired = false)]
        public string ContractName
        {
            get
            {
                return (string)this["contractName"];
            }
            set
            {
                this["contractName"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty("singleton", IsRequired = false, DefaultValue = false)]
        public bool Singleton
        {
            get
            {
                return (bool)this["singleton"];
            }
            set
            {
                this["singleton"] = value;
            }
        }
    }
}
