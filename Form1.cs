﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "manuel")
            {
                if (txt_contraseña.Text == "123")
                {
                    inicio abrir = new inicio();
                    abrir.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecto");
                }

            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
