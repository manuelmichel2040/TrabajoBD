using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PI
{
    public partial class auto : Form
    {
        public auto()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string _placa, _marca, _modelo, _color;
            _placa = txt_placaauto.Text;
            _marca = txt_marcaauto.Text;
            _modelo = txt_modeloauto.Text;
            _color = txt_colorauto.Text;

            string query = "Insert into auto(placa, marca, modelo, color) VALUES ('" + _placa + "','" + _marca + "','" + _modelo + "','" + _color + "')";
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAPTOP-PDUF7F0R\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                txt_placaauto.Text = "";
                txt_modeloauto.Text = "";
                txt_marcaauto.Text = "";
                txt_colorauto.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string _placa, _marca, _modelo, _color;
            _placa = txt_placaauto.Text;
            _marca = txt_marcaauto.Text;
            _modelo = txt_modeloauto.Text;
            _color = txt_colorauto.Text;
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAPTOP-PDUF7F0R\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema");
            con.Open();
            string query = "Delete from Auto where placa = '" + txt_placaauto.Text +  "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se elimino");
            con.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string _placa, _marca, _modelo, _color;
            _placa = txt_placaauto.Text;
            _marca = txt_marcaauto.Text;
            _modelo = txt_modeloauto.Text;
            _color = txt_colorauto.Text;

            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAPTOP-PDUF7F0R\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema");
            con.Open();
            string query = "UPDATE Auto SET marca = '" + txt_marcaauto.Text + "', modelo = '" + txt_modeloauto.Text + "', color = '" + txt_colorauto.Text + "' where placa = '" + txt_placaauto.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se modifico");
            con.Close();
        }
    }
}
