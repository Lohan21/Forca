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
    //todo: considerar espaços dos nomes
    //não deixar repetição de letras
    //deixar digitar o nome do personagem inteiro com espaços (deixar por ultimo)

    public partial class Form1 : Form
    {
        private List<PalavraComposta> palavras2 = new List<PalavraComposta>();

        //string[] palavras = new string[9]
        //{
        //    "YuukiTerumi", // 0
        //    "Azazel", // 1
        //    "HibikiKohaku", // 2
        //    "ReliusClover", // 3
        //    "Es", // 4
        //    "CarlClover", // 5
        //    "KokonoeAMercury", // 6
        //    "KonoeAMercury", // 7
        //    "CelicaAMercury" // 8
        //};

        string palavra = "";

        Bitmap imagem = null;

        private Random rnd = new Random();

        private List<char> letrasDigitadas = new List<char>();

        int chances = 7;

        public Form1()
        {
            InitializeComponent();

            PalavraComposta item = new PalavraComposta();
            item.Palavra = "YuukiTerumi";
            item.Imagem = Properties.Resources.YuukiTerumi;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "JinKisaragi";
            item.Imagem = Properties.Resources.JinKisaragi;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Ragna";
            item.Imagem = Properties.Resources.Ragna;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "NoelVermillion";
            item.Imagem = Properties.Resources.NoelVermillion;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "RachelAlucard";
            item.Imagem = Properties.Resources.RachelAlucard;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Taokaka";
            item.Imagem = Properties.Resources.Taokaka;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "IronTager";
            item.Imagem = Properties.Resources.Tager;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Litchi";
            item.Imagem = Properties.Resources.Litchi;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Arakune";
            item.Imagem = Properties.Resources.Arakune;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "BangShishigami";
            item.Imagem = Properties.Resources.Bang;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "CarlClover";
            item.Imagem = Properties.Resources.Carl;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Hakumen";
            item.Imagem = Properties.Resources.Hakuman;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Nu13";
            item.Imagem = Properties.Resources.nu;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "TsubakiYayoi";
            item.Imagem = Properties.Resources.Tsubaki;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Hazama";
            item.Imagem = Properties.Resources.Hazama;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Mu12";
            item.Imagem = Properties.Resources.mu12;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "MakotoNanaya";
            item.Imagem = Properties.Resources.makoto;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Valkenhayn";
            item.Imagem = Properties.Resources.Valkenhayn;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "PlatinumTheTrinity";
            item.Imagem = Properties.Resources.Platinum;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "PlatinumTheTrinity";
            item.Imagem = Properties.Resources.Platinum;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "ReliusClover";
            item.Imagem = Properties.Resources.Relius;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Izayoi";
            item.Imagem = Properties.Resources.Izaoy;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "AmaneNishiki";
            item.Imagem = Properties.Resources.Amane;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Bullet";
            item.Imagem = Properties.Resources.Bullet;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Azrael";
            item.Imagem = Properties.Resources.Azrael;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "KaguraMutsuki";
            item.Imagem = Properties.Resources.Kagura;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "KokonoeMercury";
            item.Imagem = Properties.Resources.kokonoe;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "CelicaAyatsukiMercury";
            item.Imagem = Properties.Resources.celica;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Lambda11";
            item.Imagem = Properties.Resources.lambda;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "HibikiKohaku";
            item.Imagem = Properties.Resources.hibiki;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "NaotoKurogane";
            item.Imagem = Properties.Resources.Naota;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "KonoeAyatsukiMercury";
            item.Imagem = Properties.Resources.nine;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "HadesIzanami";
            item.Imagem = Properties.Resources.Izanami;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Susanoo";
            item.Imagem = Properties.Resources.susano;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Es";
            item.Imagem = Properties.Resources.es;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "MaiHazuki";
            item.Imagem = Properties.Resources.mai;
            palavras2.Add(item);

            item = new PalavraComposta();
            item.Palavra = "Mitsuyoshi";
            item.Imagem = Properties.Resources.jubei;
            palavras2.Add(item);

            Jogar();
        }

        private void Jogar()
        {                       
            SortearPalavra2();

            //SortearPalavra();

            lbLetrasDigitadas.Text = "Letras Digitadas: ";

            AtualizarChances();
        }

        private void SortearPalavra2()
        {
            int indiceAleatorio = rnd.Next(0, palavras2.Count);
            palavra = palavras2[indiceAleatorio].Palavra.ToLower();
            imagem = palavras2[indiceAleatorio].Imagem;
            Console.WriteLine(palavra);

            AtualizarExibicaoPalavra();
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

        //private void SortearPalavra()
        //{
        //    int indiceAleatorio = rnd.Next(0, palavras.Length);
        //    palavra = palavras[indiceAleatorio].ToLower();
        //    Console.WriteLine(palavra);

        //    AtualizarExibicaoPalavra();
        //}

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
            pbResultado.Image = imagem;

            if (venceu)
            {
                tbLetra.Enabled = false;
                btJogar.Enabled = false;
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
                        MessageBox.Show("O personagem era: " + palavra,"Você Perdeu");
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

        private void btReiniciar_Click(object sender, EventArgs e)
        {
            chances = 7;
            letrasDigitadas = new List<char>();
            Jogar();
            AtualizarExibicaoPalavra();
            //pbResultado.Image = null;
            tbLetra.Enabled = true;
            btJogar.Enabled = true;
        }
    }
}
