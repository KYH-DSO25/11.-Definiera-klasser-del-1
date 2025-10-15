/*
 * 8.   Skapa en klass Call för att hantera samtal genom en telefon. Den bör
*       innehålla datum, tid, uppringt telefonnummer och samtalets längd (i
*       sekunder)
*  
*  9.   Lägg till en egenskap CallHistory i klassen GSM som hanterar en
*       lista med utgående samtal. Detta är samtalshistoriken. Försök att
*       använda systemklassen List<Call>
* 
* 10.   Lägg till metoder i klassen GSM för att lägga till och ta bort samtal
*       från samtalshistoriken. Lägg till en metod för att rensa
*       samtalshistoriken
*       
*/

using System.Text;

namespace GSM;
public class Call
{
    // Privata fält
    private DateTime date;
    private string dialedNumber;
    private TimeSpan duration = TimeSpan.Zero;

    // Konstruktor
    public Call(DateTime date, string dialedNumber, TimeSpan duration)
    {
        // TODO: fyll i egenskaper
    }

    // Egenskaper
    public DateTime Date
    {
        get { return date; }
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException("Datum och tid måste anges!");
            }
            date = value;
        }
    }

    public string DialedNumber
    {
        get { return dialedNumber; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Uppringt nummer måste anges");
            }
            dialedNumber = value;
        }
    }

    public TimeSpan Duration
    {
        get { return duration; }
        set
        {
            if (value == TimeSpan.Zero)
            {
                throw new ArgumentNullException("Samtalets längd måste anges");
            }
            duration = value;
        }
    }

    // Override metoder
    public override string ToString()
    {
        StringBuilder callInfo = new StringBuilder();

        callInfo.Append(string.Format("Nummer: {0} | Längd: {1} | Datum: {2}",
            DialedNumber, Duration, Date));

        return callInfo.ToString();
    }
}
