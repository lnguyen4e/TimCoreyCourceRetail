using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;

namespace TRM_DataManager.Controllers
{
    public class SaleController : ApiController
    {[Authorize]
        public void Post(SaleModel sale)
        {
            SaleData data = new SaleData();
            string userid = RequestContext.Principal.Identity.GetUserId();
            data.SaveSale(sale, userid);
        }
        //public List<ProductModel> Get()
        //{
        //    ProductData data = new ProductData();
        //    return data.GetProducts();

        //}
    }
}
