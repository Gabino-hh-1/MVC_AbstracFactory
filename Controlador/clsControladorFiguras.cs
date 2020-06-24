using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista;
using Modelo;

namespace Controlador
{
    public class clsControladorFiguras
    {
        frmVistaFiguras vistaFigura;

        public clsControladorFiguras(frmVistaFiguras ViewFig)
        {
            this.vistaFigura = ViewFig;
            Eventos();
        }

        private void Eventos()
        {
            vistaFigura.btnCalcular.Click += btnCalculcular;
        }

        private void btnCalculcular(object sender, EventArgs e)
        {
            double[] Medidas;
           modeloIntFigura Figura;

            if (vistaFigura.cmbFiguras.SelectedItem != null)
            {
                string NomFig = vistaFigura.cmbFiguras.SelectedItem.ToString();

                switch (NomFig)
                {
                    case "Cuadrado":
                        if (vistaFigura.txtLadoA.Text != null)
                        {
                            Medidas = new double[1];
                            Medidas[0] = double.Parse(vistaFigura.txtLadoA.Text);
                            Figura = clsControladorFabrica.Fabricar("Cuadrado");
                            Figura.setMedidas(Medidas);
                            vistaFigura.txtArea.Text = Figura.Area().ToString();
                            vistaFigura.txtPerimetro.Text = Figura.Perimetro().ToString();
                            System.Windows.Forms.MessageBox.Show(Figura.Descripcion());
                        }
                        break;
                    case "Rectangulo":
                        if (vistaFigura.txtLadoA.Text != null && vistaFigura.txtLadoB.Text != null)
                        {
                            Medidas = new double[2];
                            Medidas[0] = double.Parse(vistaFigura.txtLadoA.Text);
                            Medidas[1] = double.Parse(vistaFigura.txtLadoB.Text);
                            Figura = clsControladorFabrica.Fabricar("Rectangulo");
                            Figura.setMedidas(Medidas);
                            vistaFigura.txtArea.Text = Figura.Area().ToString();
                            vistaFigura.txtPerimetro.Text = Figura.Perimetro().ToString();
                            System.Windows.Forms.MessageBox.Show(Figura.Descripcion());
                        }
                        break;
                    case "Circulo":
                        if (vistaFigura.txtLadoA.Text != null && vistaFigura.txtLadoB.Text != null)
                        {
                            Medidas = new double[1];
                            Medidas[0] = double.Parse(vistaFigura.txtLadoA.Text);
                            Figura = clsControladorFabrica.Fabricar("Circulo");
                            Figura.setMedidas(Medidas);
                            vistaFigura.txtArea.Text = Figura.Area().ToString();
                            vistaFigura.txtPerimetro.Text = Figura.Perimetro().ToString();
                            System.Windows.Forms.MessageBox.Show(Figura.Descripcion());
                        }
                        break;
                    case "Triangulo":
                        if (vistaFigura.txtLadoA.Text != null)
                        {
                            Medidas = new double[2];
                            Medidas[0] = double.Parse(vistaFigura.txtLadoA.Text);
                            Medidas[1] = double.Parse(vistaFigura.txtLadoB.Text);
                            Figura = clsControladorFabrica.Fabricar("Triangulo");
                            Figura.setMedidas(Medidas);
                            vistaFigura.txtArea.Text = Figura.Area().ToString();
                            vistaFigura.txtPerimetro.Text = Figura.Perimetro().ToString();
                            System.Windows.Forms.MessageBox.Show(Figura.Descripcion());
                        }
                        break;
                }
            }
        }
    }
}
