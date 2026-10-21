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

        private string orginalAnimalID = "";

        private bool editMode = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtAnimalID.Text.Trim();
                string name = txtName.Text.Trim();
                string species = txtSpecies.Text.Trim();
                int age = (int)numAge.Value;
                int recoveryScore = (int)numRecoveryScore.Value;

                // Validate required fields.
                if (string.IsNullOrWhiteSpace(id) ||
                    string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(species))
                {
                    MessageBox.Show(
                        "Please fill in the ID, Name, and Species.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validate the animal ID format.
                if (!Regex.IsMatch(id, @"^WR-\d{4}$"))
                {
                    MessageBox.Show(
                        "Animal ID must follow the format WR-0000.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAnimalID.Focus();
                    return;
                }

                // Create the animal. Classification is handled by the Animal class.
                Animal updatedAnimal = new Animal(
                    id, name, species, age, recoveryScore);

                // Connect to the Business Layer.
                BusinessLayer businessLayer = new BusinessLayer();

                string result;

                if (editMode)
                {
                    result = businessLayer.UpdateAnimal(
                        orginalAnimalID, updatedAnimal);
                }
                else
                {
                    result = businessLayer.AddAnimal(updatedAnimal);
                }

                // Display the result from the Data Layer.
                MessageBox.Show(
                    result,
                    "Update Animal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Refresh the table.
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = businessLayer.source();

                // Return the form to Add mode.
                ClearForm();
                editMode = false;
                orginalAnimalID = "";
                txtAnimalID.ReadOnly = false;
                btnSave.Text = "Save";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Invalid Recovery Score",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An unexpected error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

            // Return to Add mode.
            editMode = false;
            orginalAnimalID = "";
            txtAnimalID.ReadOnly = false;
            btnSave.Text = "Save";

            txtAnimalID.Focus();
        }
        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
            BusinessLayer businessLayer = new BusinessLayer();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = businessLayer.source();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtAnimalID.Text = row.Cells["AnimalID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSpecies.Text = row.Cells["Species"].Value.ToString();

                if (row.Cells["Age"].Value != null)
                    numAge.Value = Convert.ToDecimal(row.Cells["Age"].Value);

                if (row.Cells["RecoveryScore"].Value != null)
                    numRecoveryScore.Value = Convert.ToDecimal(row.Cells["RecoveryScore"].Value);

                orginalAnimalID = txtAnimalID.Text;
                editMode = true;

                txtAnimalID.ReadOnly = true;

                btnSave.Text = "Save Changes";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure an animal is selected.
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                {
                    MessageBox.Show(
                        "Please select an animal to delete.",
                        "Delete Animal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }


                // Get the selected animal ID.
                string animalID = dataGridView1.CurrentRow.Cells["AnimalID"].Value?.ToString() ?? "";
                string animalName = dataGridView1.CurrentRow.Cells["Name"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(animalID))
                {
                    MessageBox.Show(
                        "Selected animal does not have a valid ID.",
                        "Delete Animal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // ask for confiramtion before delete
                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete the animal '{animalName}' (ID: {animalID})?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult != DialogResult.Yes)
                    return;

                // Delete the animal using the Business Layer.
                BusinessLayer businessLayer = new BusinessLayer();
                string result = businessLayer.DeleteAnimal(animalID);

                MessageBox.Show(
                    result,
                    "Delete Animal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Refresh the table.
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = businessLayer.source();

                if (editMode && animalID == orginalAnimalID)
                {
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An unexpected error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLayer businessLayer = new BusinessLayer();
                List<Animal> animals = businessLayer.GetAnimals();

                int total = animals.Count;
                int critCount = 0;
                int seriousCount = 0;
                int stableCount = 0;
                int recovCount = 0;
                int releaseCount = 0;

                double totalAge = 0;
                double totalScore = 0;

                foreach (Animal a in animals)
                {
                    totalAge += a.Age;
                    totalScore += a.RecoveryScore;

                    if (a.Status == "Critical")
                        critCount++;
                    else if (a.Status == "Serious")
                        seriousCount++;
                    else if (a.Status == "Stable")
                        stableCount++;
                    else if (a.Status == "Recovering")
                        recovCount++;
                    else if (a.Status == "Release-Ready")
                        releaseCount++;
                }

                string averageAge = "N/A";
                string averageScore = "N/A";


                if (total > 0)
                {
                    averageAge = (totalAge / total).ToString("0.00");
                    averageScore = (totalScore / total).ToString("0.00");
                }

                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                lblSummary.Text =
            $"ANIMAL SUMMARY REPORT: BAOBAB RIDGE WILDLIFE REHABILITATION CENTRE\n" +
            $"Generated: {timestamp}\n\n" +
            $"------------------------------------\n" +
            
            $"Total animals: {total}\n" +
            $"Average age (years): {averageAge}\n" +
            $"Average recovery score: {averageScore}\n\n" +
            $"------------------------------------\n" +
            $"Animals per status:\n" +
            $"  Critical: {critCount}\n" +
            $"  Serious: {seriousCount}\n" +
            $"  Stable: {stableCount}\n" +
            $"  Recovering: {recovCount}\n" +
            $"  Release-Ready: {releaseCount}";

                bool saved = businessLayer.MakeSummary(
                    total,
                    averageAge,
                    averageScore,
                    critCount,
                    seriousCount,
                    stableCount,
                    recovCount,
                    releaseCount);

                if (saved)
                {
                    MessageBox.Show("Summary report generated and saved to summary.txt.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Summary Report could not be generated due to:" + ex.Message
                    );
            }


        }
    }
}
