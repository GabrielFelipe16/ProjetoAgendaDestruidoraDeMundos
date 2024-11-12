﻿namespace ProjetoAgendaDestruidoraDeMundos
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            groupBox = new GroupBox();
            bt_logar = new Button();
            lbl_cadastro = new LinkLabel();
            txt_campo_usuario = new TextBox();
            txt_campo_senha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.Transparent;
            groupBox.Controls.Add(bt_logar);
            groupBox.Controls.Add(lbl_cadastro);
            groupBox.Controls.Add(txt_campo_usuario);
            groupBox.Controls.Add(txt_campo_senha);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Font = new Font("Segoe UI", 16F);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(53, 28);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(313, 496);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Login";
            // 
            // bt_logar
            // 
            bt_logar.Enabled = false;
            bt_logar.Location = new Point(103, 408);
            bt_logar.Margin = new Padding(3, 4, 3, 4);
            bt_logar.Name = "bt_logar";
            bt_logar.Size = new Size(127, 56);
            bt_logar.TabIndex = 4;
            bt_logar.Text = "Entrar";
            bt_logar.UseVisualStyleBackColor = true;
            bt_logar.Click += bt_logar_Click;
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.ActiveLinkColor = Color.Blue;
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Segoe UI", 9F);
            lbl_cadastro.LinkColor = Color.Black;
            lbl_cadastro.Location = new Point(43, 323);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(149, 20);
            lbl_cadastro.TabIndex = 3;
            lbl_cadastro.TabStop = true;
            lbl_cadastro.Text = "Não possuo cadastro";
            lbl_cadastro.LinkClicked += lbl_cadastro_LinkClicked;
            // 
            // txt_campo_usuario
            // 
            txt_campo_usuario.BackColor = Color.White;
            txt_campo_usuario.Cursor = Cursors.IBeam;
            txt_campo_usuario.Location = new Point(43, 128);
            txt_campo_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_campo_usuario.Name = "txt_campo_usuario";
            txt_campo_usuario.Size = new Size(226, 43);
            txt_campo_usuario.TabIndex = 2;
            txt_campo_usuario.TextChanged += txt_campo_usuario_TextChanged;
            // 
            // txt_campo_senha
            // 
            txt_campo_senha.Cursor = Cursors.IBeam;
            txt_campo_senha.Location = new Point(43, 253);
            txt_campo_senha.Margin = new Padding(3, 4, 3, 4);
            txt_campo_senha.Name = "txt_campo_senha";
            txt_campo_senha.PasswordChar = '*';
            txt_campo_senha.Size = new Size(226, 43);
            txt_campo_senha.TabIndex = 2;
            txt_campo_senha.TextChanged += txt_campo_senha_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 209);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 0;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 84);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.v602_nunoon_05_rippednotes1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(423, 600);
            Controls.Add(groupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Telefônica Mortifera: Login";
            FormClosed += frm_login_FormClosed;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TextBox txt_campo_usuario;
        private TextBox txt_campo_senha;
        private Label label2;
        private Label label1;
        private LinkLabel lbl_cadastro;
        private Button bt_logar;
    }
}
