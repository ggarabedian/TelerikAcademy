namespace StudentSystem.Api.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Web.Http;

    using Data;
    using Models.Tests;
    using StudentSystem.Models;

    public class TestsController : ApiController
    {
        private readonly IRepository<Test> tests;

        public TestsController()
        {
            var db = new StudentSystemDbContext();
            this.tests = new EfGenericRepository<Test>(db);
        }

        public IHttpActionResult Get()
        {
            var result = this.tests
                .All()
                .OrderBy(t => t.Id)
                .Select(t => new SaveTestRequestModel()
                {
                    CourseId = t.CourseId
                })
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            var result = this.tests
                .All()
                .Where(t => t.Id == id)
                .Select(t => new SaveTestRequestModel()
                {
                    CourseId = t.CourseId
                })
                .FirstOrDefault();

            if (result == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Test with id " + id + " does not exist");
            }

            return this.Ok(result);
        }

        public IHttpActionResult Post(SaveTestRequestModel model)
        {
            var newTest = new Test
            {
                CourseId = model.CourseId,
            };

            this.tests.Add(newTest);
            this.tests.SaveChanges();

            return this.Ok("Test with id " + newTest.Id + " was created.");
        }

        public IHttpActionResult Put(int id, SaveTestRequestModel model)
        {
            var testToUpdate = this.tests
                .All()
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (testToUpdate == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Test with id " + id + " does not exist");
            }

            testToUpdate.CourseId = model.CourseId;

            this.tests.Update(testToUpdate);
            this.tests.SaveChanges();

            return this.Ok("Test with id " + testToUpdate.Id + " was modified.");
        }

        public IHttpActionResult Delete(int id)
        {
            var testToRemove = this.tests
                .All()
                .Where(c => c.Id == id)
                .FirstOrDefault();

            if (testToRemove == null)
            {
                return this.Content(HttpStatusCode.NotFound, "Test with id " + id + " does not exist");
            }

            this.tests.Delete(testToRemove);
            this.tests.SaveChanges();

            return this.Ok("Test with id " + testToRemove.Id + " was removed.");
        }
    }
}