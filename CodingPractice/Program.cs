using System;
using System.Reflection.PortableExecutable;

// 1

TestObject obj1 = new TestObject(1);
TestObject obj2 = new TestObject(2);

obj1 = null;
obj2 = null;

Console.WriteLine("GC 실행 전");

GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("실행 후");

class TestObject
{
    private int _id;

    public TestObject(int id)
    {
        _id = id;
        Console.WriteLine($"객체 {_id} 생성");
    }
    ~TestObject()
    {
        Console.WriteLine($"객체 {_id} 소멸");
    }
}

// 2

Console.WriteLine("v프로그램 시작");

Character hero = new Characrer("용사");
hero.Attack();
hero = null;

Console.WriteLine("GC 실행");
GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("프로그램 종료");

class Character
{
    private string _name;
    
        public Character (string name)
    {
        _name = name;
        Console.WriteLin($"[1] _name)"
    }

    public void Attack()
    {
        Console.WriteLine($"[2] {_name} 공격");
    }

}