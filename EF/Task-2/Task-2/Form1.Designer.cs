namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            IdTB = new TextBox();
            NameTB = new TextBox();
            label2 = new Label();
            SalaryTB = new TextBox();
            label3 = new Label();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            DisplayButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(564, 366);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(704, 55);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // IdTB
            // 
            IdTB.Location = new Point(790, 52);
            IdTB.Name = "IdTB";
            IdTB.Size = new Size(125, 27);
            IdTB.TabIndex = 2;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(790, 151);
            NameTB.Name = "NameTB";
            NameTB.Size = new Size(125, 27);
            NameTB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(704, 154);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // SalaryTB
            // 
            SalaryTB.Location = new Point(790, 230);
            SalaryTB.Name = "SalaryTB";
            SalaryTB.Size = new Size(125, 27);
            SalaryTB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(704, 233);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Salary";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(691, 368);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(853, 368);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(1032, 368);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(290, 422);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(94, 29);
            DisplayButton.TabIndex = 10;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 613);
            Controls.Add(DisplayButton);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(SalaryTB);
            Controls.Add(label3);
            Controls.Add(NameTB);
            Controls.Add(label2);
            Controls.Add(IdTB);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox IdTB;
        private TextBox NameTB;
        private Label label2;
        private TextBox SalaryTB;
        private Label label3;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Button DisplayButton;
    }
}
