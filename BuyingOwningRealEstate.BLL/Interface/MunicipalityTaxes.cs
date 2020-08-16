using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuyingOwningRealEstate.BLL.Interface
{
    public interface IMunicipalityTaxes
    {
        string MunicipalityTaxesService(string municipalityName,DateTime taxeDate);
    }
}
