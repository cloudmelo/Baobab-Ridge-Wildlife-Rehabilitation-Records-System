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
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).BeginInit();
            SuspendLayout();
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(52, 41);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(78, 20);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(440, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(56, 164);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(62, 20);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(440, 170);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(55, 288);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(165, 20);
            lblRecoveryScore.TabIndex = 4;
            lblRecoveryScore.Text = "Recovery Score (0-100):";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(52, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Animal";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(440, 390);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(244, 41);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(125, 27);
            txtAnimalID.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(564, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 8;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(244, 167);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(125, 27);
            txtSpecies.TabIndex = 9;
            // 
            // numAge
            // 
            numAge.Location = new Point(564, 168);
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 27);
            numAge.TabIndex = 10;
            // 
            // numRecoveryScore
            // 
            numRecoveryScore.Location = new Point(244, 281);
            numRecoveryScore.Name = "numRecoveryScore";
            numRecoveryScore.Size = new Size(150, 27);
            numRecoveryScore.TabIndex = 11;
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "AddAnimalForm";
            Text = "AddAnimalForm";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).EndInit();
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
    }
}