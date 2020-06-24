using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface modeloIntFigura
    {
        double Area();
        double Perimetro();
        string Descripcion();

        void setMedidas(Double[] Medidas);
    }
}
