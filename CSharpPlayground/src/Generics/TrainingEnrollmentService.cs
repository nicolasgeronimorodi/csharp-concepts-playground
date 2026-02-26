using CSharpPlayground.Generics.Interfaces;
using CSharpPlayground.Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground.src.Generics;
public class TrainingEnrollmentService : ITrainingConsumer<Training>
{
    public void Enroll(Training training)
    {
        Console.WriteLine($"Enrolling in [{training.GetFormat()} - {training.Title}] ");
        Console.WriteLine($"Duration in hours: {training.DurationInHours} ");

    }
}
