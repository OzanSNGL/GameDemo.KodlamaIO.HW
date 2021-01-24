using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.KodlamaIO.HW.Abstract;
using GameDemo.KodlamaIO.HW.Entities;

namespace GameDemo.KodlamaIO.HW.Concrete
{
    class EDevletManager : IEDevletService
    {
        public bool IsValidCustomer()
        {
            Console.WriteLine("Kimliğiniz onaylandı.");
            return true;
            
        }
    }
}
