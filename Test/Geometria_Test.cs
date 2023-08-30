using NUnit.Framework;
using Geometrias;

namespace Geometria_Test
{
    [TestFixture]
    public class Geometria_Test
    {
        private Geometria geometria;

        [SetUp]
        public void SetUp()
        {
            geometria = new Geometria();
        }

        [Test]
        public void TestAreaCuadrado()
        {
            int lado = 4;
            int resultadoEsperado = 16;
            int resultadoActual = geometria.areacuadrado(lado);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [Test]
        public void TestAreaCirculo()
        {
            int radio = 5;
            double resultadoEsperado = 78.54; // Valor aproximado
            double resultadoActual = geometria.areaCirculo(radio);
            Assert.AreEqual(resultadoEsperado, resultadoActual, 0.01); // Pequeña diferencia debido a redondeo.
        }

        [Test]
        public void TestAreaTriangulo()
        {
            int baseTriangulo = 6;
            int alturaTriangulo = 8;
            int resultadoEsperado = 24;
            int resultadoActual = geometria.areatriangulo(baseTriangulo, alturaTriangulo);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [Test]
        public void TestAreaRectangulo()
        {
            int baseRectangulo = 5;
            int alturaRectangulo = 10;
            int resultadoEsperado = 50;
            int resultadoActual = geometria.arearectangulo(baseRectangulo, alturaRectangulo);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [Test]
        public void TestAreaPentagono()
        {
            int perimetroPentagono = 20;
            int apotemaPentagono = 4;
            int resultadoEsperado = 40;
            int resultadoActual = geometria.areapentagono(perimetroPentagono, apotemaPentagono);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [Test]
        public void TestAreaRombo()
        {
            int diagonalMayor = 10;
            int diagonalMenor = 6;
            int resultadoEsperado = 30;
            int resultadoActual = geometria.arearombo(diagonalMayor, diagonalMenor);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [Test]
        public void TestAreaRomboide()
        {
            int baseRomboide = 7;
            int alturaRomboide = 9;
            int resultadoEsperado = 63;
            int resultadoActual = geometria.arearomboide(baseRomboide, alturaRomboide);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [Test]
        public void TestAreaTrapecio()
        {
            int baseMayor = 8;
            int baseMenor = 6;
            int alturaTrapecio = 4;
            int resultadoEsperado = 28;
            int resultadoActual = geometria.areatrapecio(baseMayor, baseMenor, alturaTrapecio);
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
