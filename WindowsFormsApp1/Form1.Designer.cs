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
            this.lblInmobiliaria = new System.Windows.Forms.Label();
            this.lblIngrDatos = new System.Windows.Forms.Label();
            this.btnPiso = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lbldgtpiso = new System.Windows.Forms.Label();
            this.txtNumPiso = new System.Windows.Forms.TextBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblMetroCuadrados = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMetrosCuad = new System.Windows.Forms.TextBox();
            this.btnCrearPiso = new System.Windows.Forms.Button();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.lblLOCAL = new System.Windows.Forms.Label();
            this.txtAntiguedadL = new System.Windows.Forms.TextBox();
            this.txtNroVentanasL = new System.Windows.Forms.TextBox();
            this.txtMetroCuadL = new System.Windows.Forms.TextBox();
            this.txtDireccionL = new System.Windows.Forms.TextBox();
            this.lblAntiguedadL = new System.Windows.Forms.Label();
            this.lblNumeroVentanasL = new System.Windows.Forms.Label();
            this.lblMetrosCuadradosL = new System.Windows.Forms.Label();
            this.lblDireccionL = new System.Windows.Forms.Label();
            this.btnCrearLocal = new System.Windows.Forms.Button();
            this.lblTotalP = new System.Windows.Forms.Label();
            this.lblTotalL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInmobiliaria
            // 
            this.lblInmobiliaria.AutoSize = true;
            this.lblInmobiliaria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInmobiliaria.Location = new System.Drawing.Point(239, 32);
            this.lblInmobiliaria.Name = "lblInmobiliaria";
            this.lblInmobiliaria.Size = new System.Drawing.Size(367, 55);
            this.lblInmobiliaria.TabIndex = 0;
            this.lblInmobiliaria.Text = "INMOBILIARIA";
            this.lblInmobiliaria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIngrDatos
            // 
            this.lblIngrDatos.AutoSize = true;
            this.lblIngrDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrDatos.Location = new System.Drawing.Point(140, 138);
            this.lblIngrDatos.Name = "lblIngrDatos";
            this.lblIngrDatos.Size = new System.Drawing.Size(513, 24);
            this.lblIngrDatos.TabIndex = 1;
            this.lblIngrDatos.Text = "Ingrese los siguientes datos del inmueble vendido";
            this.lblIngrDatos.Visible = false;
            // 
            // btnPiso
            // 
            this.btnPiso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPiso.Location = new System.Drawing.Point(294, 165);
            this.btnPiso.Name = "btnPiso";
            this.btnPiso.Size = new System.Drawing.Size(95, 36);
            this.btnPiso.TabIndex = 6;
            this.btnPiso.Text = "Piso";
            this.btnPiso.UseVisualStyleBackColor = true;
            this.btnPiso.Click += new System.EventHandler(this.btnCrPiso_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(446, 164);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(92, 36);
            this.btnLocal.TabIndex = 7;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiso.Location = new System.Drawing.Point(239, 87);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(102, 40);
            this.lblPiso.TabIndex = 9;
            this.lblPiso.Text = "PISO";
            this.lblPiso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPiso.Visible = false;
            // 
            // lbldgtpiso
            // 
            this.lbldgtpiso.AutoSize = true;
            this.lbldgtpiso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldgtpiso.Location = new System.Drawing.Point(125, 269);
            this.lbldgtpiso.Name = "lbldgtpiso";
            this.lbldgtpiso.Size = new System.Drawing.Size(169, 22);
            this.lbldgtpiso.TabIndex = 10;
            this.lbldgtpiso.Text = "Numero de piso : ";
            this.lbldgtpiso.Visible = false;
            // 
            // txtNumPiso
            // 
            this.txtNumPiso.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNumPiso.Location = new System.Drawing.Point(356, 271);
            this.txtNumPiso.Name = "txtNumPiso";
            this.txtNumPiso.Size = new System.Drawing.Size(140, 20);
            this.txtNumPiso.TabIndex = 11;
            this.txtNumPiso.Visible = false;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(211, 103);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(417, 24);
            this.lblSeleccion.TabIndex = 8;
            this.lblSeleccion.Text = "Seleccion tipo de inmbueble a comprar: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(125, 187);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(108, 22);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección: ";
            this.lblDireccion.Visible = false;
            // 
            // lblMetroCuadrados
            // 
            this.lblMetroCuadrados.AutoSize = true;
            this.lblMetroCuadrados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetroCuadrados.Location = new System.Drawing.Point(130, 228);
            this.lblMetroCuadrados.Name = "lblMetroCuadrados";
            this.lblMetroCuadrados.Size = new System.Drawing.Size(181, 22);
            this.lblMetroCuadrados.TabIndex = 3;
            this.lblMetroCuadrados.Text = "Metros cuadrados:";
            this.lblMetroCuadrados.Visible = false;
            this.lblMetroCuadrados.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(356, 191);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(140, 20);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.Visible = false;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtMetrosCuad
            // 
            this.txtMetrosCuad.Location = new System.Drawing.Point(356, 228);
            this.txtMetrosCuad.Name = "txtMetrosCuad";
            this.txtMetrosCuad.Size = new System.Drawing.Size(140, 20);
            this.txtMetrosCuad.TabIndex = 5;
            this.txtMetrosCuad.Visible = false;
            // 
            // btnCrearPiso
            // 
            this.btnCrearPiso.Location = new System.Drawing.Point(520, 224);
            this.btnCrearPiso.Name = "btnCrearPiso";
            this.btnCrearPiso.Size = new System.Drawing.Size(82, 67);
            this.btnCrearPiso.TabIndex = 12;
            this.btnCrearPiso.Text = "Registrar venta";
            this.btnCrearPiso.UseVisualStyleBackColor = true;
            this.btnCrearPiso.Visible = false;
            this.btnCrearPiso.Click += new System.EventHandler(this.btnCrearPiso_Click);
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAntiguedad.Location = new System.Drawing.Point(356, 312);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(140, 20);
            this.txtAntiguedad.TabIndex = 14;
            this.txtAntiguedad.Visible = false;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedad.Location = new System.Drawing.Point(130, 308);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(198, 22);
            this.lblAntiguedad.TabIndex = 13;
            this.lblAntiguedad.Text = "Años de antiguedad:";
            this.lblAntiguedad.Visible = false;
            // 
            // lblLOCAL
            // 
            this.lblLOCAL.AutoSize = true;
            this.lblLOCAL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOCAL.Location = new System.Drawing.Point(231, 106);
            this.lblLOCAL.Name = "lblLOCAL";
            this.lblLOCAL.Size = new System.Drawing.Size(138, 40);
            this.lblLOCAL.TabIndex = 15;
            this.lblLOCAL.Text = "LOCAL";
            this.lblLOCAL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLOCAL.Visible = false;
            // 
            // txtAntiguedadL
            // 
            this.txtAntiguedadL.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAntiguedadL.Location = new System.Drawing.Point(277, 314);
            this.txtAntiguedadL.Name = "txtAntiguedadL";
            this.txtAntiguedadL.Size = new System.Drawing.Size(179, 20);
            this.txtAntiguedadL.TabIndex = 19;
            this.txtAntiguedadL.Visible = false;
            // 
            // txtNroVentanasL
            // 
            this.txtNroVentanasL.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNroVentanasL.Location = new System.Drawing.Point(415, 271);
            this.txtNroVentanasL.Name = "txtNroVentanasL";
            this.txtNroVentanasL.Size = new System.Drawing.Size(41, 20);
            this.txtNroVentanasL.TabIndex = 18;
            this.txtNroVentanasL.Visible = false;
            // 
            // txtMetroCuadL
            // 
            this.txtMetroCuadL.Location = new System.Drawing.Point(332, 226);
            this.txtMetroCuadL.Name = "txtMetroCuadL";
            this.txtMetroCuadL.Size = new System.Drawing.Size(124, 20);
            this.txtMetroCuadL.TabIndex = 17;
            this.txtMetroCuadL.Visible = false;
            // 
            // txtDireccionL
            // 
            this.txtDireccionL.Location = new System.Drawing.Point(277, 189);
            this.txtDireccionL.Name = "txtDireccionL";
            this.txtDireccionL.Size = new System.Drawing.Size(179, 20);
            this.txtDireccionL.TabIndex = 16;
            this.txtDireccionL.Visible = false;
            // 
            // lblAntiguedadL
            // 
            this.lblAntiguedadL.AutoSize = true;
            this.lblAntiguedadL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedadL.Location = new System.Drawing.Point(145, 314);
            this.lblAntiguedadL.Name = "lblAntiguedadL";
            this.lblAntiguedadL.Size = new System.Drawing.Size(198, 22);
            this.lblAntiguedadL.TabIndex = 23;
            this.lblAntiguedadL.Text = "Años de antiguedad:";
            this.lblAntiguedadL.Visible = false;
            // 
            // lblNumeroVentanasL
            // 
            this.lblNumeroVentanasL.AutoSize = true;
            this.lblNumeroVentanasL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroVentanasL.Location = new System.Drawing.Point(137, 271);
            this.lblNumeroVentanasL.Name = "lblNumeroVentanasL";
            this.lblNumeroVentanasL.Size = new System.Drawing.Size(213, 22);
            this.lblNumeroVentanasL.TabIndex = 22;
            this.lblNumeroVentanasL.Text = "Numero de ventanas : ";
            this.lblNumeroVentanasL.Visible = false;
            // 
            // lblMetrosCuadradosL
            // 
            this.lblMetrosCuadradosL.AutoSize = true;
            this.lblMetrosCuadradosL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetrosCuadradosL.Location = new System.Drawing.Point(145, 230);
            this.lblMetrosCuadradosL.Name = "lblMetrosCuadradosL";
            this.lblMetrosCuadradosL.Size = new System.Drawing.Size(181, 22);
            this.lblMetrosCuadradosL.TabIndex = 21;
            this.lblMetrosCuadradosL.Text = "Metros cuadrados:";
            this.lblMetrosCuadradosL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMetrosCuadradosL.Visible = false;
            // 
            // lblDireccionL
            // 
            this.lblDireccionL.AutoSize = true;
            this.lblDireccionL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionL.Location = new System.Drawing.Point(140, 189);
            this.lblDireccionL.Name = "lblDireccionL";
            this.lblDireccionL.Size = new System.Drawing.Size(108, 22);
            this.lblDireccionL.TabIndex = 20;
            this.lblDireccionL.Text = "Dirección: ";
            this.lblDireccionL.Visible = false;
            // 
            // btnCrearLocal
            // 
            this.btnCrearLocal.Location = new System.Drawing.Point(522, 224);
            this.btnCrearLocal.Name = "btnCrearLocal";
            this.btnCrearLocal.Size = new System.Drawing.Size(80, 67);
            this.btnCrearLocal.TabIndex = 24;
            this.btnCrearLocal.Text = "Registrar venta";
            this.btnCrearLocal.UseVisualStyleBackColor = true;
            this.btnCrearLocal.Visible = false;
            this.btnCrearLocal.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalP
            // 
            this.lblTotalP.AutoSize = true;
            this.lblTotalP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalP.Location = new System.Drawing.Point(130, 356);
            this.lblTotalP.Name = "lblTotalP";
            this.lblTotalP.Size = new System.Drawing.Size(62, 22);
            this.lblTotalP.TabIndex = 25;
            this.lblTotalP.Text = "Total:";
            this.lblTotalP.Visible = false;
            // 
            // lblTotalL
            // 
            this.lblTotalL.AutoSize = true;
            this.lblTotalL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalL.Location = new System.Drawing.Point(140, 403);
            this.lblTotalL.Name = "lblTotalL";
            this.lblTotalL.Size = new System.Drawing.Size(62, 22);
            this.lblTotalL.TabIndex = 26;
            this.lblTotalL.Text = "Total:";
            this.lblTotalL.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.lblTotalL);
            this.Controls.Add(this.lblTotalP);
            this.Controls.Add(this.btnCrearLocal);
            this.Controls.Add(this.lblAntiguedadL);
            this.Controls.Add(this.lblNumeroVentanasL);
            this.Controls.Add(this.lblMetrosCuadradosL);
            this.Controls.Add(this.lblDireccionL);
            this.Controls.Add(this.txtAntiguedadL);
            this.Controls.Add(this.txtNroVentanasL);
            this.Controls.Add(this.txtMetroCuadL);
            this.Controls.Add(this.txtDireccionL);
            this.Controls.Add(this.lblLOCAL);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.btnCrearPiso);
            this.Controls.Add(this.txtNumPiso);
            this.Controls.Add(this.lbldgtpiso);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnPiso);
            this.Controls.Add(this.txtMetrosCuad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblMetroCuadrados);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblIngrDatos);
            this.Controls.Add(this.lblInmobiliaria);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "PrimerPrograma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInmobiliaria;
        private System.Windows.Forms.Label lblIngrDatos;
        private System.Windows.Forms.Button btnPiso;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lbldgtpiso;
        private System.Windows.Forms.TextBox txtNumPiso;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblMetroCuadrados;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMetrosCuad;
        private System.Windows.Forms.Button btnCrearPiso;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.Label lblLOCAL;
        private System.Windows.Forms.TextBox txtAntiguedadL;
        private System.Windows.Forms.TextBox txtNroVentanasL;
        private System.Windows.Forms.TextBox txtMetroCuadL;
        private System.Windows.Forms.TextBox txtDireccionL;
        private System.Windows.Forms.Label lblAntiguedadL;
        private System.Windows.Forms.Label lblNumeroVentanasL;
        private System.Windows.Forms.Label lblMetrosCuadradosL;
        private System.Windows.Forms.Label lblDireccionL;
        private System.Windows.Forms.Button btnCrearLocal;
        private System.Windows.Forms.Label lblTotalP;
        private System.Windows.Forms.Label lblTotalL;
    }
}

