using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.Generics.Models;
public class Workshop : Training
{
    public string Facilitator { get; set; }

    public Workshop(string title, int durationInHours, string facilitator)
        : base(title, durationInHours)
    {
        Facilitator = facilitator;
    }

    public override string GetFormat() => "Live workshop with hands on practice";
}
