using KitchenAid.Table;

namespace KitchenAid.WinForm
{
    public partial class HubPage : Form
    {
        public HubPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitchenAid.WinForm.Forms.Recipie display = new KitchenAid.WinForm.Forms.Recipie();

            display.Show();
        }
    }


}
