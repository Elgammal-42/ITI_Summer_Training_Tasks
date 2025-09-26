namespace Task_3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EmpIdTB = new TextBox();
            EmpNameTB = new TextBox();
            EmpSalaryTB = new TextBox();
            DepIdTB = new TextBox();
            DepNameTB = new TextBox();
            EmpInsertButton = new Button();
            EmpUpdateButton = new Button();
            EmpDeleteButton = new Button();
            dataGridView2 = new DataGridView();
            DepDeleteButton = new Button();
            DepUpdateButton = new Button();
            DepInsertButton = new Button();
            EmpDepNoTB = new TextBox();
            label6 = new Label();
            DisplayButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(856, 250);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(963, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "EmpId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(963, 90);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(963, 146);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Salary:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(963, 390);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "DepId:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(963, 462);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 5;
            label5.Text = "Name:";
            // 
            // EmpIdTB
            // 
            EmpIdTB.Location = new Point(1091, 40);
            EmpIdTB.Name = "EmpIdTB";
            EmpIdTB.Size = new Size(125, 27);
            EmpIdTB.TabIndex = 6;
            // 
            // EmpNameTB
            // 
            EmpNameTB.Location = new Point(1091, 90);
            EmpNameTB.Name = "EmpNameTB";
            EmpNameTB.Size = new Size(125, 27);
            EmpNameTB.TabIndex = 7;
            // 
            // EmpSalaryTB
            // 
            EmpSalaryTB.Location = new Point(1091, 143);
            EmpSalaryTB.Name = "EmpSalaryTB";
            EmpSalaryTB.Size = new Size(125, 27);
            EmpSalaryTB.TabIndex = 8;
            // 
            // DepIdTB
            // 
            DepIdTB.Location = new Point(1091, 383);
            DepIdTB.Name = "DepIdTB";
            DepIdTB.Size = new Size(125, 27);
            DepIdTB.TabIndex = 9;
            // 
            // DepNameTB
            // 
            DepNameTB.Location = new Point(1091, 455);
            DepNameTB.Name = "DepNameTB";
            DepNameTB.Size = new Size(125, 27);
            DepNameTB.TabIndex = 10;
            // 
            // EmpInsertButton
            // 
            EmpInsertButton.Location = new Point(934, 255);
            EmpInsertButton.Name = "EmpInsertButton";
            EmpInsertButton.Size = new Size(94, 29);
            EmpInsertButton.TabIndex = 11;
            EmpInsertButton.Text = "Insert";
            EmpInsertButton.UseVisualStyleBackColor = true;
            EmpInsertButton.Click += EmpInsertButton_Click;
            // 
            // EmpUpdateButton
            // 
            EmpUpdateButton.Location = new Point(1080, 255);
            EmpUpdateButton.Name = "EmpUpdateButton";
            EmpUpdateButton.Size = new Size(94, 29);
            EmpUpdateButton.TabIndex = 12;
            EmpUpdateButton.Text = "Update";
            EmpUpdateButton.UseVisualStyleBackColor = true;
            EmpUpdateButton.Click += EmpUpdateButton_Click;
            // 
            // EmpDeleteButton
            // 
            EmpDeleteButton.Location = new Point(1222, 255);
            EmpDeleteButton.Name = "EmpDeleteButton";
            EmpDeleteButton.Size = new Size(94, 29);
            EmpDeleteButton.TabIndex = 13;
            EmpDeleteButton.Text = "Delete";
            EmpDeleteButton.UseVisualStyleBackColor = true;
            EmpDeleteButton.Click += EmpDeleteButton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(38, 373);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(856, 250);
            dataGridView2.TabIndex = 14;
            // 
            // DepDeleteButton
            // 
            DepDeleteButton.Location = new Point(1222, 553);
            DepDeleteButton.Name = "DepDeleteButton";
            DepDeleteButton.Size = new Size(94, 29);
            DepDeleteButton.TabIndex = 17;
            DepDeleteButton.Text = "Delete";
            DepDeleteButton.UseVisualStyleBackColor = true;
            DepDeleteButton.Click += DepDeleteButton_Click;
            // 
            // DepUpdateButton
            // 
            DepUpdateButton.Location = new Point(1080, 553);
            DepUpdateButton.Name = "DepUpdateButton";
            DepUpdateButton.Size = new Size(94, 29);
            DepUpdateButton.TabIndex = 16;
            DepUpdateButton.Text = "Update";
            DepUpdateButton.UseVisualStyleBackColor = true;
            DepUpdateButton.Click += DepUpdateButton_Click;
            // 
            // DepInsertButton
            // 
            DepInsertButton.Location = new Point(934, 553);
            DepInsertButton.Name = "DepInsertButton";
            DepInsertButton.Size = new Size(94, 29);
            DepInsertButton.TabIndex = 15;
            DepInsertButton.Text = "Insert";
            DepInsertButton.UseVisualStyleBackColor = true;
            DepInsertButton.Click += DepInsertButton_Click;
            // 
            // EmpDepNoTB
            // 
            EmpDepNoTB.Location = new Point(1091, 197);
            EmpDepNoTB.Name = "EmpDepNoTB";
            EmpDepNoTB.Size = new Size(125, 27);
            EmpDepNoTB.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(963, 200);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 18;
            label6.Text = "DepNo:";
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(420, 313);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(94, 29);
            DisplayButton.TabIndex = 20;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 665);
            Controls.Add(DisplayButton);
            Controls.Add(EmpDepNoTB);
            Controls.Add(label6);
            Controls.Add(DepDeleteButton);
            Controls.Add(DepUpdateButton);
            Controls.Add(DepInsertButton);
            Controls.Add(dataGridView2);
            Controls.Add(EmpDeleteButton);
            Controls.Add(EmpUpdateButton);
            Controls.Add(EmpInsertButton);
            Controls.Add(DepNameTB);
            Controls.Add(DepIdTB);
            Controls.Add(EmpSalaryTB);
            Controls.Add(EmpNameTB);
            Controls.Add(EmpIdTB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox EmpIdTB;
        private TextBox EmpNameTB;
        private TextBox EmpSalaryTB;
        private TextBox DepIdTB;
        private TextBox DepNameTB;
        private Button EmpInsertButton;
        private Button EmpUpdateButton;
        private Button EmpDeleteButton;
        private DataGridView dataGridView2;
        private Button DepDeleteButton;
        private Button DepUpdateButton;
        private Button DepInsertButton;
        private TextBox EmpDepNoTB;
        private Label label6;
        private Button DisplayButton;
    }
}
