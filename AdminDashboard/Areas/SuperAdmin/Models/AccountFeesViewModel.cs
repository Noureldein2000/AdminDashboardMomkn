﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDashboard.Areas.SuperAdmin.Models
{
    public class AccountFeesViewModel
    {
        public int Id { get; set; }
        public int FeesId { get; set; }
        public double? From { get; set; }
        public double? To { get; set; }
        public double? FeesValue { get; set; }
        public int PaymentModeId { get; set; }
        public string PaymentMode { get; set; }
        public int FeesTypeId { get; set; }
        public string FeesTypeName { get; set; }
        public int DenomiinationId { get; set; }
        public string DenominationFullName { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
