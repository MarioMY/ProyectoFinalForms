using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOperación1_Click(object sender, EventArgs e)
        {
            Distancia2PuntosRecta R1 = new Distancia2PuntosRecta();
            decimal operacion1 = R1.Operacion(numV1.Value, numV2.Value);
            lblResultado1.Text = operacion1+"";
        }

        private void btnOperación2_Click(object sender, EventArgs e)
        {
            Distancia2PuntosPlano R2 = new Distancia2PuntosPlano();
            decimal operacion2 = R2.OperacionPlano(numX1.Value, numX2.Value, numY1.Value, numY2.Value);
            lblResultado2.Text = operacion2 + "";
        }
    }
}
