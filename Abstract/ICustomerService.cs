using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.KodlamaIO.HW.Entities;
using GameDemo.KodlamaIO.HW.Concrete;

namespace GameDemo.KodlamaIO.HW.Abstract
{
    public interface ICustomerService
    {
        void SignUp(Customer customer);
        void Update();
        void Delete(string customerPassword);
    }
}
