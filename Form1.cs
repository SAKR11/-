using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Text_ToSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer Speech = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Speech.SpeakAsync(txtspeech.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Speech.Pause();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Speech.Resume();
        }
    }
}
