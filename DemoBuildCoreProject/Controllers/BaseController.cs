﻿using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace DemoBuildCoreProject.Controllers;

[Authorize]
[ApiController]
public abstract class BaseController : ControllerBase
{
    protected long UserId { get; }

    protected BaseController(IHttpContextAccessor httpContextAccessor)
    {
        var userIdString = httpContextAccessor.HttpContext?.User?.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
        long.TryParse(userIdString, out long userId);
        UserId = userId;
    }
}
