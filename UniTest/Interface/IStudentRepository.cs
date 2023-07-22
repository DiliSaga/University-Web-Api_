using UniTest.Model;

namespace UniTest.Interface
{
    public interface IStudentRepository
    {
        ICollection<Student> GetStudents();

        Student GetStudentID(int studentId);
        Student GetStudentFname(string fname);

        Student GetStudentLname(string lname);

        Student GetStudentGender(string gender);

        Student GetStudentDob(DateTime dob);

        Student GetStudentNic(int nic);

        Student GetStudentEmail(string email);

        Student GetGuardianId(int guardianId);

        Student GetStudentCourse(string studentId);


    }
}


