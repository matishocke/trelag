using Abstraction.IModels;
using Abstraction.IService;
using BusinessLogic.Services;
using Microsoft.Extensions.FileProviders;
using Repository.Models;
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
    public partial class RequestFormForAdmins : Form
    {
        private readonly IRequestService _requestService;
        private readonly ICustomerService _customerService;
        private string _username;

        private readonly IFavorLineService _favorLineService;
        private readonly IFavorService _favorService;

        public RequestFormForAdmins(IRequestService requestService, ICustomerService customerService, string username,
            IFavorLineService favorLineService, IFavorService favorService)
        {
            InitializeComponent();
            _requestService = requestService;
            _customerService = customerService;
            _username = username;

            _favorLineService = favorLineService;
            _favorService = favorService;
        }




        private async void RequestFormForAdmins_Load(object sender, EventArgs e)
        {
            await LoadAllRequestsInDataGridView();
        }



        //READ ALL
        private async Task LoadAllRequestsInDataGridView()
        {

            List<IRequest> requestList = await _requestService.GetAllRequests();


            DGV_Requests.Columns.Add("RequestID", "RequestID");
            DGV_Requests.Columns.Add("CustomerID", "CustomerID");
            DGV_Requests.Columns.Add("DateCreated", "DateCreated");
            DGV_Requests.Columns.Add("HasAlarm", "HasAlarm");
            DGV_Requests.Columns.Add("HasCleaningSupply", "HasCleaningSupply");
            DGV_Requests.Columns.Add("HasPets", "HasPets");
            DGV_Requests.Columns.Add("Discount", "Discount");
            DGV_Requests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            foreach (var item in requestList)
            {
                DGV_Requests.Rows.Add(item.RequestID, item.Customer.CustomerId, item.DateCreated,
                    item.HasAlarm, item.HasCleaningSupplies, item.HasPets, item.Discount);
            }
        }


        private async Task ShowRequestDetails(IRequest request)
        {

            if (request != null)
            {
                TXT_RequestID.Text = Convert.ToString(request.RequestID);
                TXT_customerID.Text = Convert.ToString(request.Customer.CustomerId);
                TXT_DateCreated.Text = request.DateCreated.ToString();




                //HasAlarm is the 4th column (index 3) in the DataGridView
                int hasAlarmColumnIndex = 3;
                object Value1 = DGV_Requests.Rows[DGV_Requests.SelectedCells[0].RowIndex].Cells[hasAlarmColumnIndex].Value;
                if (Value1 != null && (bool)Value1 == true)
                {
                    TXT_HasAlarm.Text = "YES";
                }
                else
                {
                    TXT_HasAlarm.Text = "NO";
                }



                //HasCleaningSupply is the 4th column (index 3) in the DataGridView
                int hasCleaningSupplyColumnIndex = 4;
                object Value2 = DGV_Requests.Rows[DGV_Requests.SelectedCells[0].RowIndex].Cells[hasCleaningSupplyColumnIndex].Value;
                if (Value2 != null && (bool)Value2 == true)
                {
                    TXT_HasCleaningSupply.Text = "YES";
                }
                else
                {
                    TXT_HasCleaningSupply.Text = "NO";
                }



                //HasAlarm is the 4th column (index 3) in the DataGridView
                int hasPetsColumnIndex = 3;
                object Value3 = DGV_Requests.Rows[DGV_Requests.SelectedCells[0].RowIndex].Cells[hasPetsColumnIndex].Value;
                if (Value3 != null && (bool)Value3 == true)
                {
                    TXT_HasPets.Text = "YES";
                }
                else
                {
                    TXT_HasPets.Text = "NO";
                }



                TXT_Discount.Text = Convert.ToString(request.Discount);
            }
            else
            {
                ClearTextboxes();
                MessageBox.Show("Request details are not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void DGV_Requests_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Requests.SelectedRows.Count > 0)
            {
                var requestID = (int)DGV_Requests.SelectedRows[0].Cells[0].Value;
                var customerID = (int)DGV_Requests.SelectedRows[0].Cells[1].Value;
                var dateCreated = (DateTime)DGV_Requests.SelectedRows[0].Cells[2].Value;
                var hasAlarm = (bool)DGV_Requests.SelectedRows[0].Cells[3].Value;
                var hasCleaningSupply = (bool)DGV_Requests.SelectedRows[0].Cells[4].Value;
                var hasPets = (bool)DGV_Requests.SelectedRows[0].Cells[5].Value;
                var discount = (double)DGV_Requests.SelectedRows[0].Cells[6].Value;


                IRequest request = new Request();
                request.RequestID = requestID;
                request.Customer = new Customer();
                request.Customer.CustomerId = customerID;
                request.DateCreated = dateCreated;
                request.HasAlarm = hasAlarm;
                request.HasCleaningSupplies = hasCleaningSupply;
                request.HasPets = hasPets;
                request.Discount = discount;

                await ShowRequestDetails(request);
            }
        }






        private void ClearTextboxes()
        {
            TXT_RequestID.Text = string.Empty;
            TXT_customerID.Text = string.Empty;
            TXT_DateCreated.Text = string.Empty;
            TXT_HasAlarm.Text = string.Empty;
            TXT_HasCleaningSupply.Text = string.Empty;
            TXT_HasPets.Text = string.Empty;
            TXT_Discount.Text = string.Empty;
        }









        //RESET
        private async void BTN_Reset_Click(object sender, EventArgs e)
        {
            DGV_Requests.Rows.Clear();
            DGV_Requests.Columns.Clear();

            await LoadAllRequestsInDataGridView();
            ClearTextboxes();
        }





        //Update
        private async void BTN_UpdateRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int requestIdNeeded = Convert.ToInt32(TXT_RequestID.Text);

                ICustomer customerNeeded = _customerService.GetCustomerByID(Convert.ToInt32(TXT_customerID.Text));

                DateTime dateCreatedNeeded = Convert.ToDateTime(TXT_DateCreated.Text);



                bool hasAlarmNeeded = false;
                if (TXT_HasAlarm.Text == "yes")
                {
                    hasAlarmNeeded = true;
                }
                else
                {
                    hasAlarmNeeded = false;
                }



                bool hasSupplyNeeded = false;
                if (TXT_HasCleaningSupply.Text == "yes")
                {
                    hasSupplyNeeded = true;
                }
                else
                {
                    hasSupplyNeeded = false;
                }



                bool hasPetsNeeded = false;
                if (TXT_HasPets.Text == "yes")
                {
                    hasPetsNeeded = true;
                }
                else
                {
                    hasPetsNeeded = false;
                }

                double discountUpdatebyAdmin = Convert.ToDouble(TXT_Discount.Text);



                await _requestService.UpdateRequest(requestIdNeeded, customerNeeded, dateCreatedNeeded,
                    hasAlarmNeeded, hasSupplyNeeded, hasPetsNeeded, discountUpdatebyAdmin);



                DGV_Requests.Rows.Clear();
                DGV_Requests.Columns.Clear();
                await LoadAllRequestsInDataGridView();
                ClearTextboxes();
                MessageBox.Show("The chosen Request has been Successfully Updated",
                    "UPDATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: (CustomerID Does Not exist)" + ex.Message,
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //DELETE
        private async void BTN_Delete_Click(object sender, EventArgs e)
        {
            int requestIDNeeded = Convert.ToInt32(TXT_RequestID.Text);

            await _requestService.DeleteRequest(requestIDNeeded);


            DGV_Requests.Rows.Clear();
            DGV_Requests.Columns.Clear();
            await LoadAllRequestsInDataGridView();
            ClearTextboxes();
            MessageBox.Show("The chosen Request has been Successfully Deleted",
                   "DELETE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //FIND BY RequestID
        private async void BTN_FindByReqID_Click(object sender, EventArgs e)
        {
            try
            {
                IRequest requestNeeded = await _requestService.GetRequest(Convert.ToInt32(TXT_RequestID.Text));
                if (requestNeeded != null)
                {

                    DGV_Requests.Rows.Clear();

                    DGV_Requests.Rows.Add(requestNeeded.RequestID, requestNeeded.Customer.CustomerId,
                        requestNeeded.DateCreated, requestNeeded.HasAlarm, requestNeeded.HasCleaningSupplies,
                        requestNeeded.HasPets, requestNeeded.Discount);

                    await ShowRequestDetails(requestNeeded);
                }
                else
                {
                    MessageBox.Show("Request not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request not found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BTN_FindByCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                List<IRequest> requestNeededList = await _requestService.GetRequestByCustomerID(Convert.ToInt32(TXT_customerID.Text));
                if (requestNeededList != null)
                {

                    DGV_Requests.Rows.Clear();


                    foreach (var item in requestNeededList)
                    {
                        DGV_Requests.Rows.Add(item.RequestID, item.Customer.CustomerId, item.DateCreated,
                            item.HasAlarm, item.HasCleaningSupplies, item.HasPets, item.Discount);

                        await ShowRequestDetails(item);
                    }
                }
                else
                {
                    MessageBox.Show("Request not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request not found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DGV_Requests_DoubleClick(object sender, EventArgs e)
        {

            var requestID = (int)DGV_Requests.SelectedRows[0].Cells[0].Value;
            var customerID = (int)DGV_Requests.SelectedRows[0].Cells[1].Value;
            var dateCreated = (DateTime)DGV_Requests.SelectedRows[0].Cells[2].Value;
            var hasAlarm = (bool)DGV_Requests.SelectedRows[0].Cells[3].Value;
            var hasCleaningSupply = (bool)DGV_Requests.SelectedRows[0].Cells[4].Value;
            var hasPets = (bool)DGV_Requests.SelectedRows[0].Cells[5].Value;
            var discount = (double)DGV_Requests.SelectedRows[0].Cells[6].Value;


            IRequest request = new Request();
            request.RequestID = requestID;
            request.Customer = new Customer();
            request.Customer.CustomerId = customerID;
            request.DateCreated = dateCreated;
            request.HasAlarm = hasAlarm;
            request.HasCleaningSupplies = hasCleaningSupply;
            request.HasPets = hasPets;
            request.Discount = discount;

            IRequest requestDetails = request;

            int requestIDD = request.RequestID;


            ShowFavorLinesFormForAdmin showFavorLinesFormForAdmin =
                new ShowFavorLinesFormForAdmin(_favorLineService, _favorService, _requestService, requestIDD);

            showFavorLinesFormForAdmin.Show();
        }








        ////CREATE
        ////This button is almost bad idea to make! admin could just create customer and log in as that customer
        //private async void BTN_CreateRequest_Click(object sender, EventArgs e)
        //{

        //    try
        //    {

        //        ICustomer currentCustomer = _customerService.GetCustomer(_username);  //CustomerID must be asked from the customer
        //        DateTime dateCreated = DateTime.Now;


        //        //Admin have to ask the customers about this that they have supply or alarm or pets
        //        bool hasAlarm = false;
        //        if (TXT_HasAlarm.Text == "yes")
        //        {
        //            hasAlarm = true;
        //        }
        //        else
        //        {
        //            hasAlarm = false;
        //        }



        //        bool hasSupply = false;
        //        double discountSupply = 0;
        //        if (TXT_HasCleaningSupply.Text == "yes")
        //        {
        //            hasSupply = true;
        //            discountSupply = discountSupply + 20;
        //        }
        //        else
        //        {
        //            hasSupply = false;
        //            discountSupply = 0;
        //        }



        //        bool hasPets = false;
        //        double discountPets = 0;
        //        if (TXT_HasPets.Text == "yes")
        //        {
        //            hasPets = true;
        //            discountPets = 5;
        //        }
        //        else
        //        {
        //            hasPets = false;
        //            discountPets = 0;
        //        }

        //        double totalDiscount = discountSupply + discountPets;



        //        await _requestService.CreateRequest(currentCustomer, dateCreated, hasAlarm, hasSupply, hasPets, totalDiscount);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("An error occurred: " + ex.Message);
        //        MessageBox.Show("Failed to create request, Customer can not be found.");
        //    }



        //}
    }
}
