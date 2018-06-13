using System;
namespace  Time
{
    class Time
    {
    [STAThread]
    static void Main(string[] args){
int years = 100;
long seconds;
long minutes;
long hours;
hours = years * 365 * 24;
minutes = hours * 60;
seconds = minutes * 60;
Console.WriteLine("{0}年有{1}小时{2}分钟{3}秒",years,hours,minutes,seconds);
Console.ReadLine();
    }
}
}