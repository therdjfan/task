using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCwithADO.Models;

namespace MVCwithADO.Models
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public ActionResult Index()
        {
            CRUDModel model = new CRUDModel();
            DataTable dt = model.GetAllProduct();
            return View("Home",dt);
        }
        //
        public ActionResult Insert()
        {
            return View("Create");
        }
        //insert
        public ActionResult InsertRecord(FormCollection frm, string action)
        {
            if (action == "Submit")
            {
                CRUDModel model = new CRUDModel();
                int prodid= Convert.ToInt32(frm["prodID"]);
                string prodname = frm["prodName"];
                int catid = Convert.ToInt32(frm["catID"]);
                string catname= frm["catName"];
               
                int status = model.InsertProduct(prodid,prodname, catid, catname);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        //edit
        public ActionResult Edit(int ProductID)
        {
            CRUDModel model = new CRUDModel();
            DataTable dt = model.GetProductByID(ProductID);
            return View("Edit", dt);
        }
        //update
        public ActionResult UpdateRecord(FormCollection frm, string action)
        {
            if (action == "Submit")
            {
                CRUDModel model = new CRUDModel();
               
                string proname = frm["prodName"];
                int catid = Convert.ToInt32(frm["catID"]);
                string catname = frm["catName"];
                
                int status = model.UpdateProduct( proname, catid, catname);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        //delete
        public ActionResult Delete(int ProductID)
        {
            CRUDModel model = new CRUDModel();
            model.DeleteProduct(ProductID);
            return RedirectToAction("Index");
        }

    }
}