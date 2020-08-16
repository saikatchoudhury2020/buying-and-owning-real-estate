using System;
using System.Collections.Generic;
using System.Text;

namespace BuyingOwningRealEstate.Dal.Models
{
    public class MunicipalityTaxes
    {
        public int Id { get; set; }
        public string MunicipalityName { get; set; }
        public string TaxesScheduled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
