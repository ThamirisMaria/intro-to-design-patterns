using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToDesignPatterns.Infra.Singleton
{
    public sealed class Singleton
    {
        public Guid Id { get; } = Guid.NewGuid();

    }
}
