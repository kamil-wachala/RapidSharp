namespace Kapps.RapidSharpNetCore.Plugins
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }

        int Execute();
    }
}
