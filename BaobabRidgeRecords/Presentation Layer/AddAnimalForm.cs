using BaobabRidgeRecords.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaobabRidgeRecords.Presentation_Layer
{
    public partial class AddAnimalForm : Form
    {
        public AddAnimalForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //inputs and validation
                string id = txtAnimalID.Text.Trim();
                string name = txtName.Text.Trim();
                string species = txtSpecies.Text.Trim();
                int age = (int)numAge.Value;
                int recoveryScore = (int)numRecoveryScore.Value;

                //check for empty fields
                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(species))
                {
                    MessageBox.Show("Please ensure all text boxes are filled in (ID, Name, and Species).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //validate animal ID format
                if (!Regex.IsMatch(id, @"^WR-\d{4}$"))
                {
                    MessageBox.Show("Animal ID must folllow the format WR-0000.", "Validation Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAnimalID.Focus();
                    return;
                }


                //trigger auto classification
                Animal newAnimal = new Animal(id, name, species, age, recoveryScore);


                //confirm success and display
                MessageBox.Show($"Animal successfully recorded.\n\nDetails:\n{newAnimal.ToString()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Recovery Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            numAge.Value = 0;
            numRecoveryScore.Value = 0;
            txtAnimalID.Focus();
        }
        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
            BusinessLayer businessLayer = new BusinessLayer();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessLayer.source();
        }
    }
}
