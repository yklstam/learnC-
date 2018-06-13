using System;
namespace salary
{
    class salary
    {
    [STAThread]
    static void Main(string[] args){
float salary = 1000.0f;
float rate = 0.05f;
double money;
money = salary - salary * rate;
Console.WriteLine("你的收入是：{0,2:F}",money);
Console.ReadLine();
    }    
    }
}