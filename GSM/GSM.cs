using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM;
public class GSM
{
    // Privata konstanter
    private static readonly GSM iphone10 = new GSM("Iphone 10", "Apple", "M-Tel", 9999.99m,
        new Display(7, 25_000), new Battery(Battery.Type.LiIon, 250, 1000));

    private const uint MaxPriceValue = 1_000_000;

    // Private Fields
    private string? model = null;
    private string? manufacturer = null;
    private string? owner = null;
    private decimal? price = 0;

    private Display display = null;
    private Battery battery = null;

    // Konstruktorer
    public GSM(string model, string manufacturer, string owner = null,
        decimal? price = null, Display display = null, Battery battery = null)
    {
        Model = model;
        Manufacturer = manufacturer;
        Owner = owner;
        Price = price;
        Display = display;
        Battery = battery;
        CallHistory = new CallHistory();
    }

    // Egenskaper
    public static GSM Iphone10 { get { return iphone10; } }
    public string Model
    {
        get { return model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Modellell måste anges!");
            }
            model = value;
        }
    }
    public string Manufacturer
    {
        get { return manufacturer; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Tillverkare måste anges!");
            }
            manufacturer = value;
        }
    }

    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    public decimal? Price
    {
        get { return price; }
        set
        {
            if (value.HasValue && (value < 0 || value > MaxPriceValue))
            {
                throw new ArgumentOutOfRangeException("Priset är för högt eller mindre än noll!");
            }
            price = value;
        }
    }

    public Display Display
    {
        get { return display; }
        set { display = value; }
    }

    public Battery Battery
    {
        get { return battery; }
        set { battery = value; }
    }

    public CallHistory CallHistory { get; set; }

    // Metoder
    public void ShowInformation()
    {
        Console.Write(this.ToString());
    }

    public override string ToString()
    {
        StringBuilder mobileInfo = new StringBuilder();

        mobileInfo.AppendLine("--------- MOBILTELEFON ----------");
        mobileInfo.AppendLine("Modell: " + model);
        mobileInfo.AppendLine("Tillverkare: " + manufacturer);

        if (owner != null)
        {
            mobileInfo.AppendLine("Ägare: " + owner);
        }

        if (price.HasValue)
        {
            mobileInfo.AppendLine(string.Format("Pris: {0} kr", price));
        }

        if (display != null)
        {
            mobileInfo.AppendLine( Environment.NewLine + display.ToString());
        }

        if (battery != null)
        {
            mobileInfo.AppendLine( Environment.NewLine + battery.ToString());
        }

        return mobileInfo.ToString();
    }
}