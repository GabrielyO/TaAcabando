namespace TrabalhoBiblioteca
{
    partial class FormExcluir
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txteditora = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(441, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(474, 44);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(51, 29);
            this.txtid.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnVoltar.Location = new System.Drawing.Point(445, 349);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(102, 39);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnExcluir.Location = new System.Drawing.Point(445, 304);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 39);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txteditora
            // 
            this.txteditora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txteditora.Enabled = false;
            this.txteditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditora.Location = new System.Drawing.Point(238, 262);
            this.txteditora.Name = "txteditora";
            this.txteditora.Size = new System.Drawing.Size(563, 29);
            this.txteditora.TabIndex = 13;
            // 
            // txtautor
            // 
            this.txtautor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtautor.Enabled = false;
            this.txtautor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtautor.Location = new System.Drawing.Point(238, 221);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(563, 29);
            this.txtautor.TabIndex = 12;
            // 
            // txttitulo
            // 
            this.txttitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttitulo.Enabled = false;
            this.txttitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitulo.Location = new System.Drawing.Point(238, 184);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(563, 29);
            this.txttitulo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Editora";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Autor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Título";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.btnPesquisar.Location = new System.Drawing.Point(445, 79);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 39);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(234, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(483, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Verifique abaixo se esse é mesmo o livro a ser excluído:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.txteditora);
            this.panel1.Controls.Add(this.txtautor);
            this.panel1.Controls.Add(this.txttitulo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 482);
            this.panel1.TabIndex = 18;
            // 
            // FormExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(133)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(965, 482);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FormExcluir";
            this.Text = "FormExcluir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txteditora;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}