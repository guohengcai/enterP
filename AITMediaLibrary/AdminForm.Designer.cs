namespace AITMediaLibrary
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.selectdUserLabel = new System.Windows.Forms.Label();
            this.newPasswordTextbox = new System.Windows.Forms.Label();
            this.UpdatePasswordbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteSelectedUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userLevelComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Users";
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(38, 43);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(263, 464);
            this.userGridView.TabIndex = 1;
            this.userGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellClick);
            // 
            // selectdUserLabel
            // 
            this.selectdUserLabel.AutoSize = true;
            this.selectdUserLabel.Location = new System.Drawing.Point(326, 13);
            this.selectdUserLabel.Name = "selectdUserLabel";
            this.selectdUserLabel.Size = new System.Drawing.Size(63, 13);
            this.selectdUserLabel.TabIndex = 2;
            this.selectdUserLabel.Text = "selectdUser";
            // 
            // newPasswordTextbox
            // 
            this.newPasswordTextbox.AutoSize = true;
            this.newPasswordTextbox.Location = new System.Drawing.Point(329, 52);
            this.newPasswordTextbox.Name = "newPasswordTextbox";
            this.newPasswordTextbox.Size = new System.Drawing.Size(81, 13);
            this.newPasswordTextbox.TabIndex = 3;
            this.newPasswordTextbox.Text = "New Password:";
            // 
            // UpdatePasswordbutton
            // 
            this.UpdatePasswordbutton.Location = new System.Drawing.Point(428, 103);
            this.UpdatePasswordbutton.Name = "UpdatePasswordbutton";
            this.UpdatePasswordbutton.Size = new System.Drawing.Size(129, 23);
            this.UpdatePasswordbutton.TabIndex = 4;
            this.UpdatePasswordbutton.Text = "UpdatePassword";
            this.UpdatePasswordbutton.UseVisualStyleBackColor = true;
            this.UpdatePasswordbutton.Click += new System.EventHandler(this.UpdatePasswordbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 5;
            // 
            // deleteSelectedUser
            // 
            this.deleteSelectedUser.Location = new System.Drawing.Point(428, 156);
            this.deleteSelectedUser.Name = "deleteSelectedUser";
            this.deleteSelectedUser.Size = new System.Drawing.Size(129, 23);
            this.deleteSelectedUser.TabIndex = 6;
            this.deleteSelectedUser.Text = "Delete Selected User";
            this.deleteSelectedUser.UseVisualStyleBackColor = true;
            this.deleteSelectedUser.Click += new System.EventHandler(this.deleteSelectedUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(428, 255);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(129, 20);
            this.usernameTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(428, 322);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(129, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(428, 428);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(129, 20);
            this.emailTextBox.TabIndex = 14;
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Location = new System.Drawing.Point(428, 373);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(129, 21);
            this.userLevelComboBox.TabIndex = 15;
            this.userLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.userLevelComboBox_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(38, 528);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(263, 23);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(409, 475);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(148, 23);
            this.addUserButton.TabIndex = 17;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Go to Maintain Media Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.userLevelComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteSelectedUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UpdatePasswordbutton);
            this.Controls.Add(this.newPasswordTextbox);
            this.Controls.Add(this.selectdUserLabel);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Label selectdUserLabel;
        private System.Windows.Forms.Label newPasswordTextbox;
        private System.Windows.Forms.Button UpdatePasswordbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteSelectedUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox userLevelComboBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button button1;
    }
}