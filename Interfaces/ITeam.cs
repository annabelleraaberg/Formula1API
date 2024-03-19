namespace Formula1API.Interfaces;

public interface ITeam
{
    int Id {get; set;}
    string? Manufacturer {get; set;}
    string? Image {get; set;}
}