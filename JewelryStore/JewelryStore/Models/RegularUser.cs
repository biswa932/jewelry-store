namespace Jewelry.Models
{
    /// <summary>
    /// Regular user class
    /// </summary>
    public class RegularUser : User
    {
        /// <summary>
        /// private property to store discount percentage
        /// </summary>
        private decimal _discountPercentage = 0;

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
