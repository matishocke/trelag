using Abstraction.IModels;
using Abstraction.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Login.F3UserChildForms
{
    public partial class ServicesForm : Form
    {
        private readonly IFavorService _favorService;
        private readonly IRequestService _requestService;
        private readonly ICustomerService _customerService;
        private readonly IFavorLineService _favorLineService; //ii
        public string _userName;

        Dictionary<IFavor, int> dictionary;

        public ServicesForm(IFavorService favorService, IRequestService requestService,
            string userName, ICustomerService customerService, IFavorLineService favorLineService)
        {
            InitializeComponent();
            _favorService = favorService;

            dictionary = new Dictionary<IFavor, int>();

            _requestService = requestService;
            _userName = userName;
            _customerService = customerService;
            _favorLineService = favorLineService; //ii
        }





        private async void ServicesForm_Load(object sender, EventArgs e)
        {
            await LoadAllFavorsInDataGridView();
        }







        /// <summary>
        /// Method to just Get All Favor into DGV
        /// </summary>
        private async Task LoadAllFavorsInDataGridView()
        {
            var favorList = await _favorService.GetAllFavors();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = favorList;

            DGV_FavorList.DataSource = bindingSource;
        }
        private async Task ShowFavorDetails(IFavor favor)  //need txt
        {
            LBL_ShowFavorName.Text = favor.FavorName;
            LBL_ShowFavorPrice.Text = Convert.ToString(favor.UnitPrice);
        }
        private async void DGV_FavorList_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_FavorList.SelectedRows.Count > 0)
            {
                await ShowFavorDetails((IFavor)DGV_FavorList.SelectedRows[0].DataBoundItem);

                TXT_inputQuantity.Text = string.Empty; //Clear textbox when choose another Favor
            }
        }







        private void BTN_AddToCart_Click(object sender, EventArgs e)
        {
            int quantity;
            if (!int.TryParse(TXT_inputQuantity.Text, out quantity))
            {
                MessageBox.Show("Please input a valid number for quantity.");
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Please input a positive number for quantity.");
                return;
            }


            if (dictionary.ContainsKey((IFavor)DGV_FavorList.SelectedRows[0].DataBoundItem))
            {
                dictionary[(IFavor)DGV_FavorList.SelectedRows[0].DataBoundItem] =
                dictionary[(IFavor)DGV_FavorList.SelectedRows[0].DataBoundItem] +
                Convert.ToInt32(TXT_inputQuantity.Text);
            }
            else
            {
                dictionary.Add((IFavor)DGV_FavorList.SelectedRows[0].DataBoundItem,
                    Convert.ToInt32(TXT_inputQuantity.Text));
            }
            MessageBox.Show
                ($"{LBL_ShowFavorName.Text} - Quantity :{TXT_inputQuantity.Text} ADDED To Cart",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }




        private void BTN_GoToCart_Click(object sender, EventArgs e)
        {
            CartForm cartForm = new CartForm(dictionary, _requestService, _userName, _customerService, _favorLineService);
            cartForm.ShowDialog();
            this.Hide();
        }










        private void DGV_FavorList_DoubleClick(object sender, EventArgs e)
        {

        }


    }

}
