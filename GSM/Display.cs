using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSM;
public class Display
{
    // Privata konstanter
    private const decimal MinSizeInches = 0.5m;
    private const decimal MaxSizeInches = 100m;
    private const decimal MaxNumberOfColors = 1E10m;

    // Privata fält
    private decimal? sizeInches = null;
    private ulong? numberOfColors = null;

    // Konstruktorer
    public Display(decimal? sizeInches = null, ulong? numberOfColors = null)
    {
        SizeInches = sizeInches;
        NumberOfColors = numberOfColors;
    }

    // Egenskaper
    public decimal? SizeInches
    {
        get { return sizeInches; }
        set
        {
            if (value.HasValue && (value < MinSizeInches || value > MaxSizeInches))
            {
                throw new ArgumentOutOfRangeException("Otillåten skärmstorlek!");
            }
            sizeInches = value;
        }
    }
    public ulong? NumberOfColors
    {
        get { return this.numberOfColors; }
        set
        {
            if (value.HasValue && value > MaxNumberOfColors)
                throw new ArgumentOutOfRangeException("Antalet färger är för stort!");

            this.numberOfColors = value;
        }
    }

    public override string ToString()
    {
        StringBuilder displayInfo = new StringBuilder();

        displayInfo.AppendLine("--> SKÄRM <--");

        if (sizeInches.HasValue)
        {
            displayInfo.AppendLine(string.Format("Storlek: {0} tum", sizeInches));
        }
        if (numberOfColors.HasValue)
        {
            displayInfo.AppendLine("Antal färger: " + numberOfColors);
        }

        return displayInfo.ToString();
    }
}
