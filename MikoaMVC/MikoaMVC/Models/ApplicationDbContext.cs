using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MikoaMVC.Models
{
    public class ApplicationDbContext 
    {
      
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}