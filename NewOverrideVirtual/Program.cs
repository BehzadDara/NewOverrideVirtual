#region inheritance
MyBaseClass myClass = new MyClass();
Console.Write("Senario 1: ");
MyMethod();
#endregion

#region inheritance and virtual-override
MyBaseClass2 myClass2 = new MyClass2();
Console.Write("Senario 2: ");
MyMethod2(myClass2);
#endregion

#region inheritance and new
Console.Write("Senario 3: ");
MyMethod3();
#endregion


static void MyMethod3()
{
    MyClass3.MyMethod();
}

static void MyMethod2(MyBaseClass2 myClass)
{
    myClass.MyMethod();
}

static void MyMethod()
{
    MyBaseClass.MyMethod();
}

class MyClass3 : MyBaseClass
{
    public static new void MyMethod()
    {
        Console.WriteLine("Class");
    }
}

class MyClass2 : MyBaseClass2
{
    public override void MyMethod()
    {
        Console.WriteLine("Class");
    }
}

class MyClass : MyBaseClass
{
    public static void MyMethod()
    {
        Console.WriteLine("Class");
    }
}

class MyBaseClass2
{
    public virtual void MyMethod()
    {
        Console.WriteLine("BaseClass");
    }
}

class MyBaseClass
{
    public static void MyMethod()
    {
        Console.WriteLine("BaseClass");
    }
}