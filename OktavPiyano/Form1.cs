using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace OktavPiyano
{
    public partial class Form1 : Form
    {
        SoundPlayer ses = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\DO.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\RE.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\Mİ.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\FA.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\SOL.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\LA.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\Sİ.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\DO-S.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\Mİ-S.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\FA-S.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\SOL-S.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath + "\\Sİ-S.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }
    }
}
