using Microsoft.AspNetCore.Mvc;

namespace InDepthRecommendation.Rest.Api.Controllers;

[ApiController]
[Route("recommendation")]
public class RecommendationController: ApiController
{
    public RecommendationController(ILogger<RecommendationController> logger) 
        : base(logger)
    { }
}