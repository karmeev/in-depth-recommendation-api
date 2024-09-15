using InDepthRecommendation.Models.Contracts;

namespace InDepthRecommendation.Models;

public class UserAction: IEntity
{
    public string Action { get; set; }
}