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
<<<<<<< HEAD
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcorreoelectronico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCertificacion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
=======
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
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
<<<<<<< HEAD
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(383, 16);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(412, 402);
            this.dgvDatos.TabIndex = 1;
=======
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
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // btnAgregar
            // 
<<<<<<< HEAD
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
=======
            this.btnAgregar.Location = new System.Drawing.Point(264, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // txtEDAD
            // 
<<<<<<< HEAD
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
=======
            this.txtEDAD.Location = new System.Drawing.Point(127, 100);
            this.txtEDAD.Name = "txtEDAD";
            this.txtEDAD.Size = new System.Drawing.Size(98, 20);
            this.txtEDAD.TabIndex = 11;
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // txtAPE
            // 
<<<<<<< HEAD
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
=======
            this.txtAPE.Location = new System.Drawing.Point(127, 74);
            this.txtAPE.MaxLength = 50;
            this.txtAPE.Name = "txtAPE";
            this.txtAPE.Size = new System.Drawing.Size(98, 20);
            this.txtAPE.TabIndex = 10;
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // txtNOM
            // 
<<<<<<< HEAD
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nacimiento:";
=======
            this.txtNOM.Location = new System.Drawing.Point(127, 48);
            this.txtNOM.MaxLength = 50;
            this.txtNOM.Name = "txtNOM";
            this.txtNOM.Size = new System.Drawing.Size(98, 20);
            this.txtNOM.TabIndex = 9;
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // txtID
            // 
<<<<<<< HEAD
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Género:";
=======
            this.txtID.Location = new System.Drawing.Point(127, 22);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(98, 20);
            this.txtID.TabIndex = 8;
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // cboEstadoCivil
            // 
<<<<<<< HEAD
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado civil:";
=======
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
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // label6
            // 
<<<<<<< HEAD
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)",
            "Vuido(a)",
            "Divociado(a)"});
            this.cboEstadoCivil.Location = new System.Drawing.Point(127, 216);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(98, 23);
            this.cboEstadoCivil.TabIndex = 7;
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(127, 44);
            this.txtidentificacion.MaxLength = 20;
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(98, 23);
            this.txtidentificacion.TabIndex = 8;
            this.txtidentificacion.TextChanged += new System.EventHandler(this.txtidentificacion_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(127, 72);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(98, 23);
            this.txtnombre.TabIndex = 9;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(127, 98);
            this.txtapellido.MaxLength = 50;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(98, 23);
            this.txtapellido.TabIndex = 10;
=======
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
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // label1
            // 
<<<<<<< HEAD
            this.btnAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(264, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
=======
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Correo electrónico:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtcorreoelectronico
            // 
            this.txtcorreoelectronico.Location = new System.Drawing.Point(127, 161);
            this.txtcorreoelectronico.Name = "txtcorreoelectronico";
            this.txtcorreoelectronico.Size = new System.Drawing.Size(98, 23);
            this.txtcorreoelectronico.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Idioma:";
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Items.AddRange(new object[] {
            "Inglés",
            "Portugués",
            "Alemán"});
            this.cboIdioma.Location = new System.Drawing.Point(127, 326);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(98, 23);
            this.cboIdioma.TabIndex = 16;
            this.cboIdioma.SelectedIndexChanged += new System.EventHandler(this.cboIdioma_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Certificación:";
            // 
            // cboCertificacion
            // 
            this.cboCertificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCertificacion.FormattingEnabled = true;
            this.cboCertificacion.Items.AddRange(new object[] {
            "N/A",
            "Ninguna",
            "IT Essentials",
            "CCNA",
            "CCNP",
            "Licencia B1",
            "Otros"});
            this.cboCertificacion.Location = new System.Drawing.Point(127, 352);
            this.cboCertificacion.Name = "cboCertificacion";
            this.cboCertificacion.Size = new System.Drawing.Size(98, 23);
            this.cboCertificacion.TabIndex = 18;
            this.cboCertificacion.SelectedIndexChanged += new System.EventHandler(this.cboCertificacion_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Título:";
            // 
            // cboTitulo
            // 
            this.cboTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Items.AddRange(new object[] {
            "N/A",
            "Bachillerato en Educación Media",
            "Ingeniería de Sistemas",
            "Licenciatura en Ingeniería en Sistemas",
            "Doctorado en Ingenería en Sistemas",
            "Título Universitario"});
            this.cboTitulo.Location = new System.Drawing.Point(127, 378);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(98, 23);
            this.cboTitulo.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Dirección exacta:";
            // 
<<<<<<< HEAD
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGenero);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.txtpromedio);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtubicacion);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboTitulo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboCertificacion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboIdioma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcorreoelectronico);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtidentificacion);
            this.groupBox1.Controls.Add(this.cboEstadoCivil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion por ingresar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cboGenero.Location = new System.Drawing.Point(127, 245);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(98, 23);
            this.cboGenero.TabIndex = 35;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(264, 133);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 24);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.Location = new System.Drawing.Point(264, 93);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtpromedio
            // 
            this.txtpromedio.Location = new System.Drawing.Point(127, 302);
            this.txtpromedio.Margin = new System.Windows.Forms.Padding(2);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(98, 23);
            this.txtpromedio.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 305);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 31;
            this.label12.Text = "Promedio prueba:";
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(127, 189);
            this.txtubicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(98, 23);
            this.txtubicacion.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 280);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Información curricular";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(5, 20);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Información personal";
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(127, 129);
            this.dt.Margin = new System.Windows.Forms.Padding(2);
            this.dt.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dt.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(98, 23);
            this.dt.TabIndex = 27;
            this.dt.Value = new System.DateTime(2018, 11, 12, 20, 26, 56, 0);
=======
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(383, 16);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(412, 383);
            this.dgvDatos.TabIndex = 1;
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
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
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(806, 434);
=======
            this.ClientSize = new System.Drawing.Size(806, 411);
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expedientes";
            this.Load += new System.EventHandler(this.FrmExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcorreoelectronico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCertificacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboTitulo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtubicacion;
        private System.Windows.Forms.ComboBox cboGenero;
<<<<<<< HEAD
=======
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
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
    }
}

