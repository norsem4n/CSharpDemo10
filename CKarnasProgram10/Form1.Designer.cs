namespace CKarnasProgram10
{
    partial class Form1
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
            this.lblDevelopedBy = new System.Windows.Forms.Label();
            this.lblOnwerName = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblBuildingSqFt = new System.Windows.Forms.Label();
            this.lblLandSqFt = new System.Windows.Forms.Label();
            this.lblYearBuilt = new System.Windows.Forms.Label();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.radioRural = new System.Windows.Forms.RadioButton();
            this.radioSuburb = new System.Windows.Forms.RadioButton();
            this.radioCity = new System.Windows.Forms.RadioButton();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudBldgSF = new System.Windows.Forms.NumericUpDown();
            this.nudLandSF = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBoxLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBldgSF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandSF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.AutoSize = true;
            this.lblDevelopedBy.Location = new System.Drawing.Point(12, 375);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(98, 13);
            this.lblDevelopedBy.TabIndex = 0;
            this.lblDevelopedBy.Text = "Developed by CGK";
            // 
            // lblOnwerName
            // 
            this.lblOnwerName.AutoSize = true;
            this.lblOnwerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnwerName.Location = new System.Drawing.Point(12, 24);
            this.lblOnwerName.Name = "lblOnwerName";
            this.lblOnwerName.Size = new System.Drawing.Size(203, 24);
            this.lblOnwerName.TabIndex = 1;
            this.lblOnwerName.Text = "Property Owner Name:";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerName.Location = new System.Drawing.Point(243, 21);
            this.txtOwnerName.MaxLength = 25;
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(281, 29);
            this.txtOwnerName.TabIndex = 1;
            // 
            // lblBuildingSqFt
            // 
            this.lblBuildingSqFt.AutoSize = true;
            this.lblBuildingSqFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildingSqFt.Location = new System.Drawing.Point(24, 62);
            this.lblBuildingSqFt.Name = "lblBuildingSqFt";
            this.lblBuildingSqFt.Size = new System.Drawing.Size(191, 24);
            this.lblBuildingSqFt.TabIndex = 3;
            this.lblBuildingSqFt.Text = "Building Sq. Footage:";
            // 
            // lblLandSqFt
            // 
            this.lblLandSqFt.AutoSize = true;
            this.lblLandSqFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandSqFt.Location = new System.Drawing.Point(50, 100);
            this.lblLandSqFt.Name = "lblLandSqFt";
            this.lblLandSqFt.Size = new System.Drawing.Size(165, 24);
            this.lblLandSqFt.TabIndex = 4;
            this.lblLandSqFt.Text = "Land Sq. Footage:";
            // 
            // lblYearBuilt
            // 
            this.lblYearBuilt.AutoSize = true;
            this.lblYearBuilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearBuilt.Location = new System.Drawing.Point(121, 137);
            this.lblYearBuilt.Name = "lblYearBuilt";
            this.lblYearBuilt.Size = new System.Drawing.Size(94, 24);
            this.lblYearBuilt.TabIndex = 5;
            this.lblYearBuilt.Text = "Year Built:";
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.Controls.Add(this.radioRural);
            this.groupBoxLocation.Controls.Add(this.radioSuburb);
            this.groupBoxLocation.Controls.Add(this.radioCity);
            this.groupBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLocation.Location = new System.Drawing.Point(125, 171);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(399, 53);
            this.groupBoxLocation.TabIndex = 6;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Location";
            // 
            // radioRural
            // 
            this.radioRural.AutoSize = true;
            this.radioRural.Location = new System.Drawing.Point(321, 17);
            this.radioRural.Name = "radioRural";
            this.radioRural.Size = new System.Drawing.Size(72, 28);
            this.radioRural.TabIndex = 7;
            this.radioRural.TabStop = true;
            this.radioRural.Text = "Rural";
            this.radioRural.UseVisualStyleBackColor = true;
            // 
            // radioSuburb
            // 
            this.radioSuburb.AutoSize = true;
            this.radioSuburb.Location = new System.Drawing.Point(209, 17);
            this.radioSuburb.Name = "radioSuburb";
            this.radioSuburb.Size = new System.Drawing.Size(90, 28);
            this.radioSuburb.TabIndex = 6;
            this.radioSuburb.TabStop = true;
            this.radioSuburb.Text = "Suburb";
            this.radioSuburb.UseVisualStyleBackColor = true;
            // 
            // radioCity
            // 
            this.radioCity.AutoSize = true;
            this.radioCity.Checked = true;
            this.radioCity.Location = new System.Drawing.Point(130, 17);
            this.radioCity.Name = "radioCity";
            this.radioCity.Size = new System.Drawing.Size(58, 28);
            this.radioCity.TabIndex = 5;
            this.radioCity.TabStop = true;
            this.radioCity.Text = "City";
            this.radioCity.UseVisualStyleBackColor = true;
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.Location = new System.Drawing.Point(243, 137);
            this.nudYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1840,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(120, 29);
            this.nudYear.TabIndex = 4;
            this.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudBldgSF
            // 
            this.nudBldgSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBldgSF.Location = new System.Drawing.Point(243, 60);
            this.nudBldgSF.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudBldgSF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBldgSF.Name = "nudBldgSF";
            this.nudBldgSF.Size = new System.Drawing.Size(120, 29);
            this.nudBldgSF.TabIndex = 2;
            this.nudBldgSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBldgSF.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // nudLandSF
            // 
            this.nudLandSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLandSF.Location = new System.Drawing.Point(243, 98);
            this.nudLandSF.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudLandSF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLandSF.Name = "nudLandSF";
            this.nudLandSF.Size = new System.Drawing.Size(120, 29);
            this.nudLandSF.TabIndex = 3;
            this.nudLandSF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLandSF.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(243, 243);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(275, 40);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "&Create Property Tax";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(243, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(386, 298);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(541, 21);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(329, 262);
            this.lblResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 402);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.nudLandSF);
            this.Controls.Add(this.nudBldgSF);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.groupBoxLocation);
            this.Controls.Add(this.lblYearBuilt);
            this.Controls.Add(this.lblLandSqFt);
            this.Controls.Add(this.lblBuildingSqFt);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOnwerName);
            this.Controls.Add(this.lblDevelopedBy);
            this.Name = "Form1";
            this.Text = "Program 10 - Property Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBldgSF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandSF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevelopedBy;
        private System.Windows.Forms.Label lblOnwerName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblBuildingSqFt;
        private System.Windows.Forms.Label lblLandSqFt;
        private System.Windows.Forms.Label lblYearBuilt;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.RadioButton radioRural;
        private System.Windows.Forms.RadioButton radioSuburb;
        private System.Windows.Forms.RadioButton radioCity;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudBldgSF;
        private System.Windows.Forms.NumericUpDown nudLandSF;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}

