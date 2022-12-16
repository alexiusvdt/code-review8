using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using BakeryOrders.Models;

namespace BakeryOrders.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendors.GetAll();
      return View(allVendors);
    }

  }
}