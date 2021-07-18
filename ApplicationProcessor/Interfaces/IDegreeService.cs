namespace Ulaw.ApplicationProcessor.Interfaces
{
    public interface IDegreeService<T> where T : class
    {
        string Publish(ULaw.ApplicationProcessor.Application application);
    }
}
