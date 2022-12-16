using Microsoft.AspNetCore.Mvc;
using BakeryOrders.Models;
using System.Collections.Generic;

namespace BakeryOrders.Controllers
{
  public class OrdersController : Controller
  { 
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("Vendor", vendor);
      return View(model);
    }
  
  }
}