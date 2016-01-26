using System;
using System.Collections;
using PX.Data;
using PX.Objects.SO;
using PX.Objects.IN;
    
namespace Acumatica.RentalPro
{
    public class SOOrderEntryExt : PXGraphExtension<SOOrderEntry>
    {
        public PXAction<SOOrder> createRental;
        [PXUIField(DisplayName = "Create Rental")]
        [PXProcessButton]
        public IEnumerable CreateRental(PXAdapter adapter)
        {
            // Find matching rental item
            var rentalItem = (RentalItem) PXSelectJoin<RentalItem, InnerJoin<InventoryItem, On<RentalItem.rentalItemCD, Equal<InventoryItem.inventoryCD>>>, Where<InventoryItem.inventoryID, Equal<Current<SOLine.inventoryID>>>>.Select(Base);
            if(rentalItem == null)
            {
                throw new PXException("No rental item was found matching code of currently selected inventory item.");
            }

            // Initialize tool management graph and position it on the currently selected tool
            var rentalManagement = PXGraph.CreateInstance<RentalManagement>();
            rentalManagement.Items.Current = rentalItem;

            // Add a row to rental grid
            var rental = (Rental)rentalManagement.Rentals.Cache.CreateInstance();
            rental.CustomerID = Base.Document.Current.CustomerID;
            rental.StartDate = Base.Document.Current.OrderDate;
            rentalManagement.Rentals.Insert(rental);

            // Redirect to tool management page
            throw new PXRedirectRequiredException(rentalManagement, true, "Rental");
        }

    }
}
