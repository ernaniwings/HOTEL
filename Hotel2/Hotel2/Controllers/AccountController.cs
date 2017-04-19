﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IdentityModel.Services;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        public ActionResult Login(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !this.Url.IsLocalUrl(returnUrl))
            {
                returnUrl = "/";
            }

            // you can use this for the 'authParams.state' parameter
            // in Lock, to provide a return URL after the authentication flow.
            ViewBag.State = "ru=" + HttpUtility.UrlEncode(returnUrl);

            return this.View();
        }

        public RedirectResult Logout()
        {
            // Clear the session cookie
            FederatedAuthentication.SessionAuthenticationModule.SignOut();

            // Redirect to Auth0's logout endpoint
            var returnTo = Url.Action("Index", "Home", null, protocol: Request.Url.Scheme);
            return this.Redirect(
              string.Format(CultureInfo.InvariantCulture,
                "https://{0}/v2/logout?returnTo={1}",
                ConfigurationManager.AppSettings["auth0:Domain"],
                this.Server.UrlEncode(returnTo)));
        }
    }
}