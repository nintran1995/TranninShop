﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkEverything.Database;
using WorkEverything.ViewModel.User;

namespace WorkEverything.Controllers
{
    public class UserController : Controller
    {
        DatabaseModel database = new DatabaseModel();
        //
        // GET: /User/
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RequestLogin(UserModel model) 
        {
            //var passWord = database.TB_User.Where(x=>x.UserName == model.userName).FirstOrDefault().PassWord;
            var passWord = database.Database.SqlQuery<TB_User>("SELECT * FROM TB_User WHERE UserName='" + model.userName + "'").FirstOrDefault().PassWord;
            if (passWord == model.passWord)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            { 
                   //asdasdasd
            }
            return View();
        }
	}
}