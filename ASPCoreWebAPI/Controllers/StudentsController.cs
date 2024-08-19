using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public List<string> student = new List<string>()
        {
            "prasanta",
            "Leena",
            "raj"
        };
        [HttpGet] 
        public List<string> getStudent() 
        {
            return student;
        }
        [HttpGet("{id}")]
        public string getStudentByID(int id)
        {
            return student.ElementAt(id);
        }
    }
}
