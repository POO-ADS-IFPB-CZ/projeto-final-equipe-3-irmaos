﻿namespace APP_POO.Telas
{
    partial class Usuario_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel7 = new Panel();
            Btn_Voltar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            Label_Saldo = new Label();
            Label_DataCadastro = new Label();
            Label_NomeUsuario = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            Btn_Recarregar = new Button();
            button1 = new Button();
            panel7.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(Btn_Voltar);
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(577, 112);
            panel7.TabIndex = 23;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.White;
            Btn_Voltar.FlatAppearance.BorderSize = 0;
            Btn_Voltar.FlatStyle = FlatStyle.Flat;
            Btn_Voltar.ForeColor = Color.Transparent;
            Btn_Voltar.Location = new Point(0, 0);
            Btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(40, 47);
            Btn_Voltar.TabIndex = 14;
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(155, 31);
            label1.Name = "label1";
            label1.Size = new Size(295, 51);
            label1.TabIndex = 12;
            label1.Text = "Configurações";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Label_Saldo);
            groupBox1.Controls.Add(Label_DataCadastro);
            groupBox1.Controls.Add(Label_NomeUsuario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(61, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 184);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // Label_Saldo
            // 
            Label_Saldo.AutoSize = true;
            Label_Saldo.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            Label_Saldo.Location = new Point(99, 123);
            Label_Saldo.Name = "Label_Saldo";
            Label_Saldo.Size = new Size(21, 24);
            Label_Saldo.TabIndex = 5;
            Label_Saldo.Text = "0";
            // 
            // Label_DataCadastro
            // 
            Label_DataCadastro.AutoSize = true;
            Label_DataCadastro.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            Label_DataCadastro.Location = new Point(207, 81);
            Label_DataCadastro.Name = "Label_DataCadastro";
            Label_DataCadastro.Size = new Size(64, 24);
            Label_DataCadastro.TabIndex = 4;
            Label_DataCadastro.Text = "label6";
            // 
            // Label_NomeUsuario
            // 
            Label_NomeUsuario.AutoSize = true;
            Label_NomeUsuario.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            Label_NomeUsuario.Location = new Point(101, 41);
            Label_NomeUsuario.Name = "Label_NomeUsuario";
            Label_NomeUsuario.Size = new Size(64, 24);
            Label_NomeUsuario.TabIndex = 3;
            Label_NomeUsuario.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            label4.Location = new Point(33, 123);
            label4.Name = "label4";
            label4.Size = new Size(68, 24);
            label4.TabIndex = 2;
            label4.Text = "Saldo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            label3.Location = new Point(33, 81);
            label3.Name = "label3";
            label3.Size = new Size(171, 24);
            label3.TabIndex = 1;
            label3.Text = "Data de Cadastro: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            label2.Location = new Point(33, 41);
            label2.Name = "label2";
            label2.Size = new Size(73, 24);
            label2.TabIndex = 0;
            label2.Text = "Nome: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 451);
            label5.Name = "label5";
            label5.Size = new Size(483, 27);
            label5.TabIndex = 25;
            label5.Text = "Sem crédito na conta? Faça sua recarga aqui:";
            // 
            // Btn_Recarregar
            // 
            Btn_Recarregar.Anchor = AnchorStyles.None;
            Btn_Recarregar.BackColor = Color.ForestGreen;
            Btn_Recarregar.FlatAppearance.BorderSize = 0;
            Btn_Recarregar.FlatStyle = FlatStyle.Flat;
            Btn_Recarregar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            Btn_Recarregar.ForeColor = Color.WhiteSmoke;
            Btn_Recarregar.ImeMode = ImeMode.NoControl;
            Btn_Recarregar.Location = new Point(226, 520);
            Btn_Recarregar.Name = "Btn_Recarregar";
            Btn_Recarregar.Size = new Size(123, 51);
            Btn_Recarregar.TabIndex = 26;
            Btn_Recarregar.Text = "Recarregar";
            Btn_Recarregar.UseVisualStyleBackColor = false;
            Btn_Recarregar.Click += Btn_Recarregar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(466, 118);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Usuario_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(Btn_Recarregar);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(panel7);
            Name = "Usuario_UC";
            Size = new Size(577, 749);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Button Btn_Voltar;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button Btn_Recarregar;
        private Label Label_Saldo;
        private Label Label_DataCadastro;
        private Label Label_NomeUsuario;
        private Button button1;
    }
}
