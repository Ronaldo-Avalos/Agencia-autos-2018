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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin f = new frmlogin();

            f.Show();
            this.Hide();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmregistrosautos fi = new frmregistrosautos();

            fi.Show();
            this.Hide();

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultar f2 = new frmconsultar();
            f2.Show();
            this.Hide();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void insertarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frminsertarclientes f3 = new frminsertarclientes();
            f3.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcunsultarclientes f4 = new frmcunsultarclientes();
            f4.Show();
            this.Hide();

        }

      
        
 
  

       
  
    }
}
