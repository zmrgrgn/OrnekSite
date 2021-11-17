using OrnekSite.Entity;
using OrnekSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrnekSite.Controllers
{
    public class AdminController : Controller
    {
        DataContext db = new DataContext();
        // GET: Admin
        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            StateModel model = new StateModel();
            model.BekleyenSiparisSayısı = db.Orders.Where(i=>i.OrderState==OrderState.Bekleniyor).ToList().Count;
            model.TamamlananSiparisSayısı = db.Orders.Where(i => i.OrderState == OrderState.Tamamlandı).ToList().Count;
            model.PaketlenenSiparisSayısı = db.Orders.Where(i => i.OrderState == OrderState.Paketlendi).ToList().Count;
            model.KargolananSiparisSayısı = db.Orders.Where(i => i.OrderState == OrderState.Kargolandı).ToList().Count;
            model.UrunSayısı = db.Products.Count();
            model.SiparisSayısı = db.Orders.Count();
            return View(model);
        }
        public PartialViewResult BildirimMenusu()
        {
            var bildirim = db.Orders.Where(i => i.OrderState == OrderState.Bekleniyor).ToList();
            return PartialView(bildirim);
        }
        

    }
}