﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities1 _db;

        public void PopulateGrid()
        {
            var cars = _db.TypesOfCars.Select(q => new
            {
                Make = q.Make,
                Model = q.Model,
                VIN = q.VIN,
                Year = q.Year,
                LicensePlateNumber = q.LicensePlateNumber,
                q.id
            }).ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
        }
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddEditVehicle addEditVehicle = new AddEditVehicle(this);
            addEditVehicle.ShowDialog();
            addEditVehicle.MdiParent = this.MdiParent;

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int) gvVehicleList.SelectedRows[0].Cells["id"].Value;

                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

                var addEditVehicle = new AddEditVehicle(car,this);
                addEditVehicle.ShowDialog();
                addEditVehicle.MdiParent = this.MdiParent;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvVehicleList.SelectedRows[0].Cells["id"].Value;

                var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

                DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Delete",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    _db.TypesOfCars.Remove(car);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
