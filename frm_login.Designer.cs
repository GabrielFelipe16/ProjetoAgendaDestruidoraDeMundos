namespace ProjetoAgendaDestruidoraDeMundos
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
            lbl_cadastro = new LinkLabel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            bt_entrar = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.Transparent;
            groupBox.Controls.Add(lbl_cadastro);
            groupBox.Controls.Add(textBox2);
            groupBox.Controls.Add(textBox1);
            groupBox.Controls.Add(bt_entrar);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Font = new Font("Segoe UI", 16F);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(46, 21);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(274, 372);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Login";
            // 
            // lbl_cadastro
            // 
            lbl_cadastro.ActiveLinkColor = Color.Blue;
            lbl_cadastro.AutoSize = true;
            lbl_cadastro.Font = new Font("Segoe UI", 9F);
            lbl_cadastro.LinkColor = Color.Black;
            lbl_cadastro.Location = new Point(38, 242);
            lbl_cadastro.Name = "lbl_cadastro";
            lbl_cadastro.Size = new Size(118, 15);
            lbl_cadastro.TabIndex = 3;
            lbl_cadastro.TabStop = true;
            lbl_cadastro.Text = "Não possuo cadastro";
            lbl_cadastro.LinkClicked += lbl_cadastro_LinkClicked;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(38, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 36);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(38, 190);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(198, 36);
            textBox1.TabIndex = 2;
            // 
            // bt_entrar
            // 
            bt_entrar.BackColor = Color.Silver;
            bt_entrar.Cursor = Cursors.Hand;
            bt_entrar.Enabled = false;
            bt_entrar.Font = new Font("Segoe UI", 10F);
            bt_entrar.Location = new Point(88, 290);
            bt_entrar.Name = "bt_entrar";
            bt_entrar.Size = new Size(86, 42);
            bt_entrar.TabIndex = 1;
            bt_entrar.Text = "Entrar";
            bt_entrar.UseVisualStyleBackColor = false;
            bt_entrar.Click += bt_entrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 157);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 0;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 63);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.v602_nunoon_05_rippednotes1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(370, 450);
            Controls.Add(groupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Agenda Telefônica Mortifera";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button bt_entrar;
        private Label label2;
        private Label label1;
        private LinkLabel lbl_cadastro;
    }
}
