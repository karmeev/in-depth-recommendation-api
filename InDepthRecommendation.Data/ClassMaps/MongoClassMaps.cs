using InDepthRecommendation.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;

namespace InDepthRecommendation.Data.ClassMaps;

public static class BsonClassMapExtension
{
    public static void RegisterClassMap()
    {
        UserActionMap.CreateMap();
        BsonSerializer.RegisterIdGenerator(typeof(string), StringObjectIdGenerator.Instance);
        var objectSerializer = new ObjectSerializer(type => type.FullName != null && (ObjectSerializer.DefaultAllowedTypes(type)
            || type.FullName.StartsWith("InDepthRecommendation.Models")));
        
        var pack = new ConventionPack
        {
            new EnumRepresentationConvention(BsonType.String),
            new IgnoreExtraElementsConvention(true)
        };

        ConventionRegistry.Register("EnumStringConvention", pack, t => true);
        
        BsonSerializer.RegisterSerializer(objectSerializer);

    }

    private class UserActionMap
    {
        public static void CreateMap()
        {
            BsonClassMap.RegisterClassMap<UserAction>(cm =>
            {
                cm.AutoMap();
                cm.SetIsRootClass(true);
            });
        }

    }
}
