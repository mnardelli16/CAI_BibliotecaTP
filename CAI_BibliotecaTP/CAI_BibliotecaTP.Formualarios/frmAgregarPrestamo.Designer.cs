namespace CAI_BibliotecaTP.Formualarios
{
    partial class frmAgregarPrestamo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEjemplar = new System.Windows.Forms.Button();
            this.txtEjemplar = new System.Windows.Forms.TextBox();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnAgregarPrestamo = new FontAwesome.Sharp.IconButton();
            this.dateFechaDevTentativa = new System.Windows.Forms.DateTimePicker();
            this.dateFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.numPlazo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblEjemplar = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlazo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEjemplar);
            this.panel1.Controls.Add(this.txtEjemplar);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnAgregarPrestamo);
            this.panel1.Controls.Add(this.dateFechaDevTentativa);
            this.panel1.Controls.Add(this.dateFechaAlta);
            this.panel1.Controls.Add(this.cbxCliente);
            this.panel1.Controls.Add(this.numPlazo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFechaPrestamo);
            this.panel1.Controls.Add(this.lblPlazo);
            this.panel1.Controls.Add(this.lblEjemplar);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(52, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 440);
            this.panel1.TabIndex = 0;
            // 
            // btnEjemplar
            // 
            this.btnEjemplar.Location = new System.Drawing.Point(415, 123);
            this.btnEjemplar.Name = "btnEjemplar";
            this.btnEjemplar.Size = new System.Drawing.Size(23, 22);
            this.btnEjemplar.TabIndex = 20;
            this.btnEjemplar.Text = "...";
            this.btnEjemplar.UseVisualStyleBackColor = true;
            this.btnEjemplar.Click += new System.EventHandler(this.btnEjemplar_Click);
            // 
            // txtEjemplar
            // 
            this.txtEjemplar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjemplar.Location = new System.Drawing.Point(268, 123);
            this.txtEjemplar.MaxLength = 5;
            this.txtEjemplar.Name = "txtEjemplar";
            this.txtEjemplar.Size = new System.Drawing.Size(141, 22);
            this.txtEjemplar.TabIndex = 19;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnVolver.IconColor = System.Drawing.Color.White;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 40;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(56, 324);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVolver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVolver.Rotation = 0D;
            this.btnVolver.Size = new System.Drawing.Size(123, 40);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnAgregarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPrestamo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarPrestamo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPrestamo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarPrestamo.IconColor = System.Drawing.Color.White;
            this.btnAgregarPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarPrestamo.IconSize = 40;
            this.btnAgregarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(300, 324);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarPrestamo.Rotation = 0D;
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(132, 40);
            this.btnAgregarPrestamo.TabIndex = 16;
            this.btnAgregarPrestamo.Text = "Agregar Prestamo";
            this.btnAgregarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // dateFechaDevTentativa
            // 
            this.dateFechaDevTentativa.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateFechaDevTentativa.Enabled = false;
            this.dateFechaDevTentativa.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaDevTentativa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaDevTentativa.Location = new System.Drawing.Point(268, 271);
            this.dateFechaDevTentativa.Name = "dateFechaDevTentativa";
            this.dateFechaDevTentativa.Size = new System.Drawing.Size(141, 22);
            this.dateFechaDevTentativa.TabIndex = 15;
            // 
            // dateFechaAlta
            // 
            this.dateFechaAlta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAlta.Location = new System.Drawing.Point(268, 217);
            this.dateFechaAlta.Name = "dateFechaAlta";
            this.dateFechaAlta.Size = new System.Drawing.Size(141, 22);
            this.dateFechaAlta.TabIndex = 14;
            this.dateFechaAlta.ValueChanged += new System.EventHandler(this.dateFechaAlta_ValueChanged);
            // 
            // cbxCliente
            // 
            this.cbxCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(268, 80);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(141, 25);
            this.cbxCliente.TabIndex = 12;
            // 
            // numPlazo
            // 
            this.numPlazo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPlazo.Location = new System.Drawing.Point(268, 172);
            this.numPlazo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPlazo.Name = "numPlazo";
            this.numPlazo.Size = new System.Drawing.Size(141, 22);
            this.numPlazo.TabIndex = 11;
            this.numPlazo.ValueChanged += new System.EventHandler(this.numPlazo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(53, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "FECHA DEV TENTATIVA";
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(53, 222);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(86, 16);
            this.lblFechaPrestamo.TabIndex = 4;
            this.lblFechaPrestamo.Text = "FECHA ALTA";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlazo.Location = new System.Drawing.Point(53, 174);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(49, 16);
            this.lblPlazo.TabIndex = 3;
            this.lblPlazo.Text = "PLAZO";
            // 
            // lblEjemplar
            // 
            this.lblEjemplar.AutoSize = true;
            this.lblEjemplar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEjemplar.Location = new System.Drawing.Point(53, 129);
            this.lblEjemplar.Name = "lblEjemplar";
            this.lblEjemplar.Size = new System.Drawing.Size(71, 16);
            this.lblEjemplar.TabIndex = 2;
            this.lblEjemplar.Text = "EJEMPLAR";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCliente.Location = new System.Drawing.Point(53, 83);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(148, 16);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "CLIENTE (solo activos)";
            // 
            // frmAgregarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(744, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarPrestamo";
            this.Text = "frmAgregarPrestamo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlazo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblEjemplar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dateFechaDevTentativa;
        private System.Windows.Forms.DateTimePicker dateFechaAlta;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.NumericUpDown numPlazo;
        private FontAwesome.Sharp.IconButton btnAgregarPrestamo;
        private FontAwesome.Sharp.IconButton btnVolver;
        private System.Windows.Forms.Button btnEjemplar;
        protected internal System.Windows.Forms.TextBox txtEjemplar;
    }
}