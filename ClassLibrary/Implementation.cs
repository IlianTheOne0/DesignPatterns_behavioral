namespace ClassLibrary.BehavioralPatterns.COR.Implementation;

using ClassLibrary.BehavioralPatterns.COR.Abstraction;

public class TechnicalSupportHandler : Handler
{
    public override void HandleRequest(string request)
    {
        if (request.Contains("login") || request.Contains("crash") || request.Contains("performance")) { Console.WriteLine($"Technical Support handled: '{request}'"); }
        else { base.HandleRequest(request); }
    }
}

public class BillingSupportHandler : Handler
{
    public override void HandleRequest(string request)
    {
        if (request.Contains("payment") || request.Contains("refund") || request.Contains("subscription")) { Console.WriteLine($"Billing Support handled: '{request}'"); }
        else { base.HandleRequest(request); }
    }
}

public class GeneralSupportHandler : Handler
{
    public override void HandleRequest(string request)
    {
        if (request.Contains("account") || request.Contains("service")) { Console.WriteLine($"General Support handled: '{request}'"); }
        else { base.HandleRequest(request); }
    }
}

public class EscalationHandler : Handler
{
    public override void HandleRequest(string request) { Console.WriteLine($"Escalation team handled critical issue: '{request}'"); }
}