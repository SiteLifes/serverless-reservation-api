namespace Domain.Domain;

public class SlotDto
{
    public string ItemId { get; set; } = default!;
    public DateOnly Date { get; set; }
    public List<SlotHourDto> Slots { get; set; } = new();

    public bool HasAvailableSlot => Slots.Any(x => x.IsAvailable);

    public class SlotHourDto
    {
        public string Label => $"{StartTime:hh\\:mm}";

        public TimeOnly StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }

        public bool IsAvailable { get; set; }
        public int RemainingSlotCount { get; set; }
    }
}
