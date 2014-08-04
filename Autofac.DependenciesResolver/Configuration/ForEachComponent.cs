using System.Configuration;

namespace Autofac.DependenciesResolver.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    [ConfigurationCollection(typeof(GenericOf))]
    public class ForEachComponent : ConfigurationElementCollection
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new GenericOf();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string ElementName
        {
            get
            {
                return "GenericOf";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((GenericOf)element).Type;
        }

        /// <summary>
        /// 
        /// </summary>
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
    }
}
