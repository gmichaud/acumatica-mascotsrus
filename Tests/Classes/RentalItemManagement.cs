using Core;

namespace Acumatica.RentalPro.Tests
{
    public class RentalItemManagement : RP301000_RentalManagement
    {
        public c_items_form Summary
        {
            get
            {
                return base.Items_form;
            }
        }

        public c_rentals_grid Details
        {
            get
            {
                return base.Rentals_grid;
            }
        }
    }
}
