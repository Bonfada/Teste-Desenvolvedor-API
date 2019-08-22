namespace WinApp
{
    partial class Form1
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.pnlCidade = new System.Windows.Forms.Panel();
            this.lblfusohorario = new System.Windows.Forms.Label();
            this.lblpordosol = new System.Windows.Forms.Label();
            this.lblAmanhecer = new System.Windows.Forms.Label();
            this.lblPopulacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTituloCidade = new System.Windows.Forms.Label();
            this.pnlPrevisao = new System.Windows.Forms.Panel();
            this.lblTituloPrevisao = new System.Windows.Forms.Label();
            this.listaLog = new System.Windows.Forms.ListBox();
            this.pnlCidade.SuspendLayout();
            this.pnlPrevisao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(551, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 21);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Get";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(34, 12);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(510, 20);
            this.txtCidade.TabIndex = 1;
            // 
            // pnlCidade
            // 
            this.pnlCidade.Controls.Add(this.lblTituloCidade);
            this.pnlCidade.Controls.Add(this.lblfusohorario);
            this.pnlCidade.Controls.Add(this.lblpordosol);
            this.pnlCidade.Controls.Add(this.lblAmanhecer);
            this.pnlCidade.Controls.Add(this.lblPopulacao);
            this.pnlCidade.Controls.Add(this.lblNome);
            this.pnlCidade.Controls.Add(this.label5);
            this.pnlCidade.Controls.Add(this.label4);
            this.pnlCidade.Controls.Add(this.label3);
            this.pnlCidade.Controls.Add(this.label2);
            this.pnlCidade.Controls.Add(this.label1);
            this.pnlCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.pnlCidade.Location = new System.Drawing.Point(34, 38);
            this.pnlCidade.Name = "pnlCidade";
            this.pnlCidade.Size = new System.Drawing.Size(281, 206);
            this.pnlCidade.TabIndex = 2;
            this.pnlCidade.Visible = false;
            // 
            // lblfusohorario
            // 
            this.lblfusohorario.AutoSize = true;
            this.lblfusohorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfusohorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(171)))));
            this.lblfusohorario.Location = new System.Drawing.Point(111, 172);
            this.lblfusohorario.Name = "lblfusohorario";
            this.lblfusohorario.Size = new System.Drawing.Size(53, 16);
            this.lblfusohorario.TabIndex = 9;
            this.lblfusohorario.Text = "Nome:";
            // 
            // lblpordosol
            // 
            this.lblpordosol.AutoSize = true;
            this.lblpordosol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpordosol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(171)))));
            this.lblpordosol.Location = new System.Drawing.Point(111, 142);
            this.lblpordosol.Name = "lblpordosol";
            this.lblpordosol.Size = new System.Drawing.Size(45, 16);
            this.lblpordosol.TabIndex = 8;
            this.lblpordosol.Text = "None";
            // 
            // lblAmanhecer
            // 
            this.lblAmanhecer.AutoSize = true;
            this.lblAmanhecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmanhecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(171)))));
            this.lblAmanhecer.Location = new System.Drawing.Point(111, 106);
            this.lblAmanhecer.Name = "lblAmanhecer";
            this.lblAmanhecer.Size = new System.Drawing.Size(45, 16);
            this.lblAmanhecer.TabIndex = 7;
            this.lblAmanhecer.Text = "None";
            // 
            // lblPopulacao
            // 
            this.lblPopulacao.AutoSize = true;
            this.lblPopulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(171)))));
            this.lblPopulacao.Location = new System.Drawing.Point(111, 72);
            this.lblPopulacao.Name = "lblPopulacao";
            this.lblPopulacao.Size = new System.Drawing.Size(45, 16);
            this.lblPopulacao.TabIndex = 6;
            this.lblPopulacao.Text = "None";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(13)))), ((int)(((byte)(171)))));
            this.lblNome.Location = new System.Drawing.Point(111, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(3, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pôr do Sol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(3, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fuso Horário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amanhecer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "População:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(551, 634);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(71, 21);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTituloCidade
            // 
            this.lblTituloCidade.AutoSize = true;
            this.lblTituloCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTituloCidade.Location = new System.Drawing.Point(3, 15);
            this.lblTituloCidade.Name = "lblTituloCidade";
            this.lblTituloCidade.Size = new System.Drawing.Size(62, 16);
            this.lblTituloCidade.TabIndex = 11;
            this.lblTituloCidade.Text = "Cidade:";
            // 
            // pnlPrevisao
            // 
            this.pnlPrevisao.Controls.Add(this.listaLog);
            this.pnlPrevisao.Controls.Add(this.lblTituloPrevisao);
            this.pnlPrevisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.pnlPrevisao.Location = new System.Drawing.Point(34, 250);
            this.pnlPrevisao.Name = "pnlPrevisao";
            this.pnlPrevisao.Size = new System.Drawing.Size(594, 378);
            this.pnlPrevisao.TabIndex = 12;
            this.pnlPrevisao.Visible = false;
            // 
            // lblTituloPrevisao
            // 
            this.lblTituloPrevisao.AutoSize = true;
            this.lblTituloPrevisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrevisao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTituloPrevisao.Location = new System.Drawing.Point(3, 15);
            this.lblTituloPrevisao.Name = "lblTituloPrevisao";
            this.lblTituloPrevisao.Size = new System.Drawing.Size(198, 16);
            this.lblTituloPrevisao.TabIndex = 14;
            this.lblTituloPrevisao.Text = "Previsão Cinco Dias 3h / 3h";
            this.lblTituloPrevisao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listaLog
            // 
            this.listaLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLog.FormattingEnabled = true;
            this.listaLog.ItemHeight = 16;
            this.listaLog.Location = new System.Drawing.Point(6, 47);
            this.listaLog.Name = "listaLog";
            this.listaLog.Size = new System.Drawing.Size(569, 324);
            this.listaLog.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(640, 660);
            this.Controls.Add(this.pnlPrevisao);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlCidade);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCidade.ResumeLayout(false);
            this.pnlCidade.PerformLayout();
            this.pnlPrevisao.ResumeLayout(false);
            this.pnlPrevisao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Panel pnlCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblfusohorario;
        private System.Windows.Forms.Label lblpordosol;
        private System.Windows.Forms.Label lblAmanhecer;
        private System.Windows.Forms.Label lblPopulacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTituloCidade;
        private System.Windows.Forms.Panel pnlPrevisao;
        private System.Windows.Forms.ListBox listaLog;
        private System.Windows.Forms.Label lblTituloPrevisao;
    }
}

