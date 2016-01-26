using System;
using PX.Data;

namespace Acumatica.RentalPro
{
    [Serializable]
    public class RentalItem : PX.Data.IBqlTable
    {
        public abstract class rentalItemCD : PX.Data.IBqlField { }
        [PXDBString(30, IsKey = true, IsUnicode = true)]
        [PXDefault()]
        [PXUIField(DisplayName = "Rental Item Code")]
        [PXSelector(typeof(Search<RentalItem.rentalItemCD>))]
        public virtual string RentalItemCD { get; set; }

        public abstract class description : PX.Data.IBqlField { }
        [PXDBString(50, IsUnicode = true)]
        [PXDefault]
        [PXUIField(DisplayName = "Description", Visibility=PXUIVisibility.SelectorVisible)]
        public virtual string Description { get; set; }

        public abstract class cost : PX.Data.IBqlField { }
        [PXDBDecimal(2)]
        [PXUIField(DisplayName = "Cost")]
        public virtual decimal? Cost { get; set; }

        public abstract class serialNumber : PX.Data.IBqlField { }
        [SerialNumber]
        public virtual string SerialNumber { get; set; }

        public abstract class noteID : PX.Data.IBqlField {}
        [PXSearchable(PX.Objects.SM.SearchCategory.IN, "{0} - {1}", new Type[] { typeof(RentalItem.rentalItemCD), typeof(RentalItem.description), typeof(RentalItem.serialNumber) },
           new Type[] { typeof(RentalItem.rentalItemCD), typeof(RentalItem.description) },
           Line1Format = "{0}", Line1Fields = new Type[] { typeof(RentalItem.description) }, 
           Line2Format = "{0}", Line2Fields = new Type[] { typeof(RentalItem.serialNumber) })]
        [PXNote]
        public virtual Guid? NoteID { get; set; }
    }
}