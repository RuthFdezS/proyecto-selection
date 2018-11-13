namespace P
{
    partial class FrmExpediente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEDAD = new System.Windows.Forms.TextBox();
            this.txtAPE = new System.Windows.Forms.TextBox();
            this.txtNOM = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCertificacion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCanton = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDistrito);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboCanton);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cboProvincia);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboTitulo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboCertificacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboIdioma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtEDAD);
            this.groupBox1.Controls.Add(this.txtAPE);
            this.groupBox1.Controls.Add(this.txtNOM);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.cboEstadoCivil);
            this.groupBox1.Controls.Add(this.cboGenero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion por ingresar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(264, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEDAD
            // 
            this.txtEDAD.Location = new System.Drawing.Point(127, 100);
            this.txtEDAD.Name = "txtEDAD";
            this.txtEDAD.Size = new System.Drawing.Size(98, 20);
            this.txtEDAD.TabIndex = 11;
            // 
            // txtAPE
            // 
            this.txtAPE.Location = new System.Drawing.Point(127, 74);
            this.txtAPE.MaxLength = 50;
            this.txtAPE.Name = "txtAPE";
            this.txtAPE.Size = new System.Drawing.Size(98, 20);
            this.txtAPE.TabIndex = 10;
            // 
            // txtNOM
            // 
            this.txtNOM.Location = new System.Drawing.Point(127, 48);
            this.txtNOM.MaxLength = 50;
            this.txtNOM.Name = "txtNOM";
            this.txtNOM.Size = new System.Drawing.Size(98, 20);
            this.txtNOM.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 22);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(98, 20);
            this.txtID.TabIndex = 8;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(127, 192);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(98, 21);
            this.cboEstadoCivil.TabIndex = 7;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(127, 165);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(98, 21);
            this.cboGenero.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado civil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(383, 16);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(412, 383);
            this.dgvDatos.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Correo Electronico:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(127, 219);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(98, 21);
            this.cboIdioma.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Idioma:";
            // 
            // cboCertificacion
            // 
            this.cboCertificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCertificacion.FormattingEnabled = true;
            this.cboCertificacion.Location = new System.Drawing.Point(127, 246);
            this.cboCertificacion.Name = "cboCertificacion";
            this.cboCertificacion.Size = new System.Drawing.Size(98, 21);
            this.cboCertificacion.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Certificacion:";
            // 
            // cboTitulo
            // 
            this.cboTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Location = new System.Drawing.Point(127, 273);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(98, 21);
            this.cboTitulo.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Titulo:";
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(127, 300);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(98, 21);
            this.cboProvincia.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Provincia:";
            // 
            // cboCanton
            // 
            this.cboCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCanton.FormattingEnabled = true;
            this.cboCanton.Location = new System.Drawing.Point(127, 327);
            this.cboCanton.Name = "cboCanton";
            this.cboCanton.Size = new System.Drawing.Size(98, 21);
            this.cboCanton.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Canton:";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(127, 354);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(98, 21);
            this.cboDistrito.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Distrito:";
            // 
            // FrmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 411);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expedientes";
            this.Load += new System.EventHandler(this.FrmExpediente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEDAD;
        private System.Windows.Forms.TextBox txtAPE;
        private System.Windows.Forms.TextBox txtNOM;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboCertificacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboCanton;
        private System.Windows.Forms.Label label12;
    }
}

