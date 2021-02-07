using Jewelry.Constants;
using Jewelry.Services.Interfaces;
using System;

namespace Jewelry.Services
{
    /// <summary>
    /// Singleton class for login related methods
    /// </summary>
    public class LoginService: ILoginService
    {
        /// <summary>
        /// Private variable that holds StorageService instance
        /// </summary>
        private IStorageService _storageService;

        /// <summary>
		/// Private singleton instance variable
		/// </summary>
        private static readonly Lazy<LoginService> _instance = new Lazy<LoginService>(() => new LoginService());

        /// <summary>
        /// Public property that returns singleton instance
        /// </summary>
        public static LoginService Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        /// <summary>
		/// Private constructor for singleton class
        /// Initializes StorageService instance
		/// </summary>
        private LoginService()
        {
            _storageService = StorageService.Instance;
        }

        ///<inheritdoc cref="ILoginService"/>
        public LoginStatus LoginUser(string username, string password)
        {
            if(_storageService.LoadUsers())
            {
                if (_storageService.IsUserPresent(username, password))
                {
                    _storageService.StoreUser(username, password);
                    return LoginStatus.Successful;
                }
                return LoginStatus.UserNotFound;
            }
            return LoginStatus.Error;
            
        }
    }
}
