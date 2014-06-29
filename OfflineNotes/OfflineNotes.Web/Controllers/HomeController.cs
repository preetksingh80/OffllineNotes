using System.Web;
using System.Web.Mvc;

namespace OfflineNotes.Web.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            return View();
        }

        public ActionResult Manifest()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.ContentType = "test/cache-manifest";
            return View();
        }
    }
}