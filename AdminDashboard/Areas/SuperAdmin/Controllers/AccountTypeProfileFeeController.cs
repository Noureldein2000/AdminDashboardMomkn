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

    public class AccountTypeProfileFeeController : Controller
    {
        private readonly IFeesApi _feesApi;
        private readonly IAccountTypeProfileFeeApi _accountTypeProfileFeeApi;
        public AccountTypeProfileFeeController(IFeesApi feesApi, IAccountTypeProfileFeeApi accountTypeProfileFeeApi)
        {
            _feesApi = feesApi;
            _accountTypeProfileFeeApi = accountTypeProfileFeeApi;
        }
        public async Task<IActionResult> Index(int id, string title, string denomination, int page = 1, int size = 10, bool processSucceded = false)
        {
            var model = await _accountTypeProfileFeeApi.ApiAccountTypeProfileFeeGetAccountTypeProfileFeesIdGetAsync(id, page, size, "ar");

            var viewModel = new PagedResult<AccountTypeProfileFeeViewModel>
            {
                Results = model.Results.Select(u => MapToViewModel(u)).ToList(),
                PageCount = (int)model.PageCount,
                CurrentPage = page,
                PageSize = size
            };

            ViewBag.FullTitle = title;
            ViewBag.processSucceded = processSucceded;
            ViewBag.accountTypeProfileDenomination = id;
            ViewBag.denomination = denomination;
            ViewBag.Fees = _feesApi.ApiFeesGetFeesGet(1, 1000, "ar").Results.Select(a => new SelectListItem
            {
                Text = $"From: {a.AmountFrom} To: {a.AmountTo}, Value: {a.Value} {a.PaymentModeName}",
                Value = a.Id.ToString()
            }).ToList();

            return View(viewModel);
        }

        public IActionResult Create(int id)
        {
            var fees = _feesApi.ApiFeesGetFeesGet(1, 1000, "ar").Results.Select(a => new SelectListItem
            {
                Text = $"From: {a.AmountFrom} To: {a.AmountTo}, Value: {a.Value} {a.PaymentModeName}",
                Value = a.Id.ToString()
            }).ToList();

            var model = new CreateAccountTypeProfileFeeViewModel
            {
                AccountTypeProfileDenominationID = id,
                Fees = fees
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(CreateAccountTypeProfileFeeViewModel model)
        {
            try
            {
                var result = _accountTypeProfileFeeApi.ApiAccountTypeProfileFeeAddAccountTypeProfileFeePost(new AccountTypeProfileFeesModel
                      (
                      accountTypeProfileDenominationID: model.AccountTypeProfileDenominationID,
                      feesID: model.FeeId
                      ));

                return Json(MapToViewModel(result));

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
            _accountTypeProfileFeeApi.ApiAccountTypeProfileFeeDeleteIdDelete(id);
            return Json(id);
        }
        private AccountTypeProfileFeesModel MapToModel(AccountTypeProfileFeeViewModel x)
        {
            return new AccountTypeProfileFeesModel
            {
                Id = x.Id,
                AmountFrom = (double)x.AmountFrom,
                AmountTo = (double)x.AmountTo,
                FeesTypeName = x.FeesTypeName,
                PaymentModeName = x.PaymentModeName,
                FeesValue = (double)x.FeesValue,
                AccountTypeProfileDenominationID = x.AccountTypeProfileDenominationID,
                FeesID = x.FeesID,
                AccountTypeName = x.AccountTypeName,
                ProfileName = x.ProfileName
            };
        }

        private AccountTypeProfileFeeViewModel MapToViewModel(AccountTypeProfileFeesModel x)
        {
            return new AccountTypeProfileFeeViewModel
            {
                Id = (int)x.Id,
                AmountFrom = (decimal)x.AmountFrom,
                AmountTo = (decimal)x.AmountTo,
                FeesTypeName = x.FeesTypeName,
                PaymentModeName = x.PaymentModeName,
                FeesValue = (decimal)x.FeesValue,
                AccountTypeProfileDenominationID = (int)x.AccountTypeProfileDenominationID,
                FeesID = (int)x.FeesID,
                AccountTypeName = x.AccountTypeName,
                ProfileName = x.ProfileName
            };
        }
    }
}
