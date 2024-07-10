using System.Net;

namespace Journey.Exception.ExceptionsBase
{
  public abstract class JourneyExceptions : System.Exception
  {
    public JourneyExceptions(string message) : base(message)
    {

    }

    public abstract HttpStatusCode GetStatusCode();
    public abstract IList<string> GetErrorMessages();
  }
}
