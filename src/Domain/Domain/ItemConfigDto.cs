using Domain.Entities;

namespace Domain.Domain;

public class ItemConfigDto
{
    public string ItemId { get; set; } = default!;

    public List<ItemConfigWorkingHourDto> WorkingHours { get; set; } = new();

    public int SlotCountAtSameTime { get; set; }
}

public static class ConfigDtoMapper
{
    public static ItemConfigDto ToDto(this ItemConfigEntity entity) =>
        new()
        {
            ItemId = entity.ItemId,
            WorkingHours = entity
                .WorkingHours.Select(x => new ItemConfigWorkingHourDto
                {
                    DayOfWeek = x.DayOfWeek,
                    Open = TimeOnly.FromTimeSpan(x.Open),
                    Close = TimeOnly.FromTimeSpan(x.Close),
                })
                .ToList(),
            SlotCountAtSameTime = entity.SlotCountAtSameTime,
        };
}
