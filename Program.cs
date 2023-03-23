// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Class1 class1 = new Class1();
Action action = new Action(class1.Report);
Func<int, int, int> func = new Func<int, int, int>(class1.Add);
Func<int, int, int> func1 = new Func<int, int, int>(class1.Sun);
class1.Report();
action.Invoke();

int a = 100;
int s = 200;
int d = 0;

d =func.Invoke(a, s);
Console.WriteLine(d);

d = func1(a, s);
Console.WriteLine(d);


class Class1
{
    public void Report()
    {
        Console.WriteLine("我有三个方法");
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sun(int a, int b)
    {
        return a - b;
    }
}