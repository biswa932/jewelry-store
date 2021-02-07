using Jewelry.Constants;
using Jewelry.Services;
using Jewelry.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Jewelry
{
    /// <summary>
    /// class for EstimationScreen form events and methods
    /// </summary>
    public partial class EstimationScreen : Form
    {
        #region Private fields
        /// <summary>
        /// private variable that holds instance of NavigationService
        /// </summary>
        private INavigationService _navigationService;

        /// <summary>
        /// private variable that holds instance of StorageService
        /// </summary>
        private IStorageService _storageService;

        /// <summary>
        /// private variable that holds instance of FileService
        /// </summary>
        private IFileService _fileService;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for EstimationScreen
        /// </summary>
        public EstimationScreen()
        {
            InitializeComponent();
        }
        #endregion

        #region Protected methods
        /// <summary>
        /// OnLoad method for EstimationScreen
        /// Initializes service instances of NavigationService, StorageService & FileService
        /// Loads the value of type of user and discount percentage
        /// </summary>
        /// <param name="e">Event Arguments</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _navigationService = NavigationService.Instance;
            _storageService = StorageService.Instance;
            _fileService = FileService.Instance;
            LoadUserLabel();
            LoadDiscountLabel();
        }
        #endregion

        #region Events
        /// <summary>
        /// Event to handle click on the button to print the calculated total price to a text file
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void btn_PrintToFile_Click(object sender, EventArgs e)
        {
            string content = txt_TotalPrice.Text;
            if (content == "")
                MessageBox.Show("Please calculate before printing", "Please calculate!", MessageBoxButtons.OK);
            else
            {
                if(_fileService.WriteToFile(content))
                {
                    MessageBox.Show("Printed to file.", "Printing complete!", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Printing error occured.", "Printing Error!", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Event to handle click on the button to print the calculated total price to paper
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void btn_PrintToPaper_Click(object sender, EventArgs e)
        {
            if (txt_TotalPrice.Text == "")
                MessageBox.Show("Please calculate before printing.", "Please calculate!", MessageBoxButtons.OK);
            else
            {
                try
                {
                    PrintToPaper();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception occured!", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Event to handle click on the button to print the calculated total price to screen
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void btn_PrintToScreen_Click(object sender, EventArgs e)
        {
            if (txt_TotalPrice.Text == "")
                MessageBox.Show("Please calculate before printing.", "Please calculate!", MessageBoxButtons.OK);
            else
                MessageBox.Show(txt_TotalPrice.Text, "Total price", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Event to handle click on the button to calculate the total price of gold
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal goldPrice = decimal.Parse(txt_GoldPrice.Text);
                decimal weight = decimal.Parse(txt_Weight.Text);
                decimal discount = GetDiscountPercentage();
                decimal toTalPrice = CalculateGoldPrice(goldPrice, weight, discount);
                txt_TotalPrice.Text = toTalPrice.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured while parsing:" + ex.Message);
                MessageBox.Show("Please enter valid values.", "Incorrect input!", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Event to handle click on the button to close the application
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            _navigationService.CloseApplication();
        }

        /// <summary>
        /// Event to allow only decimal values in gold price text box
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void txt_GoldPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event to allow only decimal values in weight text box
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void txt_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Loads the text in user type label based on current logged in user
        /// </summary>
        private void LoadUserLabel()
        {
            UserType userType = _storageService.GetCurrentUserType();
            if (userType == UserType.Regular)
                lbl_UserType.Text = "Normal User";
            else
                lbl_UserType.Text = "Privileged user";
        }

        /// <summary>
        /// Calculates the total price of gold
        /// </summary>
        /// <param name="goldPrice">Price of goold per gram</param>
        /// <param name="weightInGrams">Weight of gold in grams</param>
        /// <param name="discountPercentage">Discount percentage for current user</param>
        /// <returns>Total price of gold</returns>
        private decimal CalculateGoldPrice(decimal goldPrice, decimal weightInGrams, decimal discountPercentage)
        {
            decimal price = goldPrice * weightInGrams;
            decimal discount = (discountPercentage / 100) * goldPrice;
            decimal totalPrice = price - discount;
            return Math.Round(totalPrice, 2);
        }

        /// <summary>
        /// Method to fetch the dicount percentage for current logged in user
        /// </summary>
        /// <returns>Discount percentage for current logged in user</returns>
        private decimal GetDiscountPercentage()
        {
            return _storageService.CurrentUser.DiscountPercentage;
        }

        /// <summary>
        /// Method to make the discount label visible when current logged in user is of privileged type
        /// </summary>
        private void LoadDiscountLabel()
        {
            if (_storageService.GetCurrentUserType() == UserType.Privileged)
            {
                txt_Discount.Visible = true;
                lbl_Discount.Visible = true;
                txt_Discount.Text = _storageService.CurrentUser.DiscountPercentage.ToString() + " %";
            }
            else
            {
                txt_Discount.Visible = false;
                lbl_Discount.Visible = false;
            }

        }

        /// <summary>
        /// Method to print the total price of gold to paper
        /// </summary>
        private void PrintToPaper()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
