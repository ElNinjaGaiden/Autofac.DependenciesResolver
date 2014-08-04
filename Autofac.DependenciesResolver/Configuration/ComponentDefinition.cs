
namespace Autofac.DependenciesResolver.Configuration
{
    /// <summary>
    /// 
    /// </summary>
    public class ComponentDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public string AssemblyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsGeneric 
        { 
            get 
            {
                return ComponentName.Contains("(");
            }  
        }
    }
}
