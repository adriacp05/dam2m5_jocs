﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocs
{
    public partial class FrmPedra : Form
    {
        public EventHandler esticTancant;
        public FrmPedra()
        {
            InitializeComponent();
        }

        private void FrmPedra_FormClosed(object sender, FormClosedEventArgs e)
        {
            esticTancant(this, EventArgs.Empty);
        }
    }
}
