using System.Configuration;

namespace Autofac.DependenciesResolver.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class GenericOf : Component
    {
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
    }
}
