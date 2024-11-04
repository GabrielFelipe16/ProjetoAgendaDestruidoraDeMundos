namespace ProjetoAgendaDestruidoraDeMundos.Views
{
    partial class frm_menu
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
            bt_alterar_cadastro = new Button();
            bt_deletar_cadastro = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bt_alterar_cadastro
            // 
            bt_alterar_cadastro.Font = new Font("Segoe UI", 16F);
            bt_alterar_cadastro.Location = new Point(51, 154);
            bt_alterar_cadastro.Name = "bt_alterar_cadastro";
            bt_alterar_cadastro.Size = new Size(246, 109);
            bt_alterar_cadastro.TabIndex = 4;
            bt_alterar_cadastro.Text = "Alterar Cadastro";
            bt_alterar_cadastro.UseVisualStyleBackColor = true;
            bt_alterar_cadastro.Click += bt_alterar_cadastro_Click;
            // 
            // bt_deletar_cadastro
            // 
            bt_deletar_cadastro.Font = new Font("Segoe UI", 16F);
            bt_deletar_cadastro.Location = new Point(490, 154);
            bt_deletar_cadastro.Name = "bt_deletar_cadastro";
            bt_deletar_cadastro.Size = new Size(246, 109);
            bt_deletar_cadastro.TabIndex = 3;
            bt_deletar_cadastro.Text = "Deletar Cadastro";
            bt_deletar_cadastro.UseVisualStyleBackColor = true;
            bt_deletar_cadastro.Click += bt_deletar_cadastro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(320, 50);
            label1.Name = "label1";
            label1.Size = new Size(134, 59);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_alterar_cadastro);
            Controls.Add(bt_deletar_cadastro);
            Controls.Add(label1);
            Name = "frm_menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_alterar_cadastro;
        private Button bt_deletar_cadastro;
        private Label label1;
    }
}