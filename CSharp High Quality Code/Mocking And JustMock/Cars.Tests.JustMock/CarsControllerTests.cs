namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
             : this(new MoqCarsRepository())
           //: this(new JustMockCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void SortingByMakeShouldOrderItemsCorrectly()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(4, cars.Count);

            Assert.AreEqual("Audi", cars[0].Make);
            Assert.AreEqual("BMW", cars[1].Make);
            Assert.AreEqual("Chevrolet", cars[2].Make);
            Assert.AreEqual("Opel", cars[3].Make);
        }

        [TestMethod]
        public void SortingByYearShouldOrderItemsCorrectly()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(4, cars.Count);

            Assert.AreEqual(2005, cars[0].Year);
            Assert.AreEqual(2008, cars[1].Year);
            Assert.AreEqual(2010, cars[2].Year);
            Assert.AreEqual(2012, cars[3].Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortingByNotSortableParameterShouldThrow()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort("model"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortingByEmptyStringShouldThrow()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Sort(""));
        }

        [TestMethod]
        public void SearchShouldWorkPropperlyWithMake()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("Audi"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(1, cars.Count);

            foreach (var car in cars)
            {
                Assert.AreEqual("Audi", car.Make);
            }
        }

        [TestMethod]
        public void SearchShouldWorkPropperlyWithModel()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("Camaro"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(1, cars.Count);
            foreach (var car in cars)
            {
                Assert.AreEqual("Chevrolet", car.Make);
            }
        }

        [TestMethod]
        public void SearchShouldReturnWholeListWhenEmptyInput()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search(""));

            Assert.IsNotNull(cars);
            Assert.AreEqual(4, cars.Count);
        }

        [TestMethod]
        public void SearchShouldReturnNothingWhenInvalidInput()
        {
            var cars = (IList<Car>)this.GetModel(() => this.controller.Search("pesho"));

            Assert.IsNotNull(cars);
            Assert.AreEqual(0, cars.Count);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
