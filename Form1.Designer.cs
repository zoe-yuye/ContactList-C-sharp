namespace ContactList
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            MainTab = new TabPage();
            AddTabBtn = new Button();
            ShowAllBtn = new Button();
            SearchBtn = new Button();
            searchName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            contactsTable = new DataGridView();
            label1 = new Label();
            EditContactTab = new TabPage();
            ContactToUpdate = new Label();
            UpdateBtn = new Button();
            EditAddress = new TextBox();
            UpdateAddressLabel = new Label();
            EditEmail = new TextBox();
            UpdateEmailLabel = new Label();
            EditPhone = new TextBox();
            UpdatePhoneLabel = new Label();
            EditName = new TextBox();
            UpdateNameLabel = new Label();
            UpdateLabel = new Label();
            AddContactTab = new TabPage();
            AddButton = new Button();
            AddressTextBox = new TextBox();
            AddressLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            AddLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)contactsTable).BeginInit();
            EditContactTab.SuspendLayout();
            AddContactTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(MainTab);
            tabControl1.Location = new Point(-1, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(30, 5);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1126, 625);
            tabControl1.TabIndex = 0;
            // 
            // MainTab
            // 
            MainTab.Controls.Add(AddTabBtn);
            MainTab.Controls.Add(ShowAllBtn);
            MainTab.Controls.Add(SearchBtn);
            MainTab.Controls.Add(searchName);
            MainTab.Controls.Add(label5);
            MainTab.Controls.Add(label3);
            MainTab.Controls.Add(contactsTable);
            MainTab.Controls.Add(label1);
            MainTab.Location = new Point(4, 38);
            MainTab.Name = "MainTab";
            MainTab.Padding = new Padding(3);
            MainTab.Size = new Size(1118, 583);
            MainTab.TabIndex = 2;
            MainTab.Text = "Contacts";
            MainTab.UseVisualStyleBackColor = true;
            // 
            // AddTabBtn
            // 
            AddTabBtn.Location = new Point(888, 85);
            AddTabBtn.Name = "AddTabBtn";
            AddTabBtn.Size = new Size(112, 34);
            AddTabBtn.TabIndex = 10;
            AddTabBtn.Text = "Add";
            AddTabBtn.UseVisualStyleBackColor = true;
            AddTabBtn.Click += AddTabBtn_Click;
            // 
            // ShowAllBtn
            // 
            ShowAllBtn.Location = new Point(753, 84);
            ShowAllBtn.Name = "ShowAllBtn";
            ShowAllBtn.Size = new Size(112, 34);
            ShowAllBtn.TabIndex = 9;
            ShowAllBtn.Text = "Show All";
            ShowAllBtn.UseVisualStyleBackColor = true;
            ShowAllBtn.Click += ShowAllBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(489, 85);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(112, 34);
            SearchBtn.TabIndex = 8;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // searchName
            // 
            searchName.Location = new Point(243, 87);
            searchName.Name = "searchName";
            searchName.Size = new Size(220, 31);
            searchName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(78, 87);
            label5.Name = "label5";
            label5.Size = new Size(150, 28);
            label5.TabIndex = 6;
            label5.Text = "Search by name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(481, 21);
            label3.Name = "label3";
            label3.Size = new Size(149, 36);
            label3.TabIndex = 2;
            label3.Text = "Contact List";
            // 
            // contactsTable
            // 
            contactsTable.BackgroundColor = SystemColors.Window;
            contactsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactsTable.Location = new Point(1, 143);
            contactsTable.Name = "contactsTable";
            contactsTable.RowHeadersWidth = 62;
            contactsTable.Size = new Size(1114, 442);
            contactsTable.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 43);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // EditContactTab
            // 
            EditContactTab.Controls.Add(ContactToUpdate);
            EditContactTab.Controls.Add(UpdateBtn);
            EditContactTab.Controls.Add(EditAddress);
            EditContactTab.Controls.Add(UpdateAddressLabel);
            EditContactTab.Controls.Add(EditEmail);
            EditContactTab.Controls.Add(UpdateEmailLabel);
            EditContactTab.Controls.Add(EditPhone);
            EditContactTab.Controls.Add(UpdatePhoneLabel);
            EditContactTab.Controls.Add(EditName);
            EditContactTab.Controls.Add(UpdateNameLabel);
            EditContactTab.Controls.Add(UpdateLabel);
            EditContactTab.Location = new Point(4, 38);
            EditContactTab.Name = "EditContactTab";
            EditContactTab.Padding = new Padding(3);
            EditContactTab.Size = new Size(1118, 583);
            EditContactTab.TabIndex = 3;
            EditContactTab.Text = "Update Contact";
            EditContactTab.UseVisualStyleBackColor = true;
            // 
            // ContactToUpdate
            // 
            ContactToUpdate.AutoSize = true;
            ContactToUpdate.Location = new Point(631, 68);
            ContactToUpdate.Name = "ContactToUpdate";
            ContactToUpdate.Size = new Size(73, 25);
            ContactToUpdate.TabIndex = 25;
            ContactToUpdate.Text = "Contact";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(710, 455);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(190, 34);
            UpdateBtn.TabIndex = 24;
            UpdateBtn.Text = "Comfirm and Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // EditAddress
            // 
            EditAddress.Location = new Point(279, 359);
            EditAddress.Name = "EditAddress";
            EditAddress.Size = new Size(475, 31);
            EditAddress.TabIndex = 23;
            // 
            // UpdateAddressLabel
            // 
            UpdateAddressLabel.AutoSize = true;
            UpdateAddressLabel.Font = new Font("Segoe UI", 10F);
            UpdateAddressLabel.Location = new Point(188, 359);
            UpdateAddressLabel.Name = "UpdateAddressLabel";
            UpdateAddressLabel.Size = new Size(82, 28);
            UpdateAddressLabel.TabIndex = 22;
            UpdateAddressLabel.Text = "Address";
            // 
            // EditEmail
            // 
            EditEmail.Location = new Point(279, 296);
            EditEmail.Name = "EditEmail";
            EditEmail.Size = new Size(234, 31);
            EditEmail.TabIndex = 21;
            // 
            // UpdateEmailLabel
            // 
            UpdateEmailLabel.AutoSize = true;
            UpdateEmailLabel.Font = new Font("Segoe UI", 10F);
            UpdateEmailLabel.Location = new Point(188, 296);
            UpdateEmailLabel.Name = "UpdateEmailLabel";
            UpdateEmailLabel.Size = new Size(59, 28);
            UpdateEmailLabel.TabIndex = 20;
            UpdateEmailLabel.Text = "Email";
            // 
            // EditPhone
            // 
            EditPhone.Location = new Point(279, 231);
            EditPhone.Name = "EditPhone";
            EditPhone.Size = new Size(234, 31);
            EditPhone.TabIndex = 19;
            // 
            // UpdatePhoneLabel
            // 
            UpdatePhoneLabel.AutoSize = true;
            UpdatePhoneLabel.Font = new Font("Segoe UI", 10F);
            UpdatePhoneLabel.Location = new Point(188, 231);
            UpdatePhoneLabel.Name = "UpdatePhoneLabel";
            UpdatePhoneLabel.Size = new Size(67, 28);
            UpdatePhoneLabel.TabIndex = 18;
            UpdatePhoneLabel.Text = "Phone";
            // 
            // EditName
            // 
            EditName.Location = new Point(279, 168);
            EditName.Name = "EditName";
            EditName.Size = new Size(234, 31);
            EditName.TabIndex = 17;
            // 
            // UpdateNameLabel
            // 
            UpdateNameLabel.AutoSize = true;
            UpdateNameLabel.Font = new Font("Segoe UI", 10F);
            UpdateNameLabel.Location = new Point(188, 168);
            UpdateNameLabel.Name = "UpdateNameLabel";
            UpdateNameLabel.Size = new Size(64, 28);
            UpdateNameLabel.TabIndex = 16;
            UpdateNameLabel.Text = "Name";
            // 
            // UpdateLabel
            // 
            UpdateLabel.AutoSize = true;
            UpdateLabel.Font = new Font("Segoe UI", 13F);
            UpdateLabel.Location = new Point(411, 61);
            UpdateLabel.Name = "UpdateLabel";
            UpdateLabel.Size = new Size(222, 36);
            UpdateLabel.TabIndex = 15;
            UpdateLabel.Text = "Update Contact --";
            // 
            // AddContactTab
            // 
            AddContactTab.Controls.Add(AddButton);
            AddContactTab.Controls.Add(AddressTextBox);
            AddContactTab.Controls.Add(AddressLabel);
            AddContactTab.Controls.Add(EmailTextBox);
            AddContactTab.Controls.Add(EmailLabel);
            AddContactTab.Controls.Add(PhoneTextBox);
            AddContactTab.Controls.Add(PhoneLabel);
            AddContactTab.Controls.Add(NameTextBox);
            AddContactTab.Controls.Add(NameLabel);
            AddContactTab.Controls.Add(AddLabel);
            AddContactTab.Location = new Point(4, 38);
            AddContactTab.Name = "AddContactTab";
            AddContactTab.Padding = new Padding(3);
            AddContactTab.Size = new Size(1118, 583);
            AddContactTab.TabIndex = 0;
            AddContactTab.Text = "Add Contact";
            AddContactTab.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(710, 430);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(190, 34);
            AddButton.TabIndex = 14;
            AddButton.Text = "Comfirm and Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(279, 334);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(475, 31);
            AddressTextBox.TabIndex = 13;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 10F);
            AddressLabel.Location = new Point(188, 334);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(82, 28);
            AddressLabel.TabIndex = 12;
            AddressLabel.Text = "Address";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(279, 271);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(234, 31);
            EmailTextBox.TabIndex = 11;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 10F);
            EmailLabel.Location = new Point(188, 271);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(59, 28);
            EmailLabel.TabIndex = 10;
            EmailLabel.Text = "Email";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(279, 206);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(234, 31);
            PhoneTextBox.TabIndex = 9;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 10F);
            PhoneLabel.Location = new Point(188, 206);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(67, 28);
            PhoneLabel.TabIndex = 8;
            PhoneLabel.Text = "Phone";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(279, 143);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(234, 31);
            NameTextBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 10F);
            NameLabel.Location = new Point(188, 143);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(64, 28);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name";
            // 
            // AddLabel
            // 
            AddLabel.AutoSize = true;
            AddLabel.Font = new Font("Segoe UI", 13F);
            AddLabel.Location = new Point(450, 57);
            AddLabel.Name = "AddLabel";
            AddLabel.Size = new Size(217, 36);
            AddLabel.TabIndex = 5;
            AddLabel.Text = "Add New Contact";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 620);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Contact List";
            tabControl1.ResumeLayout(false);
            MainTab.ResumeLayout(false);
            MainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contactsTable).EndInit();
            EditContactTab.ResumeLayout(false);
            EditContactTab.PerformLayout();
            AddContactTab.ResumeLayout(false);
            AddContactTab.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private TabControl tabControl1;
        private TabPage AddContactTab;
        private TabPage MainTab;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Label AddLabel;
        private TextBox AddressTextBox;
        private Label AddressLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private Button AddButton;
        private Label RemoveLabel;
        private Label label1;
        private DataGridView contactsTable;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private ComboBox comboBox1;
        private Button SearchBtn;
        private TextBox searchName;
        private Label label5;
        private Button ShowAllBtn;
        private TabPage EditContactTab;
        private Button UpdateBtn;
        private TextBox EditAddress;
        private Label UpdateAddressLabel;
        private TextBox EditEmail;
        private Label UpdateEmailLabel;
        private TextBox EditPhone;
        private Label UpdatePhoneLabel;
        private TextBox EditName;
        private Label UpdateNameLabel;
        private Label UpdateLabel;
        private Button AddTabBtn;
        private Label ContactToUpdate;
    }
}
