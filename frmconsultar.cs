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
    public partial class frmconsultar : Form
    {
        public frmconsultar()
        {
            InitializeComponent();
        }

        private void frmconsultar_Load(object sender, EventArgs e)
        {
            cmbcampos.Items.Add("no_auto");
            cmbcampos.Items.Add("ano");
            cmbcampos.Items.Add("modelo");
            cmbcampos.Items.Add("marca");
            cmbcampos.Items.Add("placas");
            cmbcampos.Items.Add("uso");
            cmbcampos.Items.Add("no_dueno");
            cmbcampos.Items.Add("imagen");
            
            
        }

        private void btnregresar2_Click(object sender, EventArgs e)
        {
            frmprincipal f2 = new frmprincipal();
            f2.Show();
            this.Hide();
        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {
            //conexión 
            ADODB.Connection con = new ADODB.Connection();
            con.ConnectionString = "provider=microsoft.ace.oledb.12.0; Data Source=" + Application.StartupPath + "\\Agencia.accdb";

            //abrir conexion
            con.Open();

            //sentecia sql
            string sql;

            if ((cmbcampos.Text != "no_auto") && (cmbcampos.Text != "ano") && (cmbcampos.Text != "placas"))

                sql = " SELECT * FROM automoviles WHERE " + cmbcampos.Text + "=\"" + txtdato.Text + "\"";
            else
            {
                sql = "select * from automoviles where " + cmbcampos.Text + "=" + txtdato.Text;
            }

            MessageBox.Show(sql);
            ADODB.Recordset rs = new ADODB.Recordset();
            //abrir
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset;
            //sentencia
            rs.Open(sql,con,0);

            //preparar el Data
            dgvmostrar.Rows.Clear();
            dgvmostrar.Columns.Clear();
            dgvmostrar.Refresh();

            dgvmostrar.Columns.Add("no_auto", "no_auto");
            dgvmostrar.Columns.Add("ano", "Año");
            dgvmostrar.Columns.Add("modelo", "Modelo");
            dgvmostrar.Columns.Add("marca", "Marca");
            dgvmostrar.Columns.Add("placas", "Placas");
            dgvmostrar.Columns.Add("uso", "Uso");
            dgvmostrar.Columns.Add("no_dueno", "numero de dueño");
            dgvmostrar.Columns.Add("imagen", "Imagen");

           

            int f, c;
            if (!rs.EOF)
            {
                rs.MoveFirst();
                for ( f = 0; f < rs.RecordCount; f++)
                {
                    dgvmostrar.Rows.Add();

                    for ( c = 0; c <6; c++)
                    {

                        dgvmostrar.Rows[f].Cells[c].Value = Convert.ToString(rs.Fields[c].Value);
                    }
                    rs.MoveNext();
                   
                } 

            }
            rs.Close();
            con.Close();
            
        }


    }
}
