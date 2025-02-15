﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDashboard.Areas.SuperAdmin.Models
{
    public class CreateAccountTypeProfileCommissionViewModel
    {
        public int Id { get; set; }
        [Required]
        public int AccountTypeProfileDenominationID { get; set; }
        [Required]
        public int CommissionId { get; set; }
        public List<SelectListItem> Commissions{ get; set; }
    }
}
