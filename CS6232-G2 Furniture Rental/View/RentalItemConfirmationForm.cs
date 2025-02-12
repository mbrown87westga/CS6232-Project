﻿using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// Form for confirming a rental item
    /// </summary>
    public partial class RentalItemConfirmationForm : Form
    {
        private static Furniture _furniture;

        /// <summary>
        /// Rental item confirmation form constructor
        /// </summary>
        public RentalItemConfirmationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The item ready to add to cart after confirmation
        /// </summary>
        public RentalItem Result { get; set; }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Result = null;

            this.HideThisAndShowForm<FurnitureSearchForm>();
        }

        private void RentalItemConfirmationForm_Load(object sender, EventArgs e)
        {
            _furniture = (Furniture)new FurnitureSearchForm().furniture.ShallowCopy();

            furnitureIDTextBox.Text = _furniture.FurnitureID.ToString();
            nameTextBox.Text = _furniture.Name;
            descriptionTextBox.Text = _furniture.Description;
            dailyRateMaskedTextBox.Text = _furniture.DailyRentalRate.ToString();
            quantityAvailableTextBox.Text = _furniture.QuantityAvailable.ToString();
            rentalQuantityTextBox.Select();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rentalQuantityTextBox.Text))
            {
                MessageBox.Show("Please enter a rental quantity!", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Int32.Parse(rentalQuantityTextBox.Text) <= 0)
            {
                MessageBox.Show("Please enter a rental quantity > 0!", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Int32.Parse(rentalQuantityTextBox.Text) > _furniture.QuantityAvailable)
            {
                MessageBox.Show("Cannot rent more than the quantity available!", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Result = new RentalItem
                {
                    FurnitureID = _furniture.FurnitureID,
                    Quantity = Int32.Parse(rentalQuantityTextBox.Text),
                    DailyRentalRate = _furniture.DailyRentalRate
                };
                this.Close();
            }
        }
    }
}
