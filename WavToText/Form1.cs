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
using System.Speech.AudioFormat;
using System.IO;

namespace WavToText
{
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine recognitionEngine;

        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            m_cmbxLanguage.SelectedIndex = 3;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void m_btnSave_Click(object sender, EventArgs e)
        {

            //validation

            if (m_txtBoxWavFileURL.Text == "")
            {
                MessageBox.Show("Please enter/ select WAV file");
                return;
            }

            if (m_txtBoxLoopTime.Text == "")
            {
                MessageBox.Show("Please enter loop time");
                return;
            }

            if (m_txtBoxWriteToTextURL.Text == "")
            {
                MessageBox.Show("Please enter output textfile");
                return;
            }


            try
            {
                string strLngCode = "en-US";
                if(m_cmbxLanguage.Text == "English (United States)")
                {
                    strLngCode = "en-US";
                }else if (m_cmbxLanguage.Text == "English (United Kingdom)")
                {
                    strLngCode = "en-GB";
                }
                else if (m_cmbxLanguage.Text == "German (Germany)")
                {
                    strLngCode = "de-DE";
                }
                else if (m_cmbxLanguage.Text == "Spanish (Spain)")
                {
                    strLngCode = "es-ES";
                }
                else if (m_cmbxLanguage.Text == "French (France)")
                {
                    strLngCode = "fr-FR";
                }
                else if (m_cmbxLanguage.Text == "Japanese (Japan)")
                {
                    strLngCode = "ja-JP";
                }
                else if (m_cmbxLanguage.Text == "Chinese (China)")
                {
                    strLngCode = "zh-CN";
                }
                else if (m_cmbxLanguage.Text == "Chinese (Taiwan)")
                {
                    strLngCode = "zh-TW";
                }


                recognitionEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo(strLngCode));
                DictationGrammar dg = new DictationGrammar();
                dg.Name = "Dictation Grammar";
                recognitionEngine.LoadGrammar(dg);
                recognitionEngine.SetInputToDefaultAudioDevice();
                recognitionEngine.SetInputToWaveFile(@"C:\Users\mseelam\Documents\OSR_us_000_0010_8k.wav");

                // recognitionEngine.SetInputToDefaultAudioDevice();  // Gets sound from microphone
                recognitionEngine.EndSilenceTimeout = new TimeSpan(0, 0, Int16.Parse(m_txtBoxLoopTime.Text));
                // Following two lines are not needed. They cause error!
                //recognitionEngine.Recognize();
                //recognitionEngine.RecognizeAsync();
                recognitionEngine.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(reco_SpeechHypothesized);
                recognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reco_SpeechRecognized);
                recognitionEngine.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(reco_RecognizeCompleted);
                recognitionEngine.AudioSignalProblemOccurred += new EventHandler<AudioSignalProblemOccurredEventArgs>(reco_AudioSignalProblemOccurred);
                recognitionEngine.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(reco_SpeechDetected);
                recognitionEngine.SpeechRecognitionRejected += new EventHandler<SpeechRecognitionRejectedEventArgs>(reco_SpeechRecognitionRejected);
                recognitionEngine.RecognizeAsync(RecognizeMode.Single);

                MessageBox.Show("Done.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        void reco_AudioSignalProblemOccurred(object sender, AudioSignalProblemOccurredEventArgs e)
        {

            //using (StreamWriter w = File.AppendText(m_txtBoxWriteToTextURL.Text))
            //{
            //    Log("----------------------------------reco_AudioSignalProblemOccurred!---------------------------------------------", w);

            //    Log(e.AudioSignalProblem.ToString(), w);
            //    Log("----------------------------------reco_AudioSignalProblemOccurred!---------------------------------------------", w);

            //}
            // m_txtBoxWriteToTextURL.AppendText(e.AudioSignalProblem.ToString());
            //Console.WriteLine(e.AudioSignalProblem.ToString());
        }

        void reco_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
            //using (StreamWriter w = File.AppendText(m_txtBoxWriteToTextURL.Text))
            //{
            //    Log(e.Result.Text, w);
            //}
            //m_txtBoxWriteToTextURL.AppendText(e.Result.Text);
            // Console.WriteLine(e.Result.Text);
        }

        void reco_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            //m_txtBoxWriteToTextURL.AppendText("Rejected!");
            // Console.WriteLine("Rejected!");

            using (StreamWriter w = File.AppendText(m_txtBoxWriteToTextURL.Text))
            {
                Log("----------------------------------Rejected!---------------------------------------------", w);
            }
        }

        void reco_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
        {
            // m_txtBoxWriteToTextURL.AppendText("Recognition Complete!");
            //  Console.WriteLine("Recognition Complete!");

            using (StreamWriter w = File.AppendText(m_txtBoxWriteToTextURL.Text))
            {
                Log("----------------------------------Recognition Complete!---------------------------------------------", w);
            }
        }

        void reco_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            using (StreamWriter w = File.AppendText(m_txtBoxWriteToTextURL.Text))
            {
             //   Log("----------------------------------reco_SpeechRecognized!---------------------------------------------", w);
                Log(e.Result.Text, w);
               // Log("----------------------------------reco_SpeechRecognized!---------------------------------------------", w);

            }
            // m_txtBoxWriteToTextURL.AppendText(e.Result.Text);
            //  Console.WriteLine(e.Result.Text);
        }

        void reco_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            using (StreamWriter w = File.AppendText(m_txtBoxWriteToTextURL.Text))
            {
                Log("----------------------------------Speech Detected!---------------------------------------------", w);
            }
           // m_txtBoxWriteToTextURL.AppendText("Speech Detected!");
           // Console.WriteLine("Speech Detected!");
        }

        private void m_btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = false;
                openFileDialog.Filter = "Wave Files(*.wav;*.WAV)|*.wav;*.WAV";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePaths = openFileDialog.FileNames;
                    var fileNames = openFileDialog.SafeFileNames;

                    foreach (int i in Enumerable.Range(0, filePaths.Length))
                    {
                        m_txtBoxWavFileURL.Text = filePaths[i];
                        //m_txtBoxWavFileURL.AppendText(fileNames[i]);
                        //m_txtBoxWavFileURL.Name = filePaths[i];

                    }

                }
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {

            if(logMessage == "")
            {
                return;
            }
            //w.Write("\r\nLog Entry : ");
            //w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("*********************************");
            w.WriteLine(logMessage);
            w.WriteLine("*********************************\n");

        }

        private void m_cmbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
