using Api.Infrastructure;
using Api.Infrastructure.Contract;
using Domain.Domain;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Endpoints.V1.Reservation;

public class GetAll : IEndpoint
{
    private static async Task<IResult> Handler(
        [FromQuery] DateTime? startDate,
        [FromQuery] DateTime? endDate,
        [FromServices] IReservationService reservationService,
        CancellationToken cancellationToken
    )
    {
        startDate ??= DateTime.UtcNow.AddDays(-10);
        endDate ??= DateTime.UtcNow.AddDays(31);

        var reservations = await reservationService.GetAllReservationsAsync(
            startDate: startDate.Value,
            endDate: endDate.Value,
            cancellationToken
        );
        return Results.Ok(reservations);
    }

    public RouteHandlerBuilder MapEndpoint(IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapGet("/v1/reservation", Handler)
            .Produces200<List<ReservationDto>>()
            .Produces400()
            .Produces500()
            .WithTags("Reservation");
    }
}
