using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Agencia
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {

            //conexion con B_D
            ADODB.Connection con = new ADODB.Connection();
            con.ConnectionString = "provider=microsoft.ace.oledb.12.0; Data Source=" + Application.StartupPath + "\\Agencia.accdb";

            //abrir conexion
            con.Open();
            
            //sentecia sql
            string sql;

            sql = " select * from usuarios where usuario =\""+txtusuario.Text+"\" and contrasena =\""+txtcontrasena.Text+"\"";

            //recordset

            ADODB.Recordset rs = new ADODB.Recordset();

            //abrir

            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;

            //sentencia
            rs.Open(sql,con);

            if(rs.RecordCount==0)
                MessageBox.Show("Usuario o Contraseña incorrectos");
            else
            {
            frmprincipal f = new frmprincipal();
            f.Show();
            this.Hide();
            }

            rs.Close();
            con.Close();
        }

    }
}
