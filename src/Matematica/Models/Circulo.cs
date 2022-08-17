using Matematica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica.Models
{
    public class Circulo : IFormaGeometrica
    {
        private const float  PI = 3.1415f;
        private int _raio;

        public Circulo(int raio)
        {
            _raio = raio;
        }

        public float Area()
        {
            return (float)(PI * Math.Pow(_raio, 2));
        }

        public string GetName()
        {
            return "Circulo";
        }
    }
}
