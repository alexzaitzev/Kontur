﻿using System.Collections.Generic;

namespace Kontur
{
    internal class Message<T> : IMessage
    {
        private readonly T payload;

        public Message(string routeKey, T payload, IDictionary<string, string> headers)
        {
            this.RouteKey = routeKey;
            this.payload = payload;
            this.Headers = headers;
        }

        public string RouteKey { get; }

        public IDictionary<string, string> Headers { get; }
    }
}