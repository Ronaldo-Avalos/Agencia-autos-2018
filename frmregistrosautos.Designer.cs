namespace Agencia
{
    partial class frmregistrosautos
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
            this.panelinsertarautos = new System.Windows.Forms.Panel();
            this.btnregresar1 = new System.Windows.Forms.Button();
            this.btnañadir = new System.Windows.Forms.Button();
            this.lblimg = new System.Windows.Forms.Label();
            this.cmbusos = new System.Windows.Forms.ComboBox();
            this.pcbimagen = new System.Windows.Forms.PictureBox();
            this.cmbanos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnimagen = new System.Windows.Forms.Button();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.txtdueño = new System.Windows.Forms.TextBox();
            this.txtplacas = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelinsertarautos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panelinsertarautos
            // 
            this.panelinsertarautos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelinsertarautos.BackgroundImage = global::Agencia.Properties.Resources.kia01;
            this.panelinsertarautos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelinsertarautos.Controls.Add(this.btnregresar1);
            this.panelinsertarautos.Controls.Add(this.btnañadir);
            this.panelinsertarautos.Controls.Add(this.lblimg);
            this.panelinsertarautos.Controls.Add(this.cmbusos);
            this.panelinsertarautos.Controls.Add(this.pcbimagen);
            this.panelinsertarautos.Controls.Add(this.cmbanos);
            this.panelinsertarautos.Controls.Add(this.label8);
            this.panelinsertarautos.Controls.Add(this.label6);
            this.panelinsertarautos.Controls.Add(this.label7);
            this.panelinsertarautos.Controls.Add(this.label5);
            this.panelinsertarautos.Controls.Add(this.label4);
            this.panelinsertarautos.Controls.Add(this.label3);
            this.panelinsertarautos.Controls.Add(this.label9);
            this.panelinsertarautos.Controls.Add(this.label2);
            this.panelinsertarautos.Controls.Add(this.label1);
            this.panelinsertarautos.Controls.Add(this.btnimagen);
            this.panelinsertarautos.Controls.Add(this.txtimagen);
            this.panelinsertarautos.Controls.Add(this.txtdueño);
            this.panelinsertarautos.Controls.Add(this.txtplacas);
            this.panelinsertarautos.Controls.Add(this.txtmarca);
            this.panelinsertarautos.Controls.Add(this.txtserie);
            this.panelinsertarautos.Controls.Add(this.txtmodelo);
            this.panelinsertarautos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelinsertarautos.Location = new System.Drawing.Point(0, 0);
            this.panelinsertarautos.Name = "panelinsertarautos";
            this.panelinsertarautos.Size = new System.Drawing.Size(542, 364);
            this.panelinsertarautos.TabIndex = 2;
            this.panelinsertarautos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelinsertarautos_Paint);
            // 
            // btnregresar1
            // 
            this.btnregresar1.Location = new System.Drawing.Point(455, 329);
            this.btnregresar1.Name = "btnregresar1";
            this.btnregresar1.Size = new System.Drawing.Size(75, 23);
            this.btnregresar1.TabIndex = 0;
            this.btnregresar1.Text = "Regresar";
            this.btnregresar1.UseVisualStyleBackColor = true;
            this.btnregresar1.Click += new System.EventHandler(this.btnregresar1_Click_1);
            // 
            // btnañadir
            // 
            this.btnañadir.Location = new System.Drawing.Point(321, 241);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(103, 57);
            this.btnañadir.TabIndex = 1;
            this.btnañadir.Text = "Añadir\r\nRegistro";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click_1);
            // 
            // lblimg
            // 
            this.lblimg.AutoSize = true;
            this.lblimg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblimg.Location = new System.Drawing.Point(352, 127);
            this.lblimg.Name = "lblimg";
            this.lblimg.Size = new System.Drawing.Size(49, 13);
            this.lblimg.TabIndex = 7;
            this.lblimg.Text = "IMAGEN";
            // 
            // cmbusos
            // 
            this.cmbusos.FormattingEnabled = true;
            this.cmbusos.Location = new System.Drawing.Point(111, 236);
            this.cmbusos.Name = "cmbusos";
            this.cmbusos.Size = new System.Drawing.Size(103, 21);
            this.cmbusos.TabIndex = 6;
            // 
            // pcbimagen
            // 
            this.pcbimagen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pcbimagen.Location = new System.Drawing.Point(271, 62);
            this.pcbimagen.Name = "pcbimagen";
            this.pcbimagen.Size = new System.Drawing.Size(206, 142);
            this.pcbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbimagen.TabIndex = 5;
            this.pcbimagen.TabStop = false;
            // 
            // cmbanos
            // 
            this.cmbanos.FormattingEnabled = true;
            this.cmbanos.Location = new System.Drawing.Point(111, 95);
            this.cmbanos.Name = "cmbanos";
            this.cmbanos.Size = new System.Drawing.Size(103, 21);
            this.cmbanos.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Añadir registros a autos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Imagen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "No.Dueño";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Uso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Placas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "No.Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // btnimagen
            // 
            this.btnimagen.Location = new System.Drawing.Point(231, 312);
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.Size = new System.Drawing.Size(61, 20);
            this.btnimagen.TabIndex = 1;
            this.btnimagen.Text = "Examinar";
            this.btnimagen.UseVisualStyleBackColor = true;
            this.btnimagen.Click += new System.EventHandler(this.btnimagen_Click);
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(111, 312);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(103, 20);
            this.txtimagen.TabIndex = 0;
            // 
            // txtdueño
            // 
            this.txtdueño.Location = new System.Drawing.Point(111, 278);
            this.txtdueño.Name = "txtdueño";
            this.txtdueño.Size = new System.Drawing.Size(103, 20);
            this.txtdueño.TabIndex = 0;
            // 
            // txtplacas
            // 
            this.txtplacas.Location = new System.Drawing.Point(111, 201);
            this.txtplacas.Name = "txtplacas";
            this.txtplacas.Size = new System.Drawing.Size(103, 20);
            this.txtplacas.TabIndex = 0;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(111, 165);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(103, 20);
            this.txtmarca.TabIndex = 0;
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(111, 62);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(103, 20);
            this.txtserie.TabIndex = 0;
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(111, 128);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(103, 20);
            this.txtmodelo.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmregistrosautos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agencia.Properties.Resources.kia01;
            this.ClientSize = new System.Drawing.Size(542, 364);
            this.Controls.Add(this.panelinsertarautos);
            this.Name = "frmregistrosautos";
            this.Text = "frmregistrosautos";
            this.Load += new System.EventHandler(this.frmregistrosautos_Load);
            this.panelinsertarautos.ResumeLayout(false);
            this.panelinsertarautos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbimagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelinsertarautos;
        private System.Windows.Forms.Button btnregresar1;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Label lblimg;
        private System.Windows.Forms.ComboBox cmbusos;
        private System.Windows.Forms.PictureBox pcbimagen;
        private System.Windows.Forms.ComboBox cmbanos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnimagen;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.TextBox txtdueño;
        private System.Windows.Forms.TextBox txtplacas;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}