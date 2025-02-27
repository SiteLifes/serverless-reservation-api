using FluentValidation;

namespace Api.Endpoints.V1.Model;

public class ReservationModel
{
    public string ItemId { get; set; } = default!;
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string? Description { get; set; }
}

public class ReservationModelValidator : AbstractValidator<ReservationModel>
{
    public ReservationModelValidator()
    {
        
    }
}