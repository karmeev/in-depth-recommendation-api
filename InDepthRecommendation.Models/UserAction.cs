using InDepthRecommendation.Models.Contracts;

namespace InDepthRecommendation.Models;

public class UserAction: IEntity
{
    public string Id { get; set; }
    public Guid ETag { get; set; }
    public string Action { get; set; }
}