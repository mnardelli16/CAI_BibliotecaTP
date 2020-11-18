namespace CAI_BibliotecaTP.Formualarios
{
    partial class frmAgregarEjemplar
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
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.btnAgregarEjemplares = new FontAwesome.Sharp.IconButton();
            this.cbxLibro = new System.Windows.Forms.ComboBox();
            this.dateFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblidLibro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnAgregarEjemplares);
            this.panel1.Controls.Add(this.cbxLibro);
            this.panel1.Controls.Add(this.dateFechaAlta);
            this.panel1.Controls.Add(this.lblFechaAlta);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.lblObservaciones);
            this.panel1.Controls.Add(this.lblidLibro);
            this.panel1.Location = new System.Drawing.Point(54, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 476);
            this.panel1.TabIndex = 0;
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
            this.btnVolver.Location = new System.Drawing.Point(53, 311);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVolver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVolver.Rotation = 0D;
            this.btnVolver.Size = new System.Drawing.Size(123, 40);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarEjemplares
            // 
            this.btnAgregarEjemplares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEjemplares.FlatAppearance.BorderSize = 0;
            this.btnAgregarEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEjemplares.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarEjemplares.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEjemplares.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEjemplares.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAgregarEjemplares.IconColor = System.Drawing.Color.White;
            this.btnAgregarEjemplares.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarEjemplares.IconSize = 40;
            this.btnAgregarEjemplares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEjemplares.Location = new System.Drawing.Point(269, 311);
            this.btnAgregarEjemplares.Name = "btnAgregarEjemplares";
            this.btnAgregarEjemplares.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgregarEjemplares.Rotation = 0D;
            this.btnAgregarEjemplares.Size = new System.Drawing.Size(134, 40);
            this.btnAgregarEjemplares.TabIndex = 18;
            this.btnAgregarEjemplares.Text = "Agregar";
            this.btnAgregarEjemplares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEjemplares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarEjemplares.UseVisualStyleBackColor = true;
            this.btnAgregarEjemplares.Click += new System.EventHandler(this.btnAgregarEjemplares_Click);
            // 
            // cbxLibro
            // 
            this.cbxLibro.FormattingEnabled = true;
            this.cbxLibro.Location = new System.Drawing.Point(231, 89);
            this.cbxLibro.Name = "cbxLibro";
            this.cbxLibro.Size = new System.Drawing.Size(166, 21);
            this.cbxLibro.TabIndex = 17;
            // 
            // dateFechaAlta
            // 
            this.dateFechaAlta.Enabled = false;
            this.dateFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAlta.Location = new System.Drawing.Point(231, 250);
            this.dateFechaAlta.Name = "dateFechaAlta";
            this.dateFechaAlta.Size = new System.Drawing.Size(166, 20);
            this.dateFechaAlta.TabIndex = 16;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaAlta.Location = new System.Drawing.Point(70, 254);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(106, 16);
            this.lblFechaAlta.TabIndex = 15;
            this.lblFechaAlta.Text = "FECHA DE ALTA";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(231, 197);
            this.txtPrecio.MaxLength = 6;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(166, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(71, 201);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 16);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "PRECIO";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(231, 144);
            this.txtObservaciones.MaxLength = 30;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(166, 20);
            this.txtObservaciones.TabIndex = 12;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.lblObservaciones.Location = new System.Drawing.Point(70, 148);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(117, 16);
            this.lblObservaciones.TabIndex = 11;
            this.lblObservaciones.Text = "OBSERVACIONES";
            // 
            // lblidLibro
            // 
            this.lblidLibro.AutoSize = true;
            this.lblidLibro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidLibro.ForeColor = System.Drawing.SystemColors.Control;
            this.lblidLibro.Location = new System.Drawing.Point(71, 94);
            this.lblidLibro.Name = "lblidLibro";
            this.lblidLibro.Size = new System.Drawing.Size(45, 16);
            this.lblidLibro.TabIndex = 9;
            this.lblidLibro.Text = "LIBRO";
            // 
            // frmAgregarEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(829, 531);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarEjemplar";
            this.Text = "frmAgregarEjemplar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxLibro;
        private System.Windows.Forms.DateTimePicker dateFechaAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblidLibro;
        private FontAwesome.Sharp.IconButton btnAgregarEjemplares;
        private FontAwesome.Sharp.IconButton btnVolver;
    }
}