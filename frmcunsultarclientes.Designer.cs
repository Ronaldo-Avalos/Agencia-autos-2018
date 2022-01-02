namespace Agencia
{
    partial class frmcunsultarclientes
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnbuscar2 = new System.Windows.Forms.Button();
            this.txtdato1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcampos1 = new System.Windows.Forms.ComboBox();
            this.btnregrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(36, 97);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(578, 245);
            this.dgv.TabIndex = 0;
            // 
            // btnbuscar2
            // 
            this.btnbuscar2.Location = new System.Drawing.Point(505, 34);
            this.btnbuscar2.Name = "btnbuscar2";
            this.btnbuscar2.Size = new System.Drawing.Size(75, 46);
            this.btnbuscar2.TabIndex = 1;
            this.btnbuscar2.Text = "Buscar";
            this.btnbuscar2.UseVisualStyleBackColor = true;
            this.btnbuscar2.Click += new System.EventHandler(this.btnbuscar2_Click);
            // 
            // txtdato1
            // 
            this.txtdato1.Location = new System.Drawing.Point(349, 48);
            this.txtdato1.Name = "txtdato1";
            this.txtdato1.Size = new System.Drawing.Size(100, 20);
            this.txtdato1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dato";
            // 
            // cmbcampos1
            // 
            this.cmbcampos1.FormattingEnabled = true;
            this.cmbcampos1.Items.AddRange(new object[] {
            "no_dueno",
            "apellidos",
            "nombres",
            "fecha_nacimientos",
            "estado",
            "domicilio",
            "telfono",
            "celular"});
            this.cmbcampos1.Location = new System.Drawing.Point(99, 51);
            this.cmbcampos1.Name = "cmbcampos1";
            this.cmbcampos1.Size = new System.Drawing.Size(121, 21);
            this.cmbcampos1.TabIndex = 4;
            this.cmbcampos1.SelectedIndexChanged += new System.EventHandler(this.cmbcampos1_SelectedIndexChanged);
            // 
            // btnregrear
            // 
            this.btnregrear.Location = new System.Drawing.Point(539, 362);
            this.btnregrear.Name = "btnregrear";
            this.btnregrear.Size = new System.Drawing.Size(75, 23);
            this.btnregrear.TabIndex = 1;
            this.btnregrear.Text = "Regresar";
            this.btnregrear.UseVisualStyleBackColor = true;
            this.btnregrear.Click += new System.EventHandler(this.btnregrear_Click);
            // 
            // frmcunsultarclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agencia.Properties.Resources.agencia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 406);
            this.Controls.Add(this.cmbcampos1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdato1);
            this.Controls.Add(this.btnregrear);
            this.Controls.Add(this.btnbuscar2);
            this.Controls.Add(this.dgv);
            this.Name = "frmcunsultarclientes";
            this.Text = "frmcunsultarclientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnbuscar2;
        private System.Windows.Forms.TextBox txtdato1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcampos1;
        private System.Windows.Forms.Button btnregrear;
    }
}