namespace StudentSystem.Api.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Web.Http;

    using Data;
    using Models.Homeworks;
    using StudentSystem.Models;

    public class HomeworksController : ApiController
    {
        private readonly IRepository<Homework> homeworks;
        private readonly IRepository<Student> students;
        private readonly IRepository<Course> courses;

        public HomeworksController()
        {
            var db = new StudentSystemDbContext();
            this.homeworks = new EfGenericRepository<Homework>(db);
            this.students = new EfGenericRepository<Student>(db);
            this.courses = new EfGenericRepository<Course>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.homeworks
                .All()
                .OrderBy(h => h.Id)
                .Select(hw => new HomeworkResponseModel
                {
                    Id = hw.Id,
                    FileUrl = hw.FileUrl,
                    TimeSent = hw.TimeSent
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var result = this.homeworks
                .All()
                .Where(h => h.Id == id)
                .Select(hw => new HomeworkResponseModel
                {
                    Id = hw.Id,
                    FileUrl = hw.FileUrl,
                    TimeSent = hw.TimeSent
                })
                .FirstOrDefault();

            if (result == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Homework with id " + id + " does not exist");
            }

            return this.Ok(result);
        }

        public IHttpActionResult Post(SaveHomeworkRequestModel model)
        {
            var student = this.students
                .All()
                .Where(st => st.StudentIdentification == model.StudentId)
                .FirstOrDefault();

            var course = this.courses
                .All()
                .Where(c => c.Id == model.CourseId)
                .FirstOrDefault();

            var newHomework = new Homework
            {
                FileUrl = model.FileUrl,
                TimeSent = DateTime.Now
            };

            student.Homeworks.Add(newHomework);
            course.Homeworks.Add(newHomework);

            this.homeworks.Add(newHomework);
            this.students.SaveChanges();
            this.courses.SaveChanges();

            return this.Ok("Homework with id " + newHomework.Id + " was created.");
        }

        public IHttpActionResult Put(int id, SaveHomeworkRequestModel model)
        {
            var homeworkToUpdate = this.homeworks
                .All()
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (homeworkToUpdate == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Homework with id " + id + " does not exist");
            }

            homeworkToUpdate.FileUrl = model.FileUrl;
            homeworkToUpdate.CourseId = model.CourseId;
            homeworkToUpdate.StudentIdentification = model.StudentId;
            homeworkToUpdate.TimeSent = DateTime.Now;

            this.homeworks.Update(homeworkToUpdate);
            this.homeworks.SaveChanges();

            return this.Ok("Homework with id " + homeworkToUpdate.Id + " was modified.");
        }

        public IHttpActionResult Delete(int id)
        {
            var homeworkToRemove = this.homeworks
                .All()
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (homeworkToRemove == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Homework with id " + id + " does not exist");
            }

            this.homeworks.Delete(homeworkToRemove);
            this.homeworks.SaveChanges();

            return this.Ok("Homework with id " + homeworkToRemove.Id + " was removed.");
        }
    }
}