namespace ProjetoAgendaDestruidoraDeMundos.Views
{
    partial class frm_cadastro_usuario
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
            btn_alterar_senha = new Button();
            txt_alterar_senha = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_campo_telefone = new TextBox();
            txt_campo_usuario = new TextBox();
            txt_campo_nome = new TextBox();
            bt_cancelar = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dgv_usuario = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_excluir = new Button();
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_usuario).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.Transparent;
            groupBox.Controls.Add(btn_alterar_senha);
            groupBox.Controls.Add(txt_alterar_senha);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(txt_campo_telefone);
            groupBox.Controls.Add(txt_campo_usuario);
            groupBox.Controls.Add(txt_campo_nome);
            groupBox.Controls.Add(bt_cancelar);
            groupBox.Font = new Font("Segoe UI", 16F);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(10, 26);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(288, 486);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Alterar Usuario";
            groupBox.Enter += groupBox_Enter;
            // 
            // btn_alterar_senha
            // 
            btn_alterar_senha.Font = new Font("Segoe UI", 9F);
            btn_alterar_senha.Location = new Point(59, 403);
            btn_alterar_senha.Name = "btn_alterar_senha";
            btn_alterar_senha.Size = new Size(72, 49);
            btn_alterar_senha.TabIndex = 6;
            btn_alterar_senha.Text = "Alterar";
            btn_alterar_senha.UseVisualStyleBackColor = true;
            btn_alterar_senha.Click += btn_alterar_senha_Click;
            // 
            // txt_alterar_senha
            // 
            txt_alterar_senha.Location = new Point(61, 329);
            txt_alterar_senha.Multiline = true;
            txt_alterar_senha.Name = "txt_alterar_senha";
            txt_alterar_senha.Size = new Size(184, 50);
            txt_alterar_senha.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(61, 32);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 3;
            label1.Text = "Nome";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(59, 203);
            label3.Name = "label3";
            label3.Size = new Size(96, 30);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
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
            txt_campo_telefone.Location = new Point(61, 241);
            txt_campo_telefone.Multiline = true;
            txt_campo_telefone.Name = "txt_campo_telefone";
            txt_campo_telefone.Size = new Size(184, 45);
            txt_campo_telefone.TabIndex = 1;
            txt_campo_telefone.TextChanged += txt_campo_telefone_TextChanged;
            // 
            // txt_campo_usuario
            // 
            txt_campo_usuario.Location = new Point(61, 153);
            txt_campo_usuario.Multiline = true;
            txt_campo_usuario.Name = "txt_campo_usuario";
            txt_campo_usuario.PlaceholderText = "Ex.: João123";
            txt_campo_usuario.Size = new Size(184, 43);
            txt_campo_usuario.TabIndex = 1;
            txt_campo_usuario.TextChanged += txt_campo_usuario_TextChanged;
            // 
            // txt_campo_nome
            // 
            txt_campo_nome.Location = new Point(61, 73);
            txt_campo_nome.Multiline = true;
            txt_campo_nome.Name = "txt_campo_nome";
            txt_campo_nome.PlaceholderText = "Ex.: João";
            txt_campo_nome.Size = new Size(184, 47);
            txt_campo_nome.TabIndex = 1;
            txt_campo_nome.TextChanged += txt_campo_nome_TextChanged;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Font = new Font("Segoe UI", 9F);
            bt_cancelar.Location = new Point(174, 403);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(71, 49);
            bt_cancelar.TabIndex = 0;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dgv_usuario
            // 
            dgv_usuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuario.Location = new Point(439, 26);
            dgv_usuario.Margin = new Padding(3, 2, 3, 2);
            dgv_usuario.Name = "dgv_usuario";
            dgv_usuario.ReadOnly = true;
            dgv_usuario.RowHeadersWidth = 51;
            dgv_usuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_usuario.Size = new Size(489, 486);
            dgv_usuario.TabIndex = 2;
            dgv_usuario.SelectionChanged += dgv_usuario_SelectionChanged;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(304, 229);
            btn_excluir.Margin = new Padding(3, 2, 3, 2);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(129, 62);
            btn_excluir.TabIndex = 3;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // frm_cadastro_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 634);
            Controls.Add(btn_excluir);
            Controls.Add(dgv_usuario);
            Controls.Add(groupBox);
            Name = "frm_cadastro_usuario";
            Text = "Lista Telefônica Mortífera: Alterar Cadastro";
            FormClosed += frm_cadastro_usuario_FormClosed;
            Load += frm_alterar_cadastro_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_usuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_campo_telefone;
        private TextBox txt_campo_usuario;
        private TextBox txt_campo_nome;
        private Button bt_cancelar;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dgv_usuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_excluir;
        private TextBox txt_alterar_senha;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button btn_alterar_senha;
    }
}