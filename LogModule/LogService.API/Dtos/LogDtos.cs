namespace LogService.API.Dtos
{
    public record LogCreateDto(string service, string type, string detail, DateTime date);
}
