using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica.Tests
{
    public class ExternalData
    {
        public static IEnumerable<object[]> ListaDeQuadrados()
        {
            var lista = new List<object[]>();

            string[] linhas = File.ReadAllLines("Data/MassaDeDados.txt");

            foreach(var linha in linhas)
            {
                lista.Add(linha.Split(";"));
            }

            return lista;
        }
    }
}
