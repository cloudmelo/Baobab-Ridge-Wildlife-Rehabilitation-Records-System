namespace BaobabRidgeRecords.Presentation_Layer
{
    partial class AddAnimalForm
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
            lblAnimalID = new Label();
            lblName = new Label();
            lblSpecies = new Label();
            lblAge = new Label();
            lblRecoveryScore = new Label();
            btnSave = new Button();
            btnClear = new Button();
            txtAnimalID = new TextBox();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            numAge = new NumericUpDown();
            numRecoveryScore = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnSummary = new Button();
            lblSummary = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(66, 52);
            lblAnimalID.Margin = new Padding(4, 0, 4, 0);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(94, 25);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(550, 58);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(70, 205);
            lblSpecies.Margin = new Padding(4, 0, 4, 0);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(75, 25);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(550, 213);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(48, 25);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(69, 360);
            lblRecoveryScore.Margin = new Padding(4, 0, 4, 0);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(198, 25);
            lblRecoveryScore.TabIndex = 4;
            lblRecoveryScore.Text = "Recovery Score (0-100):";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(66, 487);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Animal";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(550, 487);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 37);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(306, 52);
            txtAnimalID.Margin = new Padding(4, 3, 4, 3);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(155, 31);
            txtAnimalID.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(706, 55);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 31);
            txtName.TabIndex = 8;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(306, 208);
            txtSpecies.Margin = new Padding(4, 3, 4, 3);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(155, 31);
            txtSpecies.TabIndex = 9;
            // 
            // numAge
            // 
            numAge.Location = new Point(706, 210);
            numAge.Margin = new Padding(4, 3, 4, 3);
            numAge.Name = "numAge";
            numAge.Size = new Size(187, 31);
            numAge.TabIndex = 10;
            // 
            // numRecoveryScore
            // 
            numRecoveryScore.Location = new Point(306, 352);
            numRecoveryScore.Margin = new Padding(4, 3, 4, 3);
            numRecoveryScore.Name = "numRecoveryScore";
            numRecoveryScore.Size = new Size(187, 31);
            numRecoveryScore.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 597);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1027, 250);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(346, 487);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 37);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(740, 487);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(121, 42);
            btnSummary.TabIndex = 14;
            btnSummary.Text = "Summary";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(1458, 117);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(162, 30);
            lblSummary.TabIndex = 15;
            lblSummary.Text = "Summary Label";
            lblSummary.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1929, 900);
            Controls.Add(lblSummary);
            Controls.Add(btnSummary);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(numRecoveryScore);
            Controls.Add(numAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(txtAnimalID);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(lblRecoveryScore);
            Controls.Add(lblAge);
            Controls.Add(lblSpecies);
            Controls.Add(lblName);
            Controls.Add(lblAnimalID);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddAnimalForm";
            Text = "AddAnimalForm";
            Load += AddAnimalForm_Load;
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnimalID;
        private Label lblName;
        private Label lblSpecies;
        private Label lblAge;
        private Label lblRecoveryScore;
        private Button btnSave;
        private Button btnClear;
        private TextBox txtAnimalID;
        private TextBox txtName;
        private TextBox txtSpecies;
        private NumericUpDown numAge;
        private NumericUpDown numRecoveryScore;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnSummary;
        private Label lblSummary;
    }
}