﻿using System;

using CommandLine;

namespace TestIt.Api.Configuration
{
    [Serializable]
    public class TestItApiConfig
    {
        [Option('h', "host", Required = false)]
        public string? Host { get; set; }

        [Option('t', "private-token", Required = false)]
        public string? PrivateToken { get; set; }

        [Option('c', "config-file", Required = false)]
        public string? ConfigFile { get; set; }
    }
}
