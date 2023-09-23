using Microsoft.EntityFrameworkCore;

namespace NorthWindMVC.Models
{
    public class RepositoryCustomer
    {
        private NorthwindContext _context;
        public RepositoryCustomer(NorthwindContext context)
        {
            _context = context;
        }
        public List<string> GetAllCustomerByID()
        {
            List<string> allcustomerid = (from c in _context.Customers
                                    select c.CustomerId).ToList();
            return allcustomerid;
        }
        public Customer FindCustomerByCustomerId(string customerID)
        {
            Customer customers = _context.Customers.Find(customerID);
            return customers;
        }
        public List<Order> GetCustomerOrders(string customerID)
            {
            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer customer = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == customerID);
            return customer.Orders.ToList();
        }
    }
}
