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
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.cbox_Perfiles = new System.Windows.Forms.ComboBox();
            this.perfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seleccionBDDataSet = new P.SeleccionBDDataSet();
            this.txt_nickNameUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizarPerfil = new System.Windows.Forms.Button();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabEstadistica = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabCandidato = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.perfilesTableAdapter = new P.SeleccionBDDataSetTableAdapters.PerfilesTableAdapter();
            this.perfilesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuSuperio.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.TabSistemaSeleccion.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seleccionBDDataSet)).BeginInit();
            this.tabMantenimiento.SuspendLayout();
            this.tabEstadistica.SuspendLayout();
            this.tabCandidato.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSuperio
            // 
            this.menuSuperio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuSuperio.Location = new System.Drawing.Point(0, 0);
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
            this.panelMenu.Location = new System.Drawing.Point(0, 24);
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
            this.btn_Candidato.TabStop = true;
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
            this.btn_Estadistica.TabStop = true;
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
            this.btn_Mantenimiento.TabStop = true;
            this.btn_Mantenimiento.Text = "Mantenimiento";
            this.btn_Mantenimiento.UseVisualStyleBackColor = true;
            this.btn_Mantenimiento.CheckedChanged += new System.EventHandler(this.btn_Mantenimiento_CheckedChanged);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Admin.AutoSize = true;
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
            this.TabSistemaSeleccion.Controls.Add(this.tabAdmin);
            this.TabSistemaSeleccion.Controls.Add(this.tabMantenimiento);
            this.TabSistemaSeleccion.Controls.Add(this.tabEstadistica);
            this.TabSistemaSeleccion.Controls.Add(this.tabCandidato);
            this.TabSistemaSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabSistemaSeleccion.Location = new System.Drawing.Point(0, 24);
            this.TabSistemaSeleccion.Name = "TabSistemaSeleccion";
            this.TabSistemaSeleccion.SelectedIndex = 0;
            this.TabSistemaSeleccion.Size = new System.Drawing.Size(875, 420);
            this.TabSistemaSeleccion.TabIndex = 2;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.cbox_Perfiles);
            this.tabAdmin.Controls.Add(this.txt_nickNameUsuario);
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
            // cbox_Perfiles
            // 
            this.cbox_Perfiles.DataSource = this.perfilesBindingSource;
            this.cbox_Perfiles.DisplayMember = "nomperfil";
            this.cbox_Perfiles.FormattingEnabled = true;
            this.cbox_Perfiles.Location = new System.Drawing.Point(332, 138);
            this.cbox_Perfiles.Name = "cbox_Perfiles";
            this.cbox_Perfiles.Size = new System.Drawing.Size(121, 21);
            this.cbox_Perfiles.TabIndex = 5;
            this.cbox_Perfiles.ValueMember = "codPerfil";
            // 
            // perfilesBindingSource
            // 
            this.perfilesBindingSource.DataMember = "Perfiles";
            this.perfilesBindingSource.DataSource = this.seleccionBDDataSet;
            // 
            // seleccionBDDataSet
            // 
            this.seleccionBDDataSet.DataSetName = "SeleccionBDDataSet";
            this.seleccionBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_nickNameUsuario
            // 
            this.txt_nickNameUsuario.Location = new System.Drawing.Point(332, 100);
            this.txt_nickNameUsuario.Name = "txt_nickNameUsuario";
            this.txt_nickNameUsuario.Size = new System.Drawing.Size(218, 20);
            this.txt_nickNameUsuario.TabIndex = 4;
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
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nick Name Usuario";
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
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.checkBox1);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMantenimiento.Size = new System.Drawing.Size(867, 394);
            this.tabMantenimiento.TabIndex = 1;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabEstadistica
            // 
            this.tabEstadistica.Controls.Add(this.button2);
            this.tabEstadistica.Controls.Add(this.checkBox2);
            this.tabEstadistica.Location = new System.Drawing.Point(4, 22);
            this.tabEstadistica.Name = "tabEstadistica";
            this.tabEstadistica.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstadistica.Size = new System.Drawing.Size(867, 394);
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
            this.tabCandidato.Controls.Add(this.radioButton1);
            this.tabCandidato.Location = new System.Drawing.Point(4, 22);
            this.tabCandidato.Name = "tabCandidato";
            this.tabCandidato.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidato.Size = new System.Drawing.Size(867, 394);
            this.tabCandidato.TabIndex = 3;
            this.tabCandidato.Text = "Candidato";
            this.tabCandidato.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            // perfilesTableAdapter
            // 
            this.perfilesTableAdapter.ClearBeforeFill = true;
            // 
            // perfilesBindingSource1
            // 
            this.perfilesBindingSource1.DataMember = "Perfiles";
            this.perfilesBindingSource1.DataSource = this.seleccionBDDataSet;
            // 
            // FormAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 444);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TabSistemaSeleccion);
            this.Controls.Add(this.menuSuperio);
            this.Name = "FormAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Selección";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAplicacion_Load);
            this.menuSuperio.ResumeLayout(false);
            this.menuSuperio.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.TabSistemaSeleccion.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tabAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seleccionBDDataSet)).EndInit();
            this.tabMantenimiento.ResumeLayout(false);
            this.tabMantenimiento.PerformLayout();
            this.tabEstadistica.ResumeLayout(false);
            this.tabEstadistica.PerformLayout();
            this.tabCandidato.ResumeLayout(false);
            this.tabCandidato.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_Perfiles;
        private System.Windows.Forms.TextBox txt_nickNameUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private SeleccionBDDataSet seleccionBDDataSet;
        private System.Windows.Forms.BindingSource perfilesBindingSource;
        private SeleccionBDDataSetTableAdapters.PerfilesTableAdapter perfilesTableAdapter;
        private System.Windows.Forms.BindingSource perfilesBindingSource1;
    }
}