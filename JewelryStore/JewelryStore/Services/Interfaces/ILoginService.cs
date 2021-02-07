using Jewelry.Constants;

namespace Jewelry.Services.Interfaces
{
    /// <summary>
    /// Interface for login related methods
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// Method to login user to the application
        /// </summary>
        /// <param name="username">username provided by user</param>
        /// <param name="password">password provided by user</param>
        /// <returns>Login status(Successful/Error/UserNotFound)</returns>
        LoginStatus LoginUser(string username, string password);
    }
}
