﻿using System;
using AllureCSharpCommons.Events;
using AllureCSharpCommons.AllureModel;

namespace MSTestAllureAdapter
{
    public class TestCaseFailureWithErrorInfoEvent : TestCaseFailureEvent
    {
        ErrorInfo mErrorInfo;

        public TestCaseFailureWithErrorInfoEvent(ErrorInfo errorInfo)
        {
            mErrorInfo = errorInfo;
        }

        public override void Process(AllureCSharpCommons.AllureModel.testcaseresult context)
        {
            context.status = status.failed;
            context.failure = new failure
            {
                message = mErrorInfo.Message,
                stacktrace = mErrorInfo.StackTrace
            };
        }
    }
}

