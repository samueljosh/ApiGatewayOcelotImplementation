using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderApi.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET api/order
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Get()
        {
         try{
            var o1 = new Order("ID1",10);
            var o2  = new Order("ID2",12);
             
            return Ok(new List<Order> {o1 ,o2} );
         }   catch {

             return BadRequest();
         }

        }


    
    }
    public class  Order
    {

       public Order(string Id, Decimal Amount ){

            this.Id  = Id;
            this.Amount = Amount;

       }

        public string Id { get; set; }
        public Decimal Amount { get; set; }

    }
}
