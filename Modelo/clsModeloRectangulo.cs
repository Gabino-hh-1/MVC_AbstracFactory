using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsModeloRectangulo : modeloIntFigura
    {
        protected double _base;
        protected double _altura;
        public double Area()
        {
            return _base * _altura;
        }

        public string Descripcion()
        {
            return "Este es un Rectángulo, cuya medida de su Base es de: " + _base + " y su Altura es de: " + _altura + "\n" +
                 "Su area es de: " + Area() + "\n" +
                 "Su perimetro es de: " + Perimetro();
        }

        public void setMedidas(double[] Medidas)
        {
            _base = Medidas[0];
            _altura = Medidas[1];
        }

        public double Perimetro()
        {
            return ((_base * 2) + (_altura * 2));
        }
    }
}
