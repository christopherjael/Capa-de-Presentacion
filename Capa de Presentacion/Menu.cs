namespace Capa_de_Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnTextEditor_Click(object sender, EventArgs e)
        {
            new frmTextEditor().ShowDialog();
        }

        private void btnFPaint_Click(object sender, EventArgs e)
        {
            new frmFPaint().ShowDialog();
        }
    }
}