using System.Collections.Generic;

namespace ExpansionOfLikqkit.ViewModels
{
    public class EmployeesViewModel
    {
        public IEnumerable<Employees> EmployeesDataList { get; set; }

        public EmployeesSearchModel SearchList { get; set; }
    }

    public class EmployeesSearchModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Notes { get; set; }
    }
}