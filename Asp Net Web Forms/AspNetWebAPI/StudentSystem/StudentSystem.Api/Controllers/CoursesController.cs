namespace StudentSystem.Api.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Web.Http;

    using Data;
    using Models.Courses;
    using StudentSystem.Models;

    public class CoursesController : ApiController
    {
        private readonly IRepository<Course> data;

        public CoursesController()
        {
            var db = new StudentSystemDbContext();
            this.data = new EfGenericRepository<Course>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.data
                .All()
                .OrderBy(c => c.Id)
                .Select(c => new SaveCourseRequestModel()
                {
                    Name = c.Name,
                    Description = c.Description
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(Guid? id)
        {
            var result = this.data
                .All()
                .Where(c => c.Id == id)
                .Select(c => new SaveCourseRequestModel()
                {
                    Name = c.Name,
                    Description = c.Description
                })
                .FirstOrDefault();

            if (result == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Course with id " + id + " does not exist");
            }

            return this.Ok(result);
        }

        public IHttpActionResult Post(SaveCourseRequestModel model)
        {
            var newCourse = new Course
            {
                Name = model.Name,
                Description = model.Description,
            };

            this.data.Add(newCourse);
            this.data.SaveChanges();

            return this.Ok("Course with id " + newCourse.Id + " was created.");
        }

        public IHttpActionResult Put(Guid? id, SaveCourseRequestModel model)
        {
            var courseToUpdate = this.data
                .All()
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (courseToUpdate == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Course with id " + id + " does not exist");
            }

            courseToUpdate.Name = model.Name;
            courseToUpdate.Description = model.Description;

            this.data.Update(courseToUpdate);
            this.data.SaveChanges();

            return this.Ok("Course with id " + courseToUpdate.Id + " was modified.");
        }

        public IHttpActionResult Delete(Guid? id)
        {
            var courseToRemove = this.data
                .All()
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (courseToRemove == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Course with id " + id + " does not exist");
            }

            this.data.Delete(courseToRemove);
            this.data.SaveChanges();

            return this.Ok("Course with id " + courseToRemove.Id + " was removed.");
        }
    }
}