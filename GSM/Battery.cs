using System.Text;

namespace GSM;
public class Battery
{
    // Privata konstanter
    private const uint MaxIdleHours = 500;
    private const uint MaxTalkHours = 3000;

    // Privata fält
    private uint? hoursIdle = null;
    private uint? hoursTalk = null;

    // Konstruktorer
    public Battery(Type model, uint? hoursIdle = null, uint? hoursTalk = null)
    {
        this.Model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
    }

    // Enumeration
    public enum Type
    {
        LiIon,
        NiMH,
        NiCd
    }

    // Egenskaper
    public Type Model { get; set; }

    public uint? HoursIdle
    {
        get {  return hoursIdle; }
        set
        {
            if (value.GetValueOrDefault() > MaxIdleHours)
            {
                throw new ArgumentOutOfRangeException("Max inaktiv tid är för stor!");
            }
            else
            {
                this.hoursIdle = value;
            }
        }
    }
    public uint? HoursTalk
    {
        get { return hoursTalk; }
        set
        {
            if (value.GetValueOrDefault() > MaxTalkHours)
            {
                throw new ArgumentOutOfRangeException("Max taltid är för stort!");
            }
            else
            {
                hoursTalk = value;
            }
        }
    }

    // Override metod
    public override string ToString()
    {
        StringBuilder batteryInfo = new StringBuilder();

        batteryInfo.AppendLine("--> BATTERI <--");
        batteryInfo.AppendLine("Modell: " + Model.ToString());

        if (hoursIdle.HasValue)
        {
            batteryInfo.AppendLine("Inaktiv tid: " + hoursIdle + " timmar");
        }
        if (hoursTalk.HasValue)
        {
            batteryInfo.AppendLine("Taltid: " + hoursTalk + " timmar");
        }

        return batteryInfo.ToString();
    }
}
