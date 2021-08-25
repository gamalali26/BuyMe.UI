﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BuyMe.UI.Areas.UserRole.Controllers
{
    [Area("UserRole")]
    public class BaseController : Controller
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator != null ? _mediator : HttpContext.RequestServices.GetService<IMediator>();
    }
}