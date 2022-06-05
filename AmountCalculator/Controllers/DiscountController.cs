using AmountCalculator.Abstract;
using AmountCalculator.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmountCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        readonly IRepositoryCustomer _repository;
        public DiscountController(IRepositoryCustomer repository)
        {
            _repository = repository;
        }
        // GET: api/<DiscountController>
        [HttpPost]
        public decimal Post([FromBody] Invoice invoice)
        {
            CustomerBase cust = _repository.Get(invoice.CustomerId);
            if (cust == null)
            {
                cust = new NonCustomer();
            }
            
           
            return cust.CalculateDiscount(invoice.Amount);
            
        }

        
    }
}
