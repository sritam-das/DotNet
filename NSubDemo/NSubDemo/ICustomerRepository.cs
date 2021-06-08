using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubDemo
{
    public interface ICustomerRepository
    {
        Customer getCustomerById(int custId);

        int  GetCount();
    }
}
