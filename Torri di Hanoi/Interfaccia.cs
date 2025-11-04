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
        int dischi, mosse = 1;
        int base_A_X = 147; // centrato +- base A
        int base_A_Y;
        int base_B_X = 396; // centrato +- base B
        int base_C_X = 640; // centrato +- base C
        int altezza = 20; // altezza costante
        int baseGroundY = 334;
        List<Panel>[] torri = new List<Panel>[3]
        {
            new List<Panel>(), // A
            new List<Panel>(), // B
            new List<Panel>()  // C
        };



        public Interfaccia(int dischi)
        {
            this.dischi = dischi;
            InitializeComponent();
        }

        private void Interfaccia_Load(object sender, EventArgs e)
        {
            lbl_DischiNumero.Text = dischi.ToString();
            GenDischi();
            Hanoi(dischi, 0, 2, 1);
        }

        public void GenDischi()
        {
            listaDischi = new Panel[dischi];
            base_A_Y = baseGroundY - ((dischi - 1) * altezza);
            int larghezzaMax = 100, larghezzaMin = 15;
            //pallette con arr
            Color[] colori = new Color[]
                {
                    Color.FromArgb(200, 80, 80),   
                    Color.FromArgb(230, 180, 80),  
                    Color.FromArgb(80, 150, 80),   
                    Color.FromArgb(80, 130, 180),  
                    Color.FromArgb(90, 80, 160),    
                    Color.FromArgb(170, 100, 160), 
                    Color.FromArgb(180, 180, 180)  
            };

            for (int i = 0; i < dischi; i++)
            {
                listaDischi[i] = new Panel();
                listaDischi[i].BackColor = Color.Red;

                int larghezza = larghezzaMax + ((larghezzaMax - larghezzaMin) * i / (dischi - 1));
                listaDischi[i].Size = new Size(larghezza, altezza);

                // centrarlo sulla base A +- (molto approx)
                int x = base_A_X - (larghezza / 2);
                int y = base_A_Y + (i * altezza);

                // colori (uno diverso dall'altro)
                listaDischi[i].BackColor = colori[i % colori.Length]; // prendo resto divisione (ex. 5/7 = 5 prendo il 5o colore)

                listaDischi[i].Location = new Point(x, y);
                // carico in A tutti i dischi
                torri[0].Add(listaDischi[i]);
                //
                Controls.Add(listaDischi[i]);
                listaDischi[i].BringToFront();
            }
        }

        public async Task Hanoi(int n, int da, int a, int aux)
        {
            if (n == 1)
            {
                SpostaDisco(da, a);
                return;
            }

            await Task.Delay(0);
            await Hanoi(n - 1, da, aux, a);
            mosse++;
            AggiornaMosse();

            await Task.Delay(0);
            SpostaDisco(da, a);

            await Hanoi(n - 1, aux, a, da);
            mosse++;
            AggiornaMosse();
        }



        private void SpostaDisco(int da, int a)
        {
            // 1️ prende il disco dalla cima quindi torri[0][0]
            Panel disco = torri[da][0];

            // 2 lo rimuove
            torri[da].RemoveAt(0);

            // 3️ inserisco il disco nell'array dest
            torri[a].Insert(0, disco);

            // 4️ base X della desti
            int baseX;
            if (a == 0)
            {
                baseX = base_A_X;
            }
            else if (a == 1)
            {
                baseX = base_B_X;
            }
            else
            {
                baseX = base_C_X;
            }

            // 5️ posizione
            int x = baseX - (disco.Width / 2);
            int y;

            if (torri[a].Count == 1)
            {
                // torre vuora -> questo disco va a terra
                y = base_A_Y;
            }
            else
            {
                // ci sono altri disci --> posizionati sopra quello più alto
                Panel discoSotto = torri[a][1]; // subito sotto di lui
                y = discoSotto.Location.Y - altezza;
            }

            // 6️ nuova pos
            disco.Location = new Point(x, y);
            disco.BringToFront();
            Refresh();
        }

        void AggiornaMosse()
        {
            lbl_MosseNumero.Text = mosse.ToString();
        }
    }
}
