using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib1
{
    public abstract class FiguraGeometrica
    {
        public abstract decimal area();

        public abstract decimal perimetro();
    }
    public class Circulo : FiguraGeometrica
    {
        private readonly decimal radio;
        public Circulo(decimal radio)
        {
            this.radio = radio;
        }
        public override decimal area()
        {
            return (decimal)Math.PI * radio * radio;
        }
        public override decimal perimetro()
        {
            return 2 * (decimal)Math.PI * radio;
        }
    }
    public class Triangulo : FiguraGeometrica
    {
        private readonly decimal l1;
        private readonly decimal l2;
        private readonly decimal baseTriangulo;
        private readonly decimal altura;
        public Triangulo(decimal l1, decimal l2, decimal altura, decimal baseTriangulo)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.altura = altura;
            this.baseTriangulo = baseTriangulo;
        }
        public override decimal area()
        {
            return (baseTriangulo * altura) / 2;
        }
        public override decimal perimetro()
        {
            return l1 + l2 + baseTriangulo;
        }
    }

}
