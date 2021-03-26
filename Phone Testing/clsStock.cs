using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Testing
{
    class clsStock
    {
        public bool Active { get; internal set; }
        public int StockId { get; internal set; }
        public DateTime DateOfOrder { get; internal set; }
        public DateTime ShipmentDate { get; internal set; }
        public int SupplierID { get; internal set; }
        public int NumberOfOrder { get; internal set; }
        public int NumberShipped { get; internal set; }
        public int Cost { get; internal set; }
        public string Productname { get; internal set; }

        internal int Valid(object dateOfOrder, object shipmentDate, object supplierID, int numberOfOrder, object numberShipped)
        {
            throw new NotImplementedException();
        }

        internal string Valid(string dateAdded)
        {
            throw new NotImplementedException();
        }
    }
}
