namespace NorthWindMVC.Models
{
    public class RepositoryEmployee
    {
        //dependency injection
        private NorthwindContext _context;//important if not given then you will get null pointer exception
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }

        public List<Employee> AllEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee FindEmpoyeeById(int id)
        {
            var employeeId = _context.Employees.Find(id);//byId(id)
            return employeeId;
        }
    }
}
