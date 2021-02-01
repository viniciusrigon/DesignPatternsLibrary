﻿using DesignPatternsLibrary.PatternExecutors;
using NullObjectLibrary.SmartphoneApplicationExample;

namespace NullObjectLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Null Object - Null Object Library - Behavioral Pattern";

        public override void Execute()
        {
            SmartphoneApplicationExecutor.Execute();
        }
    }
}