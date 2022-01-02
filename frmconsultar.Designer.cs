namespace Agencia
{
    partial class frmconsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnbuscar1 = new System.Windows.Forms.Button();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcampos = new System.Windows.Forms.ComboBox();
            this.dgvmostrar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregresar2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar1
            // 
            this.btnbuscar1.Location = new System.Drawing.Point(502, 51);
            this.btnbuscar1.Name = "btnbuscar1";
            this.btnbuscar1.Size = new System.Drawing.Size(75, 41);
            this.btnbuscar1.TabIndex = 0;
            this.btnbuscar1.Text = "Buscar";
            this.btnbuscar1.UseVisualStyleBackColor = true;
            this.btnbuscar1.Click += new System.EventHandler(this.btnbuscar1_Click);
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(356, 62);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(100, 20);
            this.txtdato.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dato";
            // 
            // cmbcampos
            // 
            this.cmbcampos.FormattingEnabled = true;
            this.cmbcampos.Location = new System.Drawing.Point(123, 61);
            this.cmbcampos.Name = "cmbcampos";
            this.cmbcampos.Size = new System.Drawing.Size(107, 21);
            this.cmbcampos.TabIndex = 3;
            this.cmbcampos.Text = "NO.AUTO";
            // 
            // dgvmostrar
            // 
            this.dgvmostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmostrar.Location = new System.Drawing.Point(27, 107);
            this.dgvmostrar.Name = "dgvmostrar";
            this.dgvmostrar.Size = new System.Drawing.Size(581, 233);
            this.dgvmostrar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar";
            // 
            // btnregresar2
            // 
            this.btnregresar2.Location = new System.Drawing.Point(533, 356);
            this.btnregresar2.Name = "btnregresar2";
            this.btnregresar2.Size = new System.Drawing.Size(75, 23);
            this.btnregresar2.TabIndex = 0;
            this.btnregresar2.Text = "Regresar";
            this.btnregresar2.UseVisualStyleBackColor = true;
            this.btnregresar2.Click += new System.EventHandler(this.btnregresar2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Campo";
            // 
            // frmconsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agencia.Properties.Resources.kia01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvmostrar);
            this.Controls.Add(this.cmbcampos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.btnregresar2);
            this.Controls.Add(this.btnbuscar1);
            this.Name = "frmconsultar";
            this.Text = "frmconsultar";
            this.Load += new System.EventHandler(this.frmconsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar1;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcampos;
        private System.Windows.Forms.DataGridView dgvmostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnregresar2;
        private System.Windows.Forms.Label label3;
    }
}