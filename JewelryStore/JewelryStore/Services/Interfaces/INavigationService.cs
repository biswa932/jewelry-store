using System.Windows.Forms;

namespace Jewelry.Services.Interfaces
{
    /// <summary>
    /// Interface for for navigation related methods
    /// </summary>
    public interface INavigationService
    {
        /// <summary>
        /// Method to navigate from one page to another
        /// </summary>
        /// <param name="navigateFrom">Current page</param>
        /// <param name="navigateTo">The page user wants to navigate to</param>
        void NavigateToPage(Form navigateFrom, Form navigateTo);

        /// <summary>
        /// Method to exit user from the application
        /// </summary>
        void CloseApplication();
    }
}
