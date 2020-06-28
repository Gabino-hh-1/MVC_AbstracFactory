using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista;
using Modelo;

namespace Controlador
{
    public class clsControladorOperacionesFiguras
    {
        frmVistaOperacionFiguras vistaFigura;
        modeloIntFigura Figura;

        public clsControladorOperacionesFiguras(frmVistaOperacionFiguras ViewFig)
        {
            this.vistaFigura = ViewFig;
            Eventos();
            ElemntsCuadradCirculo();
        }

        private void Eventos()
        {
            vistaFigura.btnCuadrado.Click += btnCuadrado;
            vistaFigura.btnRectangulo.Click += btnRectangulo;
            vistaFigura.btnTriangulo.Click += btnTriangulo;
            vistaFigura.btnCirculo.Click += btnCirculo;

            vistaFigura.btnCalcular.Click += btnCalcular;
        }

        private void btnCirculo(object sender, EventArgs e)
        {
            vistaFigura.btnRectangulo.Checked = false;
            vistaFigura.btnCuadrado.Checked = false;
            vistaFigura.btnTriangulo.Checked = false;
            vistaFigura.btnCirculo.Checked = true;

            LimpiarCajas();
            ElemntsCuadradCirculo();
            vistaFigura.lblLadoA.Text = "Radio:";
        }

        private void btnTriangulo(object sender, EventArgs e)
        {
            vistaFigura.btnRectangulo.Checked = false;
            vistaFigura.btnCuadrado.Checked = false;
            vistaFigura.btnTriangulo.Checked = true;
            vistaFigura.btnCirculo.Checked = false;

            LimpiarCajas();
            EmentsRectanguloTriangulo();
            vistaFigura.lblLadoA.Text = "Base:";
            vistaFigura.lblLadoB.Text = "Altura:";
        }

        private void btnRectangulo(object sender, EventArgs e)
        {
            vistaFigura.btnRectangulo.Checked = true;
            vistaFigura.btnCuadrado.Checked = false;
            vistaFigura.btnTriangulo.Checked = false;
            vistaFigura.btnCirculo.Checked = false;

            LimpiarCajas();
            EmentsRectanguloTriangulo();
            vistaFigura.lblLadoA.Text = "Base:";
            vistaFigura.lblLadoB.Text = "Altura:";
        }

        private void btnCuadrado(object sender, EventArgs e)
        {
            vistaFigura.btnRectangulo.Checked = false;
            vistaFigura.btnCuadrado.Checked = true;
            vistaFigura.btnTriangulo.Checked = false;
            vistaFigura.btnCirculo.Checked = false;

            LimpiarCajas();
            ElemntsCuadradCirculo();
            vistaFigura.lblLadoA.Text = "Lado:";
        }       

        private void LimpiarCajas()
        {
            vistaFigura.txtLadoA.Clear();
            vistaFigura.txtLadoB.Clear();
        }
        private void ElemntsCuadradCirculo()
        {
            vistaFigura.lblLadoA.Visible = true;
            vistaFigura.lblLadoB.Visible = false;
            vistaFigura.txtLadoA.Visible = true;
            vistaFigura.txtLadoB.Visible = false;
        }
        private void EmentsRectanguloTriangulo()
        {
            vistaFigura.lblLadoA.Visible = true;
            vistaFigura.lblLadoB.Visible = true;
            vistaFigura.txtLadoA.Visible = true;
            vistaFigura.txtLadoB.Visible = true;
        }

        private void operaciones(string NomFigura,double[] Medidas)
        {
            Figura = clsControladorFabrica.Fabricar(NomFigura);
            Figura.setMedidas(Medidas);
            if (vistaFigura.rbtnArea.Checked == true)
            {
                vistaFigura.lblResultado.Text = "Área: ";
                vistaFigura.txtResultado.Text= Figura.Area().ToString();
            }
            else if (vistaFigura.rbtnPerimetro.Checked == true)
            {
                vistaFigura.lblResultado.Text = "Perimetro: ";
                vistaFigura.txtResultado.Text = Figura.Perimetro().ToString();
            }
            else if (vistaFigura.rbtnDescripcion.Checked == true)
            {
                vistaFigura.lblResultado.Text = "Descripción: ";
                vistaFigura.txtResultado.Text = Figura.Descripcion().ToString();
            }
        }
        private void btnCalcular(object sender, EventArgs e)
        {
            double[] Medidas;
            if (vistaFigura.btnCuadrado.Checked == true)
            {
                if (vistaFigura.txtLadoA.Text != string.Empty)
                {
                    Medidas = new double[1];
                    Medidas[0] = double.Parse(vistaFigura.txtLadoA.Text);
                    operaciones("Cuadrado", Medidas);
                }
                else { System.Windows.Forms.MessageBox.Show("Revise los datos"); }
            } else if (vistaFigura.btnRectangulo.Checked == true)
            {
                if (vistaFigura.txtLadoA.Text != string.Empty && vistaFigura.txtLadoB.Text != string.Empty)
                {
                    Medidas = new double[2];
                    Medidas[0] = double.Parse(vistaFigura.txtLadoA.Text);
                    Medidas[1] = double.Parse(vistaFigura.txtLadoB.Text);
                    operaciones("Rectangulo", Medidas);
                }
                else { System.Windows.Forms.MessageBox.Show("Revise los datos"); }
            }
            else if (vistaFigura.btnCirculo.Checked == true)
            {
                if (vistaFigura.txtLadoA.Text != string.Empty)
                {
                    Medidas = new double[1];
                    Medidas[0] = double.Parse(vistaFigura.txtLadoA.Text);
                    operaciones("Circulo", Medidas);
                }
                else { System.Windows.Forms.MessageBox.Show("Revise los datos"); }
            }
            else if (vistaFigura.btnTriangulo.Checked == true)
            {
                if (vistaFigura.txtLadoA.Text != string.Empty && vistaFigura.txtLadoB.Text != string.Empty)
                {
                    Medidas = new double[2];
                    Medidas[0] = double.Parse(vistaFigura.txtLadoA.Text);
                    Medidas[1] = double.Parse(vistaFigura.txtLadoB.Text);
                    operaciones("Triangulo", Medidas);
                }
                else { System.Windows.Forms.MessageBox.Show("Revise los datos"); }
            }
        }
    }
}
