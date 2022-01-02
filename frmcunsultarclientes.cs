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
    public partial class frmcunsultarclientes : Form
    {
        public frmcunsultarclientes()
        {
            InitializeComponent();
        }

        private void btnbuscar2_Click(object sender, EventArgs e)
        {
            //conexión 
            ADODB.Connection con = new ADODB.Connection();
            con.ConnectionString = "provider=microsoft.ace.oledb.12.0; Data Source=" + Application.StartupPath + "\\Agencia.accdb";

            //abrir conexion
            con.Open();

            //sentecia sql
            string sql;
            if ((cmbcampos1.Text != "fecha_nacimientos") && (cmbcampos1.Text != "telefono") && (cmbcampos1.Text != "celular"))
                sql = " SELECT * FROM clientes WHERE " + cmbcampos1.Text + "=\"" + txtdato1.Text + "\"";
            else
            {
                sql = "select * from clientes where " + cmbcampos1.Text + "=" + txtdato1.Text;
            }
           
            ADODB.Recordset rs = new ADODB.Recordset();
            //abrir
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            //sentencia
            rs.Open(sql, con);

            //preparar el Data
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Refresh();

            dgv.Columns.Add("no_dueno", "No.dueño");
            dgv.Columns.Add("apellidos", "Apellidos");
            dgv.Columns.Add("nombres", "Nombres");
            dgv.Columns.Add("fecha_nacimiento", "Fecha de nacimientos");
            dgv.Columns.Add("estado", "Estado");
            dgv.Columns.Add("domicilio", "Domucilio");
            dgv.Columns.Add("telefono", "Telefono");
            dgv.Columns.Add("celular", "Celular");



            int f, c;
            if (!rs.EOF)
            {
                rs.MoveFirst();
                for (f = 0; f < rs.RecordCount; f++)
                {
                    dgv.Rows.Add();

                    for (c = 0; c < 6; c++)
                    {

                        dgv.Rows[f].Cells[c].Value = Convert.ToString(rs.Fields[c].Value);
                    }
                    rs.MoveNext();

                }

            }
            rs.Close();
            con.Close();
        }

        private void btnregrear_Click(object sender, EventArgs e)
        {
            frmprincipal fr = new frmprincipal();
            fr.Show();
            this.Hide();
        }

        private void cmbcampos1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
