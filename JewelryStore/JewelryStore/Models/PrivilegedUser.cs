namespace Jewelry.Models
{
    /// <summary>
    /// Privileged user class
    /// </summary>
    public class PrivilegedUser: User
    {
        /// <summary>
        /// private property to store discount percentage
        /// </summary>
        private decimal _discountPercentage = 2;

        /// <summary>
        /// Public readonly property that returns discount percentage
        /// </summary>
        public override decimal DiscountPercentage 
        { 
            get 
            { 
                return _discountPercentage; 
            }
        }

    }
}
