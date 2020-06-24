using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class clsControladorFabrica
    {
        public static modeloIntFigura Fabricar(string NomFig)
        {
            switch (NomFig)
            {
                case "Cuadrado":
                    return new clsModeloCuadrado();
                case "Rectangulo":
                    return new clsModeloRectangulo();
                case "Circulo":
                    return new clsModeloCirculo();
                case "Triangulo":
                    return new clsModeloTriangulo();
                default:
                    return null;
            }
        }
    }
}
