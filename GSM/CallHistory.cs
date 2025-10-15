using System.Text;

namespace GSM;

public class CallHistory
{
    // Privat fält som innehåller samtalshistorik
    private readonly List<Call> performedCalls = new List<Call>();

    // Metoder
    public int Count() {  return performedCalls.Count; }

    public void Add(Call call)
    {
        performedCalls.Add(call);
    }
    public void Remove(Call call)
    {
        performedCalls.Remove(call);
    }

    public override string ToString()
    {
        if (performedCalls.Count == 0)
        {
            return "- Inga samtal i historiken -";
        }

        StringBuilder callHistoryInfo = new StringBuilder();

        callHistoryInfo.AppendLine("----- SAMTALSHISTORIK -----");
        foreach (var call in performedCalls)
        {
            callHistoryInfo.AppendLine("- " + call.ToString());
        }

        return callHistoryInfo.ToString();
    }
}