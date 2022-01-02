using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agencia
{
    public partial class frmregistrosautos : Form
    {
        public frmregistrosautos()
        {
            InitializeComponent();
        }



        private void btnregresar1_Click_1(object sender, EventArgs e)
        {
            frmprincipal rr3 = new frmprincipal();

            rr3.Show();

            this.Hide();

            txtmarca.Text = null;
            txtserie.Text = null;
            txtdueño.Text = null;
            txtplacas.Text = null;
            txtmodelo.Text = null;
            txtimagen.Text = null;
            cmbanos.Text = null;
            cmbusos.Text = null;
            pcbimagen.Image = null;
        }

        private void btnañadir_Click_1(object sender, EventArgs e)
        {
            //añadir registro
            //conexion
            //conexion con B_D
            ADODB.Connection con = new ADODB.Connection();
            con.ConnectionString = "provider=microsoft.ace.oledb.12.0; Data Source=" + Application.StartupPath + "\\Agencia.accdb";

            //abrir conexion
            con.Open();

            //sentecia sql
            string sql;

            sql = "INSERT Into automoviles (no_auto,ano,modelo,marca,placas,uso,no_dueno,imagen) values ('" + txtserie.Text + "','" + cmbanos.Text + "','" + txtmodelo.Text + "','" + txtmarca.Text + "','" + txtplacas.Text + "','" + cmbusos.Text + "','" + txtdueño.Text + "','" + txtimagen.Text + "') ";
          

            object p;
            con.Execute(sql, out p, 0);
            MessageBox.Show("Registro existoso");

            con.Close();

            txtmarca.Text = null;
            txtserie.Text = null;
            txtdueño.Text = null;
            txtplacas.Text = null;
            txtmodelo.Text = null;
            txtimagen.Text = null;
            cmbanos.Text =   null;
            cmbusos.Text = null;
            pcbimagen.Image = null;




        }

        private void frmregistrosautos_Load(object sender, EventArgs e)
        {

            for (int i = 1970; i <= 2019; i++)
            {
                cmbanos.Items.Add(Convert.ToString(i));
            }

            cmbusos.Items.Add("Personal");
            cmbusos.Items.Add("Laboral");
            cmbusos.Text = "Personal";
        }

        private void btnimagen_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagen = openFileDialog1.FileName;
                txtimagen.Text = imagen;
                pcbimagen.Image = Image.FromFile(imagen);
                lblimg.Visible = false;
            }
            else
            {
                MessageBox.Show("El archivo no es de tipo imagen");
            }
        }

        private void panelinsertarautos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
