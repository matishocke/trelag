using Abstraction.IModels;
using Abstraction.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Login.F3UserChildForms
{
    public partial class CartForm : Form
    {
        private readonly IRequestService _requestService;
        private string _username;
        private readonly ICustomerService _customerService;
        private Dictionary<IFavor, int> cartItems;
        private readonly IFavorLineService _favorLineService;  //ii


        Dictionary<IFavor, ICustomer> userAcceptedItems;

        

        public CartForm(Dictionary<IFavor, int> dictionary, IRequestService requestService,
            string username, ICustomerService customerService, IFavorLineService favorLineService)  //dictionary is carrying data
        {
            InitializeComponent();
            this.cartItems = dictionary;
            _requestService = requestService;
            _username = username;
            _customerService = customerService;

            userAcceptedItems = new Dictionary<IFavor, ICustomer>();


            _favorLineService = favorLineService; //ii
        }


        private void CartForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView(); //Show information and total price for each favor and its quantity
            
            LBL_ShowTotalPriceBeforeDicsount.Text = Convert.ToString(CalculateTotalPrice());

        }







        /// <summary>
        /// Input data into Our DATAGRIDVIEW
        /// </summary>
        private void InitializeDataGridView()
        {
            DGV_Cart.Columns.Add("FavorName", "Favor Name");  //the first parameters is just a name for culumn
            DGV_Cart.Columns.Add("UnitPrice", "Unit Price");
            DGV_Cart.Columns.Add("Quantity", "Quantity");
            DGV_Cart.Columns.Add("PriceForQuantity", "Price For Quantity");
            DGV_Cart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Now we Populate our Datagridview
            foreach (var item in cartItems)
            {
                double totalPriceForFavorAndItsQuantity = item.Key.UnitPrice * item.Value;

                //Input data into datagridview
                DGV_Cart.Rows.Add(item.Key.FavorName, item.Key.UnitPrice, item.Value, totalPriceForFavorAndItsQuantity);
            }
        }





        //Buttom to Delete the chosen in DATAGRIDVIEW and Refresh the Price
        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Cart.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DGV_Cart.SelectedRows)
                {
                    DGV_Cart.Rows.Remove(row);
                }

                LBL_ShowTotalPriceBeforeDicsount.Text = Convert.ToString(CalculateTotalPrice());
                UpdateTotalPrice();
            }
        }





        /// <summary>
        /// Method to Calculate the price by taking data from DATAGRIDVIEW
        /// </summary>
        /// <returns></returns>
        private double CalculateTotalPrice()
        {
            double totalPrice = 0;

            foreach (DataGridViewRow row in DGV_Cart.Rows)
            {
                if (row.Cells["PriceForQuantity"].Value != null &&
                    double.TryParse(row.Cells["PriceForQuantity"].Value.ToString(), out double priceForQuantity))
                {
                    totalPrice = totalPrice + priceForQuantity;
                }
            }
            return totalPrice;
        }









        private void UpdateTotalPrice()
        {
            double totalPrice = Convert.ToDouble(LBL_ShowTotalPriceBeforeDicsount.Text);
            double DiscountInProcent = 0;

            if (checkBox_Supply.Checked == true)
            {
                totalPrice = totalPrice * 0.80;
                DiscountInProcent = DiscountInProcent + 20;
            }

            if (checkBox_Pets.Checked == true)
            {
                totalPrice = totalPrice * 0.95;
                DiscountInProcent = DiscountInProcent + 5;
            }

            LBL_ShowProcent.Text = DiscountInProcent.ToString(); //Show Discount in procent
            LBL_ShowTotalPriceAfterDiscount.Text = totalPrice.ToString();  //Show price after discount


        }



        //Change the totalPrice by CheckedChanged Alarm (nothing changes here)
        private void checkBox_Alarm_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox_Supply_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
        private void checkBox_Pets_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }




        private async void BTN_Bestil_Click(object sender, EventArgs e)
        {
            //try
            //{
            ICustomer currentCustomer = _customerService.GetCustomer(_username);



            bool alarmChecked = checkBox_Alarm.Checked;

            bool supplyChecked = false;            //SUPPLY CHECKED 
            double supplyDiscount = 0;
            if (checkBox_Supply.Checked == true)
            {
                supplyChecked = true;
                supplyDiscount = 0.2;     //20% DISCOUNT FOR SELF SUPPLY
            }



            bool petsChecked = false;
            double petsDiscount = 0;
            if (checkBox_Pets.Checked == true)
            {
                petsChecked = true;
                petsDiscount = 0.05;
            }



            double discountGottenFromLBL = Convert.ToDouble(LBL_ShowProcent.Text);




            if (currentCustomer != null)
            {
                int requestId = await _requestService.CreateRequest(currentCustomer, DateTime.Now,
                    alarmChecked, supplyChecked, petsChecked, discountGottenFromLBL);


                foreach (var item in cartItems)
                {
                    await _favorLineService.CreateFavorLine(item.Key, requestId, item.Value, item.Key);  //item.Key==Favor && item.Value==Quantity
                }





                //Receipt
                ICustomer customerForImage = _customerService.GetCustomer(_username);
                double totalPriceBeforeDiscount = Convert.ToDouble(LBL_ShowTotalPriceBeforeDicsount.Text);
                double totalPriceAfterDiscount = Convert.ToDouble(LBL_ShowTotalPriceAfterDiscount.Text);
                double discount = Convert.ToDouble(LBL_ShowProcent.Text);
                DateTime dateCreated = DateTime.Now;


                string receiptContent = GenerateReceiptContent(totalPriceBeforeDiscount, totalPriceAfterDiscount,
                    discount, dateCreated, cartItems, customerForImage); //for txt faktur
                string filePath = "Receipt " + "reqID" + requestId.ToString() + "CID" + currentCustomer.CustomerId + ".txt";
                System.IO.File.WriteAllText(filePath, receiptContent);




                MessageBox.Show("New Request has been Successfully Created",
                    "CREATED Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The Customer can NOT be found",
                    "CREATE Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //    MessageBox.Show("Failed to create request.");
            //}

        }




        private string GenerateReceiptContent(double totalPriceBeforeDiscount, double totalPriceAfterDiscount, double discount, DateTime dateCreated, Dictionary<IFavor, int> cartItems, ICustomer customer)
        {
            StringBuilder buildStringComesIntoFaktur = new StringBuilder();
            buildStringComesIntoFaktur.AppendLine($"Customer Username : {customer.Username}");
            buildStringComesIntoFaktur.AppendLine($"Customer FullName : {customer.Firstname} {customer.Lastname}");
            buildStringComesIntoFaktur.AppendLine($"Date Created : {dateCreated}");

            foreach (var item in cartItems)
            {
                string favorName = item.Key.FavorName;
                double unitPrice = item.Key.UnitPrice;
                int quantity = item.Value;
                double priceForManyQuantity = unitPrice * quantity;

                buildStringComesIntoFaktur.AppendLine($"FavorName : {favorName}");
                buildStringComesIntoFaktur.AppendLine($"UnitPrice: {unitPrice} - Quantity: " +
                    $"{quantity} - Price For This Quantity: {priceForManyQuantity}");
            }

            buildStringComesIntoFaktur.AppendLine($"TotalPrice : {totalPriceBeforeDiscount}");
            buildStringComesIntoFaktur.AppendLine($"Discount : -{discount}%");
            buildStringComesIntoFaktur.AppendLine($"Total Price After Discount : {totalPriceAfterDiscount}");

            return buildStringComesIntoFaktur.ToString();
        }







        //BACK BUTTON
        private void BTN_GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
