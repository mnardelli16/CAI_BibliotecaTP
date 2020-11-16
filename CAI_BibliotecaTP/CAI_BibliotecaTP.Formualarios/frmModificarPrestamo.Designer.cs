
namespace CAI_BibliotecaTP.Formualarios
{
    partial class frmModificarPrestamo
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
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.cbxPrestamos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEjemplar = new System.Windows.Forms.TextBox();
            this.lblEjemplar = new System.Windows.Forms.Label();
            this.dateFechadeBaja = new System.Windows.Forms.DateTimePicker();
            this.dateFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnModificarPrestamo = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrestamo.Location = new System.Drawing.Point(48, 70);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(142, 17);
            this.lblPrestamo.TabIndex = 0;
            this.lblPrestamo.Text = "Seleccione Prestamo";
            // 
            // cbxPrestamos
            // 
            this.cbxPrestamos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrestamos.FormattingEnabled = true;
            this.cbxPrestamos.Location = new System.Drawing.Point(235, 66);
            this.cbxPrestamos.Name = "cbxPrestamos";
            this.cbxPrestamos.Size = new System.Drawing.Size(307, 25);
            this.cbxPrestamos.TabIndex = 13;
            this.cbxPrestamos.SelectedIndexChanged += new System.EventHandler(this.cbxPrestamos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(232, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Número Prestamo - Cliente";
            // 
            // txtEjemplar
            // 
            this.txtEjemplar.Enabled = false;
            this.txtEjemplar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjemplar.Location = new System.Drawing.Point(266, 159);
            this.txtEjemplar.Name = "txtEjemplar";
            this.txtEjemplar.Size = new System.Drawing.Size(141, 22);
            this.txtEjemplar.TabIndex = 21;
            // 
            // lblEjemplar
            // 
            this.lblEjemplar.AutoSize = true;
            this.lblEjemplar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjemplar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEjemplar.Location = new System.Drawing.Point(51, 165);
            this.lblEjemplar.Name = "lblEjemplar";
            this.lblEjemplar.Size = new System.Drawing.Size(71, 16);
            this.lblEjemplar.TabIndex = 20;
            this.lblEjemplar.Text = "EJEMPLAR";
            // 
            // dateFechadeBaja
            // 
            this.dateFechadeBaja.CalendarTitleForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateFechadeBaja.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechadeBaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechadeBaja.Location = new System.Drawing.Point(266, 272);
            this.dateFechadeBaja.Name = "dateFechadeBaja";
            this.dateFechadeBaja.Size = new System.Drawing.Size(141, 22);
            this.dateFechadeBaja.TabIndex = 25;
            // 
            // dateFechaAlta
            // 
            this.dateFechaAlta.Enabled = false;
            this.dateFechaAlta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAlta.Location = new System.Drawing.Point(266, 218);
            this.dateFechaAlta.Name = "dateFechaAlta";
            this.dateFechaAlta.Size = new System.Drawing.Size(141, 22);
            this.dateFechaAlta.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(51, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "FECHA DE BAJA";
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(51, 223);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(86, 16);
            this.lblFechaPrestamo.TabIndex = 22;
            this.lblFechaPrestamo.Text = "FECHA ALTA";
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
            this.btnVolver.Location = new System.Drawing.Point(51, 371);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVolver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVolver.Rotation = 0D;
            this.btnVolver.Size = new System.Drawing.Size(123, 40);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.FlatAppearance.BorderSize = 0;
            this.btnModificarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPrestamo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnModificarPrestamo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnModificarPrestamo.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnModificarPrestamo.IconColor = System.Drawing.Color.White;
            this.btnModificarPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarPrestamo.IconSize = 40;
            this.btnModificarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPrestamo.Location = new System.Drawing.Point(392, 371);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnModificarPrestamo.Rotation = 0D;
            this.btnModificarPrestamo.Size = new System.Drawing.Size(150, 40);
            this.btnModificarPrestamo.TabIndex = 26;
            this.btnModificarPrestamo.Text = "Dar de Baja Prestamo";
            this.btnModificarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarPrestamo.UseVisualStyleBackColor = true;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // frmModificarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(744, 468);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Controls.Add(this.dateFechadeBaja);
            this.Controls.Add(this.dateFechaAlta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.txtEjemplar);
            this.Controls.Add(this.lblEjemplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPrestamos);
            this.Controls.Add(this.lblPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarPrestamo";
            this.Text = "frmModificarPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.ComboBox cbxPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEjemplar;
        private System.Windows.Forms.Label lblEjemplar;
        private System.Windows.Forms.DateTimePicker dateFechadeBaja;
        private System.Windows.Forms.DateTimePicker dateFechaAlta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private FontAwesome.Sharp.IconButton btnVolver;
        private FontAwesome.Sharp.IconButton btnModificarPrestamo;
    }
}