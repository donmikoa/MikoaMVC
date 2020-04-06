using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MikoaMVC.Models;

namespace MikoaMVC.ViewModels
{
    //Coonected to models
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public  Customer Customer { get; set; }
    }
}