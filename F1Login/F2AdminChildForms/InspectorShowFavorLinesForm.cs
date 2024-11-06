using Abstraction.IModels;
using Abstraction.IService;
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
    public partial class InspectorShowFavorLinesForm : Form
    {

        private readonly IFavorLineService _favorLineService;
        private readonly IFavorService _favorService;
        private readonly IRequestService _requestService;
        private readonly int _requestIDD;
        public InspectorShowFavorLinesForm(IFavorLineService favorLineService, IFavorService favorService,
            IRequestService requestService, int requestIDD)
        {
            InitializeComponent();
            _favorLineService = favorLineService;
            _favorService = favorService;
            _requestService = requestService;
            _requestIDD = requestIDD;

        }




        private async void InspectorShowFavorLinesForm_Load(object sender, EventArgs e)
        {
            await LoadAllFavorLinesForRequest();
        }





        public async Task LoadAllFavorLinesForRequest()
        {
            List<IFavorLine> listOfAllFavorLines = await _favorLineService.GetAllFavorLines();
            IRequest requestNeeded = await _requestService.GetRequest(_requestIDD);

            var requestsInFavorLinesList = await _favorLineService.GetAllFavorLinesByFavorID(requestNeeded, listOfAllFavorLines);


            DGV_AllFavorLines.Columns.Add("FavorLineID", "FavorLineID");
            DGV_AllFavorLines.Columns.Add("FavorID", "FavorID");
            DGV_AllFavorLines.Columns.Add("FavorName", "FavorName");
            DGV_AllFavorLines.Columns.Add("RequestID", "RequestID");
            DGV_AllFavorLines.Columns.Add("FavorQuantity", "FavorQuantity");
            DGV_AllFavorLines.Columns.Add("FavorStatus", "FavorStatus");
            DGV_AllFavorLines.Columns.Add("FavorComment", "FavorComment");

            DGV_AllFavorLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (var item in requestsInFavorLinesList)
            {
                DGV_AllFavorLines.Rows.Add(item.FavorLineID, item.Favor.FavorID, item.Favor.FavorName,
                          item.Request.RequestID, item.FavorQuantity, item.FavorStatus, item.FavorComment);
            }

        }

        private async Task ShowFavorLineDetails(IFavorLine favorLine)
        {
            TXT_FavorQuantityIns.Text = Convert.ToString(favorLine.FavorQuantity);
            TXT_FavorLineIDIns.Text = Convert.ToString(favorLine.FavorLineID);
            TXT_FavorComment.Text = Convert.ToString(favorLine.FavorComment);
        }

        private async void DGV_AllFavorLines_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_AllFavorLines.SelectedRows.Count > 0)
            {
                var favorLineID = (int)DGV_AllFavorLines.SelectedRows[0].Cells[0].Value;
                var favorQuantity = (int)DGV_AllFavorLines.SelectedRows[0].Cells[4].Value;
                var favorComment = (string)DGV_AllFavorLines.SelectedRows[0].Cells[6].Value;

                IFavorLine favorLine = new FavorLine();
                favorLine.FavorLineID = favorLineID;
                favorLine.FavorQuantity = favorQuantity;
                favorLine.FavorComment = favorComment;

                await ShowFavorLineDetails(favorLine);
            }
        }



        private async void ClearTextboxes()
        {
            TXT_FavorLineIDIns.Text = string.Empty;
            TXT_FavorQuantityIns.Text = string.Empty;
            TXT_FavorComment.Text = string.Empty;
        }





        //Approved
        private async void BTN_Approved_Click(object sender, EventArgs e)
        {
            int favorLineID = int.Parse(TXT_FavorLineIDIns.Text);
            string favorStatus = "Approved"; // Set the status accordingly

            string favorComment = TXT_FavorComment.Text.Trim(); // Include the inspector's comment
            if (string.IsNullOrEmpty(favorComment))
            {
                favorComment = string.Empty; // Set an empty string if the textbox is empty
            }

            bool inserted = await _favorLineService.InsertInspectorComments(favorLineID, favorStatus.Trim(), favorComment);


            if (inserted)
            {
                MessageBox.Show("Approved. Comments added. ");
                ClearTextboxes();
            }
            else
            {
                MessageBox.Show("Failed to add comments");
            }

            DGV_AllFavorLines.Rows.Clear();
            DGV_AllFavorLines.Columns.Clear();
            await LoadAllFavorLinesForRequest(); //refresh the datagridview
            ClearTextboxes();
        }



        //Denied
        private async void BTN_Denied_Click(object sender, EventArgs e)
        {
            int favorLineID = int.Parse(TXT_FavorLineIDIns.Text);
            string favorStatus = "Denied"; // Set the status accordingly

            string favorComment = TXT_FavorComment.Text.Trim(); // Include the inspector's comment
            if (string.IsNullOrEmpty(favorComment))
            {
                favorComment = string.Empty; // Set an empty string if the textbox is empty
            }

            bool inserted = await _favorLineService.InsertInspectorComments(favorLineID, favorStatus.Trim(), favorComment);


            if (inserted)
            {
                MessageBox.Show("Approved. Comments added. ");
                ClearTextboxes();
            }
            else
            {
                MessageBox.Show("Failed to add comments");
            }


            DGV_AllFavorLines.Rows.Clear();
            DGV_AllFavorLines.Columns.Clear();
            await LoadAllFavorLinesForRequest(); //refresh the datagridview
            ClearTextboxes();
        }






        //RESET
        private async void BTN_Reset_Click(object sender, EventArgs e)
        {
            DGV_AllFavorLines.Rows.Clear();
            DGV_AllFavorLines.Columns.Clear();

            await LoadAllFavorLinesForRequest();
            ClearTextboxes();
        }


    }
}
