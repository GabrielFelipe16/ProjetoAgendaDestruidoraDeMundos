namespace ProjetoAgendaDestruidoraDeMundos.Views
{
    partial class frm_cadastrar_categoria
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            txt_categoria = new TextBox();
            btn_cadastrar = new Button();
            btn_sair = new Button();
            dgv_Categoria = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_excluir_categoria = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(993, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem, voltarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(75, 24);
            arquivoToolStripMenuItem.Text = "A&rquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(131, 26);
            sairToolStripMenuItem.Text = "S&air";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(131, 26);
            voltarToolStripMenuItem.Text = "&Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_categoria);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(30, 73);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(469, 261);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira a nova categoria";
            // 
            // txt_categoria
            // 
            txt_categoria.Location = new Point(7, 100);
            txt_categoria.Margin = new Padding(3, 4, 3, 4);
            txt_categoria.MaxLength = 45;
            txt_categoria.Multiline = true;
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(454, 59);
            txt_categoria.TabIndex = 1;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(7, 191);
            btn_cadastrar.Margin = new Padding(3, 4, 3, 4);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(455, 56);
            btn_cadastrar.TabIndex = 0;
            btn_cadastrar.Text = "C&adastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(30, 444);
            btn_sair.Margin = new Padding(3, 4, 3, 4);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(79, 44);
            btn_sair.TabIndex = 2;
            btn_sair.Text = "&Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // dgv_Categoria
            // 
            dgv_Categoria.AllowUserToDeleteRows = false;
            dgv_Categoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categoria.Location = new Point(562, 60);
            dgv_Categoria.Margin = new Padding(3, 4, 3, 4);
            dgv_Categoria.Name = "dgv_Categoria";
            dgv_Categoria.ReadOnly = true;
            dgv_Categoria.RowHeadersWidth = 51;
            dgv_Categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Categoria.Size = new Size(361, 375);
            dgv_Categoria.TabIndex = 3;
            dgv_Categoria.CellContentClick += dgv_Categoria_CellContentClick;
            // 
            // btn_excluir_categoria
            // 
            btn_excluir_categoria.Location = new Point(402, 435);
            btn_excluir_categoria.Name = "btn_excluir_categoria";
            btn_excluir_categoria.Size = new Size(97, 53);
            btn_excluir_categoria.TabIndex = 5;
            btn_excluir_categoria.Text = "Excluir";
            btn_excluir_categoria.UseVisualStyleBackColor = true;
            btn_excluir_categoria.Click += bt_teste_Click;
            // 
            // frm_cadastrar_categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 504);
            Controls.Add(btn_excluir_categoria);
            Controls.Add(dgv_Categoria);
            Controls.Add(btn_sair);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frm_cadastrar_categoria";
            Text = "Lista Telefônica Mortífera: Cadastrar Categoria";
            FormClosed += frm_cadastrar_categoria_FormClosed;
            Load += frm_cadastrar_categoria_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Categoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btn_cadastrar;
        private TextBox txt_categoria;
        private Button btn_sair;
        private DataGridView dgv_Categoria;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_excluir_categoria;
    }
}