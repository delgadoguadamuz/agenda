﻿namespace agenda
{
    partial class agendaPersonal
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
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxDirrecion = new System.Windows.Forms.TextBox();
            this.tbxTelefonoCasa = new System.Windows.Forms.TextBox();
            this.tbxTelefonoCelular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.smiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(43, 49);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(132, 22);
            this.tbxNombre.TabIndex = 0;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(184, 49);
            this.tbxApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(132, 22);
            this.tbxApellido.TabIndex = 1;
            // 
            // tbxDirrecion
            // 
            this.tbxDirrecion.Location = new System.Drawing.Point(325, 49);
            this.tbxDirrecion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDirrecion.Name = "tbxDirrecion";
            this.tbxDirrecion.Size = new System.Drawing.Size(132, 22);
            this.tbxDirrecion.TabIndex = 2;
            // 
            // tbxTelefonoCasa
            // 
            this.tbxTelefonoCasa.Location = new System.Drawing.Point(467, 49);
            this.tbxTelefonoCasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTelefonoCasa.Name = "tbxTelefonoCasa";
            this.tbxTelefonoCasa.Size = new System.Drawing.Size(132, 22);
            this.tbxTelefonoCasa.TabIndex = 3;
            // 
            // tbxTelefonoCelular
            // 
            this.tbxTelefonoCelular.Location = new System.Drawing.Point(608, 49);
            this.tbxTelefonoCelular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTelefonoCelular.Name = "tbxTelefonoCelular";
            this.tbxTelefonoCelular.Size = new System.Drawing.Size(132, 22);
            this.tbxTelefonoCelular.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefono Casa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono Celular";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(760, 33);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 28);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(43, 97);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(943, 224);
            this.dgvContactos.TabIndex = 11;
            this.dgvContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsMenu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnsMenu
            // 
            this.mnsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smiGuardar});
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(71, 24);
            this.mnsMenu.Text = "Archivo";
            this.mnsMenu.Click += new System.EventHandler(this.mnsMenu_Click);
            // 
            // smiGuardar
            // 
            this.smiGuardar.Name = "smiGuardar";
            this.smiGuardar.Size = new System.Drawing.Size(137, 26);
            this.smiGuardar.Text = "Guardar";
            this.smiGuardar.Click += new System.EventHandler(this.smiGuardar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(886, 33);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(119, 28);
            this.btnCargarArchivo.TabIndex = 14;
            this.btnCargarArchivo.Text = "Cargar Agenda";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // agendaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 352);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTelefonoCelular);
            this.Controls.Add(this.tbxTelefonoCasa);
            this.Controls.Add(this.tbxDirrecion);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "agendaPersonal";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.agendaPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxDirrecion;
        private System.Windows.Forms.TextBox tbxTelefonoCasa;
        private System.Windows.Forms.TextBox tbxTelefonoCelular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem smiGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCargarArchivo;
    }
}

