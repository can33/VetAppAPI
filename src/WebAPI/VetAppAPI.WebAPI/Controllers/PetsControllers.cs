using MediatR;
using Microsoft.AspNetCore.Mvc;
using VetAppAPI.Application.Features.PetCommandQuery.Commands.CreatePet;

namespace VetAppAPI.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PetsControllers : ControllerBase
{
    private readonly IMediator _mediator;

    public PetsControllers(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePetCommandRequest request)
    {
        var response = await _mediator.Send(request);

        return StatusCode(201, response);
    }

}
