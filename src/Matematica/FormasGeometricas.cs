using Matematica.Interfaces;
using Matematica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    public class FormasGeometricas
    {
        private List<IFormaGeometrica> lista;

        public FormasGeometricas()
        {
            CarregarDadosFake();
        }

        private void CarregarDadosFake()
        {
            lista = new List<IFormaGeometrica>();

            lista.Add(new Quadrado(10));
            lista.Add(new Quadrado(3));
            lista.Add(new Quadrado(5));
            lista.Add(new Retangulo(3, 2));
            lista.Add(new Circulo(3));
            lista.Add(new Circulo(12));
        }
        public IEnumerable<IFormaGeometrica> ListarObjetos()
        {
            return lista;
        }

        public Quadrado CriarQuadradoInvalido()
        {
            var quad = new Quadrado(-1);

            return quad;
        }

    }
}
