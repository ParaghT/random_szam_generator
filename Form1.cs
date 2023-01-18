using System.Windows.Forms;

namespace Random_szam_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generalas_Click(object sender, EventArgs e)
        {
            Random vs = new Random();
            try
            {
                int felso = int.Parse(felso_szam.Text);
                int also = int.Parse(also_szam.Text);
                int number = 0;
            
               
                if (felso < also)
                {
                    number = vs.Next(felso, also);
                    szam_generated.Text = number.ToString();
                }
                else {
                    MessageBox.Show("Az alsó érték nem lehet kisebb, mint a felsõ!");
                }
                
            } catch (Exception hiba)
            {
                MessageBox.Show("Helytelen használat: "+hiba);
            }     
        }
    }
}