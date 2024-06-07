using Microsoft.Maui.Platform;
using System.Reflection;
using System.Speech.Synthesis;
namespace Text_to_Speech
{
    public partial class MainPage : ContentPage
    {

        SpeechSynthesizer rdr;
        public MainPage()
        {
            InitializeComponent();
            rdr = new SpeechSynthesizer();
        }

        public void SpeakSettings()
        {
            rdr.SpeakAsyncCancelAll();
            int Speed = (int)SpeedSlider.Value;
            rdr.Rate = Speed;
            string texto = EditorText.Text;
            if(texto!=null)
            {
                rdr.SpeakAsync(texto);
            }
        }

        private void Speak_Button_Clicked(object sender, EventArgs e)
        {
            SpeakSettings();
        }
    }
}
