using MyCodeFirst.Data;
using MyCodeFirst.Entity;
using MyCodeFirst.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeFirst.Service
{
    public class StudentService
    {
        public bool AddStudent(StudentViewModel studentViewModel)
        {
            try
            {
                var student = new Student()
                {
                    Id = studentViewModel.Id,
                    Name = studentViewModel.Name
                };
                var dbManager = new DataManager<Student>();
                dbManager.Insert(student);
            }
            catch (Exception ex)
            {
                throw;
            }

            return true;
        }
    }
}
