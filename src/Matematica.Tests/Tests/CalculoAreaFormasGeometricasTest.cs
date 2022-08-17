using Matematica.Models;
using System;
using Xunit;

namespace Matematica.Tests
{
    [Trait("Category","Calculo Area Simples")]
    public class CalculoAreaFormasGeometricasTest
    {
        [Fact]
        public void AreaDeUmQuadradoSimples()
        {
            var sut = new Quadrado(10);

            var area = sut.Area();

            Assert.Equal(100, area);
        }

        [Fact]
        public void AreaDeUmRetanguloSimples()
        {
            var sut = new Retangulo(10, 5);

            var area = sut.Area();

            Assert.Equal(50, area);
        }

        [Fact]
        public void AreaDeUmCirculo()
        {
            var sut = new Circulo(5);

            var area = sut.Area();

            Assert.Equal(78.5375, area, 4);
        }

    }
}
