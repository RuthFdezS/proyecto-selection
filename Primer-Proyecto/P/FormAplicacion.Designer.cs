namespace P
{
    partial class FormAplicacion
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
            this.components = new System.ComponentModel.Container();
            this.menuSuperio = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Candidato = new System.Windows.Forms.RadioButton();
            this.btn_Estadistica = new System.Windows.Forms.RadioButton();
            this.btn_Mantenimiento = new System.Windows.Forms.RadioButton();
            this.btn_Admin = new System.Windows.Forms.RadioButton();
            this.TabSistemaSeleccion = new System.Windows.Forms.TabControl();
<<<<<<< HEAD
=======
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizarPerfil = new System.Windows.Forms.Button();
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_expediente = new System.Windows.Forms.Button();
            this.tabEstadistica = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabCandidato = new System.Windows.Forms.TabPage();
<<<<<<< HEAD
            this.label5 = new System.Windows.Forms.Label();
            this.btn_puesto = new System.Windows.Forms.Button();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.cb_Perfil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizarPerfil = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.perfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
=======
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.perfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            this.perfilesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cb_Perfil = new System.Windows.Forms.ComboBox();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuSuperio.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.TabSistemaSeleccion.SuspendLayout();
<<<<<<< HEAD
            this.tabMantenimiento.SuspendLayout();
            this.tabEstadistica.SuspendLayout();
            this.tabCandidato.SuspendLayout();
            this.tabAdmin.SuspendLayout();
=======
            this.tabAdmin.SuspendLayout();
            this.tabMantenimiento.SuspendLayout();
            this.tabEstadistica.SuspendLayout();
            this.tabCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).BeginInit();
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSuperio
            // 
            this.menuSuperio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuSuperio.Location = new System.Drawing.Point(0, 46);
            this.menuSuperio.Name = "menuSuperio";
            this.menuSuperio.Size = new System.Drawing.Size(875, 24);
            this.menuSuperio.TabIndex = 0;
            this.menuSuperio.Text = "menuSup";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesónToolStripMenuItem,
            this.cerrarSistemaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // cerrarSesónToolStripMenuItem
            // 
            this.cerrarSesónToolStripMenuItem.Name = "cerrarSesónToolStripMenuItem";
            this.cerrarSesónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarSesónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesónToolStripMenuItem_Click);
            // 
            // cerrarSistemaToolStripMenuItem
            // 
            this.cerrarSistemaToolStripMenuItem.Name = "cerrarSistemaToolStripMenuItem";
            this.cerrarSistemaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarSistemaToolStripMenuItem.Text = "Cerrar Sistema";
            this.cerrarSistemaToolStripMenuItem.Click += new System.EventHandler(this.cerrarSistemaToolStripMenuItem_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelMenu.Controls.Add(this.btn_Candidato);
            this.panelMenu.Controls.Add(this.btn_Estadistica);
            this.panelMenu.Controls.Add(this.btn_Mantenimiento);
            this.panelMenu.Controls.Add(this.btn_Admin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(875, 46);
            this.panelMenu.TabIndex = 1;
            // 
            // btn_Candidato
            // 
            this.btn_Candidato.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Candidato.AutoSize = true;
            this.btn_Candidato.FlatAppearance.BorderSize = 0;
            this.btn_Candidato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Candidato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_Candidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Candidato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Candidato.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Candidato.Location = new System.Drawing.Point(422, 11);
            this.btn_Candidato.Name = "btn_Candidato";
            this.btn_Candidato.Size = new System.Drawing.Size(109, 29);
            this.btn_Candidato.TabIndex = 3;
            this.btn_Candidato.Text = "Candidatos";
            this.btn_Candidato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Candidato.UseVisualStyleBackColor = true;
            this.btn_Candidato.CheckedChanged += new System.EventHandler(this.btn_Candidato_CheckedChanged);
            // 
            // btn_Estadistica
            // 
            this.btn_Estadistica.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Estadistica.AutoSize = true;
            this.btn_Estadistica.FlatAppearance.BorderSize = 0;
            this.btn_Estadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Estadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_Estadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estadistica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Estadistica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Estadistica.Location = new System.Drawing.Point(312, 11);
            this.btn_Estadistica.Name = "btn_Estadistica";
            this.btn_Estadistica.Size = new System.Drawing.Size(104, 29);
            this.btn_Estadistica.TabIndex = 2;
            this.btn_Estadistica.Text = "Estadísticas";
            this.btn_Estadistica.UseVisualStyleBackColor = true;
            this.btn_Estadistica.CheckedChanged += new System.EventHandler(this.btn_Estadistica_CheckedChanged);
            // 
            // btn_Mantenimiento
            // 
            this.btn_Mantenimiento.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Mantenimiento.AutoSize = true;
            this.btn_Mantenimiento.FlatAppearance.BorderSize = 0;
            this.btn_Mantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Mantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mantenimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mantenimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Mantenimiento.Location = new System.Drawing.Point(173, 11);
            this.btn_Mantenimiento.Name = "btn_Mantenimiento";
            this.btn_Mantenimiento.Size = new System.Drawing.Size(136, 29);
            this.btn_Mantenimiento.TabIndex = 1;
            this.btn_Mantenimiento.Text = "Mantenimiento";
            this.btn_Mantenimiento.UseVisualStyleBackColor = true;
            this.btn_Mantenimiento.CheckedChanged += new System.EventHandler(this.btn_Mantenimiento_CheckedChanged);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Admin.AutoSize = true;
            this.btn_Admin.Checked = true;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Admin.Location = new System.Drawing.Point(39, 11);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(128, 29);
            this.btn_Admin.TabIndex = 0;
            this.btn_Admin.TabStop = true;
            this.btn_Admin.Text = "Administrador";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.CheckedChanged += new System.EventHandler(this.btn_Admin_CheckedChanged);
            // 
            // TabSistemaSeleccion
            // 
            this.TabSistemaSeleccion.Controls.Add(this.tabMantenimiento);
            this.TabSistemaSeleccion.Controls.Add(this.tabEstadistica);
            this.TabSistemaSeleccion.Controls.Add(this.tabCandidato);
            this.TabSistemaSeleccion.Controls.Add(this.tabAdmin);
            this.TabSistemaSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabSistemaSeleccion.Location = new System.Drawing.Point(0, 70);
            this.TabSistemaSeleccion.Name = "TabSistemaSeleccion";
            this.TabSistemaSeleccion.SelectedIndex = 0;
            this.TabSistemaSeleccion.Size = new System.Drawing.Size(875, 374);
            this.TabSistemaSeleccion.TabIndex = 2;
            // 
<<<<<<< HEAD
=======
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.comboBox1);
            this.tabAdmin.Controls.Add(this.cb_Usuario);
            this.tabAdmin.Controls.Add(this.cb_Perfil);
            this.tabAdmin.Controls.Add(this.label3);
            this.tabAdmin.Controls.Add(this.label2);
            this.tabAdmin.Controls.Add(this.label1);
            this.tabAdmin.Controls.Add(this.btn_actualizarPerfil);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(867, 394);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.Text = "Administrador";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CAMBIAR PERMISOS";
            // 
            // btn_actualizarPerfil
            // 
            this.btn_actualizarPerfil.Location = new System.Drawing.Point(386, 195);
            this.btn_actualizarPerfil.Name = "btn_actualizarPerfil";
            this.btn_actualizarPerfil.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizarPerfil.TabIndex = 0;
            this.btn_actualizarPerfil.Text = "Actualizar";
            this.btn_actualizarPerfil.UseVisualStyleBackColor = true;
            this.btn_actualizarPerfil.Click += new System.EventHandler(this.btn_actualizarPerfil_Click);
            // 
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.label4);
            this.tabMantenimiento.Controls.Add(this.btn_expediente);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(867, 348);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Creación de un nuevo Expediente ";
            // 
            // btn_expediente
            // 
            this.btn_expediente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_expediente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expediente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_expediente.Location = new System.Drawing.Point(286, 91);
            this.btn_expediente.Name = "btn_expediente";
            this.btn_expediente.Size = new System.Drawing.Size(283, 148);
            this.btn_expediente.TabIndex = 0;
            this.btn_expediente.Text = "EXPEDIENTE";
            this.btn_expediente.UseVisualStyleBackColor = false;
            this.btn_expediente.Click += new System.EventHandler(this.btn_expediente_Click);
            // 
            // tabEstadistica
            // 
            this.tabEstadistica.Controls.Add(this.button2);
            this.tabEstadistica.Controls.Add(this.checkBox2);
            this.tabEstadistica.Location = new System.Drawing.Point(4, 22);
            this.tabEstadistica.Name = "tabEstadistica";
            this.tabEstadistica.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstadistica.Size = new System.Drawing.Size(867, 348);
            this.tabEstadistica.TabIndex = 2;
            this.tabEstadistica.Text = "Estadisticas";
            this.tabEstadistica.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(35, 34);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tabCandidato
            // 
            this.tabCandidato.Controls.Add(this.label5);
            this.tabCandidato.Controls.Add(this.btn_puesto);
            this.tabCandidato.Location = new System.Drawing.Point(4, 22);
            this.tabCandidato.Name = "tabCandidato";
            this.tabCandidato.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidato.Size = new System.Drawing.Size(867, 348);
            this.tabCandidato.TabIndex = 3;
            this.tabCandidato.Text = "Candidato";
            this.tabCandidato.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Creación de un nuevo Puesto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_puesto
            // 
            this.btn_puesto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_puesto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_puesto.Location = new System.Drawing.Point(292, 100);
            this.btn_puesto.Name = "btn_puesto";
            this.btn_puesto.Size = new System.Drawing.Size(283, 148);
            this.btn_puesto.TabIndex = 1;
            this.btn_puesto.Text = "PUESTO";
            this.btn_puesto.UseVisualStyleBackColor = false;
            this.btn_puesto.Click += new System.EventHandler(this.btn_puesto_Click);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.cb_Usuario);
            this.tabAdmin.Controls.Add(this.cb_Perfil);
            this.tabAdmin.Controls.Add(this.label3);
            this.tabAdmin.Controls.Add(this.label2);
            this.tabAdmin.Controls.Add(this.label1);
            this.tabAdmin.Controls.Add(this.btn_actualizarPerfil);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(867, 348);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.Text = "Administrador";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Items.AddRange(new object[] {
            "Maria Vargas",
            "Juan Gomez",
            "Ana Montes",
            "Antoni Díaz",
            "Rebeca Herrera"});
            this.cb_Usuario.Location = new System.Drawing.Point(332, 91);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(221, 29);
            this.cb_Usuario.TabIndex = 5;
            this.cb_Usuario.SelectedIndexChanged += new System.EventHandler(this.cb_Usuario_SelectedIndexChanged);
            // 
            // cb_Perfil
            // 
            this.cb_Perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Perfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Perfil.FormattingEnabled = true;
            this.cb_Perfil.Items.AddRange(new object[] {
            "Administrador",
            "Mantenimiento",
            "Estadístico",
            "Candidatos"});
            this.cb_Perfil.Location = new System.Drawing.Point(331, 140);
            this.cb_Perfil.Name = "cb_Perfil";
            this.cb_Perfil.Size = new System.Drawing.Size(222, 29);
            this.cb_Perfil.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CAMBIAR PERMISOS";
            // 
            // btn_actualizarPerfil
            // 
            this.btn_actualizarPerfil.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_actualizarPerfil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarPerfil.ForeColor = System.Drawing.Color.MintCream;
            this.btn_actualizarPerfil.Location = new System.Drawing.Point(386, 195);
            this.btn_actualizarPerfil.Name = "btn_actualizarPerfil";
            this.btn_actualizarPerfil.Size = new System.Drawing.Size(141, 50);
            this.btn_actualizarPerfil.TabIndex = 0;
            this.btn_actualizarPerfil.Text = "Actualizar";
            this.btn_actualizarPerfil.UseVisualStyleBackColor = false;
            this.btn_actualizarPerfil.Click += new System.EventHandler(this.btn_actualizarPerfil_Click);
            // 
            // perfilesBindingSource
            // 
            this.perfilesBindingSource.DataMember = "Perfiles";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_usuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel1.Text = "Usuario logueado:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tssl_usuario
            // 
            this.tssl_usuario.Name = "tssl_usuario";
            this.tssl_usuario.Size = new System.Drawing.Size(72, 17);
            this.tssl_usuario.Text = "(sin usuario)";
            // 
