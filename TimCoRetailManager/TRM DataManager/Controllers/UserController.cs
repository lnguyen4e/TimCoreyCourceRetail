﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;

namespace TRM_DataManager.Controllers
{
    [Authorize]
    
    public class UserController : ApiController
    {
        public UsereModel GetById()
        {
            string id = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();
        
            return data.GetUserById(id).First();
        }


    }
}
