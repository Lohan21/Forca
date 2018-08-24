using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2_2emia_24_08_18
{
    public partial class Form1 : Form
    {
        string[] palavras = new string[9]
        {
            "YuukiTerumi", // 0
            "Azazel", // 1
            "HibikiKohaku", // 2
            "ReliusClover", // 3
            "Es", // 4
            "CarlClover",
            "KokonoeAMercury",
            "KonoeAMercury",
            "CelicaAMercury"
        };

        string palavra = "";

        private Random rnd = new Random();

        private List<char> letrasDigitadas = new List<char>();

        int chances = 7;

        public Form1()
        {
            InitializeComponent();

            SortearPalavra();

            lbLetrasDigitadas.Text = "Letras Digitadas: ";

            AtualizarChances();
        }

        private void AtualizarChances()
        {
            lbChances.Text = "Chances: " + chances;

            if (chances >= 6)
            {
                lbChances.ForeColor = Color.Green;
            }
            else if (chances >= 3)
            {
                lbChances.ForeColor = Color.Orange;
            }
            else
            {
                lbChances.ForeColor = Color.Red;
            }
        }

        private void SortearPalavra()
        {
            int indiceAleatorio = rnd.Next(0, palavras.Length);
            palavra = palavras[indiceAleatorio].ToLower();
            Console.WriteLine(palavra);

            AtualizarExibicaoPalavra();
        }

        private void AtualizarExibicaoPalavra()
        {
            string exibirPalavra = "";

            bool venceu = true;

            foreach (char letra in palavra)
            {
                if (letrasDigitadas.Contains(letra))
                {
                    exibirPalavra += letra + " ";
                }
                else
                {
                    exibirPalavra += "_ ";
                    venceu = false;
                }
            }

            lbPalavra.Text = exibirPalavra;

            if (venceu)
            {
                tbLetra.Enabled = false;
                btJogar.Enabled = false;
                pbResultado.Image = Properties.Resources.acerto_mizeravi;
                MessageBox.Show("Acerrto, mizerávi!");
            }
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            if (tbLetra.Text.Length == 1)
            {
                char letra = Convert.ToChar(tbLetra.Text.ToLower());
                letrasDigitadas.Add(letra);
                AtualizarExibicaoPalavra();

                tbLetra.Clear();
                tbLetra.Focus();
                lbLetrasDigitadas.Text += letra + "; ";

                if (palavra.Contains(letra))
                {
                    lbResultado.Text = "A letra informada está na palavra.";
                }
                else
                {
                    chances--;
                    AtualizarChances();

                    if (chances == 0)
                    {
                        tbLetra.Enabled = false;
                        btJogar.Enabled = false;
                        pbResultado.Image = Properties.Resources.sabe_nada;
                        MessageBox.Show("Ta queimando tudo bixo!");
                    }

                    lbResultado.Text = "A letra informada não esta não palavra.";
                }
            }
            else
            {
                lbResultado.Text = "Digite uma letra.";
            }
        }

        private void tbLetra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btJogar.PerformClick();
            }
        }
    }
}
