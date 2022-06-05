using AmountCalculator.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmountCalculator.Abstract
{
    public interface IRepositoryCustomer
    {
        CustomerBase Get(int id);
    }
}
