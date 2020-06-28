using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class clsModeloCirculo : modeloIntFigura
    {
        protected double _radio;
        public double Area()
        {
            return (3.1416 * (Math.Pow(_radio, 2)));
        }

        public string Descripcion()
        {
            return "Este es un Circulo, cuya medida de su Radio es de: " + _radio + ". \n" +
               "  Su area es de: " + Area() + "\n" +
               "  y Su perimetro es de: " + Perimetro();
        }


        public void setMedidas(double[] Medidas)
        {
            _radio = Medidas[0];
        }

        public double Perimetro()
        {
            return ((2 * _radio) * 3.1416);
        }
    }
}
