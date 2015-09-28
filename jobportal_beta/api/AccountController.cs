using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using jobportal_beta.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Web;
using System.Web.Http.Description;
using Newtonsoft.Json;

namespace jobportal_beta.api
{
    public class AccountController : ApiController
    {

        [Route("createUser/{userDetails}")]
        [HttpGet]
        public IdentityUser createUser(string userDetails)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);

            var user = new IdentityUser() { UserName = "laks", Email = "lakshman.pilaka@gmail.com", PhoneNumber = "7032906292" };
            IdentityResult result = manager.Create(user, "pass123");

            return user;
        }
        
        [Route("checkAuth/{userId}")]
        [HttpGet]
         public dynamic authenticateUser(string userId, string password)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var user = userManager.Find(userId, password);

            return user;

//if (user != null)
            //{

            //    //var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            //    //var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
            //    //authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
            //    //Response.Redirect("~/loggingin.aspx");
            //}
            //else
            //{
            //    return "{//"auth//" : false}";

            //    //Response.Redirect("~/Login.aspx?credentials=wrong");
            //}
        }
    }
}
