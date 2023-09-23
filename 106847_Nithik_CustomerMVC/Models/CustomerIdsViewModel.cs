using Microsoft.AspNetCore.Mvc.Rendering;
namespace NorthWindMVC.Models
{
    public class CustomerIdsViewModel
    {
        //private RepositoryCustomer _repositoryCustomers;
        public string Id { get; set; }
        public readonly List<SelectListItem> CustomerIdSelectedList;
        public CustomerIdsViewModel(List<string> customerIds/*, RepositoryCustomer repository*/)
        {
            //_repositoryCustomers = repository;
            CustomerIdSelectedList = new List<SelectListItem>();
            foreach (var ids in customerIds)
            {
                //Customer name = _repositoryCustomers.FindCustomerByCustomerId(ids);
                CustomerIdSelectedList.Add(new SelectListItem { Text = $"{ids/*name.ContactName*/}", Value = $"{ids}" });
            }
        }
    }
}
