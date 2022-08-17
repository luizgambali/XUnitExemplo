using Matematica.Models;
using Xunit.Abstractions;
using Xunit;
using System;

namespace Matematica.Tests.Tests
{
    [Trait("Category","Testes Gerais")]
    public class FormasGeometricasTest
    {
        private readonly ITestOutputHelper _output;

        public FormasGeometricasTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void TestarString()
        {
            var sut = new Quadrado(3);

            Assert.Equal("Quadrado", sut.GetName());
        }

        [Fact]
        public void VerificarSeExisteUmQuadradoNaLista()
        {
            var sut = new FormasGeometricas();

            Assert.Contains(sut.ListarObjetos(), p => p.GetName() == "Quadrado");
        }

        [Fact]
        public void VerificaSeAreaMenorQueUm()
        {
            var sut = new FormasGeometricas();
            var lista = sut.ListarObjetos();

            Assert.All(lista, lista => Assert.False(lista.Area() <= 0));
        }

        [Fact]
        public void VerificaTipoObjetoRetornado()
        {
            var sut = new Quadrado(10);
            
            Assert.IsType<Quadrado>(sut);
        }

        [Fact]
        public void VerificaTipoObjetoRetornadoHeranca()
        {
            var sut = new Quadrado(10);

            Assert.IsAssignableFrom<Retangulo>(sut);
        }

        [Fact]
        public void MostrarMensagemNaSaidaDoTeste()
        {
            _output.WriteLine("Esta mensagem será exibida no output do método de teste");

            Assert.True(true);
        }

        [Fact]
        public void TestarLancamentoExcecao()
        {
            var sut = new FormasGeometricas();

            Assert.Throws<ArgumentException>(() => sut.CriarQuadradoInvalido());

        }
    }
}