<<<<<<< HEAD
            // perfilesBindingSource
            // 
            this.perfilesBindingSource.DataMember = "Perfiles";
            // 
            // perfilesBindingSource1
            // 
            this.perfilesBindingSource1.DataMember = "Perfiles";
=======
            // perfilesBindingSource1
            // 
            this.perfilesBindingSource1.DataMember = "Perfiles";
            // 
            // cb_Perfil
            // 
            this.cb_Perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Perfil.FormattingEnabled = true;
            this.cb_Perfil.Items.AddRange(new object[] {
            "Administrador",
            "Mantenimiento",
            "Estadístico",
            "Candidatos"});
            this.cb_Perfil.Location = new System.Drawing.Point(332, 130);
            this.cb_Perfil.Name = "cb_Perfil";
            this.cb_Perfil.Size = new System.Drawing.Size(121, 21);
            this.cb_Perfil.TabIndex = 4;
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Items.AddRange(new object[] {
            "Maria Vargas",
            "Juan Gomez",
            "Ana Montes",
            "Antoni Díaz",
            "Rebeca Herrera"});
            this.cb_Usuario.Location = new System.Drawing.Point(332, 91);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(121, 21);
            this.cb_Usuario.TabIndex = 5;
            this.cb_Usuario.SelectedIndexChanged += new System.EventHandler(this.cb_Usuario_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(534, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            // 
            // FormAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TabSistemaSeleccion);
            this.Controls.Add(this.menuSuperio);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Selección";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuSuperio.ResumeLayout(false);
            this.menuSuperio.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.TabSistemaSeleccion.ResumeLayout(false);
<<<<<<< HEAD
=======
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            this.tabMantenimiento.ResumeLayout(false);
            this.tabMantenimiento.PerformLayout();
            this.tabEstadistica.ResumeLayout(false);
            this.tabEstadistica.PerformLayout();
            this.tabCandidato.ResumeLayout(false);
            this.tabCandidato.PerformLayout();
<<<<<<< HEAD
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
=======
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).EndInit();
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSuperio;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSistemaToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.TabControl TabSistemaSeleccion;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.TabPage tabEstadistica;
        private System.Windows.Forms.TabPage tabCandidato;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_usuario;
        private System.Windows.Forms.RadioButton btn_Candidato;
        private System.Windows.Forms.RadioButton btn_Estadistica;
        private System.Windows.Forms.RadioButton btn_Mantenimiento;
        private System.Windows.Forms.RadioButton btn_Admin;
        private System.Windows.Forms.Button btn_actualizarPerfil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource perfilesBindingSource;
        private System.Windows.Forms.BindingSource perfilesBindingSource1;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private System.Windows.Forms.ComboBox cb_Perfil;
<<<<<<< HEAD
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_expediente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_puesto;
=======
        private System.Windows.Forms.ComboBox comboBox1;
>>>>>>> 6d1d6dde61926c1ef9f2b171a7285dcf51d70d66
    }
}