using System;
using System.Diagnostics;
using System.Net;



Console.WriteLine("Измерение скорости интернета...");// вывод тектса 


WebClient client = new WebClient(); // создание нового вебклиента


Stopwatch stopwatch = new Stopwatch(); // создание нового класса для измерения времени при запросе на сервер
stopwatch.Start();


byte[] data = client.DownloadData("http://www.google.com"); // Отправляем запрос на сервер для получения данных

stopwatch.Stop(); // конец измерения 

double elapsedTimeInSeconds = stopwatch.Elapsed.TotalSeconds; // получение затраченных секуед
double dataSizeInBytes = data.Length; // получение обьема данных 
double speedInMbps = dataSizeInBytes / elapsedTimeInSeconds * 8 / 1024 / 1024; // делим обьем на скорость * 8 /1024 /1024

Console.WriteLine($"Скорость интернета: {speedInMbps:F2} Mbps"); //вывод 

client.Dispose();// удаление ресов занимаемыми вебклиентом