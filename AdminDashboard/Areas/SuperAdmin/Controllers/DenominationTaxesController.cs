﻿using AdminDashboard.Areas.SuperAdmin.Models;
using AdminDashboard.Models;
using AdminDashboard.Models.SwaggerModels;
using AdminDashboard.SwaggerClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class DenominationTaxesController : Controller
    {
        private readonly ITaxApi _apiTaxes;
        private readonly IDenominationTaxesApi _apiDenominationTaxes;
        private readonly IDenominationApi _apiDenomination;
        public DenominationTaxesController(ITaxApi apiTaxes, IDenominationTaxesApi denominationTaxes, IDenominationApi denominationApi)
        {
            _apiTaxes = apiTaxes;
            _apiDenominationTaxes = denominationTaxes;
            _apiDenomination = denominationApi;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int denominationId, string denominationName, bool processSucceded = false)
        {
            var data = await _apiDenominationTaxes.ApiDenominationTaxesGetdenominationTaxesByDenominationIdDenominationIdGetAsync(denominationId);
            ViewBag.denominationId = denominationId;
            ViewBag.DenominationName = denominationName;
            ViewBag.ProcessSucceded = processSucceded;
            ViewBag.Taxes = _apiTaxes.ApiTaxGetTaxesGet(1, 100).Results.Select(a => new SelectListItem
            {
                Text = $"From: {a.AmountFrom} To: {a.AmountTo}, Value: {a.Value} {a.PaymentModeName}",
                Value = a.Id.ToString()
            }).ToList();

            return View(data.Select(x => Map(x)));
        }

        [HttpGet]
        public IActionResult Create(int id, string denominationName)
        {
            var taxes = _apiTaxes.ApiTaxGetTaxesGet(1, 100).Results.Select(a => new SelectListItem
            {
                Text = $"From: {a.AmountFrom} To: {a.AmountTo}, Value: {a.Value} {a.PaymentModeName}",
                Value = a.Id.ToString()
            }).ToList();

            var model = new CreateDenominationTaxesViewModel
            {
                DenominationId = id,
                DenominationName = denominationName,
                Taxes = taxes,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CreateDenominationTaxesViewModel model)
        {
            try
            {

                var result = _apiDenominationTaxes.ApiDenominationTaxesAddDenominationTaxesPost(new AddDenominationTaxesModel(
                      denominationId: model.DenominationId,
                      taxId: model.TaxesId));

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
                _apiDenominationTaxes.ApiDenominationTaxesDeleteDenominationTaxIdDelete(id: id);

                return Json(id);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }

        }

        private DenominationTaxesViewModel Map(DenominationTaxesModel x)
        {
            return new DenominationTaxesViewModel
            {

                Id = (int)x.Id,
                TaxId = (int)x.TaxId,
                TaxTypeId = (int)x.TaxTypeId,
                TaxTypeName = x.TaxTypeName,
                PaymentMode = x.PaymentMode,
                TaxValue = (decimal)x.TaxValue,
                PaymentModeId = (int)x.PaymentModeId,
                DenominationId = (int)x.DenominationId,
                AmountFrom =(decimal) x.AmountFrom,
                AmountTo = (decimal) x.AmountTo,
            };
        }
    }
}
