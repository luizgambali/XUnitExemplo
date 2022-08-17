using Matematica.Models;
using Xunit;

namespace Matematica.Tests
{
    [Trait("Category", "Calculo Area Data Driven Tests")]
    public class CalculoAreasDataDrivenTests
    {
        //Data driven test inline data
        [Theory]
        [InlineData(10, 3, 30)]
        [InlineData(5, 2, 10)]
        [InlineData(7, 7, 49)]
        public void TesteAreaUsandoInlineData(int largura, int altura, float resultado)
        {
            var sut = new Retangulo(largura, altura);

            var area = sut.Area();

            Assert.Equal(resultado, area);
        }

        [Theory]
        [MemberData(nameof(Quadrados.ListaDeQuadrados), MemberType = typeof(Quadrados))]
        public void TesteAreaUsandoPropertyData(int largura, int altura, float resultado)
        {
            var sut = new Retangulo(largura, altura);

            var area = sut.Area();

            Assert.Equal(resultado, area);
        }

        [Theory]
        [MemberData(nameof(Quadrados.ListaDeQuadrados), MemberType = typeof(ExternalData))]
        public void TesteAreaUsandoExternalData(int largura, int altura, float resultado)
        {
            var sut = new Retangulo(largura, altura);

            var area = sut.Area();

            Assert.Equal(resultado, area);
        }

        [Theory]
        [QuadradoData]
        public void TesteAreaUsandoDataAttribute(int largura, int altura, float resultado)
        {
            var sut = new Retangulo(largura, altura);

            var area = sut.Area();

            Assert.Equal(resultado, area);
        }
    }
}
