﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToDesignPatterns.Infra.Singleton
{
    public sealed class Singleton
    {
        public Guid Id { get; } = Guid.NewGuid();

        private static Singleton instance = null;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
