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
            groupBox1 = new GroupBox();
            txt_categoria = new TextBox();
            btn_cadastrar = new Button();
            btn_sair = new Button();
            dataGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(869, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "A&rquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "S&air";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_categoria);
            groupBox1.Controls.Add(btn_cadastrar);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.Location = new Point(26, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 196);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira a nova categoria";
            // 
            // txt_categoria
            // 
            txt_categoria.Location = new Point(6, 75);
            txt_categoria.MaxLength = 45;
            txt_categoria.Multiline = true;
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(398, 45);
            txt_categoria.TabIndex = 1;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(6, 143);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(398, 42);
            btn_cadastrar.TabIndex = 0;
            btn_cadastrar.Text = "C&adastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(26, 333);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(69, 33);
            btn_sair.TabIndex = 2;
            btn_sair.Text = "&Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(492, 45);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(316, 281);
            dataGridView.TabIndex = 3;
            // 
            // frm_cadastrar_categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 378);
            Controls.Add(dataGridView);
            Controls.Add(btn_sair);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_cadastrar_categoria";
            Text = "frm_cadastrar_categoria";
            FormClosed += frm_cadastrar_categoria_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
        private DataGridView dataGridView;
    }
}