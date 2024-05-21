// See https://aka.ms/new-console-template for more information
using ChainofResponsibility.Loggers;

Console.WriteLine("Hello, World!");
Logger _logger = new InfoLogger(new DebugLogger(null));
string msg = "test";
_logger.log("INFO",msg);
_logger.log("DEBUG",msg);