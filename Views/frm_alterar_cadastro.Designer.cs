namespace ProjetoAgendaDestruidoraDeMundos.Views
{
    partial class frm_alterar_cadastro
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
            groupBox = new GroupBox();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_campo_confirma_senha = new TextBox();
            txt_campo_senha = new TextBox();
            txt_campo_telefone = new TextBox();
            txt_campo_usuario = new TextBox();
            txt_campo_nome = new TextBox();
            bt_cancelar = new Button();
            bt_alterar = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.Transparent;
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(txt_campo_confirma_senha);
            groupBox.Controls.Add(txt_campo_senha);
            groupBox.Controls.Add(txt_campo_telefone);
            groupBox.Controls.Add(txt_campo_usuario);
            groupBox.Controls.Add(txt_campo_nome);
            groupBox.Controls.Add(bt_cancelar);
            groupBox.Controls.Add(bt_alterar);
            groupBox.Font = new Font("Segoe UI", 16F);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(91, 35);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(408, 759);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Alterar Cadastro";
            groupBox.Enter += groupBox_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(70, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(66, 479);
            label5.Name = "label5";
            label5.Size = new Size(189, 37);
            label5.TabIndex = 2;
            label5.Text = "Repita a senha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(69, 381);
            label4.Name = "label4";
            label4.Size = new Size(89, 37);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(67, 271);
            label3.Name = "label3";
            label3.Size = new Size(116, 37);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 160);
            label2.Name = "label2";
            label2.Size = new Size(108, 37);
            label2.TabIndex = 2;
            label2.Text = "Usuário";
            // 
            // txt_campo_confirma_senha
            // 
            txt_campo_confirma_senha.Location = new Point(70, 523);
            txt_campo_confirma_senha.Margin = new Padding(3, 4, 3, 4);
            txt_campo_confirma_senha.Multiline = true;
            txt_campo_confirma_senha.Name = "txt_campo_confirma_senha";
            txt_campo_confirma_senha.PasswordChar = '*';
            txt_campo_confirma_senha.PlaceholderText = "Repita a senha acima";
            txt_campo_confirma_senha.Size = new Size(270, 53);
            txt_campo_confirma_senha.TabIndex = 1;
            // 
            // txt_campo_senha
            // 
            txt_campo_senha.Location = new Point(70, 423);
            txt_campo_senha.Margin = new Padding(3, 4, 3, 4);
            txt_campo_senha.Multiline = true;
            txt_campo_senha.Name = "txt_campo_senha";
            txt_campo_senha.PasswordChar = '*';
            txt_campo_senha.PlaceholderText = "Ex.: Godofredo123";
            txt_campo_senha.Size = new Size(270, 51);
            txt_campo_senha.TabIndex = 1;
            // 
            // txt_campo_telefone
            // 
            txt_campo_telefone.Location = new Point(70, 321);
            txt_campo_telefone.Margin = new Padding(3, 4, 3, 4);
            txt_campo_telefone.Multiline = true;
            txt_campo_telefone.Name = "txt_campo_telefone";
            txt_campo_telefone.Size = new Size(270, 55);
            txt_campo_telefone.TabIndex = 1;
            // 
            // txt_campo_usuario
            // 
            txt_campo_usuario.Location = new Point(70, 204);
            txt_campo_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_campo_usuario.Multiline = true;
            txt_campo_usuario.Name = "txt_campo_usuario";
            txt_campo_usuario.PlaceholderText = "Ex.: João123";
            txt_campo_usuario.Size = new Size(270, 52);
            txt_campo_usuario.TabIndex = 1;
            // 
            // txt_campo_nome
            // 
            txt_campo_nome.Location = new Point(70, 97);
            txt_campo_nome.Margin = new Padding(3, 4, 3, 4);
            txt_campo_nome.Multiline = true;
            txt_campo_nome.Name = "txt_campo_nome";
            txt_campo_nome.PlaceholderText = "Ex.: João";
            txt_campo_nome.Size = new Size(270, 57);
            txt_campo_nome.TabIndex = 1;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Location = new Point(215, 637);
            bt_cancelar.Margin = new Padding(3, 4, 3, 4);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(142, 61);
            bt_cancelar.TabIndex = 0;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // bt_alterar
            // 
            bt_alterar.Enabled = false;
            bt_alterar.Location = new Point(49, 637);
            bt_alterar.Margin = new Padding(3, 4, 3, 4);
            bt_alterar.Name = "bt_alterar";
            bt_alterar.Size = new Size(142, 61);
            bt_alterar.TabIndex = 0;
            bt_alterar.Text = "Alterar";
            bt_alterar.UseVisualStyleBackColor = true;
            bt_alterar.Click += bt_cadastrar_Click;
            // 
            // frm_alterar_cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 845);
            Controls.Add(groupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_alterar_cadastro";
            Text = "Lista Telefônica Mortífera: Alterar Cadastro";
            Load += frm_alterar_cadastro_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_campo_confirma_senha;
        private TextBox txt_campo_senha;
        private TextBox txt_campo_telefone;
        private TextBox txt_campo_usuario;
        private TextBox txt_campo_nome;
        private Button bt_cancelar;
        private Button bt_alterar;
    }
}