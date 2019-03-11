using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class CourseRepo:BaseRepo
    {
        public List<Course> GetAll()
        {
            return (from c in Context.Courses select c).ToList();
        }
        public List<Course> GetAll(int skip, int take)
        {
            return (from c in Context.Courses select c).Skip(skip).Take(take).ToList();
        }
        public Course GetById(string Id)
        {
            return (from c in Context.Courses where c.CourseCode==Id select c).FirstOrDefault();
        }
        public void Save(Course course)
        {
            Context.Courses.Add(course);
            Context.SaveChanges();
        }
    }
}
