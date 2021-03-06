﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcmusicstore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Store Index";
        }

        //GET: /Store/Browse
        public string Browse(string genre) //passes a string "genre" to the Browse action method 
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return message;
        }

        //GET: /Store/Details
        public string Details(int id)
        {
            string message = HttpUtility.HtmlEncode("Store.Details, ID = " + id);
            return message; 
        }
    }
}