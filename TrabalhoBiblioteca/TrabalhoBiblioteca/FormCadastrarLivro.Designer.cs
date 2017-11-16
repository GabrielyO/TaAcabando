namespace TrabalhoBiblioteca
{
    partial class FormCadastrarLivro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txteditora = new System.Windows.Forms.TextBox();
            this.btnEnviarCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(187, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editora";
            // 
            // txttitulo
            // 
            this.txttitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(266, 86);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(563, 29);
            this.txttitulo.TabIndex = 3;
            // 
            // txtautor
            // 
            this.txtautor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.Location = new System.Drawing.Point(266, 123);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(563, 29);
            this.txtautor.TabIndex = 4;
            // 
            // txteditora
            // 
            this.txteditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txteditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditora.Location = new System.Drawing.Point(266, 164);
            this.txteditora.Name = "txteditora";
            this.txteditora.Size = new System.Drawing.Size(563, 29);
            this.txteditora.TabIndex = 5;
            // 
            // btnEnviarCadastro
            // 
            this.btnEnviarCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnEnviarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnEnviarCadastro.Location = new System.Drawing.Point(476, 205);
            this.btnEnviarCadastro.Name = "btnEnviarCadastro";
            this.btnEnviarCadastro.Size = new System.Drawing.Size(102, 39);
            this.btnEnviarCadastro.TabIndex = 6;
            this.btnEnviarCadastro.Text = "Cadastrar";
            this.btnEnviarCadastro.UseVisualStyleBackColor = false;
            this.btnEnviarCadastro.Click += new System.EventHandler(this.btnEnviarCadastro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnVoltar.Location = new System.Drawing.Point(476, 241);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 39);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnEnviarCadastro);
            this.panel1.Controls.Add(this.txteditora);
            this.panel1.Controls.Add(this.txtautor);
            this.panel1.Controls.Add(this.txttitulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(40, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 353);
            this.panel1.TabIndex = 8;
            // 
            // FormCadastrarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1095, 377);
            this.Controls.Add(this.panel1);
            this.Name = "FormCadastrarLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarLivro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txteditora;
        private System.Windows.Forms.Button btnEnviarCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel1;
    }
}