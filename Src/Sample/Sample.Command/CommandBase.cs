﻿using IFramework.Command;
using IFramework.Infrastructure;
using IFramework.Message;

namespace Sample.Command
{
    [Topic("commandqueue")]
    public abstract class CommandBase : ICommand
    {
        public CommandBase()
        {
            NeedRetry = false;
            ID = ObjectId.GenerateNewId().ToString();
        }

        public bool NeedRetry { get; set; }

        public string ID { get; set; }

        public string Key { get; set; }
    }

    public abstract class LinearCommandBase : CommandBase, ILinearCommand { }
}