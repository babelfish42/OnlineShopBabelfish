using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Online_Shop_Babelfish.Models;

namespace Online_Shop_Babelfish.Controllers
{
    public class StoreController : Controller
    {
        DatabaseOnlineShopEntities storeDB = new DatabaseOnlineShopEntities();

        //
        // GET: /Store/
        public ActionResult Index()
        {
            var beanBagTypes = this.storeDB.BeanBagTypes;
            return this.View(beanBagTypes);
        }

        //
        // GET: /Store/Browse
        public ActionResult Browse(string beanBagType)
        {
            return View();
            /*var beanBagTypeModel = new BeanBagType
            {
                Name = beanBagType,
                BeanBag = this.storeDB.BeanBags.ToList()
            };
            return this.View(beanBagTypeModel);
             */
        }
        

        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            //var beanBag = storeDB.BeanBags.Find(id);
            //return View(beanBag);
            return View();
        }

    }
}
