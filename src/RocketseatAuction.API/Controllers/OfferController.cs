using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Filters;
using RocketseatAuction.API.UseCases.Offers.CreateOffer;

namespace RocketseatAuction.API.Controllers;

// Colocando esta linha antes da classe faz com que todos os endpoints sejam necessário autenticar.
[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute]int itemId,
        [FromBody]RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase
    )
    {
        var id = useCase.Execute(itemId, request);

        return Created(string.Empty, id);
    }
}
