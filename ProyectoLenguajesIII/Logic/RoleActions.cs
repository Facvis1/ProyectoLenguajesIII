using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ProyectoLenguajesIII.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProyectoLenguajesIII.Logic
{
    internal class RoleActions
    {
        internal void AddUserAndRole()
        {
            // Access the application context and create result variables.
            Models.ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;
            IdentityResult IdRoleResult1;
            IdentityResult IdUserResult1;
            //Cadete
            IdentityResult IdRoleCad;
            IdentityResult IdUserCad;
            IdentityResult IdRoleCad2;
            IdentityResult IdUserCad2;

            // Create a RoleStore object by using the ApplicationDbContext object. 
            // The RoleStore is only allowed to contain IdentityRole objects.
            var roleStore = new RoleStore<IdentityRole>(context);

            // Create a RoleManager object that is only allowed to contain IdentityRole objects.
            // When creating the RoleManager object, you pass in (as a parameter) a new RoleStore object. 
            var roleMgr = new RoleManager<IdentityRole>(roleStore);
            //Cadete
            var roleMgrCad= new RoleManager<IdentityRole>(roleStore);

            // Then, you create the "canEdit" role if it doesn't already exist.
            if (!roleMgr.RoleExists("canEdit"))
            {
                IdRoleResult = roleMgr.Create(new IdentityRole { Name = "canEdit" });
                IdRoleResult1= roleMgr.Create(new IdentityRole { Name = "canEdit" });
            }
            //cadete
            if (!roleMgrCad.RoleExists("canDesp"))
            {
                IdRoleCad = roleMgrCad.Create(new IdentityRole { Name = "canDesp" });
                IdRoleCad2 = roleMgrCad.Create(new IdentityRole { Name = "canDesp" });

            }

            // Create a UserManager object based on the UserStore object and the ApplicationDbContext  
            // object. Note that you can create new objects and use them as parameters in
            // a single line of code, rather than using multiple lines of code, as you did
            // for the RoleManager object.
            var userMgr = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                UserName = "canEditUser@proyectolenguajesIII.com",
                
                Email = "canEditUser@proyectolenguajesIII.com"
            };
            var appUser1 = new ApplicationUser
            {
                UserName = "admin@gmail.com",

                Email = "admin@gmail.com"
            };
            IdUserResult = userMgr.Create(appUser, "123Admin@");
            IdUserResult1 = userMgr.Create(appUser1, "123Admin@");
            //Cadete
            var userMgrCad = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUserCad = new ApplicationUser
            {
                UserName = "cadete1@gmail.com",
                Email = "cadete1@gmail.com"
            };
            var appUserCad2 = new ApplicationUser
            {
                UserName = "cadete2@gmail.com",
                Email = "cadete2@gmail.com"
            };
            IdUserCad = userMgrCad.Create(appUserCad, "123Cad@");
            IdUserCad2 = userMgrCad.Create(appUserCad2, "1234Cad@");

            // If the new "canEdit" user was successfully created, 
            // add the "canEdit" user to the "canEdit" role. 
            if (!userMgr.IsInRole(userMgr.FindByEmail("canEditUser@proyectolenguajesIII.com").Id, "canEdit"))
            {
                IdUserResult = userMgr.AddToRole(userMgr.FindByEmail("canEditUser@proyectolenguajesIII.com").Id, "canEdit");
            }
            if (!userMgr.IsInRole(userMgr.FindByEmail("admin@gmail.com").Id, "canEdit"))
            {
                IdUserResult1= userMgr.AddToRole(userMgr.FindByEmail("admin@gmail.com").Id, "canEdit");
            }
            //Cadete
            if (!userMgrCad.IsInRole(userMgrCad.FindByEmail("cadete1@gmail.com").Id, "canDesp"))
            {
                IdUserCad = userMgrCad.AddToRole(userMgrCad.FindByEmail("cadete1@gmail.com").Id, "canDesp");
            }
            if (!userMgrCad.IsInRole(userMgrCad.FindByEmail("cadete2@gmail.com").Id, "canDesp"))
            {
                IdUserCad = userMgrCad.AddToRole(userMgrCad.FindByEmail("cadete2@gmail.com").Id, "canDesp");
            }
            //if (!userMgr.IsInRole(userMgr.FindByEmail("admin@gmail.com").Id, "canEdit"))
            //{
            //    IdUserResult1 = userMgr.AddToRole(userMgr.FindByEmail("admin@gmail.com").Id, "canEdit");
            //}
        }
    }
}