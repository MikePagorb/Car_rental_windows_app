namespace WindowsFormsApp1
{
    partial class AddRentalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCusctomerName = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.dateTimeRented = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReturned = new System.Windows.Forms.DateTimePicker();
            this.DateRentedLabel = new System.Windows.Forms.Label();
            this.dateReturnedLabel = new System.Windows.Forms.Label();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.typeOfCarLabel = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Rental Record";
            // 
            // tbCusctomerName
            // 
            this.tbCusctomerName.Location = new System.Drawing.Point(12, 159);
            this.tbCusctomerName.Name = "tbCusctomerName";
            this.tbCusctomerName.Size = new System.Drawing.Size(282, 22);
            this.tbCusctomerName.TabIndex = 1;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(12, 131);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(151, 25);
            this.CustomerNameLabel.TabIndex = 2;
            this.CustomerNameLabel.Text = "Customer name";
            // 
            // dateTimeRented
            // 
            this.dateTimeRented.Location = new System.Drawing.Point(12, 236);
            this.dateTimeRented.Name = "dateTimeRented";
            this.dateTimeRented.Size = new System.Drawing.Size(282, 22);
            this.dateTimeRented.TabIndex = 3;
            // 
            // dateTimeReturned
            // 
            this.dateTimeReturned.Location = new System.Drawing.Point(418, 236);
            this.dateTimeReturned.Name = "dateTimeReturned";
            this.dateTimeReturned.Size = new System.Drawing.Size(282, 22);
            this.dateTimeReturned.TabIndex = 4;
            // 
            // DateRentedLabel
            // 
            this.DateRentedLabel.AutoSize = true;
            this.DateRentedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRentedLabel.Location = new System.Drawing.Point(12, 208);
            this.DateRentedLabel.Name = "DateRentedLabel";
            this.DateRentedLabel.Size = new System.Drawing.Size(120, 25);
            this.DateRentedLabel.TabIndex = 5;
            this.DateRentedLabel.Text = "Date Rented";
            // 
            // dateReturnedLabel
            // 
            this.dateReturnedLabel.AutoSize = true;
            this.dateReturnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturnedLabel.Location = new System.Drawing.Point(413, 208);
            this.dateReturnedLabel.Name = "dateReturnedLabel";
            this.dateReturnedLabel.Size = new System.Drawing.Size(137, 25);
            this.dateReturnedLabel.TabIndex = 6;
            this.dateReturnedLabel.Text = "Date Returned";
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(12, 325);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(282, 24);
            this.cbTypeOfCar.TabIndex = 7;
            // 
            // typeOfCarLabel
            // 
            this.typeOfCarLabel.AutoSize = true;
            this.typeOfCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfCarLabel.Location = new System.Drawing.Point(7, 297);
            this.typeOfCarLabel.Name = "typeOfCarLabel";
            this.typeOfCarLabel.Size = new System.Drawing.Size(120, 25);
            this.typeOfCarLabel.TabIndex = 8;
            this.typeOfCarLabel.Text = "Type Of Car";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Matura MT Script Capitals", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(454, 296);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(201, 72);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(418, 158);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(282, 22);
            this.tbCost.TabIndex = 10;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(413, 130);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(53, 25);
            this.labelCost.TabIndex = 11;
            this.labelCost.Text = "Cost";
            // 
            // AddRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.typeOfCarLabel);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.dateReturnedLabel);
            this.Controls.Add(this.DateRentedLabel);
            this.Controls.Add(this.dateTimeReturned);
            this.Controls.Add(this.dateTimeRented);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.tbCusctomerName);
            this.Controls.Add(this.label1);
            this.Name = "AddRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.TextBox tbCusctomerName;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.DateTimePicker dateTimeRented;
        private System.Windows.Forms.DateTimePicker dateTimeReturned;
        private System.Windows.Forms.Label DateRentedLabel;
        private System.Windows.Forms.Label dateReturnedLabel;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
        private System.Windows.Forms.Label typeOfCarLabel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label labelCost;
    }
}