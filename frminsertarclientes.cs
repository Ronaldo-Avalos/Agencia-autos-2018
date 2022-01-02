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
    public partial class frminsertarclientes : Form
    {
        public frminsertarclientes()
        {
            InitializeComponent();
        }

      

        private void btninsert_Click(object sender, EventArgs e)
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

            sql = "INSERT Into clientes (no_dueno,apellidos,nombres,fecha_nacimientos,estado,domicilio,telefono,celular) values ('" + txtnumerodueño.Text + "','" + txtapellidos.Text + "','" +txtnombres.Text + "','"  + txtfecha_nacimiento.Text + "','" + txtestado.Text + "','" +txtdomicilio.Text + "','" + txttelefono.Text + "','" + txtcelular.Text + "') ";

            MessageBox.Show(sql);
            object p;
            con.Execute(sql, out p, 0);
            MessageBox.Show("Registro existoso");

            con.Close();

            txtnumerodueño.Text = null;
            txtapellidos.Text = null;
            txtnombres.Text = null;
            txtfecha_nacimiento.Text = null;
            txtestado.Text = null;
            txtdomicilio.Text = null;
            txttelefono.Text = null;
            txtcelular.Text = null;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmprincipal fr = new frmprincipal();

            fr.Show();
            this.Hide();
            txtnumerodueño.Text = null;
            txtapellidos.Text = null;
            txtnombres.Text = null;
            txtfecha_nacimiento.Text = null;
            txtestado.Text = null;
            txtdomicilio.Text = null;
            txttelefono.Text = null;
            txtcelular.Text = null;
            
        }

     

    }
}
