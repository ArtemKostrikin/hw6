using static System.Console;
Clear();
int a = 5;
int b = 7;

int max = a;

if (a > max) max = a;
if (b > max) max = b;

Write("max = ");
WriteLine(max);
