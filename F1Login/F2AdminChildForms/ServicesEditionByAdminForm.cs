using Abstraction.IModels;
using Abstraction.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Login.F2AdminChildForms
{
    public partial class ServicesEditionByAdminForm : Form
    {
        private readonly IFavorService _favorService;
        public ServicesEditionByAdminForm(IFavorService favorService)
        {
            InitializeComponent();
            _favorService = favorService;

        }


        //READ
        private async void ServicesEditionByAdminForm_Load(object sender, EventArgs e)
        {
            await LoadAllFavorsInDataGridView();
        }




        //READ
        private async Task LoadAllFavorsInDataGridView()
        {
            var favorList = await _favorService.GetAllFavors();  //READ

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = favorList;

            DGV_FavorListEdition.DataSource = bindingSource;
        }
        private async Task ShowFavorDetails(IFavor favor)
        {
            LBL_ShowID.Text = Convert.ToString(favor.FavorID);
            TXT_ShowFavorName.Text = favor.FavorName;
            TXT_ShowUnitPrice.Text = Convert.ToString(favor.UnitPrice);
        }
        private async void DGV_FavorListEdition_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_FavorListEdition.SelectedRows.Count > 0)
            {
                await ShowFavorDetails((IFavor)DGV_FavorListEdition.SelectedRows[0].DataBoundItem);
            }
        }



        private void ClearTextboxes()
        {
            LBL_ShowID.Text = string.Empty;
            TXT_ShowFavorName.Text = string.Empty;
            TXT_ShowUnitPrice.Text = string.Empty;
        }




        //CREATE
        private async void BTN_CreateFavor_Click(object sender, EventArgs e)
        {

            string favorNameNeed = TXT_ShowFavorName.Text;
            double unitPriceNeed = Convert.ToDouble(TXT_ShowUnitPrice.Text);

            await _favorService.CreateFavor(favorNameNeed, unitPriceNeed);


            ClearTextboxes();

            await LoadAllFavorsInDataGridView();
            MessageBox.Show("New Favor has been Successfully Created",
                    "CREATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //UPDATE
        private async void BTN_UpdateFavor_Click(object sender, EventArgs e)
        {
            int idNeed = Convert.ToInt32(LBL_ShowID.Text);
            string favorNameNeed = TXT_ShowFavorName.Text;
            double unitPriceNeed = Convert.ToDouble(TXT_ShowUnitPrice.Text);

            await _favorService.UpdateFavor(idNeed, favorNameNeed, unitPriceNeed);

            await LoadAllFavorsInDataGridView();

            ClearTextboxes();
            MessageBox.Show("The chosen Favor has been Successfully Updated",
                    "UPDATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //DELETE
        private async void BTN_DeleteFavor_Click(object sender, EventArgs e)
        {
            int idNeed = Convert.ToInt32(LBL_ShowID.Text);

            await _favorService.DeleteFavor(idNeed);

            await LoadAllFavorsInDataGridView();

            ClearTextboxes();
            MessageBox.Show("The chosen Favor has been Successfully Deleted",
                   "DELETE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }






        //RESET TEXTBOXES
        private void BTN_Reset_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
        }




    }
}
