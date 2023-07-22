using UniTest.Interface;
using UniTest.Model;
using static System.Net.Mime.MediaTypeNames;

namespace UniTest.Repository
{
    public class TestRepository : ITestRepository 
    {
        private readonly UniversityContext _context;

        public TestRepository(UniversityContext context)
        {
            _context = context;
        }

        public Test GetTestDate(DateTime date)
        {
            return _context.Tests.Where(p => p.TestDate == date).FirstOrDefault();
        }

        public Test GetTestID(int id)
        {
            return _context.Tests.Where(p => p.TestId == id).FirstOrDefault();
        }

        public Test GetTestName(string name)
        {
            return _context.Tests.Where(p => p.TestName == name).FirstOrDefault();
        }

        public  Test GetTestExist(bool id)
        {
            return _context.Tests.Any(p => p.TestId == id);
        }

        public ICollection<Test> GetTests()
        {
            return _context.Tests.OrderBy(p => p.TestId).ToList();

        }

        
    }
}
