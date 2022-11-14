namespace visori_scrittori
{
    public partial class Form1 : Form
    {
        public static Visualizzatore vi = new Visualizzatore();
        public Scrittore scrittore = new Scrittore("joseph",vi);
        public Form1()
        {
            InitializeComponent();
        }
    }
}