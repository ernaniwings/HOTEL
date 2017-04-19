using Hotel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel2.Controllers
{
    public class BaseController : Controller
    {
        public static ApplicationUser CurrentUser
        {
            get
            {
                return VerifyLocalUser();
            }
        }

        private static ApplicationUser VerifyLocalUser()
        {
            Models.HotelDbContext context = new HotelDbContext();

            var email = System.Security.Claims.ClaimsPrincipal.Current.FindFirst("email").Value;
            var firstName = System.Security.Claims.ClaimsPrincipal.Current.FindFirst("given_name").Value;
            var familyName = System.Security.Claims.ClaimsPrincipal.Current.FindFirst("family_name").Value;
            var fullName = firstName + " " + familyName;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                fullName = System.Security.Claims.ClaimsPrincipal.Current.FindFirst("nickname").Value;
            }

            using (context)
            {
                try
                {
                    var existingUser = context.Users.FirstOrDefault(x => x.Email == email);

                    if (existingUser == null)
                    {
                        var addedUser = context.Users.Add(
                            new Models.ApplicationUser
                            {
                                Email = email,
                                Name = fullName
                            }
                        );

                        context.SaveChanges();
                        return addedUser;
                    }
                    else
                    {
                        return existingUser;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}