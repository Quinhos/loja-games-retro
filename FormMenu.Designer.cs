namespace LojaGames
{
    partial class FormMenu
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
            lblmenu = new Label();
            btnJogos = new Button();
            btnRelatorio = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblmenu
            // 
            lblmenu.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblmenu.ForeColor = Color.White;
            lblmenu.Location = new Point(40, 30);
            lblmenu.Name = "lblmenu";
            lblmenu.Size = new Size(520, 50);
            lblmenu.TabIndex = 0;
            lblmenu.Text = "MENU PRINCIPAL";
            lblmenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnJogos
            // 
            btnJogos.BackColor = Color.RoyalBlue;
            btnJogos.FlatStyle = FlatStyle.Flat;
            btnJogos.ForeColor = Color.White;
            btnJogos.Location = new Point(190, 105);
            btnJogos.Name = "btnJogos";
            btnJogos.Size = new Size(220, 45);
            btnJogos.TabIndex = 1;
            btnJogos.Text = "jogos";
            btnJogos.UseVisualStyleBackColor = false;
            btnJogos.Click += btnJogos_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.RoyalBlue;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.Location = new Point(190, 160);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(220, 45);
            btnRelatorio.TabIndex = 2;
            btnRelatorio.Text = "relatorio de vendas";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Firebrick;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(190, 215);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(220, 45);
            btnSair.TabIndex = 3;
            btnSair.Text = "sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(584, 311);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorio);
            Controls.Add(btnJogos);
            Controls.Add(lblmenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Label lblmenu;
        private Button btnJogos;
        private Button btnRelatorio;
        private Button btnSair;
    }
}