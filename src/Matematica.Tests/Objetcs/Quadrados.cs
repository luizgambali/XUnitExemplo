using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica.Tests
{
    public class Quadrados
    {
        public static IEnumerable<object[]> ListaDeQuadrados()
        {
            yield return new object[] { 10, 3, 30 };
            yield return new object[] { 7, 2, 14 };
            yield return new object[] { 2, 3, 6 };
            yield return new object[] { 5, 3, 15 };
        }
    }
}
