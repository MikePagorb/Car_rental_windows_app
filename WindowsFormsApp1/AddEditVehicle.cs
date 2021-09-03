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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities1 _db = new CarRentalEntities1();
        public AddEditVehicle()
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            isEditMode = false;

        }

        public AddEditVehicle(TypesOfCar carEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            isEditMode = true;
            _db = new CarRentalEntities1();
            PopulateFields(carEdit);
        }

        private void PopulateFields(TypesOfCar car)
        {
            lblId.Text = car.id.ToString();
            tbMake.Text = car.Make;
            tbModel.Text = car.Model;
            tbLicenseNum.Text = car.LicensePlateNumber;
            tbVIN.Text = car.VIN;
            tbYear.Text = car.Year.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "";
                bool isValid = true;
                if (string.IsNullOrWhiteSpace(tbModel.Text) || string.IsNullOrWhiteSpace(tbMake.Text))
                {
                    isValid = false;
                    message += "Please enter Car Make and Model\n\r";
                }

                if (isValid)
                {
                    if (isEditMode)
                    {
                        var id = int.Parse(lblId.Text);
                        var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);
                        car.Model = tbModel.Text;
                        car.Make = tbMake.Text;
                        car.VIN = tbVIN.Text;
                        car.LicensePlateNumber = tbLicenseNum.Text;
                        car.Year = int.Parse(tbYear.Text);

                        _db.SaveChanges();
                    }
                    else
                    {
                        var newCar = new TypesOfCar
                        {
                            LicensePlateNumber = tbLicenseNum.Text,
                            Make = tbMake.Text,
                            Model = tbModel.Text,
                            VIN = tbVIN.Text,
                            Year = int.Parse(tbYear.Text)
                        };

                        _db.TypesOfCars.Add(newCar);
                        _db.SaveChanges();
                    }

                    MessageBox.Show("Please, In Manage Vehicle window refresh a table");
                    Close();
                }
                else
                {
                    MessageBox.Show(message);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
