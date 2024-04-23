using System;
using System.Net.NetworkInformation;

/*networkInterface = NetworkInterface.GetAllNetworkInterfaces()
IPInterfaceProperties properties = networkInterface.GetIPProperties();
Console.WriteLine(properties.UnicastAddresses)
*/
Console.WriteLine("Устройства, подключенные к сети:");

foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
{
    IPInterfaceProperties properties = networkInterface.GetIPProperties();
    foreach (UnicastIPAddressInformation address in properties.UnicastAddresses){
        if (address.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork){
            Console.WriteLine($"Имя устройства: {networkInterface.Name}");
            Console.WriteLine($"IP-адрес: {address.Address}");
            Console.WriteLine();
        }
    }
}

