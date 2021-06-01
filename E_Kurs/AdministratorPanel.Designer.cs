namespace E_Kurs
{
    partial class AdministratorPanel
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.inputSerialNumber = new System.Windows.Forms.TextBox();
            this.inputModelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.buttonAddAdministrator = new System.Windows.Forms.Button();
            this.buttonAddModerator = new System.Windows.Forms.Button();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(350, 258);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(350, 82);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(100, 68);
            this.titleLabel.TabIndex = 25;
            this.titleLabel.Text = "Shop";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(271, 208);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 13);
            this.password.TabIndex = 24;
            this.password.Text = "Serial Number";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(279, 182);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(65, 13);
            this.Username.TabIndex = 23;
            this.Username.Text = "Model name";
            // 
            // inputSerialNumber
            // 
            this.inputSerialNumber.Location = new System.Drawing.Point(350, 208);
            this.inputSerialNumber.Name = "inputSerialNumber";
            this.inputSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.inputSerialNumber.TabIndex = 21;
            // 
            // inputModelName
            // 
            this.inputModelName.AccessibleDescription = "username";
            this.inputModelName.AccessibleName = "username";
            this.inputModelName.Location = new System.Drawing.Point(350, 182);
            this.inputModelName.Name = "inputModelName";
            this.inputModelName.Size = new System.Drawing.Size(100, 20);
            this.inputModelName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Price";
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(350, 232);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(100, 20);
            this.inputPrice.TabIndex = 27;
            // 
            // buttonAddAdministrator
            // 
            this.buttonAddAdministrator.Location = new System.Drawing.Point(350, 357);
            this.buttonAddAdministrator.Name = "buttonAddAdministrator";
            this.buttonAddAdministrator.Size = new System.Drawing.Size(100, 23);
            this.buttonAddAdministrator.TabIndex = 29;
            this.buttonAddAdministrator.Text = "Add Administrator";
            this.buttonAddAdministrator.UseVisualStyleBackColor = true;
            this.buttonAddAdministrator.Click += new System.EventHandler(this.buttonAddAdministrator_Click);
            // 
            // buttonAddModerator
            // 
            this.buttonAddModerator.Location = new System.Drawing.Point(350, 328);
            this.buttonAddModerator.Name = "buttonAddModerator";
            this.buttonAddModerator.Size = new System.Drawing.Size(100, 23);
            this.buttonAddModerator.TabIndex = 30;
            this.buttonAddModerator.Text = "Add Moderator";
            this.buttonAddModerator.UseVisualStyleBackColor = true;
            this.buttonAddModerator.Click += new System.EventHandler(this.buttonAddModerator_Click);
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Location = new System.Drawing.Point(350, 386);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(100, 23);
            this.buttonRemoveUser.TabIndex = 31;
            this.buttonRemoveUser.Text = "Remove User";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            this.buttonRemoveUser.Click += new System.EventHandler(this.buttonRemoveUser_Click);
            // 
            // AdministratorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveUser);
            this.Controls.Add(this.buttonAddModerator);
            this.Controls.Add(this.buttonAddAdministrator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.inputSerialNumber);
            this.Controls.Add(this.inputModelName);
            this.Name = "AdministratorPanel";
            this.Text = "AdministratorPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorPanel_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox inputSerialNumber;
        private System.Windows.Forms.TextBox inputModelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Button buttonAddAdministrator;
        private System.Windows.Forms.Button buttonAddModerator;
        private System.Windows.Forms.Button buttonRemoveUser;
    }
}