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
                int number = vs.Next(felso, also);
                szam_generated.Text = number.ToString();
                if (felso > also)
                {
                    erorr_text.Text = "Felsõ érték nem lehet kissebb, mint a alsó!";
                }

            } catch (Exception hiba)
            {
                erorr_text.Text = "Nem megfeleõ használat!";
            }

           
        }
    }
}