using Microsoft.AspNetCore.Mvc;
using OdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeeter)
        {
            _greeter = greeeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetMessageOfTheday();
            return View("Default", model);
        }
    }
}
