﻿using AdminDashboard.Models.SwaggerModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDashboard.Areas.SuperAdmin.Models
{
    public class DenominationReceiptParamViewModel
    {
        public int Id { get; set; }
        public int DenominationID { get; set; }
        [Required]
        public int ParameterID { get; set; }
        public string ParameterName { get; set; }
        public bool Bold { get; set; }
        [Required]
        public int Alignment { get; set; }
        public bool Status { get; set; }
        public int? DenominationReceiptDataID { get; set; }
        public FontSize FontSize{ get; set; }
    }
}
