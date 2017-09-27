using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using BillboardApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillboardApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        ApplicationDbContext context;
        public UsersController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var list = context.Users.ToList();
            return View(list);
        }


        public ActionResult GetRoles(string UserName)
        {

            if (!string.IsNullOrWhiteSpace(UserName))
            {
                ApplicationUser user = context.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
                //var account = new AccountController();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                ViewBag.RolesForThisUser = UserManager.GetRoles(user.Id);

                // Prepopulate roles for the view dropdown
                var list = context.Roles.OrderBy(r => r.Name).ToList().Select(rr => new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
                ViewBag.Roles = list;

            }

            return View("GetRoles");


        }

        public ActionResult AddRole(string UserName)
        {
            //Get the user
            ApplicationUser user = context.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

            //Get the object to the view
            ViewBag.ThisUser = user.UserName;

            //pass the list of roles as a viewbag property to the view

            var list = context.Roles.OrderBy(r => r.Name).ToList().Select(rr => new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
            ViewBag.Roles = list;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddRole(string UserName, string RoleName)
        {
            ApplicationUser user = context.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            //var account = new AccountController();

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            UserManager.AddToRole(user.Id, RoleName);

            //Get all roles for this user even the just added
            ViewBag.RolesForThisUser = UserManager.GetRoles(user.Id);

            ViewBag.ResultMessage = "Role '" + RoleName + "' added successfully to user '" + UserName + "' !";

            return View("GetRoles");
        }


        public ActionResult ShowRolesToDelete(string UserName)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                ApplicationUser user = context.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
                //var account = new AccountController();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                ViewBag.RolesForThisUser = UserManager.GetRoles(user.Id);

                ViewBag.UserName = UserName;

            }
            return View();
        }

        //[Route("Users/DeleteRole/{UserName}/{RoleName}")]
        public ActionResult DeleteRole(string UserName)
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                ApplicationUser user = context.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
                //var account = new AccountController();
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                ViewBag.RolesForThisUser = UserManager.GetRoles(user.Id);

                // prepopulat roles for the view dropdown
                var list = context.Roles.OrderBy(r => r.Name).ToList().Select(rr => new SelectListItem { Value = rr.Name.ToString(), Text = rr.Name }).ToList();
                ViewBag.Roles = list;

                ViewBag.UserName = UserName;

            }
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteRoleConfirmed(string UserName, string RoleName)
        {
            //var account = new AccountController();
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            ApplicationUser user = context.Users.Where(u => u.UserName.Equals(UserName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

            if (UserManager.IsInRole(user.Id, RoleName))
            {
                UserManager.RemoveFromRole(user.Id, RoleName);
                ViewBag.ResultMessage = "Role" + RoleName + " removed from this " + UserName + "user successfully !";
            }
            else
            {
                ViewBag.ResultMessage = "This user(" + UserName + ") doesn't belong to selected role(" + RoleName + ")";
            }
            ViewBag.RolesForThisUser = UserManager.GetRoles(user.Id);

            return View("GetRoles");
        }

        // GET: userscontroller
        public ActionResult Index2()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;
                ViewBag.Name = user.Name;

                ViewBag.displayMenu = "No";

                if (isAdminUser())
                {
                    ViewBag.displayMenu = "Yes";
                }
                return View();
            }
            else
            {
                ViewBag.Name = "Not Logged IN";
            }
            return View();
        }

        public Boolean isAdminUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity;

                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                if (s[0].ToString() == "Admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// Error handler
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            //Logging the Exception
            filterContext.ExceptionHandled = true;


            var Result = this.View("Error", new HandleErrorInfo(exception,
                filterContext.RouteData.Values["controller"].ToString(),
                filterContext.RouteData.Values["action"].ToString()));

            filterContext.Result = Result;

        }
    }
}