using System;
using System.Collections;
using PX.Data;

namespace Acumatica.RentalPro
{
    public class RentalManagement : PXGraph<RentalManagement, RentalItem>
    {
        public PXSelect<RentalItem> Items;
        public PXSelect<Rental, Where<Rental.rentalItemCD, Equal<Current<RentalItem.rentalItemCD>>>> Rentals;
    }
}
