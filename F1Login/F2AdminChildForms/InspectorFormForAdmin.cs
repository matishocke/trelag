using Abstraction.IModels;
using Abstraction.IService;
using BusinessLogic.Services;
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
    public partial class InspectorFormForAdmin : Form
    {
        private readonly IRequestService _requestService;
        private readonly IFavorLineService _favorLineService;
        private readonly IFavorService _favorService;

        public InspectorFormForAdmin(IRequestService requestService, IFavorLineService favorLineService,
            IFavorService favorService)
        {
            InitializeComponent();
            _requestService = requestService;
            _favorLineService = favorLineService;
            _favorService = favorService;
        }


        private async void InspectorFormForAdmin_Load(object sender, EventArgs e)
        {
            await LoadAllRequestsInDataGridView();
        }




        private async Task LoadAllRequestsInDataGridView()
        {

            List<IRequest> requestList = await _requestService.GetAllRequests();


            DGV_AllRequests.Columns.Add("RequestID", "RequestID");
            DGV_AllRequests.Columns.Add("CustomerID", "CustomerID");
            DGV_AllRequests.Columns.Add("DateCreated", "DateCreated");
            DGV_AllRequests.Columns.Add("HasAlarm", "HasAlarm");
            DGV_AllRequests.Columns.Add("HasCleaningSupply", "HasCleaningSupply");
            DGV_AllRequests.Columns.Add("HasPets", "HasPets");
            DGV_AllRequests.Columns.Add("Discount", "Discount");
            DGV_AllRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            foreach (var item in requestList)
            {
                DGV_AllRequests.Rows.Add(item.RequestID, item.Customer.CustomerId, item.DateCreated,
                    item.HasAlarm, item.HasCleaningSupplies, item.HasPets, item.Discount);
            }
        }


        private async Task ShowRequestDetails(IRequest request)
        {

            if (request != null)
            {
                TXT_RequestIDIns.Text = Convert.ToString(request.RequestID);
                TXT_customerIDIns.Text = Convert.ToString(request.Customer.CustomerId);
                TXT_DateCreatedIns.Text = request.DateCreated.ToString();




                //HasAlarm is the 4th column (index 3) in the DataGridView
                int hasAlarmColumnIndex = 3;
                object Value1 = DGV_AllRequests.Rows[DGV_AllRequests.SelectedCells[0].RowIndex].Cells[hasAlarmColumnIndex].Value;
                if (Value1 != null && (bool)Value1 == true)
                {
                    TXT_HasAlarmIns.Text = "YES";
                }
                else
                {
                    TXT_HasAlarmIns.Text = "NO";
                }



                //HasCleaningSupply is the 4th column (index 3) in the DataGridView
                int hasCleaningSupplyColumnIndex = 4;
                object Value2 = DGV_AllRequests.Rows[DGV_AllRequests.SelectedCells[0].RowIndex].Cells[hasCleaningSupplyColumnIndex].Value;
                if (Value2 != null && (bool)Value2 == true)
                {
                    TXT_HasCleaningSupplyIns.Text = "YES";
                }
                else
                {
                    TXT_HasCleaningSupplyIns.Text = "NO";
                }



                //HasAlarm is the 4th column (index 3) in the DataGridView
                int hasPetsColumnIndex = 3;
                object Value3 = DGV_AllRequests.Rows[DGV_AllRequests.SelectedCells[0].RowIndex].Cells[hasPetsColumnIndex].Value;
                if (Value3 != null && (bool)Value3 == true)
                {
                    TXT_HasPetsIns.Text = "YES";
                }
                else
                {
                    TXT_HasPetsIns.Text = "NO";
                }



                TXT_DiscountIns.Text = Convert.ToString(request.Discount);
            }
            else
            {
                ClearTextboxes();
                MessageBox.Show("Request details are not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void DGV_AllRequests_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_AllRequests.SelectedRows.Count > 0)
            {
                var requestID = (int)DGV_AllRequests.SelectedRows[0].Cells[0].Value;
                var customerID = (int)DGV_AllRequests.SelectedRows[0].Cells[1].Value;
                var dateCreated = (DateTime)DGV_AllRequests.SelectedRows[0].Cells[2].Value;
                var hasAlarm = (bool)DGV_AllRequests.SelectedRows[0].Cells[3].Value;
                var hasCleaningSupply = (bool)DGV_AllRequests.SelectedRows[0].Cells[4].Value;
                var hasPets = (bool)DGV_AllRequests.SelectedRows[0].Cells[5].Value;
                var discount = (double)DGV_AllRequests.SelectedRows[0].Cells[6].Value;


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
            TXT_RequestIDIns.Text = string.Empty;
            TXT_customerIDIns.Text = string.Empty;
            TXT_DateCreatedIns.Text = string.Empty;
            TXT_HasAlarmIns.Text = string.Empty;
            TXT_HasCleaningSupplyIns.Text = string.Empty;
            TXT_HasPetsIns.Text = string.Empty;
            TXT_DiscountIns.Text = string.Empty;
        }


        private void DGV_AllRequests_DoubleClick(object sender, EventArgs e)
        {
            var requestID = (int)DGV_AllRequests.SelectedRows[0].Cells[0].Value;
            var customerID = (int)DGV_AllRequests.SelectedRows[0].Cells[1].Value;
            var dateCreated = (DateTime)DGV_AllRequests.SelectedRows[0].Cells[2].Value;
            var hasAlarm = (bool)DGV_AllRequests.SelectedRows[0].Cells[3].Value;
            var hasCleaningSupply = (bool)DGV_AllRequests.SelectedRows[0].Cells[4].Value;
            var hasPets = (bool)DGV_AllRequests.SelectedRows[0].Cells[5].Value;
            var discount = (double)DGV_AllRequests.SelectedRows[0].Cells[6].Value;


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

            InspectorShowFavorLinesForm inspectorShowFavorLinesForm =
                new InspectorShowFavorLinesForm(_favorLineService, _favorService, _requestService, requestIDD);

            inspectorShowFavorLinesForm.Show();
        }




        //Reset
        private async void BTN_Reset_Click(object sender, EventArgs e)
        {
            DGV_AllRequests.Rows.Clear();
            DGV_AllRequests.Columns.Clear();

            await LoadAllRequestsInDataGridView();
            ClearTextboxes();
        }


        //Find By RequestID
        private async void BTN_FindByRequestID_Click(object sender, EventArgs e)
        {
            try
            {
                IRequest requestNeeded = await _requestService.GetRequest(Convert.ToInt32(TXT_RequestIDIns.Text));
                if (requestNeeded != null)
                {

                    DGV_AllRequests.Rows.Clear();

                    DGV_AllRequests.Rows.Add(requestNeeded.RequestID, requestNeeded.Customer.CustomerId,
                        requestNeeded.DateCreated, requestNeeded.HasAlarm, requestNeeded.HasCleaningSupplies,
                        requestNeeded.HasPets, requestNeeded.Discount);


                    await ShowRequestDetails(requestNeeded);
                }
                else
                {
                    MessageBox.Show("Request not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Request ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request not found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //Find All By Customer
        private async void BTN_FindByCustomerID_Click(object sender, EventArgs e)
        {
            try
            {
                List<IRequest> requestNeededList = await _requestService.GetRequestByCustomerID(Convert.ToInt32(TXT_customerIDIns.Text));
                if (requestNeededList != null)
                {

                    DGV_AllRequests.Rows.Clear();


                    foreach (var item in requestNeededList)
                    {
                        DGV_AllRequests.Rows.Add(item.RequestID, item.Customer.CustomerId, item.DateCreated,
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
    }
}
