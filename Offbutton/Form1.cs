using Microsoft.VisualBasic.ApplicationServices;
using System.Media;
namespace Offbutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("C:\\Users\\ttied_h26vpbv\\source\\repos\\Offbutton\\Offbutton\\Data\\smitethee.wav");
            sp.Play();
            Thread.Sleep(3000);
            SoundPlayer spsp = new SoundPlayer("C:\\Users\\ttied_h26vpbv\\source\\repos\\Offbutton\\Offbutton\\Data\\vineboom.wav");
            spsp.Play();
            
        }
    }
}