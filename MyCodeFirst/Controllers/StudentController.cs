using MyCodeFirst.Service;
using MyCodeFirst.ViewModel;
using System;
using System.Web.Http;

namespace MyCodeFirst.Controllers
{
    public class StudentController : ApiController
    {
        private StudentService studentService;

        public StudentController()
        {
            studentService = new StudentService();
        }

        [HttpPost]
        public bool Add(StudentViewModel studentViewModel)
        {
            try
            {
                studentService.AddStudent(studentViewModel);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
