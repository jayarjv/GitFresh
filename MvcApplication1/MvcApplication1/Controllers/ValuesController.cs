﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //FirstChange JB1
        //FirstChange by new person RB1
        //Change by new person RB2

        public IEnumerable<string> Get()
        {
            //Some comments from resolving branch by JB
            return new string[] { "value6", "value8" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value3";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}