using Jewelry.Constants;
using Jewelry.Models;
using System.Collections.Generic;

namespace Jewelry.Services.Interfaces
{
    /// <summary>
    /// Interface for methods related to reading & storing data from xml file
    /// </summary>
    public interface IStorageService
    {
        /// <summary>
        /// Property that contains list of privileged users fetched from xml file
        /// </summary>
        List<PrivilegedUser> PrivilegedUsers { get; set; }

        /// <summary>
        /// Property that contains list of regular users fetched from xml file
        /// </summary>
        List<RegularUser> RegularUsers { get; set; }

        /// <summary>
        /// Property that contains the current user details
        /// </summary>
        User CurrentUser { get; set; }

        /// <summary>
        /// Method to check whether an user with the provided credentials exists
        /// </summary>
        /// <param name="username">Username provided</param>
        /// <param name="password">Password provided</param>
        /// <returns>TRUE if user is present,FALSE otherwise</returns>
        bool IsUserPresent(string username, string password);

        /// <summary>
        /// Method to load users from xml file
        /// </summary>
        /// <returns>TRUE if loading of user data is successful, FALSE otherwise</returns>
        bool LoadUsers();

        /// <summary>
        /// Method to store user as current user with provided credentials fetched from xml file
        /// </summary>
        /// <param name="username">Username provided</param>
        /// <param name="password">Password provided</param>
        void StoreUser(string username, string password);

        /// <summary>
        /// Method to fetch the user type for current logged in user
        /// </summary>
        /// <returns>"Privileged" if user is of privileged type, "Regular" otherwise</returns>
        UserType GetCurrentUserType();
    }
}
