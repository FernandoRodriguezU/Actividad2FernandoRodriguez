using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaDatos : Form
    {
        public DetalleVentaDatos()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();

        private void DetalleVentaDatos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetalleVentaDatosBSS();

        }
    }
}
