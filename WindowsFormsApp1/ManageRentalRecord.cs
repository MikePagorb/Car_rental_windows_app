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
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRentalEntities1 _db;
        public ManageRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            AddEditRentalRecord addRentalRecord = new AddEditRentalRecord
            {
                MdiParent = this.MdiParent
            };
            addRentalRecord.Show();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {

            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["id"].Value;

                var record = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                var addEditREntalRecord = new AddEditRentalRecord(record);
                addEditREntalRecord.MdiParent = this.MdiParent;
                addEditREntalRecord.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRecordList.SelectedRows[0].Cells["id"].Value;

                var car = _db.CarRentalRecords.FirstOrDefault(q => q.id == id);

                _db.CarRentalRecords.Remove(car);
                _db.SaveChanges();

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void ManageRentalRecord_Load(object sender, EventArgs e)
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

        public void PopulateGrid()
        {
            var records = _db.CarRentalRecords.Select(q => new
            {
                Customer = q.CustomerName,
                DateOut = q.DateRented,
                DateIn = q.DateReturned,
                Id = q.id,
                q.Cost,
                Car = q.TypesOfCar.Make + " " + q.TypesOfCar.Model
            }).ToList();

            gvRecordList.DataSource = records;
            gvRecordList.Columns["DateIn"].HeaderText = "Date In";
            gvRecordList.Columns["DateOut"].HeaderText = "Date Out";

            gvRecordList.Columns["Id"].Visible = false;
        }
    }
}
