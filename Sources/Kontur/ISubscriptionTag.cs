﻿using System;

namespace Kontur
{
    public interface ISubscriptionTag : IDisposable
    {
        string Id { get; }
    }
}
