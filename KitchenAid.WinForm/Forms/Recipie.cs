using KitchenAid.DataAccess;
using KitchenAid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

        List<string> nameData;

        KitchenAid.Domain.Entities.Recipe? RecipieReff;
        List<KitchenAid.Domain.Entities.RecipeSubRecipe> ingredeantsData;


        public Recipie()
        {
            InitializeComponent();


            RecipieReff = null;

            nameData = new List<string>();

            ingredeantsData = new List<KitchenAid.Domain.Entities.RecipeSubRecipe>();

            UpdateRecipeNameDropDown();

        }



        private void UpdateRecipeNameDropDown()
        {
            nameDataComboBox.Items.Clear();
            nameDataComboBox.Enabled = false;

            var dbLog = GetAllRecipieNamesFromDb();

            if (dbLog == null || dbLog.Count == 0)
            {

                return;
            }

            nameData.Clear();
            nameData.AddRange(dbLog);

            foreach (var name in nameData)
            {
                nameDataComboBox.Items.Add(name);
            }

            nameDataComboBox.Enabled = true;

        }

        private List<string> GetAllRecipieNamesFromDb()
        {
            List<string> names = new List<string>();

            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=myapp.db"));
            services.AddScoped<IKitchenAidRepository>(provider => provider.GetRequiredService<AppDbContext>());
            var serviceProvider = services.BuildServiceProvider();

            var repository = serviceProvider.GetRequiredService<IKitchenAidRepository>();

            names = repository.GetAllRecipeNames().ToList();

            return names;

        }

        private void nameDataComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeDataBoxOutput(nameDataComboBox.SelectedItem.ToString());
        }

        private void ChangeDataBoxOutput(string selectedNameIndex)
        {
            UpdateReffDataFromDb(selectedNameIndex);

            DisplayRecipieReffData();
        }

        private void UpdateReffDataFromDb(string selectedNameIndex)
        {
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=myapp.db"));
            services.AddScoped<IKitchenAidRepository>(provider => provider.GetRequiredService<AppDbContext>());
            var serviceProvider = services.BuildServiceProvider();

            var repository = serviceProvider.GetRequiredService<IKitchenAidRepository>();

            RecipieReff = repository.GetRecipe(selectedNameIndex);

            ingredeantsData = repository.GetSubRecipesByRecipeId(RecipieReff.Id).ToList();

        }

        private void DisplayRecipieReffData()
        {
            if (RecipieReff == null)
            {
                IdDataLabel.Text = "N/A";

                finalMesureDataLabel.Text = "N/A";
                finalMesureDataUnitLabel.Text = "";

                ingredeantsDataGridView.Rows.Clear();

                instructiconTextBox.Text = "N/A";

            }
            else
            {
                IdDataLabel.Text = RecipieReff.Id.ToString();

                finalMesureDataLabel.Text = RecipieReff.FinalMeasure.Measurement.ToString();
                finalMesureDataUnitLabel.Text = RecipieReff.FinalMeasure.Unit.ToString();

                UpdateIngredeantsDataGrid();

                instructiconTextBox.Text = (RecipieReff.Instructions != null || RecipieReff.Instructions != "") ? "N/A" : RecipieReff.Instructions;


            }
        }


        private void UpdateIngredeantsDataGrid()
        {
            ingredeantsDataGridView.Rows.Clear();


            foreach (var ingredient in ingredeantsData)
            {
                ingredeantsDataGridView.Rows.Add(ingredient.ChildRecipe.Name, ingredient.ChildRecipe.FinalMeasure.Measurement.ToString(), ingredient.ChildRecipe.FinalMeasure.Unit.ToString());
            }
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            
        }
    }




}
