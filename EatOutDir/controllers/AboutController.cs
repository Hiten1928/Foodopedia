using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.controllers
{
    [Route("[controller]")]
    public class AboutController
    {

        [Route("phone")]
        public string phone(){
            return "123456";
        }

        [Route("address")]
        public string address(){
            return "USA";
        }

    }
}
