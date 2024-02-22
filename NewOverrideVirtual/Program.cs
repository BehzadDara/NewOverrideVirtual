#region inheritance
MyBaseClass myClass = new MyClass();
Console.Write("Senario 1: ");
myClass.MyMethod();
#endregion

#region inheritance and virtual-override
MyBaseClass2 myClass2 = new MyClass2();
Console.Write("Senario 2: ");
myClass2.MyMethod();
#endregion

#region inheritance and new
MyBaseClass3 myClass3 = new MyClass3();
Console.Write("Senario 3: ");
myClass3.MyMethod();
#endregion


class MyClass3 : MyBaseClass3
{
    public new void MyMethod()
    {
        Console.WriteLine("Class3");
        base.MyMethod();
    }
    /*public new int MyMethod()
    {
        Console.WriteLine("Class3");
        return 0;
    } OK */ 
}

class MyClass2 : MyBaseClass2
{
    public override void MyMethod()
    {
        Console.WriteLine("Class2");
    }
    /*public override int MyMethod()
    {
        Console.WriteLine("Class2");
        return 0;
    } ERROR */
}

class MyClass : MyBaseClass
{
    public void MyMethod()
    {
        Console.WriteLine("Class1");
    }
}

class MyBaseClass3
{
    public void MyMethod()
    {
        Console.WriteLine("BaseClass3");
    }
}

class MyBaseClass2
{
    public virtual void MyMethod()
    {
        Console.WriteLine("BaseClass2");
    }
}

class MyBaseClass
{
    public void MyMethod()
    {
        Console.WriteLine("BaseClass1");
    }
}