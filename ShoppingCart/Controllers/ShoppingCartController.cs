﻿using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ShoppingCartController : ControllerBase
  {
    private readonly ILogger<ShoppingCartController> _logger;

    public ShoppingCartController(ILogger<ShoppingCartController> logger)
    {
      _logger = logger;
    }

    [HttpPost]
    [Route("cart")]
    public IActionResult CreateCart()
    {
      return View();
    }
  }
}
