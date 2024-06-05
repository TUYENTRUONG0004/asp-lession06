using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdtlession06CF.Models;

namespace Tdtlession06CF.Controllers
{
public class TdtCategoriesController : Controller
    {
        private static TdtBookStore tdtDb;
        public TdtCategoriesController()
        {
            tdtDb = new TdtBookStore();
        }
        // GET: TdtCategories
        public ActionResult TdtIndex()
        {
            /*
            * Khởi tạo DbContext:
            * EF sẽ tìm thông tin kết nối trong file machine.config của .NET Framework trên máy
            * và sau đó tạo csdl
            */
            TdtBookStore tdtDb = new TdtBookStore();
            var tdtCategories = tdtDb.TdtCategories.ToList();
            return View(tdtCategories);
        }
        [HttpPost]
        public ActionResult TdtCreate(TdtCategory TdtCategory)
        {
            tdtDb.TdtCategories.Add(TdtCategory);
            tdtDb.SaveChanges();
            return RedirectToAction("TdtIndex");
        }
    }

}