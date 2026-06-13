using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class EventModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Location { get; set; } = string.Empty;
    public int Capacity { get; set; }
}

public class RegistrationFormModel
{
    [Required(ErrorMessage = "Full Name is required.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters.")]
    public string FullName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    [Required]
    [Range(1, 5, ErrorMessage = "You can only register up to 5 guests.")]
    public int GuestCount { get; set; } = 1;
}