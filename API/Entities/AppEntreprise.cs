using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppEntreprise
    {


        public int Id { get; set; }
        public string CompanyName { get; set; }

        public byte[] CompanyPassword { get; set; }

        public byte[] CompanyPasswordHash { get; set; }

        public string CompanyField { get; set; }

        public string CompanyDescription { get; set; }
    }
}