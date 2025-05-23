﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.CommandLine;
using System.Management.Automation;

namespace Test.Isolated.Nested
{
    [Cmdlet("Test", "NestedCommand")]
    public class TestNestedCommand : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public Foo Param { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject($"{Param.Name}-{Param.Path}-{typeof(RootCommand).Assembly.FullName}");
        }
    }

    public class Foo
    {
        public string Name { get; }

        public string Path { get; }

        public Foo(string name, string path)
        {
            Name = name;
            Path = path;
        }
    }

    public class Bar
    {
        public string Id { get; }

        public Bar(string id)
        {
            Id = id;
        }
    }
}
