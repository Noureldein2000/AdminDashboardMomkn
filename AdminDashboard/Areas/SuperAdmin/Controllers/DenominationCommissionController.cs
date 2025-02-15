﻿using AdminDashboard.Areas.SuperAdmin.Models;
using AdminDashboard.Models;
using AdminDashboard.Models.SwaggerModels;
using AdminDashboard.SwaggerClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDashboard.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    [Route("SuperAdmin/[controller]/{action}/{id?}")]
    [Authorize]
    public class DenominationCommissionController : Controller
    {
        private readonly ICommissionApi _apiCommissions;
        private readonly IDenominationCommissionApi _apiDenominationCommission;
        public DenominationCommissionController(ICommissionApi commissionApi, IDenominationCommissionApi denominationCommissionApi)
        {
            _apiCommissions = commissionApi;
            _apiDenominationCommission = denominationCommissionApi;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int denominationId, string denominationName, bool processSucceded = false)
        {
            var data = await _apiDenominationCommission.ApiDenominationCommissionGetdenominationCommissionByDenominationIdDenominationIdGetAsync(denominationId);

            ViewBag.denominationId = denominationId;
            ViewBag.DenominationName = denominationName;
            ViewBag.processSucceded = processSucceded;

            ViewBag.Commissions = _apiCommissions.ApiCommissionGetCommissionsGet(1, 100).Results.Select(a => new SelectListItem
            {
                Text = $"From: {a.AmountFrom} To: {a.AmountTo}, Value: {a.Value} {a.PaymentModeName}",
                Value = a.Id.ToString()
            }).ToList();

            return View(data.Select(x => Map(x)));
        }

        [HttpGet]
        public IActionResult Create(int id, string denominationName)
        {
            var commissions = _apiCommissions.ApiCommissionGetCommissionsGet(1, 100).Results.Select(a => new SelectListItem
            {
                Text = $"From: {a.AmountFrom} To: {a.AmountTo}, Value: {a.Value} {a.PaymentModeName}",
                Value = a.Id.ToString()
            }).ToList();

            var model = new CreateDenominationCommissionViewModel
            {
                DenominationId = id,
                DenominationName = denominationName,
                Commissions = commissions,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateDenominationCommissionViewModel model)
        {
            try
            {
                //if (!ModelState.IsValid)
                //{
                //    var commissions = _apiCommissions.ApiCommissionGetCommissionsGet(1, 100).Results.Select(a => new SelectListItem
                //    {
                //        Text = $"From: {a.AmountFrom} To: {a.AmountTo}, Value: {a.Value} {a.PaymentModeName}",
                //        Value = a.Id.ToString()
                //    }).ToList();

                //    model.Commissions = commissions;

                //    return View(model);
                //}

                var result = _apiDenominationCommission.ApiDenominationCommissionAddDenominationCommissionPost(new AddDenominationCommissionModel(
                     denominationId: model.DenominationId,
                     commissionId: model.CommissionId));

                return Json(Map(result));
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message.Remove(0, ex.Message.IndexOf('{'));
                return Json(JsonConvert.DeserializeObject<ExceptionErrorMessage>(errorMessage));
            }
        }

        [HttpGet]
        public JsonResult Delete(int id)
        {
            try
            {

                _apiDenominationCommission.ApiDenominationCommissionDeleteDenominationCommissionIdDelete(id: id);

                return Json(id);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        private DenominationCommissionViewModel Map(DenominationCommissionModel x)
        {
            return new DenominationCommissionViewModel
            {

                Id = (int)x.Id,
                CommissionId = (int)x.CommissionId,
                CommissionTypeId = (int)x.CommissionTypeId,
                CommissionTypeName = x.CommissionTypeName,
                PaymentMode = x.PaymentMode,
                CommissionValue = x.CommissionValue,
                PaymentModeId = (int)x.PaymentModeId,
                DenominationId = (int)x.DenominationId,
                AmountFrom = (decimal)x.AmountFrom,
                AmountTo = (decimal)x.AmountTo,
            };
        }
    }
}
