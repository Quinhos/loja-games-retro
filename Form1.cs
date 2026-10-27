namespace LojaGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Stop();

            this.Hide();

            using (FormMenu menu = new FormMenu())
            {
                menu.ShowDialog();
            }

            this.Close();
        }
    }
}
