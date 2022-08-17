using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica.Models
{
    public class Quadrado: Retangulo
    {
        public Quadrado(int lado): base(lado, lado) { }

        public override float Area()
        {
            return _base * _base;
        }

        public override string GetName()
        {
            return "Quadrado";
        }
    }
}
