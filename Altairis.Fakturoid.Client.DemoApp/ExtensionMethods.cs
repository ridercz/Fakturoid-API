using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Altairis.Fakturoid.Client.DemoApp {
    internal static class ExtensionMethods {

        public static void DumpProperties(this object element) {
            element.DumpProperties(Console.Out);
        }

        public static void DumpProperties(this object element, TextWriter tw, string linePrefix = null) {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (tw == null) throw new ArgumentNullException(nameof(tw));

            var propertyInfos = element.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance).OfType<PropertyInfo>();
            foreach (var pi in propertyInfos) {
                if (pi.PropertyType.IsValueType || pi.PropertyType == typeof(string)) {
                    // Primitive type or string
                    Console.WriteLine("{0}{1} = {2}", linePrefix, pi.Name, pi.GetValue(element));
                }
                else if (typeof(IEnumerable).IsAssignableFrom(pi.PropertyType)) {
                    // Some kind of enumerable
                    Console.WriteLine("{0}{1} = ... (enumerable)", linePrefix, pi.Name);
                }
                else {
                    // Complex type
                    Console.WriteLine("{0}{1}:", linePrefix, pi.Name);
                    pi.GetValue(element).DumpProperties(tw, linePrefix + "  ");
                }
            }
        }

    }
}
