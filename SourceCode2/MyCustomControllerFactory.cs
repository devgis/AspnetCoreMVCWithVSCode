using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using Temp.Controllers;

namespace Temp
{
    public class MyCustomControllerFactory:IControllerFactory
    {
        public object CreateController(ControllerContext context)
        {
            return new MyCommonController2();            
        }
        //
        // Summary:
        //     Releases a controller instance.
        //
        // Parameters:
        //   context:
        //     Microsoft.AspNetCore.Mvc.ControllerContext for the executing action.
        //
        //   controller:
        //     The controller.
        public void ReleaseController(ControllerContext context, object controller)
        {
        }
    }
}
