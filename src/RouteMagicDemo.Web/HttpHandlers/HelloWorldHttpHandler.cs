﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouteMagicDemo.Web.HttpHandlers {
    public class HelloWorldHttpHandler : IHttpHandler {
        public bool IsReusable {
            get { throw new NotImplementedException(); }
        }

        public void ProcessRequest(HttpContext context) {
            context.Response.Write("Hello World!");
        }
    }
}