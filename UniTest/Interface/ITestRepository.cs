using UniTest.Model;

namespace UniTest.Interface
{
    public interface ITestRepository
    {
        ICollection<Test> GetTests();

        Test GetTestID(int id);

        Test GetTestName(string name);

        Test GetTestDate(DateTime date);

        Test GetTestExist(bool id);
    }
}


