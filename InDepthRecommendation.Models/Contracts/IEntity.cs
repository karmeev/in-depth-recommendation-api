namespace InDepthRecommendation.Models.Contracts;

public interface IEntity
{
    string Id { get; init; }
    Guid ETag { get; set; }
}