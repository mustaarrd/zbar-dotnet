// See https://aka.ms/new-console-template for more information
using System.Drawing;

var bitmap = (Bitmap)Image.FromFile("barcode.bmp");
var scanner = new ZBar.ImageScanner();

var symbols = scanner.Scan(bitmap);
foreach (var symbol in symbols)
{
    Console.WriteLine(symbol.Data);
}

Console.ReadKey();