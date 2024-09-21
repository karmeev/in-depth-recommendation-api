namespace InDepthRecommendation.Models.Contracts;

public interface IEntity
{
    string Id { get; set; }
    Guid ETag { get; set; }
}