namespace ApiProje.API.Entities;

public class Reservation
{
    public int ReservationId { get; set; }
    public string NameSurname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime Date { get; set; }
    public string RezervationTime { get; set; }
    public int CountofPeople { get; set; }
    public string Message { get; set; }
    public string RezervationStatus { get; set; }
}