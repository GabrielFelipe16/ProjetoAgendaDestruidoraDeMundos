namespace ProjetoAgendaDestruidoraDeMundos
{
    partial class frm_cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro));
            groupBox = new GroupBox();
            bt_cadastrar = new Button();
            txt_campo_nome = new TextBox();
            label1 = new Label();
            bt_cancelar = new Button();
            txt_campo_usuario = new TextBox();
            label2 = new Label();
            txt_campo_telefone = new TextBox();
            label3 = new Label();
            txt_campo_senha = new TextBox();
            label4 = new Label();
            txt_campo_confirma_senha = new TextBox();
            label5 = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.Transparent;
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(txt_campo_confirma_senha);
            groupBox.Controls.Add(txt_campo_senha);
            groupBox.Controls.Add(txt_campo_telefone);
            groupBox.Controls.Add(txt_campo_usuario);
            groupBox.Controls.Add(txt_campo_nome);
            groupBox.Controls.Add(bt_cancelar);
            groupBox.Controls.Add(bt_cadastrar);
            groupBox.Font = new Font("Segoe UI", 16F);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(44, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(357, 569);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Cadastro";
            // 
            // bt_cadastrar
            // 
            bt_cadastrar.Location = new Point(43, 478);
            bt_cadastrar.Name = "bt_cadastrar";
            bt_cadastrar.Size = new Size(124, 46);
            bt_cadastrar.TabIndex = 0;
            bt_cadastrar.Text = "Cadastrar";
            bt_cadastrar.UseVisualStyleBackColor = true;
            // 
            // txt_campo_nome
            // 
            txt_campo_nome.Location = new Point(61, 86);
            txt_campo_nome.Multiline = true;
            txt_campo_nome.Name = "txt_campo_nome";
            txt_campo_nome.Size = new Size(237, 25);
            txt_campo_nome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // bt_cancelar
            // 
            bt_cancelar.Location = new Point(188, 478);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(124, 46);
            bt_cancelar.TabIndex = 0;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_campo_usuario
            // 
            txt_campo_usuario.Location = new Point(61, 159);
            txt_campo_usuario.Multiline = true;
            txt_campo_usuario.Name = "txt_campo_usuario";
            txt_campo_usuario.Size = new Size(237, 27);
            txt_campo_usuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 120);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 2;
            label2.Text = "Usuário";
            // 
            // txt_campo_telefone
            // 
            txt_campo_telefone.Location = new Point(61, 252);
            txt_campo_telefone.Multiline = true;
            txt_campo_telefone.Name = "txt_campo_telefone";
            txt_campo_telefone.Size = new Size(237, 27);
            txt_campo_telefone.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(59, 208);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // txt_campo_senha
            // 
            txt_campo_senha.Location = new Point(61, 319);
            txt_campo_senha.Multiline = true;
            txt_campo_senha.Name = "txt_campo_senha";
            txt_campo_senha.Size = new Size(237, 27);
            txt_campo_senha.TabIndex = 1;
            txt_campo_senha.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(60, 286);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // txt_campo_confirma_senha
            // 
            txt_campo_confirma_senha.Location = new Point(59, 392);
            txt_campo_confirma_senha.Multiline = true;
            txt_campo_confirma_senha.Name = "txt_campo_confirma_senha";
            txt_campo_confirma_senha.Size = new Size(237, 27);
            txt_campo_confirma_senha.TabIndex = 1;
            txt_campo_confirma_senha.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(58, 359);
            label5.Name = "label5";
            label5.Size = new Size(152, 30);
            label5.TabIndex = 2;
            label5.Text = "Repita a senha";
            // 
            // frm_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.v602_nunoon_05_rippednotes;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(447, 593);
            Controls.Add(groupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista Telefônica Mortífera: Cadastro";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Button bt_cadastrar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_campo_telefone;
        private TextBox txt_campo_usuario;
        private TextBox txt_campo_nome;
        private Button bt_cancelar;
        private Label label4;
        private TextBox txt_campo_senha;
        private Label label5;
        private TextBox txt_campo_confirma_senha;
    }
}