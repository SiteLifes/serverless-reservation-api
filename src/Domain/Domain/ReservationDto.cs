using Domain.Entities;

namespace Domain.Domain;

public class ReservationDto
{
    public string Id { get; set; } = default!;
    public string ItemId { get; set; } = default!;
    public string UserId { get; set; } = default!;
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string? Description { get; set; }
}

public static class ReservationDtoMapper
{
    public static ReservationDto ToDto(this ReservationEntity entity)
    {
        return new ReservationDto
        {
            Id = entity.Id,
            ItemId = entity.ItemId,
            UserId = entity.UserId,
            Date = DateOnly.FromDateTime(entity.StartDate),
            StartTime = TimeOnly.FromDateTime(entity.StartDate),
            EndTime = TimeOnly.FromDateTime(entity.EndDate),
            Description = entity.Description
        };
    }
}