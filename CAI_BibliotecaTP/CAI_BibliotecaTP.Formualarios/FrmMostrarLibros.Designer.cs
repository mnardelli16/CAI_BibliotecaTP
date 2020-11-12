namespace CAI_BibliotecaTP.Formualarios
{
    partial class FrmMostrarLibros
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
            this.panelLibros = new System.Windows.Forms.Panel();
            this.lstLibros = new System.Windows.Forms.ListBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.txtTema = new System.Windows.Forms.TextBox();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.btnVolver = new FontAwesome.Sharp.IconButton();
            this.panelLibros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLibros
            // 
            this.panelLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLibros.Controls.Add(this.btnVolver);
            this.panelLibros.Controls.Add(this.lstLibros);
            this.panelLibros.Controls.Add(this.txtAutor);
            this.panelLibros.Controls.Add(this.txtPagina);
            this.panelLibros.Controls.Add(this.txtEditorial);
            this.panelLibros.Controls.Add(this.lblAutor);
            this.panelLibros.Controls.Add(this.lblEdicion);
            this.panelLibros.Controls.Add(this.lblPaginas);
            this.panelLibros.Controls.Add(this.lblTema);
            this.panelLibros.Controls.Add(this.txtEdicion);
            this.panelLibros.Controls.Add(this.lblEditorial);
            this.panelLibros.Controls.Add(this.txtTema);
            this.panelLibros.Location = new System.Drawing.Point(0, 0);
            this.panelLibros.Name = "panelLibros";
            this.panelLibros.Size = new System.Drawing.Size(726, 429);
            this.panelLibros.TabIndex = 0;
            // 
            // lstLibros
            // 
            this.lstLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lstLibros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLibros.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLibros.ForeColor = System.Drawing.Color.White;
            this.lstLibros.FormattingEnabled = true;
            this.lstLibros.ItemHeight = 17;
            this.lstLibros.Location = new System.Drawing.Point(12, 23);
            this.lstLibros.Name = "lstLibros";
            this.lstLibros.ScrollAlwaysVisible = true;
            this.lstLibros.Size = new System.Drawing.Size(233, 374);
            this.lstLibros.TabIndex = 0;
            this.lstLibros.SelectedIndexChanged += new System.EventHandler(this.lstLibros_SelectedIndexChanged);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAutor.Location = new System.Drawing.Point(270, 36);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(48, 16);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "AUTOR";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditorial.Location = new System.Drawing.Point(270, 87);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(67, 16);
            this.lblEditorial.TabIndex = 3;
            this.lblEditorial.Text = "EDITORIAL";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEdicion.Location = new System.Drawing.Point(270, 135);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(58, 16);
            this.lblEdicion.TabIndex = 4;
            this.lblEdicion.Text = "EDICION";
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTema.Location = new System.Drawing.Point(270, 177);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(40, 16);
            this.lblTema.TabIndex = 5;
            this.lblTema.Text = "TEMA";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPaginas.Location = new System.Drawing.Point(270, 223);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(62, 16);
            this.lblPaginas.TabIndex = 6;
            this.lblPaginas.Text = "PAGINAS";
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(361, 36);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(184, 21);
            this.txtAutor.TabIndex = 7;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Enabled = false;
            this.txtEditorial.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(361, 87);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(184, 21);
            this.txtEditorial.TabIndex = 8;
            // 
            // txtEdicion
            // 
            this.txtEdicion.Enabled = false;
            this.txtEdicion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicion.Location = new System.Drawing.Point(361, 131);
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(184, 21);
            this.txtEdicion.TabIndex = 9;
            // 
            // txtTema
            // 
            this.txtTema.Enabled = false;
            this.txtTema.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(361, 173);
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(184, 21);
            this.txtTema.TabIndex = 10;
            // 
            // txtPagina
            // 
            this.txtPagina.Enabled = false;
            this.txtPagina.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagina.Location = new System.Drawing.Point(361, 219);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(184, 21);
            this.txtPagina.TabIndex = 11;
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnVolver.IconColor = System.Drawing.Color.White;
            this.btnVolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolver.IconSize = 40;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(422, 345);
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
            // FrmMostrarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(728, 429);
            this.Controls.Add(this.panelLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMostrarLibros";
            this.Text = "FrmMostrarLibros";
            this.panelLibros.ResumeLayout(false);
            this.panelLibros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLibros;
        private System.Windows.Forms.ListBox lstLibros;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.TextBox txtPagina;
        private FontAwesome.Sharp.IconButton btnVolver;
    }
}