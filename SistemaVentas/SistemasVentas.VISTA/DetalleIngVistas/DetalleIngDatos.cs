﻿using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngDatos : Form
    {
        public DetalleIngDatos()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void DetalleIngDatos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.DetalleingDatosBSS();
        }
    }
}
