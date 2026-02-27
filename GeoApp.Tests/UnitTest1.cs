using Xunit;
using GeoApp.Core.Models;
using System;

namespace GeoApp.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void AreaRectangulo_Correcto()
        {
            double resultado = Calculadora.AreaRectangulo(10, 5);
            Assert.Equal(50, resultado);
        }

        [Fact]
        public void AreaCirculo_Correcto()
        {
            double resultado = Calculadora.AreaCirculo(1);
            Assert.Equal(Math.PI, resultado, 5);
        }

        [Fact]
        public void AreaTriangulo_Correcto()
        {
            double resultado = Calculadora.AreaTriangulo(10, 4);
            Assert.Equal(20, resultado);
        }
    }
}