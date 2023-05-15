// See https://aka.ms/new-console-template for more information

// Integer types
byte by = 255;
by = 254;
Console.WriteLine(by);
short sh = 32_767;
sh = 32_766;
Console.WriteLine(sh);
int it = 32_768;
it = 32_767;
Console.WriteLine(it);
long lo = 9_999_999_999;
lo = 9_999_999_998;
Console.WriteLine(lo);
sbyte sb = 127;
sb = 126;
Console.WriteLine(sb);
ushort us = 65_535;
us = 65_534;
Console.WriteLine(us);
uint ui = 4_294_967_295;
ui = 4_294_967_294;
Console.WriteLine(ui);
ulong ul = 18_446_744_073_709_551_615;
ul = 18_446_744_073_709_551_614;
Console.WriteLine(ul);

// Characters and strings
char ch = 'a';
ch = 'b';
Console.WriteLine(ch);
string st = "This is a string";
st = "This is also a string";
Console.WriteLine(st);

// Floating point types
float fl = (float)12.5;
fl = (float)12.4;
Console.WriteLine(fl);
double db = 12.5;
db = 12.4;
Console.WriteLine(db);
decimal de = (decimal)12.576364;
de = (decimal)12.576363;
Console.WriteLine(de);

bool bo = true;
bo = false;
Console.WriteLine(bo);
