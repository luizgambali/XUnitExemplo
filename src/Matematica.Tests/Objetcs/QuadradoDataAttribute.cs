using System.Collections.Generic;
using System.Reflection;
using Xunit.Sdk;

namespace Matematica.Tests
{
    public class QuadradoDataAttribute : DataAttribute
    {
        public static IEnumerable<object[]> ListaDeQuadrados()
        {
            yield return new object[] { 9, 5, 45 };
            yield return new object[] { 2, 5, 10 };
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 10, 3, 30 };
            yield return new object[] { 7, 2, 14 };
            yield return new object[] { 2, 3, 6 };
            yield return new object[] { 5, 3, 15 };
        }
    }
}
