﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diav0._0._1
{
    public partial class FormVendor : Form
    {
        private int _idVendedor;
        public FormVendor(int idVendedor)
        {
            InitializeComponent();
            _idVendedor = idVendedor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNuevoCliente frmNuevoCliente = new FormNuevoCliente();
            frmNuevoCliente.ShowDialog();
        }

        private void btnComenzarVenta_Click(object sender, EventArgs e)
        {
            FormVenta frmVenta = new FormVenta(_idVendedor);
            frmVenta.ShowDialog();
        }
    }
}
