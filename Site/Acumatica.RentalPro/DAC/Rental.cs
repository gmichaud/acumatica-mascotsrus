using System;
using PX.Data;
using PX.Objects.AR;

namespace Acumatica.RentalPro
{
    [Serializable]
    public class Rental : PX.Data.IBqlTable
    {
        public abstract class rentalID : PX.Data.IBqlField {}
        [PXDBIdentity(IsKey=true)]
        public virtual int RentalID { get; set;  }

        public abstract class rentalItemCD : PX.Data.IBqlField {}
        [PXDBString(30, IsKey = true, IsUnicode = true)]
        [PXDBDefault(typeof(RentalItem.rentalItemCD))]
        [PXUIField(DisplayName = "Rental Item Code")]
        public virtual string RentalItemCD { get; set; } 

        public abstract class customerID : PX.Data.IBqlField {}
        [PXDefault]
        [CustomerActive(Visibility = PXUIVisibility.SelectorVisible, DescriptionField = typeof(Customer.acctName), Filterable = true)]
        public virtual Int32? CustomerID { get; set; }

        public abstract class startDate : PX.Data.IBqlField {}
        [PXDBDate]
        [PXUIField(DisplayName = "Start Date")]
        public virtual DateTime? StartDate { get; set; }

        public abstract class endDate : PX.Data.IBqlField {}
        [PXDBDate]
        [PXUIField(DisplayName = "End Date")]
        public virtual DateTime? EndDate { get; set; }

        public abstract class noteID : PX.Data.IBqlField {}
        [PXNote]
        public virtual Guid? NoteID { get; set; }
    }
}