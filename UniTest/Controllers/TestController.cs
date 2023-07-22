using Microsoft.AspNetCore.Mvc;
using UniTest.Interface;
using UniTest.Model;

namespace UniTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private readonly ITestRepository _testRepository;

        public TestController(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Test>))]

        public IActionResult GetTests()
        {
            var test = _testRepository.GetTests();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(test);
        }

        [HttpGet("TestId")]
        [ProducesResponseType(200, Type = typeof(Test))]
        [ProducesResponseType(400)]
        public IActionResult GetTest(int TestId)
        {
            if (!_testRepository.TestExists(TestId))
            {
                return NotFound();
            }
        }

    }
}
