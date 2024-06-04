namespace WA_Instructor_Manager.Data;

public class InstructorService
{
    private static readonly Rating[] Ratings = new[]
    {
        new Rating( "123456789", "Multi Instrument", new DateTime(2020, 1, 1), new DateTime(2025, 1, 1)),
        new Rating( "123456789", "Multi Engine", new DateTime(2019, 1, 1), new DateTime(2024, 1, 1)),
        new Rating( "123456789", "Night Rating", new DateTime(2018, 1, 1), new DateTime(2023, 1, 1)),
        new Rating( "123456789", "Instrument Rating", new DateTime(2017, 1, 1), new DateTime(2022, 1, 1)),
    };
    
    // Takes a random number of random ratings from the example Ratings array
    private static Rating[] RandomRatings()
    {
        return Ratings.OrderBy(x => Guid.NewGuid()).Take(Random.Shared.Next(1, Ratings.Length)).ToArray();
    }

    private Instructor[] Instructors;

    public void RefreshInstructors()
    { 
        Instructors = new[]
        {
            new Instructor("John Doe", 
                new DateTime(1980, 1, 1), 
                "John@doe.com",
                "2047658493", 
                new MedicalCertificate(1, new DateTime(2019, 1, 1), new DateTime(2024, 1, 1)), 
                RandomRatings()),
            
            new Instructor("Smith Doe", 
                new DateTime(1977, 1, 1), 
                "Smith@doe.com", 
                "2046543271", 
                new MedicalCertificate(1, new DateTime(2022, 1, 1), new DateTime(2024, 1, 1)), 
                RandomRatings()),
            
            new Instructor("Alice Smith",
                new DateTime(1987, 1, 1),
                "Alice@google.com",
                "2048754621",
                new MedicalCertificate(1, new DateTime(2023, 1, 1), new DateTime(2024, 1, 1)),
                RandomRatings()),
            new Instructor("Bob Smith",
                new DateTime(2000, 1, 1),
                "Bob@google.com",
                "2047478451",
                new MedicalCertificate(1, new DateTime(2015, 1, 1), new DateTime(2024, 1, 1)),
                RandomRatings()),
            new Instructor("John Johnson",
                new DateTime(2001, 1, 1),
                phone:"2047478451",
                medicalCertificate:new MedicalCertificate(1, new DateTime(2015, 1, 1), new DateTime(2024, 1, 1)),
                ratings:RandomRatings()),
            new Instructor("Joe Bob Johnson",
                new DateTime(1998, 1, 1),
                email:"JoeBobJohnson@email.com",
                medicalCertificate:new MedicalCertificate(1, new DateTime(2015, 1, 1), new DateTime(2024, 1, 1)),
                ratings:RandomRatings()),
            new Instructor("Bob Johnson Jr.",
                new DateTime(1982, 1, 1),
                medicalCertificate:new MedicalCertificate(1, new DateTime(2015, 1, 1), new DateTime(2024, 1, 1)),
                ratings:RandomRatings()),
        };
        Instructors = Instructors.OrderBy(x => Guid.NewGuid()).ToArray();
    }

    public Task<Instructor[]> GetInstructorsAsync()
    {
        RefreshInstructors();
        return Task.FromResult(Instructors.OrderBy(x => Guid.NewGuid()).ToArray());
    }
    
    public Instructor[] GetInstructorsSync()
    {
        RefreshInstructors();
        return Instructors.OrderBy(x => Guid.NewGuid()).ToArray();
    }
}