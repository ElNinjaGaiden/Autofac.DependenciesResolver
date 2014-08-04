using Autofac.DependenciesResolver.Configuration;
using System;
using System.Linq;
using System.Reflection;

namespace Autofac.DependenciesResolver
{
    /// <summary>
    /// 
    /// </summary>
    internal static class Extensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static ComponentDefinition ResolveComponentDefinition(this string value)
        {
            if (value.Contains("("))
            {
                var pp = value.Split(',');
                var assemblyName = pp[2];
                var assemblyNameIndex = value.IndexOf(assemblyName);

                return new ComponentDefinition
                {
                    AssemblyName = assemblyName.Trim(),
                    ComponentName = value.Substring(0, assemblyNameIndex - 1).Trim()
                };
            }

            string[] parts = value.Split(',');

            return new ComponentDefinition
            {
                AssemblyName = parts[1].Trim(),
                ComponentName = parts[0].Trim()
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        /// <param name="contractName"></param>
        /// <returns></returns>
        internal static Type TryGetForcedComponent(this ModuleConfig module, string contractName)
        {
            var config =
                module.Ensure.OfType<Configuration.Component>()
                      .FirstOrDefault(
                          c => c.ContractName.Equals(contractName, StringComparison.InvariantCultureIgnoreCase));

            if (config != null)
            {
                var componentDefinition = config.Type.ResolveComponentDefinition();
                var assembly = Assembly.Load(new AssemblyName(componentDefinition.AssemblyName));
                return assembly.GetType(componentDefinition.ComponentName, true, true);
            }

            return null;
        }
    }
}
