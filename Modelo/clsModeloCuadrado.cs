using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class clsModeloCuadrado:modeloIntFigura
    {
        protected double _lado;
        public double Area()
        {
            return _lado * _lado;
        }

        public string Descripcion()
        {
            return "Este es un cuadrado, cuya medida de su lado de: " + _lado + " \n" +
                "Su area es de: " + Area() + "\n" +
                "Su perimetro es de: " + Perimetro();
        }

        public void setMedidas(double[] Medidas)
        {
            _lado = Medidas[0];
        }

        public double Perimetro()
        {
            return _lado * 4;
        }
    }
}
