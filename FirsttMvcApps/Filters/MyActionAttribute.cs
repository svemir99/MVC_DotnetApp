using Microsoft.AspNetCore.Mvc.Filters;

namespace FirsttMvcApps.Filters
{
    public class MyActionAttribute:ActionFilterAttribute
    {


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("Action started");
        }



        public override void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("Action finished");
        }



        public override void OnResultExecuted(ResultExecutedContext context) 
        
        { 

            Console.WriteLine("ActionResult finished");


        }
        public override void OnResultExecuting(ResultExecutingContext context)
       
        {


            Console.WriteLine("ActionResult started");


        }
    }
}
