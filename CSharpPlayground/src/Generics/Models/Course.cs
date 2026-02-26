using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.Generics.Models;
public class Course : Training
{
    public string Syllabus { get; set; }


    public Course(string title, int durationInHours, string syllabus)
        : base(title, durationInHours)
    {
        Syllabus = syllabus;
    }
    public override string GetFormat() => "Self paced asyncrhonous course";
}
