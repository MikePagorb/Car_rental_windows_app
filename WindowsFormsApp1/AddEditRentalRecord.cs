using System;
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
    public partial class AddEditRentalRecord : Form
    {
        private bool isEditMode;
        private ManageRentalRecord _manageRentalRecords;
        private readonly CarRentalEntities1 carRentalEntities;
        public AddEditRentalRecord(ManageRentalRecord manageRentalRecords=null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Rental";
            this.Text = "Add New Rental";
            isEditMode = false;
            _manageRentalRecords = manageRentalRecords;
            carRentalEntities = new CarRentalEntities1();
        }

        public AddEditRentalRecord(CarRentalRecord recordToEdit, ManageRentalRecord manageRentalRecord = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit New Rental";
            this.Text = "Edit New Rental";
            _manageRentalRecords = manageRentalRecord;
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                carRentalEntities = new CarRentalEntities1();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(CarRentalRecord recordToEdit)
        {
            tbCusctomerName.Text = recordToEdit.CustomerName;
            dateTimeRented.Value = (DateTime)recordToEdit.DateRented;
            dateTimeReturned.Value = (DateTime)recordToEdit.DateReturned;
            tbCost.Text = recordToEdit.Cost.ToString();
            lblRecordId.Text = recordToEdit.id.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCusctomerName.Text;
                var dateOut = dateTimeRented.Value;
                var dateIn = dateTimeReturned.Value;
                double cost = Convert.ToDouble(tbCost.Text);

                var carType = cbTypeOfCar.Text;
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter customer name and type of car\n\r";
                }

                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal Date Selection.\n\r";
                }

                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    if (isEditMode)
                    {
                        var id = int.Parse(lblRecordId.Text);
                        rentalRecord = carRentalEntities.CarRentalRecords.FirstOrDefault(q => q.id == id);
                    }

                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = Convert.ToDecimal(cost);
                    rentalRecord.TypeOfCarId = (int)cbTypeOfCar.SelectedValue;

                    if (!isEditMode)
                    {
                        carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    }

                    carRentalEntities.SaveChanges();
                    _manageRentalRecords.PopulateGrid();

                    MessageBox.Show($"Customer name: {customerName}\n\r" +
                                    $"Date Rented: {dateOut}\n\r" +
                                    $"Date Returned: {dateIn}\n\r" +
                                    $"Cost: {cost}\n\r" +
                                    $"Car Type: {carType}\n\r" +
                                    $"THANK YU FOR YOUR BUSINESS!!!");

                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var cars = carRentalEntities.TypesOfCars.ToList();

            var cars = carRentalEntities.TypesOfCars
                .Select(q => new
                {
                    Id = q.id,
                    Name = q.Make + " " + q.Model,

                })
                .ToList();
            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember = "id";
            cbTypeOfCar.DataSource = cars;
        }
    }
}