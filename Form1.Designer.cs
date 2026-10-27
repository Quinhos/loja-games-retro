namespace LojaGames
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblcarregando = new Label();
            timerSplash = new System.Windows.Forms.Timer(components);
            progressBarSplash = new ProgressBar();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(50, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(500, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\tLOJA DE GAMES RETRÔ";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblcarregando
            // 
            lblcarregando.Font = new Font("Segoe UI", 12F);
            lblcarregando.ForeColor = Color.White;
            lblcarregando.Location = new Point(50, 160);
            lblcarregando.Name = "lblcarregando";
            lblcarregando.Size = new Size(500, 30);
            lblcarregando.TabIndex = 1;
            lblcarregando.Text = "Carregando...";
            lblcarregando.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerSplash
            // 
            timerSplash.Interval = 3000;
            timerSplash.Tick += timerSplash_Tick;
            // 
            // progressBarSplash
            // 
            progressBarSplash.Location = new Point(125, 240);
            progressBarSplash.MarqueeAnimationSpeed = 30;
            progressBarSplash.Name = "progressBarSplash";
            progressBarSplash.Size = new Size(350, 20);
            progressBarSplash.Style = ProgressBarStyle.Marquee;
            progressBarSplash.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(584, 311);
            Controls.Add(progressBarSplash);
            Controls.Add(lblcarregando);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loja de Games Retrô";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblcarregando;
        private System.Windows.Forms.Timer timerSplash;
        private ProgressBar progressBarSplash;
    }
}
