using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_PS3.Models.User;
using ASP_PS3.Models.ViewModel.User;
using ASP_PS3.Models.ViewModel.User.Static;

namespace ASP_PS3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            UserVM userVM = new UserVM((List<UserDB>)Session["Users"]);
            if (userVM.Users != null)
            {
                return View(userVM);
            }
            return View(new UserVM(new List<UserDB>()));
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            DetailsVM detailsVM = new DetailsVM((List<UserDB>)Session["Users"], id);
            return View(detailsVM);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserFrame user)
        {
            try
            {
                Tools tools = new Tools();
                Session["Users"] = tools.SendUserToList((List<UserDB>)Session["Users"], user);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            EditVM editVM = new EditVM((List<UserDB>)Session["Users"], id);
            return View(editVM);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UserFrame user)
        {
            try
            {
                Tools tools = new Tools();
                Session["Users"] = tools.ReplaceUserInList((List<UserDB>)Session["Users"], user, id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            DeleteVM deleteVM = new DeleteVM((List<UserDB>)Session["Users"], id);
            return View(deleteVM);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, UserFrame User)
        {
            try
            {
                Tools tools = new Tools();
                Session["Users"] = tools.RemoveUserFromList((List<UserDB>)Session["Users"], id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
