using Domain;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models.User;

namespace Web.Controllers
{
    public class UserController : Controller
    {

        private IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public ActionResult Index()
        {
            return View(userRepository.Get());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            User user = new User();

            user.Name = model.Name;
            user.Email = model.Email;
            user.Username = model.Username;
            user.Password = model.Password;

            userRepository.Save(user);

            return View("User.Index");
        }
    }
}