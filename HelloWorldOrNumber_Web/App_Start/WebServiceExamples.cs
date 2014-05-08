using System.Linq;
using System.Collections.Generic;
using ServiceStack;
using System.Runtime.Serialization;
using ServiceStack.Configuration;
using HelloWorldOrNumber_Class;

namespace HelloWorldOrNumber_Web
{
    //this class was used from the example found at https://github.com/ServiceStack/ServiceStack.Examples/tree/master/src/ServiceStack.Examples
    public class ExampleConfig
    {
        /// <summary>
        /// Would've preferred to use [assembly: ContractNamespace] attribute but it is not supported in Mono
        /// </summary>
        public const string DefaultNamespace = "http://schemas.servicestack.net/types";

        public ExampleConfig() { }

        public ExampleConfig(IAppSettings appConfig)
        {
            ConnectionString = appConfig.GetString("ConnectionString");
            DefaultFibonacciLimit = appConfig.Get("DefaultFibonacciLimit", 10);
        }

        public string ConnectionString { get; set; }
        public int DefaultFibonacciLimit { get; set; }
    }



    [DataContract(Namespace = ExampleConfig.DefaultNamespace)]
    public class GetInputCheck
    {
        [DataMember]
        public string ForValue { get; set; }
    }

    [DataContract(Namespace = ExampleConfig.DefaultNamespace)]
    public class GetInputCheckResponse
    {
        [DataMember]
        public string Result { get; set; }
    }

    /// <summary>
    /// This is the service designed to check what a value has when posted from the web page.
    /// </summary>
    public class GetInputCheckService : Service
    {
        private HelloWorldOrNumberPart2 sourceClass = new HelloWorldOrNumberPart2();
        public object Any(GetInputCheck request)
        {
            GetInputCheckResponse result = new GetInputCheckResponse();
            result.Result = sourceClass.CheckForMultiplesPart2(request.ForValue);
            return result;
        }

    }


}

