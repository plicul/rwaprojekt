using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjektRWA.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ProjektRWA.Logic
{
    public class RoleActions
    {
        internal void AddUserAndRole()
        {
            //Models.ArtikalContext context = new ArtikalContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            var roleStore = new RoleStore<IdentityRole>();

            var roleMgr = new RoleManager<IdentityRole>(roleStore);

            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }

            var userMgr = new UserManager<IdentityUser>(new UserStore<IdentityUser>());
            var appUser = new IdentityUser
            {
                UserName = "admin",
            };
            IdUserResult = userMgr.Create(appUser, "admin1");

            if (!userMgr.IsInRole(userMgr.FindByName("admin").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByName("admin").Id, "canEdit");
            }
        }
    }
}