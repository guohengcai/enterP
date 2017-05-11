namespace AITMediaLibrary
{
    partial class MediaBrowser
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
            this.mediaDataGridView = new System.Windows.Forms.DataGridView();
            this.listMediaBtn = new System.Windows.Forms.Button();
            this.userDetailLbl = new System.Windows.Forms.Label();
            this.mediaLbl = new System.Windows.Forms.Label();
            this.publishYearTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.publishYearSearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.genreNameText = new System.Windows.Forms.TextBox();
            this.genreNameSearchBtn = new System.Windows.Forms.Button();
            this.languageNameSearchBtn = new System.Windows.Forms.Button();
            this.languageNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaDataGridView
            // 
            this.mediaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaDataGridView.Location = new System.Drawing.Point(55, 70);
            this.mediaDataGridView.Name = "mediaDataGridView";
            this.mediaDataGridView.Size = new System.Drawing.Size(552, 150);
            this.mediaDataGridView.TabIndex = 0;
            this.mediaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaDataGridView_CellClick);
            this.mediaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaDataGridView_CellContentClick);
            // 
            // listMediaBtn
            // 
            this.listMediaBtn.Location = new System.Drawing.Point(242, 250);
            this.listMediaBtn.Name = "listMediaBtn";
            this.listMediaBtn.Size = new System.Drawing.Size(161, 23);
            this.listMediaBtn.TabIndex = 1;
            this.listMediaBtn.Text = "List All Media";
            this.listMediaBtn.UseVisualStyleBackColor = true;
            this.listMediaBtn.Click += new System.EventHandler(this.listMediaBtn_Click);
            // 
            // userDetailLbl
            // 
            this.userDetailLbl.AutoSize = true;
            this.userDetailLbl.Location = new System.Drawing.Point(55, 13);
            this.userDetailLbl.Name = "userDetailLbl";
            this.userDetailLbl.Size = new System.Drawing.Size(61, 13);
            this.userDetailLbl.TabIndex = 2;
            this.userDetailLbl.Text = "UserDetails";
            // 
            // mediaLbl
            // 
            this.mediaLbl.AutoSize = true;
            this.mediaLbl.Location = new System.Drawing.Point(432, 250);
            this.mediaLbl.Name = "mediaLbl";
            this.mediaLbl.Size = new System.Drawing.Size(84, 13);
            this.mediaLbl.TabIndex = 3;
            this.mediaLbl.Text = "Selected Media:";
            // 
            // publishYearTxt
            // 
            this.publishYearTxt.Location = new System.Drawing.Point(58, 318);
            this.publishYearTxt.Name = "publishYearTxt";
            this.publishYearTxt.Size = new System.Drawing.Size(100, 20);
            this.publishYearTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Publish Year:";
            // 
            // publishYearSearchBtn
            // 
            this.publishYearSearchBtn.Location = new System.Drawing.Point(184, 314);
            this.publishYearSearchBtn.Name = "publishYearSearchBtn";
            this.publishYearSearchBtn.Size = new System.Drawing.Size(121, 23);
            this.publishYearSearchBtn.TabIndex = 6;
            this.publishYearSearchBtn.Text = "Search by Year";
            this.publishYearSearchBtn.UseVisualStyleBackColor = true;
            this.publishYearSearchBtn.Click += new System.EventHandler(this.publishYearSearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genre Name:";
            // 
            // genreNameText
            // 
            this.genreNameText.Location = new System.Drawing.Point(58, 430);
            this.genreNameText.Name = "genreNameText";
            this.genreNameText.Size = new System.Drawing.Size(100, 20);
            this.genreNameText.TabIndex = 8;
            // 
            // genreNameSearchBtn
            // 
            this.genreNameSearchBtn.Location = new System.Drawing.Point(184, 426);
            this.genreNameSearchBtn.Name = "genreNameSearchBtn";
            this.genreNameSearchBtn.Size = new System.Drawing.Size(130, 23);
            this.genreNameSearchBtn.TabIndex = 9;
            this.genreNameSearchBtn.Text = "Search by Genre Name";
            this.genreNameSearchBtn.UseVisualStyleBackColor = true;
            this.genreNameSearchBtn.Click += new System.EventHandler(this.genreNameSearchBtn_Click);
            // 
            // languageNameSearchBtn
            // 
            this.languageNameSearchBtn.Location = new System.Drawing.Point(184, 521);
            this.languageNameSearchBtn.Name = "languageNameSearchBtn";
            this.languageNameSearchBtn.Size = new System.Drawing.Size(151, 23);
            this.languageNameSearchBtn.TabIndex = 10;
            this.languageNameSearchBtn.Text = "Search by Language Name";
            this.languageNameSearchBtn.UseVisualStyleBackColor = true;
            this.languageNameSearchBtn.Click += new System.EventHandler(this.languageNameSearchBtn_Click);
            // 
            // languageNameText
            // 
            this.languageNameText.Location = new System.Drawing.Point(55, 523);
            this.languageNameText.Name = "languageNameText";
            this.languageNameText.Size = new System.Drawing.Size(100, 20);
            this.languageNameText.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Language Name:";
            // 
            // MediaBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 649);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.languageNameText);
            this.Controls.Add(this.languageNameSearchBtn);
            this.Controls.Add(this.genreNameSearchBtn);
            this.Controls.Add(this.genreNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publishYearSearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publishYearTxt);
            this.Controls.Add(this.mediaLbl);
            this.Controls.Add(this.userDetailLbl);
            this.Controls.Add(this.listMediaBtn);
            this.Controls.Add(this.mediaDataGridView);
            this.Name = "MediaBrowser";
            this.Text = "MediaBrowser";
            this.Load += new System.EventHandler(this.MediaBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mediaDataGridView;
        private System.Windows.Forms.Button listMediaBtn;
        private System.Windows.Forms.Label userDetailLbl;
        private System.Windows.Forms.Label mediaLbl;
        private System.Windows.Forms.TextBox publishYearTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button publishYearSearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox genreNameText;
        private System.Windows.Forms.Button genreNameSearchBtn;
        private System.Windows.Forms.Button languageNameSearchBtn;
        private System.Windows.Forms.TextBox languageNameText;
        private System.Windows.Forms.Label label3;
    }
}