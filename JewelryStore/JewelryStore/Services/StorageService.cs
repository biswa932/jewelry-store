using Jewelry.Constants;
using Jewelry.Models;
using Jewelry.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jewelry.Services
{
    /// <summary>
    /// Singleton class for methods related to reading & storing data from xml file
    /// </summary>
    public sealed class StorageService: IStorageService
    {
        /// <summary>
        /// variable to hold file service instance
        /// </summary>
        private IFileService _fileService;

        /// <summary>
		/// private singleton instance variable
		/// </summary>
        private static readonly Lazy<StorageService> _instance = new Lazy<StorageService>(() => new StorageService());

        /// <summary>
        /// public property that returns singleton instance
        /// </summary>
        public static StorageService Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        ///<inheritdoc cref="IStorageService"/>
        public List<PrivilegedUser> PrivilegedUsers { get; set; }

        ///<inheritdoc cref="IStorageService"/>
        public List<RegularUser> RegularUsers { get; set; }

        ///<inheritdoc cref="IStorageService"/>
        public User CurrentUser { get; set; }

        /// <summary>
		/// private constructor for singleton class
		/// </summary>
        private StorageService()
        {
            PrivilegedUsers = new List<PrivilegedUser>();
            RegularUsers = new List<RegularUser>();
            _fileService = FileService.Instance;
        }

        ///<inheritdoc cref="IStorageService"/>
        public bool IsUserPresent(string username, string password)
        {
            if(PrivilegedUsers.Exists(x=>x.Username == username && x.Password == password))
            {
                return true;
            }
            else if(RegularUsers.Exists(x => x.Username == username && x.Password == password))
            {
                return true;
            }
            else
                return false;
        }

        ///<inheritdoc cref="IStorageService"/>
        public void StoreUser(string username, string password)
        {
            if(IsUserPresent(username,password))
            {
                if (PrivilegedUsers.Exists(x => x.Username == username && x.Password == password))
                {
                    PrivilegedUser user = PrivilegedUsers.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                    CurrentUser = user;
                }
                else
                {
                    RegularUser user = RegularUsers.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                    CurrentUser = user;
                }
            }
        }

        ///<inheritdoc cref="IStorageService"/>
        public bool LoadUsers()
        {
            return _fileService.LoadFromXMLFile(RegularUsers, PrivilegedUsers);
        }

        ///<inheritdoc cref="IStorageService"/>
        public UserType GetCurrentUserType()
        {
            if (CurrentUser.GetType() == typeof(RegularUser))
                return UserType.Regular;
            return UserType.Privileged;
        }
    }
}
