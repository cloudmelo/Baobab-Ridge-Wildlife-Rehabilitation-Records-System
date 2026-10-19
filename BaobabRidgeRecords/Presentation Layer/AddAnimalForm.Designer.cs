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
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(46, 31);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(62, 15);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(385, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(49, 123);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(49, 15);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(385, 128);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(48, 216);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(130, 15);
            lblRecoveryScore.TabIndex = 4;
            lblRecoveryScore.Text = "Recovery Score (0-100):";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(46, 292);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 22);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Animal";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(385, 292);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(214, 31);
            txtAnimalID.Margin = new Padding(3, 2, 3, 2);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(110, 23);
            txtAnimalID.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(494, 33);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 8;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(214, 125);
            txtSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(110, 23);
            txtSpecies.TabIndex = 9;
            // 
            // numAge
            // 
            numAge.Location = new Point(494, 126);
            numAge.Margin = new Padding(3, 2, 3, 2);
            numAge.Name = "numAge";
            numAge.Size = new Size(131, 23);
            numAge.TabIndex = 10;
            // 
            // numRecoveryScore
            // 
            numRecoveryScore.Location = new Point(214, 211);
            numRecoveryScore.Margin = new Padding(3, 2, 3, 2);
            numRecoveryScore.Name = "numRecoveryScore";
            numRecoveryScore.Size = new Size(131, 23);
            numRecoveryScore.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 341);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(599, 150);
            dataGridView1.TabIndex = 12;
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1448, 540);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}