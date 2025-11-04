namespace Torri_di_Hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Invia_Click(object sender, EventArgs e)
        {
            int dischi = (int)nmr_Dischi.Value;
            if (dischi > 0 && dischi < 8)
            {
                Interfaccia interfacciaNuovoForm = new Interfaccia(dischi);
                interfacciaNuovoForm.ShowDialog();
            } else
            {
                MessageBox.Show("Il numero di dischi deve essere > 0 e < 8", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}