﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace Achei.Amigos.Web.Controllers
{
    public class LocationController : ApiController
    {
        // POST /api/location
        public string Post(string value)
        {
            return "Post Ok";
        }

        // GET /api/location
        public string Get()
        {
            return "Get Ok";
        }
    }
}