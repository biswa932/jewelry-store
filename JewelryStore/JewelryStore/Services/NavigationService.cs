using Jewelry.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace Jewelry.Services
{
    /// <summary>
    /// Singleton class for navigation related methods
    /// </summary>
    public class NavigationService: INavigationService
    {
        /// <summary>
		/// private singleton instance variable
		/// </summary>
        private static readonly Lazy<NavigationService> _instance = new Lazy<NavigationService>(() => new NavigationService());
        
        /// <summary>
		/// public property that returns singleton instance
		/// </summary>
        public static NavigationService Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        /// <summary>
		/// private constructor for singleton class
		/// </summary>
        private NavigationService() { }

        ///<inheritdoc cref="INavigationService"/>
        public void NavigateToPage(Form navigateFrom, Form navigateTo)
        {
            navigateTo.Show();
            navigateFrom.Hide();
        }

        ///<inheritdoc cref="INavigationService"/>
        public void CloseApplication()
        {
            Application.Exit();
        }
    }
}
