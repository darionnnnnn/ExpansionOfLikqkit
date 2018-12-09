using ExpansionOfLikqkit.Infrastructure;
using ExpansionOfLikqkit.ViewModels;
using LinqKit;
using System.Linq;
using System.Web.Mvc;

namespace ExpansionOfLikqkit.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            NorthwindEntities db = new NorthwindEntities();
            EmployeesViewModel empVM = new EmployeesViewModel();

            empVM.EmployeesDataList = db.Employees;

            return View(empVM);
        }

        [HttpPost]
        public ActionResult Index(EmployeesViewModel instance)
        {
            NorthwindEntities db = new NorthwindEntities();

            //var pred = PredicateBuilder.New<Employees>(true);

            //if (instance.SearchList != null)
            //{
            //    if (!string.IsNullOrWhiteSpace(instance.SearchList.LastName))
            //    {
            //        pred = pred.And(p => p.LastName.Contains(instance.SearchList.LastName.Trim()));
            //    }
            //    if (!string.IsNullOrWhiteSpace(instance.SearchList.FirstName))
            //    {
            //        pred = pred.And(p => p.FirstName.Contains(instance.SearchList.FirstName.Trim()));
            //    }
            //    if (!string.IsNullOrWhiteSpace(instance.SearchList.Title))
            //    {
            //        pred = pred.And(p => p.Title.Contains(instance.SearchList.Title.Trim()));
            //    }
            //    if (!string.IsNullOrWhiteSpace(instance.SearchList.Address))
            //    {
            //        pred = pred.And(p => p.Address.Contains(instance.SearchList.Address.Trim()));
            //    }
            //    if (!string.IsNullOrWhiteSpace(instance.SearchList.City))
            //    {
            //        pred = pred.And(p => p.City.Contains(instance.SearchList.City.Trim()));
            //    }
            //    if (!string.IsNullOrWhiteSpace(instance.SearchList.Notes))
            //    {
            //        pred = pred.And(p => p.Notes.Contains(instance.SearchList.Notes.Trim()));
            //    }
            //}

            var pred = LinqkitHelper.GetPredicate<Employees, EmployeesSearchModel>(instance.SearchList);

            instance.EmployeesDataList = db.Employees.Where(pred);

            return View(instance);
        }
    }
}