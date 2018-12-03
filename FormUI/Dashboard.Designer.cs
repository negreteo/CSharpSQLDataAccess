namespace FormUI
{
    partial class Dashboard
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
      this.peopleFoundListBox = new System.Windows.Forms.ListBox();
      this.lastNameText = new System.Windows.Forms.TextBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.searchButton = new System.Windows.Forms.Button();
      this.insertRecordButton = new System.Windows.Forms.Button();
      this.firstNameInsLabel = new System.Windows.Forms.Label();
      this.firstNameInsText = new System.Windows.Forms.TextBox();
      this.lastNameInsLabel = new System.Windows.Forms.Label();
      this.lastNameInsText = new System.Windows.Forms.TextBox();
      this.eMailInsLabel = new System.Windows.Forms.Label();
      this.emailInsText = new System.Windows.Forms.TextBox();
      this.phoneInsLabel = new System.Windows.Forms.Label();
      this.phoneInsText = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // peopleFoundListBox
      // 
      this.peopleFoundListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.peopleFoundListBox.FormattingEnabled = true;
      this.peopleFoundListBox.ItemHeight = 16;
      this.peopleFoundListBox.Location = new System.Drawing.Point(49, 79);
      this.peopleFoundListBox.Name = "peopleFoundListBox";
      this.peopleFoundListBox.Size = new System.Drawing.Size(450, 164);
      this.peopleFoundListBox.TabIndex = 0;
      // 
      // lastNameText
      // 
      this.lastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameText.Location = new System.Drawing.Point(125, 34);
      this.lastNameText.Name = "lastNameText";
      this.lastNameText.Size = new System.Drawing.Size(155, 22);
      this.lastNameText.TabIndex = 1;
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameLabel.Location = new System.Drawing.Point(46, 37);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(73, 16);
      this.lastNameLabel.TabIndex = 2;
      this.lastNameLabel.Text = "Last Name";
      // 
      // searchButton
      // 
      this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.searchButton.Location = new System.Drawing.Point(286, 34);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(62, 23);
      this.searchButton.TabIndex = 3;
      this.searchButton.Text = "Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // insertRecordButton
      // 
      this.insertRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.insertRecordButton.Location = new System.Drawing.Point(369, 369);
      this.insertRecordButton.Name = "insertRecordButton";
      this.insertRecordButton.Size = new System.Drawing.Size(62, 23);
      this.insertRecordButton.TabIndex = 8;
      this.insertRecordButton.Text = "Insert";
      this.insertRecordButton.UseVisualStyleBackColor = true;
      this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
      // 
      // firstNameInsLabel
      // 
      this.firstNameInsLabel.AutoEllipsis = true;
      this.firstNameInsLabel.AutoSize = true;
      this.firstNameInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstNameInsLabel.Location = new System.Drawing.Point(56, 287);
      this.firstNameInsLabel.Name = "firstNameInsLabel";
      this.firstNameInsLabel.Size = new System.Drawing.Size(73, 16);
      this.firstNameInsLabel.TabIndex = 5;
      this.firstNameInsLabel.Text = "First Name";
      // 
      // firstNameInsText
      // 
      this.firstNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstNameInsText.Location = new System.Drawing.Point(160, 284);
      this.firstNameInsText.Name = "firstNameInsText";
      this.firstNameInsText.Size = new System.Drawing.Size(155, 22);
      this.firstNameInsText.TabIndex = 4;
      // 
      // lastNameInsLabel
      // 
      this.lastNameInsLabel.AutoSize = true;
      this.lastNameInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameInsLabel.Location = new System.Drawing.Point(56, 317);
      this.lastNameInsLabel.Name = "lastNameInsLabel";
      this.lastNameInsLabel.Size = new System.Drawing.Size(73, 16);
      this.lastNameInsLabel.TabIndex = 8;
      this.lastNameInsLabel.Text = "Last Name";
      // 
      // lastNameInsText
      // 
      this.lastNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameInsText.Location = new System.Drawing.Point(160, 314);
      this.lastNameInsText.Name = "lastNameInsText";
      this.lastNameInsText.Size = new System.Drawing.Size(155, 22);
      this.lastNameInsText.TabIndex = 5;
      // 
      // eMailInsLabel
      // 
      this.eMailInsLabel.AutoSize = true;
      this.eMailInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.eMailInsLabel.Location = new System.Drawing.Point(56, 345);
      this.eMailInsLabel.Name = "eMailInsLabel";
      this.eMailInsLabel.Size = new System.Drawing.Size(42, 16);
      this.eMailInsLabel.TabIndex = 10;
      this.eMailInsLabel.Text = "Email";
      // 
      // emailInsText
      // 
      this.emailInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailInsText.Location = new System.Drawing.Point(160, 342);
      this.emailInsText.Name = "emailInsText";
      this.emailInsText.Size = new System.Drawing.Size(155, 22);
      this.emailInsText.TabIndex = 6;
      // 
      // phoneInsLabel
      // 
      this.phoneInsLabel.AutoSize = true;
      this.phoneInsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.phoneInsLabel.Location = new System.Drawing.Point(56, 373);
      this.phoneInsLabel.Name = "phoneInsLabel";
      this.phoneInsLabel.Size = new System.Drawing.Size(98, 16);
      this.phoneInsLabel.TabIndex = 12;
      this.phoneInsLabel.Text = "Phone Number";
      // 
      // phoneInsText
      // 
      this.phoneInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.phoneInsText.Location = new System.Drawing.Point(160, 370);
      this.phoneInsText.Name = "phoneInsText";
      this.phoneInsText.Size = new System.Drawing.Size(155, 22);
      this.phoneInsText.TabIndex = 7;
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(547, 462);
      this.Controls.Add(this.phoneInsLabel);
      this.Controls.Add(this.phoneInsText);
      this.Controls.Add(this.eMailInsLabel);
      this.Controls.Add(this.emailInsText);
      this.Controls.Add(this.lastNameInsLabel);
      this.Controls.Add(this.lastNameInsText);
      this.Controls.Add(this.insertRecordButton);
      this.Controls.Add(this.firstNameInsLabel);
      this.Controls.Add(this.firstNameInsText);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.lastNameLabel);
      this.Controls.Add(this.lastNameText);
      this.Controls.Add(this.peopleFoundListBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Dashboard";
      this.Text = "SQL Data Access Demo";
      this.Load += new System.EventHandler(this.Dashboard_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label eMailInsLabel;
        private System.Windows.Forms.TextBox emailInsText;
        private System.Windows.Forms.Label phoneInsLabel;
        private System.Windows.Forms.TextBox phoneInsText;
    }
}

