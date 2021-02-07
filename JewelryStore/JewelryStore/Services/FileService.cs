using Jewelry.Models;
using Jewelry.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using JewelryStore.Constants;

namespace Jewelry.Services
{
	/// <summary>
	/// Singleton class containing methods related to writing to files
	/// </summary>
    public sealed class FileService:IFileService
    {
		/// <summary>
		/// Private singleton instance variable
		/// </summary>
		private static readonly Lazy<FileService> _instance = new Lazy<FileService>(() => new FileService());
		
		/// <summary>
		/// Public property that returns singleton instance
		/// </summary>
		public static FileService Instance
		{
			get
			{
				return _instance.Value;
			}
		}

		/// <summary>
		/// Private constructor for singleton class
		/// </summary>
		private FileService() { }

		///<inheritdoc cref="IFileService"/>
		public bool WriteToFile(string content)
        {
			string fileName = StringConstants.OutputTextFileName;
			try
			{
				using (StreamWriter writer = new StreamWriter(fileName))
				{
					writer.Write(content);
				}
				return true;
			}
			catch (Exception exp)
			{
				Console.Write(exp.Message);
				return false;
			}
		}

		///<inheritdoc cref="IFileService"/>
		public bool LoadFromXMLFile(List<RegularUser> regularUsers, List<PrivilegedUser> privilegedUsers)
        {
			try
            {
				foreach (XElement privilegedUserElement in XElement.Load(StringConstants.InputXMLFilename).Elements(StringConstants.PrivilegedUserTypeElement))
				{
					XElement userNameElement = privilegedUserElement.Elements(StringConstants.UsernameElement).FirstOrDefault();
					XElement passwordElement = privilegedUserElement.Elements(StringConstants.PasswordElement).FirstOrDefault();
					PrivilegedUser privilegedUser = new PrivilegedUser()
					{
						Username = userNameElement.Attribute(StringConstants.ValueAttribute).Value,
						Password = passwordElement.Attribute(StringConstants.ValueAttribute).Value
					};
					privilegedUsers.Add(privilegedUser);
				}
				foreach (XElement regularUserElement in XElement.Load(StringConstants.InputXMLFilename).Elements(StringConstants.RegularUserTypeElement))
				{
					XElement userNameElement = regularUserElement.Elements(StringConstants.UsernameElement).FirstOrDefault();
					XElement passwordElement = regularUserElement.Elements(StringConstants.PasswordElement).FirstOrDefault();
					RegularUser regularUser = new RegularUser()
					{
						Username = userNameElement.Attribute(StringConstants.ValueAttribute).Value,
						Password = passwordElement.Attribute(StringConstants.ValueAttribute).Value
					};
					regularUsers.Add(regularUser);
				}
                return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error occured while fetching data:" + ex);
				return false;
			}
			
		}


	}
}
