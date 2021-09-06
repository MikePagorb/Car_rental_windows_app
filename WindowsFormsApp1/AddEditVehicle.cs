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
        private ManageVehicleListing _manageVehicleListing;
        private readonly CarRentalEntities1 _db;
        public AddEditVehicle(ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Vehicle";
            this.Text = "Add New Vehicle";
            isEditMode = false;
            _manageVehicleListing = manageVehicleListing;
            _db = new CarRentalEntities1();

        }

        public AddEditVehicle(TypesOfCar carEdit, ManageVehicleListing manageVehicleListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";
            _manageVehicleListing = manageVehicleListing;
            if (carEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new CarRentalEntities1();
                PopulateFields(carEdit);
            }
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

                    }

                    _db.SaveChanges();
                    _manageVehicleListing.PopulateGrid();
                    //MessageBox.Show("Please, In Manage Vehicle window refresh a table");
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
