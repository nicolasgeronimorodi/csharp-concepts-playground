using CSharpPlayground.Generics.Interfaces;
using CSharpPlayground.Generics.Models;
using CSharpPlayground.src.Generics;

namespace CSharpPlayground.Generics;
public static class Runner
{

    public static void Run()
    {
        Console.WriteLine(" === Invariance === ");
        //A course IS a training, so a direct assignment works
        Training training = new Course(
            "Clean Architecture", 20, "Layers, dependencies, boundaries"
            );
        Console.WriteLine($"Training format: {training.GetFormat()}");


        /*
         * This would not compile.
         */
        // List<Training> trainings = new List<Course>();

        /*
         * The compiler sees List<Course> and List<Training> as unrelated types. 
         * If it allowed this, trainings.Add(new Workshop(...)) would be allowed
         * and it would corrupt a list that in memory really is a List<Course>.
         */

        Console.WriteLine("\n=== Covariance (out) ===");
        /*
         * CourseProducer implements ITrainingProducer<Course>
         * Because of "out", ITrainingProducer<Course> IS an ITrainingProducer<Training>
         * The assignment below is valid: whatever comes out is at least a Training
        */

        ITrainingProducer<Course> courseProducer = new CourseProducer();
        ITrainingProducer<Training> trainingProducer = courseProducer;

        Training produced = trainingProducer.Produce();
        Console.WriteLine($"Produced: {produced.Title} (of format: {produced.GetFormat()})");

        Console.WriteLine("\n=== Contravariance (in) ===");

        /*TrainingEnrollmentService implements ITrainingConsumer<Training>
         * Because of "in, ITraningConsumer<Training> IS an ITrainingConsumer<Course>
         * and also an ITrainingConsumer<Worskhop>
         * It makes sense that if it can handle any Training it can sure handle a Course
         */

        ITrainingConsumer<Training> generalEnrollmentService = new TrainingEnrollmentService();
        ITrainingConsumer<Course> courseEnrollmentService = generalEnrollmentService;
        ITrainingConsumer<Workshop> workshopEnrollmentService = generalEnrollmentService;


        courseEnrollmentService.Enroll(new Course("Event-Driven Architecture", 20, "Kafka, Outbox pattern"));
        workshopEnrollmentService.Enroll(new Workshop("Docker Hands-on", 16, "Nicolas R."));



    }
}
