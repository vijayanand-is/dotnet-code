﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.Reflection;

namespace WcfLogPrints
{
    class LoggingParameterInspector : IParameterInspector
    {
        #region IParameterInspector Members

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            LoggingContext.ClearCurrentContextDetails();

            if (!LogAfterCall)
            {
                return;
            }

            if (ServiceType == null)
            {
                return;
            }

            MethodInfo mi = ServiceType.GetMethod(operationName);
            if (mi == null)
            {
                return;
            }

            LoggingArgument arg = CreateArgumentForResultLog(mi, outputs, returnValue);

            LoggingStrategy.Log(arg);
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            if (ServiceType == null)
            {
                return null;
            }

            MethodInfo mi = ServiceType.GetMethod(operationName);
            if (mi == null)
            {
                return null;
            }

            SetLoggingContext(inputs, mi);

            if (LogBeforeCall)
            {
                LoggingArgument arg = CreateArgumentForInvokeLog(mi, inputs);

                LoggingStrategy.Log(arg);
            }

            return null;
        }

        #endregion

        private void SetLoggingContext(object[] inputs, MethodInfo mi)
        {
            LoggingContextDetails lcd = new LoggingContextDetails
            {
                MethodDetails = mi,
                Inputs = inputs,
                LoggingStrategy = LoggingStrategy,
                LogErrors = LogErrors,
                LogWarnings = LogWarnings,
                LogInformation = LogInformation
            };

            LoggingContext.SetCurrentContextDetails(lcd);
        }

        #region Properties

        public Type ServiceType { get; set; }

        #region LoggingStrategy
        private ILoggingStrategy _loggingStrategy;
        public ILoggingStrategy LoggingStrategy
        {
            get { return _loggingStrategy ?? (_loggingStrategy = new ConsoleLoggingStrategy()); }
            set { _loggingStrategy = value; }
        }
        #endregion

        public bool LogBeforeCall { get; set; }
        public bool LogAfterCall { get; set; }
        public bool LogErrors { get; set; }
        public bool LogWarnings { get; set; }
        public bool LogInformation { get; set; }

        #endregion

        private LoggingArgument CreateArgumentForInvokeLog(MethodInfo mi, object[] inputs)
        {
            if (mi == null)
            {
                return null;
            }

            LoggingArgument res =
                new LoggingArgument
                {
                    LogType = LoggingType.Invoke,
                    OperationName = mi.Name
                };

            if (inputs != null && inputs.Length > 0)
            {
                res.InputsData = new LoggingInputsData
                {
                    InputParameters = mi.GetParameters().Where(p => !p.IsOut).ToArray(),
                    InputValues = inputs
                };
            }

            return res;
        }

        private LoggingArgument CreateArgumentForResultLog(MethodInfo mi, object[] outputs, object returnValue)
        {
            if (mi == null)
            {
                return null;
            }

            LoggingArgument res =
                new LoggingArgument
                {
                    LogType = LoggingType.Result,
                    OperationName = mi.Name
                };

            if (outputs != null && outputs.Length > 0)
            {
                res.OutputsData = new LoggingOutputsData
                {
                    OutputParameters =
                        mi.GetParameters().Where(p => p.IsOut || p.ParameterType.IsByRef).ToArray(),
                    OutputValues = outputs
                };
            }

            if (mi.ReturnType != typeof(void))
            {
                res.ReturnValueData = new LoggingReturnValueData
                {
                    Value = returnValue
                };
            }

            return res;
        }

    }
}
