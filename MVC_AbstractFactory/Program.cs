using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Vista;
using Controlador;

namespace MVC_AbstractFactory
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            frmVistaOperacionFiguras vista = new frmVistaOperacionFiguras();
            clsControladorOperacionesFiguras controll = new clsControladorOperacionesFiguras(vista);            
            vista.ShowDialog();
        }
    }
}
