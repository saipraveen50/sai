using System;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TextToSpecch
{
    public partial class TextToSpeech : Form
    {
        SpeechSynthesizer ss;
        string file = string.Empty;

        public TextToSpeech()
        {
            InitializeComponent();
            /*comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.SelectedIndex = 1;*/
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            ss = new SpeechSynthesizer();
            ss.SelectVoice(comboBox1.Text);
            ss.Rate = 1;
            ss.Volume = 100;
            ss.SpeakAsync(textBox1.Text);


        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            ss.Pause();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            ss.Resume();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.ShowDialog();
                string fname = openFileDialog.FileName;
                StreamReader streamReader = new StreamReader(fname);
                textBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
            catch (Exception)
            {

                MessageBox.Show(" Select a file");
            }
        }

        private void BtnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "wav Files|*.wav";
                saveFile.ShowDialog();
                string fname;
                fname = saveFile.FileName;
                SpeechSynthesizer ss = new SpeechSynthesizer();
                ss.SelectVoice(comboBox1.Text);
                ss.Rate = 1;
                ss.Volume = 100;
                ss.SetOutputToWaveFile(fname);
                ss.Speak(textBox1.Text);
                ss.SetOutputToDefaultAudioDevice();
                MessageBox.Show("Succesful");
                file = fname;
            }
            catch (Exception)
            {

                MessageBox.Show("Please select a name for file ");
            }

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextToSpeech_Load(object sender, EventArgs e)
        {
            try
            {
                ss = new SpeechSynthesizer();
                foreach (var voice in ss.GetInstalledVoices())
                {
                    comboBox1.Items.Add(voice.VoiceInfo.Name);
                }
                comboBox1.SelectedItem = "Microsoft Mark";
            }
            catch (Exception)
            {

                MessageBox.Show("Please Select Voice");
            }


        }
        
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = file;
        }
    }
}
