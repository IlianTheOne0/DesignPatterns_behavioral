namespace ClassLibrary.BehavioralPatterns.COR;

using ClassLibrary.BehavioralPatterns.COR.Abstraction;
using ClassLibrary.BehavioralPatterns.COR.Implementation;

class Client
{
    static void Main(string[] args)
    {
        Handler technical = new TechnicalSupportHandler();
        Handler billing = new BillingSupportHandler();
        Handler general = new GeneralSupportHandler();
        Handler escalation = new EscalationHandler();

        technical.SetNext(billing).SetNext(general).SetNext(escalation);

        string[] requests = new[] {
            "User can't login to application",
            "Payment processing failed",
            "Account information request",
            "Hardware failure detected",
            "Refund request for order #12345"
        };

        foreach (var request in requests) { Console.WriteLine($"\nProcessing request: \"{request}\""); technical.HandleRequest(request); }
    }
}