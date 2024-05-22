public interface IDoSmthng
{
    int SayMyAge();
    string SayMyName();
    void Info();
}

class AboutMe: IDoSmthng
{
    int Age;
    string Name;
    
    public AboutMe()
    {
        Age = 0;
        Name = "";
    }
    public int MyAge
    {
        get
        {
            return Age;
        }
        set
        {
            if (value > 0) Age = value;
        }
    }

    //ctor with parameters
    public AboutMe(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public int SayMyAge()
    {
        Age = -31;
        return Age;
    }

    public string SayMyName()
    {
        Name = "Projkeen";
        return Name;
    }           

    public void Info()
    {
        Console.WriteLine("Information via method Info: "+ Age+", "+ Name);
    }

    static void Main()
    {
        AboutMe aboutMe = new AboutMe();
        Console.WriteLine("My age: "+ aboutMe.SayMyAge());
        Console.WriteLine("My name: "+ aboutMe.SayMyName());
        AboutMe aboutMeWithParam=new AboutMe(33, "Projkeen2"); //insert parameters(arguments) in ctor with parameters
        Console.WriteLine("Show info via ctor with parameters: Age: " + aboutMeWithParam.Age);
        Console.WriteLine("Show info via ctor with parameters: Name: " + aboutMeWithParam.Name);
        aboutMe.Info();        
        Console.WriteLine("Проверка значения на . Значение aboutMe.MyAge: "+ aboutMe.MyAge);
    }
}

