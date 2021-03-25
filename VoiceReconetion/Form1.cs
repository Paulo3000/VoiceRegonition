using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Media;

namespace VoiceReconetion
{
    public partial class Form1 : Form
    {
        static CultureInfo linguagem = new CultureInfo("pt-BR");
        //static SpeechRecognitionEngine reconhecedor;
        SpeechSynthesizer resposta = new SpeechSynthesizer();
        string saudacao = "Olá, sou um programa de computador ainda não tenho nome, meu criador se chama Paulo Sérgio, e  qual é seu nome?";
        string nome;
        public Form1()
        {
            InitializeComponent();
            sound.Play();

        }
        private SoundPlayer sound = new SoundPlayer(@"C:\Users\1988p\Desktop\programação\c#\ProgrmasConcluidos\35-VoiceReconetion\VoiceReconetion\audioFotos\cosmos2.wav");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound.Stop();
            resposta.SpeakAsync(saudacao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resposta.SpeakAsync("prazer em conhecelo "+nome);
            if (nome =="dayane")
            {
                resposta.SpeakAsync("...Fiquei sabendo, que você terá um bêbê, é uma menina ....e se chama Julia, não é mesmo?");
                resposta.SpeakAsync("Meus parabêns mamãe, que venha com muita saúde, a Julia, tenho certeza que será uma criança" +
                    "muito esperta, e muito inteligente,....Meu criador me contou também, que no futuro ele irá ensinar programação pra ela.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nome = textBox1.Text.ToString();
            if (textBox1.Text=="qual é seu nome"||textBox1.Text=="como se chama")
            {
                resposta.SpeakAsync("Ainda não tenho nome,... estou em processo de construção");
            }
            if (textBox1.Text =="oi"||textBox1.Text=="ola")
            {
                resposta.SpeakAsync("Olá, ainda meu vocabulário é bem limitado, num futuro próximo acredito que meu criador, possa me dar mais abilidades");
            }
            if (textBox1.Text=="quantos anos você tem"||textBox1.Text=="qual sua idade")
            {
                resposta.SpeakAsync("Fui criada em 18 de agosto de 2020");
            }
            if (textBox1.Text=="o que você faz")
            {
                resposta.SpeakAsync("No momento não faço grandes coisas, mas no futuro poderei gravar audiolivros, poderei ouvir um vídeo e extrair sua legenda, e o mais importante," +
                    "serei uma asistente virtual ");
            }
            sound.Stop();
        }

        /*private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=bgjJ62SOlXo");
        }*/
    }
}
