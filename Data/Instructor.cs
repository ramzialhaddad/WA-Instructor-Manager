namespace WA_Instructor_Manager.Data;

public class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public MedicalCertificate? MedicalCertificate { get; set; }
    public Rating[]? Ratings { get; set; }

    public Instructor(string name = null, DateTime dateOfBirth = default, string? email = null, string? phone = null,
        MedicalCertificate? medicalCertificate = null, Rating[]? ratings = null)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        DateOfBirth = dateOfBirth;
        Email = email;
        Phone = phone;
        MedicalCertificate = medicalCertificate;
        Ratings = ratings;
    }
}

public class MedicalCertificate
{
    public int MedicalCategory { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime DateOfExpiry { get; set; }

    public MedicalCertificate(int medicalCategory = default, DateTime dateOfIssue = default, DateTime dateOfExpiry = default)
    {
        MedicalCategory = medicalCategory;
        DateOfIssue = dateOfIssue;
        DateOfExpiry = dateOfExpiry;
    }
}

public class Rating
{
    public string CertificateNumber { get; set; }
    public string RatingType { get; set; }
    public DateTime DateOfIssue { get; set; }
    public DateTime DateOfExpiry { get; set; }

    public Rating(string? certificateNumber = "", string? ratingType = "", DateTime? dateOfIssue = null,
        DateTime? dateOfExpiry = null)
    {
        dateOfIssue ??= DateTime.Now;
        dateOfExpiry ??= DateTime.Now;

        CertificateNumber = certificateNumber ?? throw new ArgumentNullException(nameof(certificateNumber));
        RatingType = ratingType ?? throw new ArgumentNullException(nameof(ratingType));
        DateOfIssue = dateOfIssue.Value;
        DateOfExpiry = dateOfExpiry.Value;
    }
}