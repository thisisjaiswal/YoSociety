using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoSociety.Entities
{
    public class MaintenanceInfo
    {
        public int BillNo { get; set; }
        public string BillFor { get; set; }
        public double Amount { get; set; }
        public string PaymetStatus { get; set; }
        public DateTime DueDate { get; set; }
    }
}
