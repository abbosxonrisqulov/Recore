﻿using Microsoft.AspNetCore.Mvc;
using Recore.Service.Interfaces;
using Recore.WebApi.Models;

namespace Recore.WebApi.Controllers;

public class AuthController : BaseController
{
    private readonly IAuthService authService;
	public AuthController(IAuthService authService)
	{
		this.authService = authService;
	}

	[HttpPost("login")]
	public async Task<IActionResult> GenerateTokenAsync(string phone, string password)
		=> Ok(new Response
		{
			StatusCode = 200,
			Message = "Success",
			Data = await this.authService.GenerateTokenAsync(phone, password)
		});
}
