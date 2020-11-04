﻿using System.Text;
using System.Text.Json;
using Confluent.Kafka;

namespace Gamer.Menu.Website.Serializers
{
    public class JsonValueSerializer<T> : ISerializer<T>
        where T : class
    {
        public byte[] Serialize(T data, SerializationContext context)
        {
            return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(data));
        }
    }
}