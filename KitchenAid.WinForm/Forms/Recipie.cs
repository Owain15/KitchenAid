using KitchenAid.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitchenAid.WinForm.Forms
{
    public partial class Recipie : Form
    {
        List<string>? nameData;
        

        int? RecipieReff;


        public Recipie()
        {
            InitializeComponent();

            nameData = UpdateRecipeNameDropDown();

        }




        private List<string> UpdateRecipeNameDropDown()
        {
            nameData.Clear();

            nameData = iMyDb.GetAllRecipeNames();
   
        }

        private void nameDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDataBoxOutput();
        }
        private void ChangeDataBoxOutput()
        {
            reffData = iMyDb.GetRecipie();

        }

    }




}
