﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationDto.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the LocationDto type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace NewsSightseeing.Data.Dto
{
    using MongoDB.Bson.Serialization.Attributes;

    public class LocationDto
    {
        [BsonElement("lat")]
        public float Latitude { get; set; }

        [BsonElement("lng")]
        public float Longtitude { get; set; }
    }
}