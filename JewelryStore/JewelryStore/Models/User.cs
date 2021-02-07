namespace Jewelry.Models
{
    /// <summary>
    /// Abstract class for all types of user
    /// </summary>
    public abstract class User
    {
        /// <summary>
        /// Property to store username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Property to store password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Abstract property to store discount percentage for each user type
        /// </summary>
        public abstract decimal DiscountPercentage { get; }
    }
}
