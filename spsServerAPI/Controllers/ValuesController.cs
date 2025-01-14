﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace spsServerAPI.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [Authorize(Roles = "admin")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [Authorize(Roles = "admin")]        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
