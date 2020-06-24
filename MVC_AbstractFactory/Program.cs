﻿using System;
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
            //clsModeloFiguras Model = new clsModeloFiguras();
            frmVistaFiguras view = new frmVistaFiguras();
            clsControladorFiguras controll = new clsControladorFiguras(view);
            view.ShowDialog();
        }
    }
}
