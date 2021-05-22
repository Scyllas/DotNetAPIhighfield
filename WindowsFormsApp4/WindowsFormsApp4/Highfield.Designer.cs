namespace HighfieldTechTest
{
    partial class Highfield
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
            this.getData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_AgePlusTwentyTwo = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgePlusTwenty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_TopColours = new System.Windows.Forms.DataGridView();
            this.Colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendResponse = new System.Windows.Forms.Button();
            this.dgv_UserEntities = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FavouriteColour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AgePlusTwentyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TopColours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserEntities)).BeginInit();
            this.SuspendLayout();
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(12, 12);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(118, 43);
            this.getData.TabIndex = 0;
            this.getData.Text = "Get Data";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.GetData_ClickAsync);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Process Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ProcessData_Click);
            // 
            // dgv_AgePlusTwentyTwo
            // 
            this.dgv_AgePlusTwentyTwo.AllowUserToAddRows = false;
            this.dgv_AgePlusTwentyTwo.AllowUserToDeleteRows = false;
            this.dgv_AgePlusTwentyTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AgePlusTwentyTwo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.OriginalAge,
            this.AgePlusTwenty});
            this.dgv_AgePlusTwentyTwo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_AgePlusTwentyTwo.Location = new System.Drawing.Point(12, 227);
            this.dgv_AgePlusTwentyTwo.Name = "dgv_AgePlusTwentyTwo";
            this.dgv_AgePlusTwentyTwo.RowHeadersVisible = false;
            this.dgv_AgePlusTwentyTwo.Size = new System.Drawing.Size(515, 211);
            this.dgv_AgePlusTwentyTwo.TabIndex = 2;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserID.DataPropertyName = "userID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            // 
            // OriginalAge
            // 
            this.OriginalAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OriginalAge.DataPropertyName = "originalAge";
            this.OriginalAge.HeaderText = "OriginalAge";
            this.OriginalAge.Name = "OriginalAge";
            this.OriginalAge.Width = 86;
            // 
            // AgePlusTwenty
            // 
            this.AgePlusTwenty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AgePlusTwenty.DataPropertyName = "agePlusTwenty";
            this.AgePlusTwenty.HeaderText = "AgePlusTwenty";
            this.AgePlusTwenty.Name = "AgePlusTwenty";
            this.AgePlusTwenty.Width = 106;
            // 
            // dgv_TopColours
            // 
            this.dgv_TopColours.AllowUserToAddRows = false;
            this.dgv_TopColours.AllowUserToDeleteRows = false;
            this.dgv_TopColours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TopColours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Colour,
            this.Count});
            this.dgv_TopColours.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_TopColours.Location = new System.Drawing.Point(533, 227);
            this.dgv_TopColours.Name = "dgv_TopColours";
            this.dgv_TopColours.RowHeadersVisible = false;
            this.dgv_TopColours.Size = new System.Drawing.Size(255, 211);
            this.dgv_TopColours.TabIndex = 4;
            // 
            // Colour
            // 
            this.Colour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Colour.DataPropertyName = "colour";
            this.Colour.HeaderText = "Colour";
            this.Colour.Name = "Colour";
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.DataPropertyName = "count";
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            // 
            // sendResponse
            // 
            this.sendResponse.Location = new System.Drawing.Point(12, 110);
            this.sendResponse.Name = "sendResponse";
            this.sendResponse.Size = new System.Drawing.Size(118, 43);
            this.sendResponse.TabIndex = 5;
            this.sendResponse.Text = "Send Response";
            this.sendResponse.UseVisualStyleBackColor = true;
            this.sendResponse.Click += new System.EventHandler(this.Btn_sendResponse_ClickAsync);
            // 
            // dgv_UserEntities
            // 
            this.dgv_UserEntities.AllowUserToAddRows = false;
            this.dgv_UserEntities.AllowUserToDeleteRows = false;
            this.dgv_UserEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserEntities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Email,
            this.DateOfBirth,
            this.FavouriteColour});
            this.dgv_UserEntities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_UserEntities.Location = new System.Drawing.Point(151, 10);
            this.dgv_UserEntities.Name = "dgv_UserEntities";
            this.dgv_UserEntities.RowHeadersVisible = false;
            this.dgv_UserEntities.Size = new System.Drawing.Size(637, 211);
            this.dgv_UserEntities.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.DataPropertyName = "firstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.DataPropertyName = "lastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfBirth.DataPropertyName = "dob";
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // FavouriteColour
            // 
            this.FavouriteColour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FavouriteColour.DataPropertyName = "favouriteColour";
            this.FavouriteColour.HeaderText = "FavouriteColour";
            this.FavouriteColour.Name = "FavouriteColour";
            // 
            // Highfield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_UserEntities);
            this.Controls.Add(this.sendResponse);
            this.Controls.Add(this.dgv_TopColours);
            this.Controls.Add(this.dgv_AgePlusTwentyTwo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getData);
            this.Name = "Highfield";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AgePlusTwentyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TopColours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserEntities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_AgePlusTwentyTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgePlusTwenty;
        private System.Windows.Forms.DataGridView dgv_TopColours;
        private System.Windows.Forms.Button sendResponse;
        private System.Windows.Forms.DataGridView dgv_UserEntities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn FavouriteColour;
    }
}

