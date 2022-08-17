using Matematica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica.Models
{
    public class Retangulo: IFormaGeometrica
    {
        protected float _base;
        protected float _altura;

        public Retangulo(float altura, float largura)
        {
            if (altura < 0 || largura < 0)
                throw new ArgumentException("O valor da altura ou largura não pode ser negativo");

            _altura = altura;
            _base = largura;
        }

        public virtual float Area()
        {
            return _base * _altura;
        }

        public virtual string GetName()
        {
            return "Retangulo";
        }

    }
}
