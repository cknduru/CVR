using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CVR.Models
{
    public class ApiOwners : ModelBase 
    {
        public string Name { get; set; }
    }

    public class ApiProductionUnits : ModelBase
    {
        public string Pno { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public bool @protected { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public string Employees { get; set; }
        public string Addressco { get; set; }
        public int Industrycode { get; set; }
        public string Industrydesc { get; set; }
        public int Companycode { get; set; }
        public string Companydesc { get; set; }
        public string Creditstartdate { get; set; }
        public int? Creditstatus { get; set; }
        public bool Creditbankrupt { get; set; }
    }

    public class CvrEntry : ModelBase
    {
        public string VAT { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public bool @protected { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public string Employees { get; set; }
        public string Addressco { get; set; }
        public int Industrycode { get; set; }
        public string Industrydesc { get; set; }
        public int Companycode { get; set; }
        public string Companydesc { get; set; }
        public string Creditstartdate { get; set; }
        public int? Creditstatus { get; set; }
        public bool Creditbankrupt { get; set; }
        [ForeignKey("ApiOwners")]
        public ApiOwners[] Owners { get; set; }
        [ForeignKey("ApiProductionUnits")]
        public ApiProductionUnits[] Productionunits { get; set; }
        public int T { get; set; }
        public int Version { get; set; }
    }
}
