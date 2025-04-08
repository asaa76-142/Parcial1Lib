
using Parcial1Lib1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parcial1Test
{
    [TestClass]
    public sealed class TesUnitTriangulo
    {
        [TestMethod]
        public void Triangulo()
        {
            decimal l1 = 3;
            decimal l2 = 4;
            decimal baseTriangulo = 5;
            decimal altura = 6;
            Triangulo triangulo = new Triangulo(l1, l2, altura, baseTriangulo);
            decimal area = triangulo.area();
            decimal perimetro = triangulo.perimetro();
            Assert.AreEqual(15, area);
            Assert.AreEqual(12, perimetro);
        }
    }
}

