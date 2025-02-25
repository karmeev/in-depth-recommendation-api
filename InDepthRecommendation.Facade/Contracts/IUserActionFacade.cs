﻿using InDepthRecommendation.Models;
using InDepthRecommendation.Rest.Api.Contracts.Requests;

namespace InDepthRecommendation.Facade.Contracts;

public interface IUserActionFacade
{
    Task AddAction(AddUserActionRequest request);
    Task<UserAction> GetAction(string id);
}