Person stud = new Professor();
Person prof = new Student();

stud.PrintHeight();
prof.PrintHeight();

class Person
{
    public int height = 100;
    public virtual void PrintHeight()
    {
        Console.WriteLine("from base");
    }
}

class Student : Person
{
  
  override public void PrintHeight()
  {
    base.PrintHeight();
    Console.WriteLine("called from Student");
  }

}

class Professor : Person
{
    override public void PrintHeight()
  {
    base.PrintHeight();
    Console.WriteLine("called from Professor");
  }

}
