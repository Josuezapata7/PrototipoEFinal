using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVistaReporte;
using CapaVista;

namespace CapaVistaPolizaF
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void polizaDetlladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolizaDet pd = new PolizaDet();
            pd.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
                nombreUsuario.nombre = txtUsuario.Text;

            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteadorAdmin repo = new ReporteadorAdmin();
            repo.Show();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas consultas = new menuconsultas();
            consultas.Show();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad seguridad = new frmMIDSeguridad();
            seguridad.Show();
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuentasContables cCo = new cuentasContables();
            cCo.Show();
        }

        private void polizaEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolizaEnc Pe = new PolizaEnc();
            Pe.Show();
        }
    }
}
