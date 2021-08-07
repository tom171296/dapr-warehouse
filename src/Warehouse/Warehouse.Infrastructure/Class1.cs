using Dapr.Client;

namespace Warehouse.Infrastructure
{
    public class Class1
    {
        private readonly DaprClientBuilder _daprClientBuilder;

        public Class1(DaprClientBuilder daprClientBuilder)
        {
            _daprClientBuilder = daprClientBuilder;
        }


        public void X()
        {
            var daprClient = _daprClientBuilder.Build();
        }

    }
}
