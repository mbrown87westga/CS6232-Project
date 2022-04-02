﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class FurnitureSearchForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static FurnitureBusiness _furnitureBusiness;
        private static List<Furniture> _furnitureList;
        private static List<string> _categoryList;
        private static List<string> _styleList;
        private static Employee _admin;

        public FurnitureSearchForm()
        {
            _loginBusiness = new LoginBusiness();
            _furnitureBusiness = new FurnitureBusiness();

            InitializeComponent();
        }

        private void FurnitureSearchForm_Activated(object sender, System.EventArgs e)
        {
            _admin = _loginBusiness.GetLoggedInUser();

            this.adminIDLabel.Text = _admin.FirstName + " " + _admin.LastName + " (" + _admin.UserName + ")";
        }

        private void FurnitureSearchForm_Load(object sender, System.EventArgs e)
        {            
            _furnitureList = _furnitureBusiness.GetAllFurniture();
            this.furnitureDataGridView.DataSource = _furnitureList;

            this.LoadIDListBox();
            this.LoadCategoryListBox();
            this.LoadStyleListBox();
        }

        private void LoadIDListBox()
        {
            try
            {
                furnitureIDComboBox.DataSource = null;
                furnitureIDComboBox.DataSource = _furnitureList;
                furnitureIDComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoadCategoryListBox()
        {
            try
            {
                _categoryList = _furnitureBusiness.GetCategories();
                categoryComboBox.DataSource = _categoryList;
                categoryComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoadStyleListBox()
        {
            try
            {
                _styleList = _furnitureBusiness.GetStyles();
                styleComboBox.DataSource = _styleList;
                styleComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void FurnitureSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int? furnitureID = (int?)this.furnitureIDComboBox.SelectedValue;

            try
            {
                _furnitureList = _furnitureBusiness.FindFurniture(furnitureID, nameTextBox.Text, descriptionTextBox.Text,
                                                                  categoryComboBox.SelectedIndex < 0 ? "" : categoryComboBox.SelectedValue.ToString(),
                                                                  styleComboBox.SelectedIndex < 0 ? "" : styleComboBox.SelectedValue.ToString());
                if (_furnitureList.Count > 0)
                {
                    furnitureDataGridView.DataSource = _furnitureList;
                }
                else
                {
                    MessageBox.Show("No furniture found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _furnitureList = _furnitureBusiness.GetAllFurniture();
            furnitureDataGridView.DataSource = _furnitureList;

            this.furnitureIDComboBox.SelectedIndex = -1;
            this.categoryComboBox.SelectedIndex = -1;
            this.styleComboBox.SelectedIndex = -1;
            this.nameTextBox.Text = "";
            this.descriptionTextBox.Text = "";
        }
    }
}
