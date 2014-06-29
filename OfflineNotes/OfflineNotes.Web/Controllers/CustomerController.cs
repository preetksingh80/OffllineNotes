using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OfflineNotes.Core;
using OfflineNotes.Web.ViewModels;

namespace OfflineNotes.Web.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ActionResult Save(CustomerInputModel model)
        {
            var service = new InMemoryNotesService();

            service.Save(model.Id, model.Name, model.Note);

            var customerViewModel = new CustomerViewModel();
            return Json(customerViewModel);
        }
	}
}