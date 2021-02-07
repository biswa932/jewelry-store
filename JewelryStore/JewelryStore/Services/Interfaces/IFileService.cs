using Jewelry.Models;
using System.Collections.Generic;

namespace Jewelry.Services.Interfaces
{
    /// <summary>
    /// Interface containing methods related to writing to files
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Method to write data to text file
        /// </summary>
        /// <param name="content">string data to be written to the text file</param>
        /// <returns>TRUE if writing to file is successful, FALSE otherwise</returns>
        bool WriteToFile(string content);

        /// <summary>
        /// Method to load users from xml file
        /// </summary>
        /// <param name="regularUsers">List of regular users in which regular user data will be loaded</param>
        /// <param name="privilegedUsers">List of privileged users in which privileged user data will be loaded</param>
        /// <returns>TRUE if loading of user data is successful, FALSE otherwise</returns>
        bool LoadFromXMLFile(List<RegularUser> regularUsers, List<PrivilegedUser> privilegedUsers);
    }
}
