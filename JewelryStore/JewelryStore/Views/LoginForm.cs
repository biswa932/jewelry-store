using Jewelry.Constants;
using Jewelry.Services;
using Jewelry.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Jewelry
{
    /// <summary>
    /// class for LoginForm events and methods
    /// </summary>
    public partial class LoginForm : Form
    {
        #region Private fields
        /// <summary>
        /// private variable that holds instance of LoginService
        /// </summary>
        private ILoginService _loginService;

        /// <summary>
        /// private variable that holds instance of NavigationService
        /// </summary>
        private INavigationService _navigationService;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for LoginForm
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Protected methods
        /// <summary>
        /// OnLoad method for EstimationScreen
        /// Initializes service instances of NavigationService, LoginService
        /// </summary>
        /// <param name="e">Event Arguments</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _loginService = LoginService.Instance;
            _navigationService = NavigationService.Instance;
        }
        #endregion

        #region Events
        /// <summary>
        /// Event to handle click on the button to perform login related actions
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            PerformLoginActions(txt_Username.Text, txt_Password.Text);
        }

        /// <summary>
        /// Event to handle click on the button to clear the Username & Password textboxes
        /// </summary>
        /// <param name="sender">Control that generates this event</param>
        /// <param name="e">Event Arguments</param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_Password.Text = "";
            txt_Username.Text = "";
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Method to login user to the application based on username and password provided
        /// </summary>
        /// <param name="username">Provided Username by user</param>
        /// <param name="password">Provided Password by user</param>
        private void PerformLoginActions(string username, string password)
        {
            LoginStatus status = _loginService.LoginUser(username, password);
            if(status == LoginStatus.Successful)
            {
                _navigationService.NavigateToPage(this, new EstimationScreen());
            }
            else if(status == LoginStatus.UserNotFound)
            {
                MessageBox.Show("User not found.", "Not found!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please ensure data Is present.", "Error!", MessageBoxButtons.OK);
            }
        }

        #endregion
    }
}
