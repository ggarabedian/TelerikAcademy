namespace CarSearching
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class CarSearching : Page
    {
        private List<Producer> producers;
        private List<Extra> extras;
        private string[] engines;
        private string selectedProducer;
        private string selectedModel;

        protected void Page_Load(object sender, EventArgs e)
        {
            producers = FillCarData();

            if (!Page.IsPostBack)
            {
                selectedProducer = producers.FirstOrDefault().Name;
                this.DropDownListProducers.DataSource = producers.Select(p => p.Name);

                this.CheckBoxListExtras.DataSource = extras.Select(ex => ex.Name);
                this.RadioButtonListEngines.DataSource = engines;

                this.DataBind();
                ModelsBinding();
            }
        }

        protected void DropDownListProducers_Changed(object sender, EventArgs e)
        {
            selectedProducer = this.DropDownListProducers.SelectedValue;
            ModelsBinding();
        }

        protected void DropDownListModels_Changed(object sender, EventArgs e)
        {
            selectedModel = this.DropDownListModels.SelectedValue;
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            selectedModel = this.DropDownListModels.SelectedValue;
            selectedProducer = this.DropDownListProducers.SelectedValue;
            var selectedExtras = new List<string>();
            var extras = this.CheckBoxListExtras.Items;

            foreach (ListItem extra in extras)
            {
                if (extra.Selected)
                {
                    selectedExtras.Add(extra.Value);
                }
            }

            var selectedEngine = this.RadioButtonListEngines.SelectedItem;

            string carInfo = string.Format("Producer: {0}, Model: {1}, Extras: {2}, Engine: {3}",
                selectedProducer, selectedModel, string.Join(", ", selectedExtras), selectedEngine);

            this.LiteralCarDetails.Text = carInfo;
        }

        private List<Producer> FillCarData()
        {
            producers = new List<Producer>();
            extras = new List<Extra>()
            {
                new Extra("Airbags"),
                new Extra("Automatic Transmission"),
                new Extra("Air Conditioning"),
                new Extra("Parktronic")
            };

            ICollection<Model> chevroletModels = new HashSet<Model>()
            {
                new Model("Camaro"),
                new Model("Corvette"),
                new Model("Impala")
            };

            Producer chevrolet = new Producer("Chevrolet", chevroletModels);
            producers.Add(chevrolet);

            ICollection<Model> audiModels = new HashSet<Model>()
            {
                new Model("A3"),
                new Model("A4"),
                new Model("A6")
            };

            Producer audi = new Producer("Audi", audiModels);
            producers.Add(audi);

            ICollection<Model> bmwModels = new HashSet<Model>()
            {
                new Model("M5"),
                new Model("M3"),
                new Model("520d")
            };

            Producer bmw = new Producer("BMW", bmwModels);
            producers.Add(bmw);

            engines = new[] { "Petrol", "Diesel", "AutoGas", "Electric"};

            return producers;
        }

        private void ModelsBinding()
        {
            var models = from producer in producers
                         where producer.Name == selectedProducer
                         from model in producer.Models
                         select model.Name;

            this.DropDownListModels.DataSource = models;
            this.DropDownListModels.DataBind();
            //selectedProducer = models.FirstOrDefault();
        }
    }
}