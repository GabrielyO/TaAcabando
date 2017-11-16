namespace TrabalhoBiblioteca
{
    partial class FormConsultar
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnFazerConsulta = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.radiotitulo = new System.Windows.Forms.RadioButton();
            this.radioautor = new System.Windows.Forms.RadioButton();
            this.radioeditora = new System.Windows.Forms.RadioButton();
            this.filtro = new System.Windows.Forms.GroupBox();
            this.LISTA = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TÍTULO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AUTOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EDITORA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnID = new System.Windows.Forms.Button();
            this.btnTITULO = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filtro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(438, 27);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(370, 29);
            this.txtConsulta.TabIndex = 4;
            // 
            // btnFazerConsulta
            // 
            this.btnFazerConsulta.AccessibleName = "";
            this.btnFazerConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFazerConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnFazerConsulta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFazerConsulta.FlatAppearance.BorderSize = 5;
            this.btnFazerConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFazerConsulta.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnFazerConsulta.Location = new System.Drawing.Point(438, 62);
            this.btnFazerConsulta.Name = "btnFazerConsulta";
            this.btnFazerConsulta.Size = new System.Drawing.Size(370, 36);
            this.btnFazerConsulta.TabIndex = 5;
            this.btnFazerConsulta.Text = "Consultar";
            this.btnFazerConsulta.UseVisualStyleBackColor = false;
            this.btnFazerConsulta.Click += new System.EventHandler(this.btnFazerConsulta_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AccessibleName = "";
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatAppearance.BorderSize = 5;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnVoltar.Location = new System.Drawing.Point(1157, 27);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(109, 51);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // radiotitulo
            // 
            this.radiotitulo.AutoSize = true;
            this.radiotitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.radiotitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radiotitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiotitulo.ForeColor = System.Drawing.Color.White;
            this.radiotitulo.Location = new System.Drawing.Point(61, 19);
            this.radiotitulo.Name = "radiotitulo";
            this.radiotitulo.Size = new System.Drawing.Size(88, 26);
            this.radiotitulo.TabIndex = 7;
            this.radiotitulo.TabStop = true;
            this.radiotitulo.Text = "TÍTULO";
            this.radiotitulo.UseVisualStyleBackColor = false;
            // 
            // radioautor
            // 
            this.radioautor.AutoSize = true;
            this.radioautor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.radioautor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioautor.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioautor.ForeColor = System.Drawing.Color.White;
            this.radioautor.Location = new System.Drawing.Point(61, 48);
            this.radioautor.Name = "radioautor";
            this.radioautor.Size = new System.Drawing.Size(87, 26);
            this.radioautor.TabIndex = 8;
            this.radioautor.TabStop = true;
            this.radioautor.Text = "AUTOR";
            this.radioautor.UseVisualStyleBackColor = false;
            // 
            // radioeditora
            // 
            this.radioeditora.AutoSize = true;
            this.radioeditora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.radioeditora.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioeditora.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioeditora.ForeColor = System.Drawing.Color.White;
            this.radioeditora.Location = new System.Drawing.Point(61, 74);
            this.radioeditora.Name = "radioeditora";
            this.radioeditora.Size = new System.Drawing.Size(102, 26);
            this.radioeditora.TabIndex = 9;
            this.radioeditora.TabStop = true;
            this.radioeditora.Text = "EDITORA";
            this.radioeditora.UseVisualStyleBackColor = false;
            // 
            // filtro
            // 
            this.filtro.Controls.Add(this.radiotitulo);
            this.filtro.Controls.Add(this.radioautor);
            this.filtro.Controls.Add(this.radioeditora);
            this.filtro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtro.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtro.ForeColor = System.Drawing.Color.White;
            this.filtro.Location = new System.Drawing.Point(216, 3);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(167, 111);
            this.filtro.TabIndex = 10;
            this.filtro.TabStop = false;
            this.filtro.Text = "FILTRAR";
            // 
            // LISTA
            // 
            this.LISTA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LISTA.BackColor = System.Drawing.Color.White;
            this.LISTA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TÍTULO,
            this.AUTOR,
            this.EDITORA});
            this.LISTA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LISTA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.LISTA.GridLines = true;
            this.LISTA.Location = new System.Drawing.Point(13, 126);
            this.LISTA.MultiSelect = false;
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(1298, 338);
            this.LISTA.TabIndex = 11;
            this.LISTA.UseCompatibleStateImageBehavior = false;
            this.LISTA.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 69;
            // 
            // TÍTULO
            // 
            this.TÍTULO.Text = "TÍTULO";
            this.TÍTULO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TÍTULO.Width = 578;
            // 
            // AUTOR
            // 
            this.AUTOR.Text = "AUTOR";
            this.AUTOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AUTOR.Width = 367;
            // 
            // EDITORA
            // 
            this.EDITORA.Text = "EDITORA";
            this.EDITORA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EDITORA.Width = 303;
            // 
            // btnID
            // 
            this.btnID.AccessibleName = "";
            this.btnID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnID.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnID.FlatAppearance.BorderSize = 5;
            this.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnID.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnID.Location = new System.Drawing.Point(13, 12);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(118, 38);
            this.btnID.TabIndex = 13;
            this.btnID.Text = "Tudo por ID";
            this.btnID.UseVisualStyleBackColor = false;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnTITULO
            // 
            this.btnTITULO.AccessibleName = "";
            this.btnTITULO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTITULO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnTITULO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTITULO.FlatAppearance.BorderSize = 5;
            this.btnTITULO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTITULO.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTITULO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnTITULO.Location = new System.Drawing.Point(13, 45);
            this.btnTITULO.Name = "btnTITULO";
            this.btnTITULO.Size = new System.Drawing.Size(118, 38);
            this.btnTITULO.TabIndex = 14;
            this.btnTITULO.Text = "Tudo por TÍTULO";
            this.btnTITULO.UseVisualStyleBackColor = false;
            this.btnTITULO.Click += new System.EventHandler(this.btnTITULO_Click);
            // 
            // count
            // 
            this.count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.count.Enabled = false;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(966, 54);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(36, 29);
            this.count.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(858, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quantidade de livros na busca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTITULO);
            this.panel1.Controls.Add(this.btnID);
            this.panel1.Controls.Add(this.filtro);
            this.panel1.Controls.Add(this.LISTA);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.txtConsulta);
            this.panel1.Controls.Add(this.btnFazerConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 473);
            this.panel1.TabIndex = 17;
            // 
            // FormConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1322, 473);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FormConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.filtro.ResumeLayout(false);
            this.filtro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnFazerConsulta;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton radiotitulo;
        private System.Windows.Forms.RadioButton radioautor;
        private System.Windows.Forms.RadioButton radioeditora;
        private System.Windows.Forms.GroupBox filtro;
        private System.Windows.Forms.ListView LISTA;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnTITULO;
        public System.Windows.Forms.ColumnHeader ID;
        public System.Windows.Forms.ColumnHeader TÍTULO;
        public System.Windows.Forms.ColumnHeader AUTOR;
        public System.Windows.Forms.ColumnHeader EDITORA;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}