namespace GigAuth.Communication.Responses;

public class ResponseRole
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public List<ResponsePermission> Permissions { get; set; } = [];
}