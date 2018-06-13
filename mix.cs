using System;
namespace mix
{
    class mix
    {
    [STAThread]
    static void Main(string[] args)
    {
int cx=10,cy=12,cr=0;
cr=cx*cy;
Console.WriteLine("长方形的长是：{0} 宽是：{1}",cx,cy);
Console.WriteLine("长方形的面积是：{0}",cr);
double sx=12,sy=10.5;
Console.WriteLine("三角型的底是：{0} 高是：{1}",sx,sy);
Console.WriteLine("三角形的面积是：{0}",sx*sy/2);
char ca='C',cb='N';
Console.WriteLine("{0}{1}代表中国",ca,cb);
bool bh=cx>cy;
Console.WriteLine("{0}>{1}是{2}",cx,cy,bh);
Console.ReadLine();
    }    
    }
}