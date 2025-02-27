namespace Domain.Domain;

public class ItemConfigWorkingHourDto
{
    public DayOfWeek DayOfWeek { get; set; } = default!;

    public TimeOnly Open { get; set; } = default!;
    public TimeOnly Close { get; set; } = default!;
}
