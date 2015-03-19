using Nancy;

public class MainModule : NancyModule
{
    public MainModule()
    {
        Get["/nancy"] = p => 
            //"test2";
            View["staticview"];
    }
}

/*
public class CustomRootPathProvider : IRootPathProvider
{
    public string GetRootPath()
    {
        return "What ever path you want to use as your application root";
    }
}
*/