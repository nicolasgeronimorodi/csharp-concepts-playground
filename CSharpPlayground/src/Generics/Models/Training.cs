using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.Generics.Models;
public abstract class Training
{
    public string Title { get; set; }
    public int DurationInHours { get; set; }

    protected Training(string title, int durationInHours)
    {
        Title = title;
        DurationInHours = durationInHours;
    }

    public abstract string GetFormat();
}
