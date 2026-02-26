using CSharpPlayground.Generics.Interfaces;
using CSharpPlayground.Generics.Models;


namespace CSharpPlayground.src.Generics;
public class CourseProducer : ITrainingProducer<Course>
{
    public Course Produce()
    {
        return new Course(
            title: "Microservices with .NET 8",
            durationInHours: 40,
            syllabus: "Vertical Slice, CQRS, Clean Arch., Docker, RabbitMQ"
            );
    }
}
