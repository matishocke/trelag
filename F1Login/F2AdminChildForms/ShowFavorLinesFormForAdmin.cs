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
    public partial class ShowFavorLinesFormForAdmin : Form
    {
        private readonly IFavorLineService _favorLineService;
        private readonly IFavorService _favorService;
        private readonly IRequestService _requestService;
        private readonly int _requestIDD;

        public ShowFavorLinesFormForAdmin(IFavorLineService favorLineService, IFavorService favorService,
            IRequestService requestService, int requestIDD)
        {
            InitializeComponent();
            _favorLineService = favorLineService;
            _favorService = favorService;
            _requestService = requestService;
            _requestIDD = requestIDD;
        }


        private async void ShowFavorLinesFormForAdmin_Load(object sender, EventArgs e)
        {
            await LoadAllFavorLinesForRequest();
        }





        public async Task LoadAllFavorLinesForRequest()
        {
            List<IFavorLine> listOfAllFavorLines = await _favorLineService.GetAllFavorLines();
            IRequest requestNeeded = await _requestService.GetRequest(_requestIDD);

            var requestsInFavorLinesList = await _favorLineService.GetAllFavorLinesByFavorID(requestNeeded, listOfAllFavorLines);


            DGV_FavorLine.Columns.Add("FavorLineID", "FavorLineID");
            DGV_FavorLine.Columns.Add("FavorID", "FavorID");
            DGV_FavorLine.Columns.Add("FavorName", "FavorName");
            DGV_FavorLine.Columns.Add("RequestID", "RequestID");
            DGV_FavorLine.Columns.Add("FavorQuantity", "FavorQuantity");
            DGV_FavorLine.Columns.Add("FavorStatus", "FavorStatus");
            DGV_FavorLine.Columns.Add("Comment", "Comment");

            DGV_FavorLine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (var item in requestsInFavorLinesList)
            {
                DGV_FavorLine.Rows.Add(item.FavorLineID, item.Favor.FavorID, item.Favor.FavorName,
                                       item.Request.RequestID, item.FavorQuantity, item.FavorStatus, item.FavorComment);
            }

        }

        private async Task ShowFavorLineDetails(IFavorLine favorLine)
        {
            TXT_FavorQuantity.Text = Convert.ToString(favorLine.FavorQuantity);
            TXT_FavorLineID.Text = Convert.ToString(favorLine.FavorLineID);
        }

        private async void DGV_FavorLine_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_FavorLine.SelectedRows.Count > 0)
            {
                var favorLineID = (int)DGV_FavorLine.SelectedRows[0].Cells[0].Value;
                var favorQuantity = (int)DGV_FavorLine.SelectedRows[0].Cells[4].Value;

                IFavorLine favorLine = new FavorLine();
                favorLine.FavorLineID = favorLineID;
                favorLine.FavorQuantity = favorQuantity;

                await ShowFavorLineDetails(favorLine);
            }
        }




        private async void ClearTextboxes()
        {
            TXT_FavorLineID.Text = string.Empty;
            TXT_FavorQuantity.Text = string.Empty;
        }



        //Reset button
        private async void BTN_Reset_Click(object sender, EventArgs e)
        {
            DGV_FavorLine.Rows.Clear();
            DGV_FavorLine.Columns.Clear();

            await LoadAllFavorLinesForRequest();
            ClearTextboxes();
        }



        //Update 
        private async void BTN_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int favorQuantityNeeded = Convert.ToInt32(TXT_FavorQuantity.Text);
                int favorLineIDNeeded = Convert.ToInt32(TXT_FavorLineID.Text);


                await _favorLineService.UpdateFavorLine(favorLineIDNeeded, favorQuantityNeeded);



                DGV_FavorLine.Rows.Clear();
                DGV_FavorLine.Columns.Clear();

                await LoadAllFavorLinesForRequest();
                ClearTextboxes();
                MessageBox.Show("The chosen FavorLine has been Successfully Updated",
                    "UPDATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: (FavorLineID Does Not exist)" + ex.Message,
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //DELETE
        private async void BTN_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int favorLineIDNeeded = Convert.ToInt32(TXT_FavorLineID.Text);

                await _favorLineService.DeleteFavorLine(favorLineIDNeeded);


                DGV_FavorLine.Rows.Clear();
                DGV_FavorLine.Columns.Clear();

                await LoadAllFavorLinesForRequest();
                ClearTextboxes();
                MessageBox.Show("The chosen FavorLine has been Successfully Updated",
                    "UPDATE Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: (FavorLineID Does Not exist)" + ex.Message,
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        //Find By FavorLineID
        private async void BTN_FindFavorLineID_Click(object sender, EventArgs e)
        {
            try
            {
                int favorLineIDNeeded = Convert.ToInt32(TXT_FavorLineID.Text);
                IFavorLine favorLineFound = await _favorLineService.GetFavorLine(favorLineIDNeeded);

                if (favorLineFound != null)
                {
                    DGV_FavorLine.Rows.Clear();
                    DGV_FavorLine.Rows.Add(favorLineFound.FavorLineID, favorLineFound.Favor.FavorID, 
                        favorLineFound.Favor.FavorName, favorLineFound.Request.RequestID, favorLineFound.FavorQuantity);

                    await ShowFavorLineDetails(favorLineFound);

                }
                else
                {
                    MessageBox.Show("FavorLine not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FavorLine not found ", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
