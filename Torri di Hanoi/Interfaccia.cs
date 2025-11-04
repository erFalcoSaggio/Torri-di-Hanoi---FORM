using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torri_di_Hanoi
{
    public partial class Interfaccia : Form
    {
        // pannelli
        // primo size 55; 20 location 120; 334

        Panel[] listaDischi;
        int dischi;
        
        public Interfaccia(int dischi)
        {
            this.dischi = dischi;
            InitializeComponent();
        }

        private void Interfaccia_Load(object sender, EventArgs e)
        {
            lbl_DischiNumero.Text = dischi.ToString();
            GenDischi();
        }

        public void GenDischi()
        {
            listaDischi = new Panel[dischi];
            int altezza = 20; //questa rimane
            int base_A_X = 120;
            int base_A_Y = 334 - ((dischi - 1) * altezza);
            int larghezzaMax = 140;
            bool primoMesso = false;
            for (int i = 0; i < dischi; i++)
            {
                listaDischi[i] = new Panel();
                listaDischi[i].BackColor = Color.Red;
                listaDischi[i].Size = new Size(larghezzaMax / (dischi - i), altezza);
                listaDischi[i].Location = new Point(base_A_X, base_A_Y + (i * altezza));
                //listaDischi[i].Left = //????//;
                Controls.Add(listaDischi[i]);
            }
        }
    }
}
