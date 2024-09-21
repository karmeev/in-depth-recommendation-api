using System.Text.Json;
using InDepthRecommendation.Models;
using StackExchange.Redis;

namespace InDepthRecommendation.Data.ClassMaps;

public static class RedisClassMaps
{
    public static UserAction MapToUserAction(this RedisValue value)
    {
        var @string = value.ToString();
        var userAction = JsonSerializer.Deserialize<UserAction>(@string);
        return userAction ?? new UserAction();
    }
}