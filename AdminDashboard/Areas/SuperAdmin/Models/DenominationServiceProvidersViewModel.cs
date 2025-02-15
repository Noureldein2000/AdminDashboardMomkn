﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDashboard.Areas.SuperAdmin.Models
{
    public class DenominationServiceProvidersViewModel
    {
        public DenominationServiceProvidersViewModel()
        {
            DenominationProviderConfigurations = new List<DenominationProviderConfigurationViewModel>();
        }

        public int Id { get; set; }
        public int DenominationID { get; set; }
        [Required]
        public int ServiceProviderID { get; set; }
        [Required]
        public int ServiceConfigerationID { get; set; }
        public string ServiceProviderName { get; set; }
        [Required]
        public double Balance { get; set; }
        public bool Status { get; set; }
        public string ProviderCode { get; set; }
        public double ProviderAmount { get; set; }
        public int? OldServiceID { get; set; }
        public bool ProviderHasFees { get; set; }
        public ServiceConfigerationViewModel ServiceConfigeration { get; set; }
        public List<DenominationProviderConfigurationViewModel> DenominationProviderConfigurations { get; set; }
    }
}
