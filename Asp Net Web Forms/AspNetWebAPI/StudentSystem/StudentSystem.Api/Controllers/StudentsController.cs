namespace StudentSystem.Api.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Web.Http;

    using Data;
    using Models.Students;
    using StudentSystem.Models;

    public class StudentsController : ApiController
    {
        private readonly IRepository<Student> data;

        public StudentsController()
        {
            var db = new StudentSystemDbContext();
            this.data = new EfGenericRepository<Student>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.data
                .All()
                .OrderBy(st => st.FirstName)
                .ThenBy(st => st.LastName)
                .Select(st => new SaveStudentRequestModel()
                {
                    FirstName = st.FirstName,
                    LastName = st.LastName,
                    Level = st.Level
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var result = this.data
                .All()
                .Where(st => st.StudentIdentification == id)
                .Select(st => new SaveStudentRequestModel()
                {
                    FirstName = st.FirstName,
                    LastName = st.LastName,
                    Level = st.Level
                })
                .FirstOrDefault();

            if (result == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Student with id " + id + " does not exist");
            }

            return this.Ok(result);
        }

        public IHttpActionResult Post(SaveStudentRequestModel model)
        {
            var newStudent = new Student
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Level = model.Level
            };

            this.data.Add(newStudent);
            this.data.SaveChanges();

            return this.Ok("Student with id " + newStudent.StudentIdentification + " was created.");
        }

        public IHttpActionResult Put(int id, SaveStudentRequestModel model)
        {
            var studentToUpdate = this.data
                .All()
                .Where(st => st.StudentIdentification == id)
                .FirstOrDefault();

            if (studentToUpdate == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Student with id " + id + " does not exist");
            }

            studentToUpdate.FirstName = model.FirstName;
            studentToUpdate.LastName = model.LastName;
            studentToUpdate.Level = model.Level;

            this.data.Update(studentToUpdate);
            this.data.SaveChanges();

            return this.Ok("Student with id " + studentToUpdate.StudentIdentification + " was modified.");
        }

        public IHttpActionResult Delete(int id)
        {
            var studentToRemove = this.data
                .All()
                .Where(st => st.StudentIdentification == id)
                .FirstOrDefault();

            if (studentToRemove == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Student with id " + id + " does not exist");
            }

            this.data.Delete(studentToRemove);
            this.data.SaveChanges();

            return this.Ok("Student with id " + studentToRemove.StudentIdentification + " was removed.");
        }
    }
}