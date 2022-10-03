namespace WindowsFormsApp1
{
    partial class Form1
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
            this.LbFechaInicio = new System.Windows.Forms.Label();
            this.TbFechaInicio = new System.Windows.Forms.TextBox();
            this.TbFechaTermino = new System.Windows.Forms.TextBox();
            this.LbFechaTermino = new System.Windows.Forms.Label();
            this.CbSucursal = new System.Windows.Forms.ComboBox();
            this.LbSucursal = new System.Windows.Forms.Label();
            this.BtnGenerarReporte = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnGuardaConexion = new System.Windows.Forms.Button();
            this.TbLibreria = new System.Windows.Forms.TextBox();
            this.LbLibreria = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.LbPuerto = new System.Windows.Forms.Label();
            this.TbIp = new System.Windows.Forms.TextBox();
            this.LbIp = new System.Windows.Forms.Label();
            this.TbRutaBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LbContra = new System.Windows.Forms.Label();
            this.TbUsusario = new System.Windows.Forms.TextBox();
            this.LbUsusario = new System.Windows.Forms.Label();
            this.TbNombreSucursal = new System.Windows.Forms.TextBox();
            this.LbNomSuc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbFechaInicio
            // 
            this.LbFechaInicio.AutoSize = true;
            this.LbFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFechaInicio.Location = new System.Drawing.Point(12, 14);
            this.LbFechaInicio.Name = "LbFechaInicio";
            this.LbFechaInicio.Size = new System.Drawing.Size(94, 13);
            this.LbFechaInicio.TabIndex = 0;
            this.LbFechaInicio.Text = "Fecha de inicio";
            this.LbFechaInicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // TbFechaInicio
            // 
            this.TbFechaInicio.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbFechaInicio.Location = new System.Drawing.Point(15, 30);
            this.TbFechaInicio.Name = "TbFechaInicio";
            this.TbFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.TbFechaInicio.TabIndex = 1;
            this.TbFechaInicio.Text = "01.01.2020";
            this.TbFechaInicio.Enter += new System.EventHandler(this.TbFechaInicio_enter);
            this.TbFechaInicio.Leave += new System.EventHandler(this.TbFechaInicio_leave);
            // 
            // TbFechaTermino
            // 
            this.TbFechaTermino.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbFechaTermino.Location = new System.Drawing.Point(145, 30);
            this.TbFechaTermino.Name = "TbFechaTermino";
            this.TbFechaTermino.Size = new System.Drawing.Size(100, 20);
            this.TbFechaTermino.TabIndex = 3;
            this.TbFechaTermino.Text = "01.01.2020";
            this.TbFechaTermino.Enter += new System.EventHandler(this.TxtBox);
            this.TbFechaTermino.Leave += new System.EventHandler(this.TbFechaTermino_leave);
            // 
            // LbFechaTermino
            // 
            this.LbFechaTermino.AutoSize = true;
            this.LbFechaTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFechaTermino.Location = new System.Drawing.Point(142, 14);
            this.LbFechaTermino.Name = "LbFechaTermino";
            this.LbFechaTermino.Size = new System.Drawing.Size(87, 13);
            this.LbFechaTermino.TabIndex = 2;
            this.LbFechaTermino.Text = "FechaTermino";
            // 
            // CbSucursal
            // 
            this.CbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbSucursal.FormattingEnabled = true;
            this.CbSucursal.Location = new System.Drawing.Point(278, 30);
            this.CbSucursal.Name = "CbSucursal";
            this.CbSucursal.Size = new System.Drawing.Size(156, 21);
            this.CbSucursal.TabIndex = 4;
            // 
            // LbSucursal
            // 
            this.LbSucursal.AutoSize = true;
            this.LbSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSucursal.Location = new System.Drawing.Point(275, 14);
            this.LbSucursal.Name = "LbSucursal";
            this.LbSucursal.Size = new System.Drawing.Size(56, 13);
            this.LbSucursal.TabIndex = 5;
            this.LbSucursal.Text = "Sucursal";
            // 
            // BtnGenerarReporte
            // 
            this.BtnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarReporte.Location = new System.Drawing.Point(48, 80);
            this.BtnGenerarReporte.Name = "BtnGenerarReporte";
            this.BtnGenerarReporte.Size = new System.Drawing.Size(116, 23);
            this.BtnGenerarReporte.TabIndex = 6;
            this.BtnGenerarReporte.Text = "Extraer Datos";
            this.BtnGenerarReporte.UseVisualStyleBackColor = true;
            this.BtnGenerarReporte.Click += new System.EventHandler(this.BtnGenerarReporte_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 210);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSalir);
            this.tabPage1.Controls.Add(this.BtnExportar);
            this.tabPage1.Controls.Add(this.BtnGenerarReporte);
            this.tabPage1.Controls.Add(this.LbFechaInicio);
            this.tabPage1.Controls.Add(this.LbSucursal);
            this.tabPage1.Controls.Add(this.TbFechaInicio);
            this.tabPage1.Controls.Add(this.CbSucursal);
            this.tabPage1.Controls.Add(this.LbFechaTermino);
            this.tabPage1.Controls.Add(this.TbFechaTermino);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 184);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reporte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Black;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Location = new System.Drawing.Point(388, 119);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(62, 26);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExportar.Location = new System.Drawing.Point(278, 79);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(75, 23);
            this.BtnExportar.TabIndex = 7;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnGuardaConexion);
            this.tabPage2.Controls.Add(this.TbLibreria);
            this.tabPage2.Controls.Add(this.LbLibreria);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.LbPuerto);
            this.tabPage2.Controls.Add(this.TbIp);
            this.tabPage2.Controls.Add(this.LbIp);
            this.tabPage2.Controls.Add(this.TbRutaBase);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.LbContra);
            this.tabPage2.Controls.Add(this.TbUsusario);
            this.tabPage2.Controls.Add(this.LbUsusario);
            this.tabPage2.Controls.Add(this.TbNombreSucursal);
            this.tabPage2.Controls.Add(this.LbNomSuc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 184);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sucursales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnGuardaConexion
            // 
            this.BtnGuardaConexion.Location = new System.Drawing.Point(335, 240);
            this.BtnGuardaConexion.Name = "BtnGuardaConexion";
            this.BtnGuardaConexion.Size = new System.Drawing.Size(135, 56);
            this.BtnGuardaConexion.TabIndex = 14;
            this.BtnGuardaConexion.Text = "Guardar";
            this.BtnGuardaConexion.UseVisualStyleBackColor = true;
            // 
            // TbLibreria
            // 
            this.TbLibreria.Location = new System.Drawing.Point(310, 80);
            this.TbLibreria.Name = "TbLibreria";
            this.TbLibreria.Size = new System.Drawing.Size(176, 20);
            this.TbLibreria.TabIndex = 13;
            // 
            // LbLibreria
            // 
            this.LbLibreria.AutoSize = true;
            this.LbLibreria.Location = new System.Drawing.Point(307, 64);
            this.LbLibreria.Name = "LbLibreria";
            this.LbLibreria.Size = new System.Drawing.Size(41, 13);
            this.LbLibreria.TabIndex = 12;
            this.LbLibreria.Text = "Libreria";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(310, 28);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // LbPuerto
            // 
            this.LbPuerto.AutoSize = true;
            this.LbPuerto.Location = new System.Drawing.Point(307, 12);
            this.LbPuerto.Name = "LbPuerto";
            this.LbPuerto.Size = new System.Drawing.Size(38, 13);
            this.LbPuerto.TabIndex = 10;
            this.LbPuerto.Text = "Puerto";
            // 
            // TbIp
            // 
            this.TbIp.Location = new System.Drawing.Point(9, 256);
            this.TbIp.Name = "TbIp";
            this.TbIp.Size = new System.Drawing.Size(131, 20);
            this.TbIp.TabIndex = 9;
            // 
            // LbIp
            // 
            this.LbIp.AutoSize = true;
            this.LbIp.Location = new System.Drawing.Point(6, 240);
            this.LbIp.Name = "LbIp";
            this.LbIp.Size = new System.Drawing.Size(43, 13);
            this.LbIp.TabIndex = 8;
            this.LbIp.Text = "TCP/IP";
            // 
            // TbRutaBase
            // 
            this.TbRutaBase.Location = new System.Drawing.Point(9, 201);
            this.TbRutaBase.Name = "TbRutaBase";
            this.TbRutaBase.Size = new System.Drawing.Size(239, 20);
            this.TbRutaBase.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ruta de la base";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // LbContra
            // 
            this.LbContra.AutoSize = true;
            this.LbContra.Location = new System.Drawing.Point(6, 121);
            this.LbContra.Name = "LbContra";
            this.LbContra.Size = new System.Drawing.Size(61, 13);
            this.LbContra.TabIndex = 4;
            this.LbContra.Text = "Contraseña";
            // 
            // TbUsusario
            // 
            this.TbUsusario.Location = new System.Drawing.Point(9, 80);
            this.TbUsusario.Name = "TbUsusario";
            this.TbUsusario.Size = new System.Drawing.Size(100, 20);
            this.TbUsusario.TabIndex = 3;
            // 
            // LbUsusario
            // 
            this.LbUsusario.AutoSize = true;
            this.LbUsusario.Location = new System.Drawing.Point(6, 64);
            this.LbUsusario.Name = "LbUsusario";
            this.LbUsusario.Size = new System.Drawing.Size(43, 13);
            this.LbUsusario.TabIndex = 2;
            this.LbUsusario.Text = "Usuario";
            // 
            // TbNombreSucursal
            // 
            this.TbNombreSucursal.Location = new System.Drawing.Point(9, 28);
            this.TbNombreSucursal.Name = "TbNombreSucursal";
            this.TbNombreSucursal.Size = new System.Drawing.Size(100, 20);
            this.TbNombreSucursal.TabIndex = 1;
            // 
            // LbNomSuc
            // 
            this.LbNomSuc.AutoSize = true;
            this.LbNomSuc.Location = new System.Drawing.Point(6, 12);
            this.LbNomSuc.Name = "LbNomSuc";
            this.LbNomSuc.Size = new System.Drawing.Size(101, 13);
            this.LbNomSuc.TabIndex = 0;
            this.LbNomSuc.Text = "Nombre de sucursal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 211);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Modificados";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbFechaInicio;
        private System.Windows.Forms.TextBox TbFechaInicio;
        private System.Windows.Forms.TextBox TbFechaTermino;
        private System.Windows.Forms.Label LbFechaTermino;
        private System.Windows.Forms.ComboBox CbSucursal;
        private System.Windows.Forms.Label LbSucursal;
        private System.Windows.Forms.Button BtnGenerarReporte;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TbNombreSucursal;
        private System.Windows.Forms.Label LbNomSuc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LbContra;
        private System.Windows.Forms.TextBox TbUsusario;
        private System.Windows.Forms.Label LbUsusario;
        private System.Windows.Forms.TextBox TbLibreria;
        private System.Windows.Forms.Label LbLibreria;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label LbPuerto;
        private System.Windows.Forms.TextBox TbIp;
        private System.Windows.Forms.Label LbIp;
        private System.Windows.Forms.TextBox TbRutaBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardaConexion;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnSalir;
    }
}

