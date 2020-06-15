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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string a, b, c, d, f;
            //int i = 1;
            a = txt_rfc.Text;
            b = txt_nombreclient.Text;
            c = txt_domicilioclient.Text;
            d = txt_telclient.Text;
            f = txt_correoclient.Text;

            string query = "Insert into Cliente(rfc, nombre, domicilio, telefono, correo) VALUES('" + a + "','" + b + "','" + c + "','" + d + "','" + f + "')";
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAPTOP-PDUF7F0R\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txt_rfc.Text = "";
                txt_nombreclient.Text = "";
                txt_domicilioclient.Text = "";
                txt_telclient.Text = "";
                txt_correoclient.Text = "";
                oleDbDataAdapter1.Fill(dsCliente1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Delete from Cliente where nombre = ''

            string a, b, c, d, f;
            //int flag = 0;
            a = txt_rfc.Text;
            b = txt_nombreclient.Text;
            c = txt_domicilioclient.Text;
            d = txt_telclient.Text;
            f = txt_correoclient.Text;
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAPTOP-PDUF7F0R\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema");
            con.Open();
            string query = "Delete from Cliente where rfc = '" + txt_rfc.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se elimino");
            con.Close();


        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string a, b, c, d, f;
            //int flag = 0;
            a = txt_rfc.Text;
            b = txt_nombreclient.Text;
            c = txt_domicilioclient.Text;
            d = txt_telclient.Text;
            f = txt_correoclient.Text;
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAPTOP-PDUF7F0R\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Sistema");
            con.Open();
            string query = "UPDATE Cliente SET nombre = '" + txt_nombreclient.Text + "', domicilio = '" + txt_domicilioclient.Text + "', telefono = '" + txt_telclient.Text + "', correo='" + txt_correoclient.Text + "' where rfc = '" + txt_rfc.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se modifico");
            con.Close();
        }
    }
}
