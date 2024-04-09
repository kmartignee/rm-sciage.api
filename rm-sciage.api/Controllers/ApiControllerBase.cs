using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace rm_sciage.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class ApiControllerBase<T> : ControllerBase
{
    private ILogger<T> _logger;
    private ISender _mediator;
    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetService<ILogger<T>>();
}