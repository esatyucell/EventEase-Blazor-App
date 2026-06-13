using EventEase.Models;

namespace EventEase.Services;

public class SessionStateService
{
    public string? CurrentUser { get; private set; }
    public List<EventModel> AttendingEvents { get; private set; } = new();

    public event Action? OnChange;

    public void LoginUser(string name)
    {
        CurrentUser = name;
        NotifyStateChanged();
    }

    public void RegisterForEvent(EventModel ev)
    {
        if (!AttendingEvents.Any(e => e.Id == ev.Id))
        {
            AttendingEvents.Add(ev);
            NotifyStateChanged();
        }
    }

    public void CancelAttendance(int eventId)
    {
        var ev = AttendingEvents.FirstOrDefault(e => e.Id == eventId);
        if (ev != null)
        {
            AttendingEvents.Remove(ev);
            NotifyStateChanged();
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}