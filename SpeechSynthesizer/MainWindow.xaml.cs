using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Synthesis;

namespace TextToSpeech
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textToSpeech(object sender, RoutedEventArgs e)        {
            //add using system.speech.synthesis
            
            if(textBox.Text !="")
            {
             //used system.speech.synthesis despite using statement due to namespace error
                
                System.Speech.Synthesis.SpeechSynthesizer s = new System.Speech.Synthesis.SpeechSynthesizer();
               
                 s.Speak(textBox.Text);
                
            }
            else
            {
                MessageBox.Show("It's blank. Type something", "Error", MessageBoxButton.OK);
            }
        }
    }
}
