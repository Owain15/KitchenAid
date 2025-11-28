using KitchenAid.DataAccess;

namespace KitchenAid.WinForm
{
    public partial class HubPage : Form
    {
        public HubPage()
        {
            InitializeComponent();

            // Remove Code. Skips to Recipe Dialog
            KitchenAid.WinForm.Forms.Recipie recipieDiolog = new KitchenAid.WinForm.Forms.Recipie();
            recipieDiolog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitchenAid.WinForm.Forms.Recipie recipieDiolog = new KitchenAid.WinForm.Forms.Recipie();

            recipieDiolog.ShowDialog();
        }
    }


}
