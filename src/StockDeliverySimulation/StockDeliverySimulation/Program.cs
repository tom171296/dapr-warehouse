using StockDeliverySimulation.Events;
using System;
using System.Net.Mqtt;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace StockDeliverySimulation
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            try
            {
                var mqttHost = Environment.GetEnvironmentVariable("MQTT_HOST") ?? "localhost";
                var client = await MqttClient.CreateAsync(mqttHost, 1883);
                await client.ConnectAsync(new MqttClientCredentials(clientId: "Simulation"));
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Sending message " + i);
                    var eventJson = JsonSerializer.Serialize(new StockDelivered { Name = i.ToString(), Id = i.ToString() });
                    var message = new MqttApplicationMessage("stockupdate/entrysensor", Encoding.UTF8.GetBytes(eventJson));
                   
                    await client.PublishAsync(message, MqttQualityOfService.AtLeastOnce);
                    Console.WriteLine("Message send " + i);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
            catch(Exception ex){
                Console.WriteLine($"exception occurd + {ex.Message}");
            }
            
        }
    }
}