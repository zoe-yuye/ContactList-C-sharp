using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Xml.Linq;

namespace ContactList
{
    public partial class Form1 : Form
    {

        List<Contact> contacts;
        List<Contact> searchContacts;
        string path = "MyContacts.txt";
        public Form1()
        {
            contacts = new List<Contact>();
            searchContacts = new List<Contact>();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            loadContacts();
            InitializeComponent();
            InitializeDataGridView();
        }

        private void loadContacts()
        {
           
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] info = line.Split(';');
                if (info.Length > 0)
                {
                    string name = info[0];
                    string phone = info[1];
                    string email = info[2];
                    string address = info[3];
                    Contact contact = new Contact(name, phone, email, address);
                    contacts.Add(contact);
                }
            }
        }

        private void loadSearchContact()
        {
            searchContacts.Clear();
            foreach (Contact contact in contacts)
            {
                if (string.Equals(searchName.Text, contact.Name, StringComparison.OrdinalIgnoreCase))
                {
                    searchContacts.Add(contact);
                }
            }
            contactsTable.Columns.Clear();
            AddButtonsToTabel();
            contactsTable.CellContentClick -= CellOnClick;
            contactsTable.CellContentClick += SearchCellOnClick;
            contactsTable.DataSource = null;
            contactsTable.DataSource = searchContacts;
            contactsTable.Columns[contactsTable.Columns.Count - 2].Width = 210;
            contactsTable.Columns[contactsTable.Columns.Count - 1].Width = 390;
        }
        private void AddButtonsToTabel()
        {

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Text = "Edit";
            editColumn.Width = 70;
            editColumn.UseColumnTextForButtonValue = true;
            contactsTable.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Text = "Delete";
            deleteColumn.Width = 80;
            deleteColumn.UseColumnTextForButtonValue = true;
            contactsTable.Columns.Add(deleteColumn);

        }
        private void InitializeDataGridView()
        {
            contactsTable.Columns.Clear();
            AddButtonsToTabel();
            contactsTable.CellContentClick -= CellOnClick;
            contactsTable.CellContentClick -= SearchCellOnClick;
            contactsTable.CellContentClick += CellOnClick;
            contactsTable.DataSource = null;
            contactsTable.DataSource = contacts;
            contactsTable.Columns[contactsTable.Columns.Count - 2].Width = 215;
            contactsTable.Columns[contactsTable.Columns.Count - 1].Width = 385;

            contactsTable.ReadOnly = true;
        }
        private void OverWriteContact()
        {
            string[] lines = contacts.Select(contact =>
                    $"{contact.Name};{contact.Phone};{contact.Email};{contact.Address}").ToArray();

            File.WriteAllLines(path, lines);
        }

        private void SearchCellOnClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (searchContacts.Count > 0 && e.RowIndex < searchContacts.Count)
            {
                Contact contact = searchContacts.ElementAt(e.RowIndex);
                if (e.ColumnIndex == 1)
                {
                    DeleteOnAction(contact);
                }
                else if (e.ColumnIndex == 0)
                {
                    EditOnAction(contact);
                }
            }
        }
        private void CellOnClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < contacts.Count)
            {
                Contact contact = contacts.ElementAt(e.RowIndex);
                if (e.ColumnIndex == 1)
                {
                    DeleteOnAction(contact);
                }
                else if (e.ColumnIndex == 0)
                {
                    EditOnAction(contact);
                }
            }
        }

        private void DeleteOnAction(Contact contact)
        {
            string message = "Do you want to delete " + contact.Name + "?";
            DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                contacts.Remove(contact);
                InitializeDataGridView();
                OverWriteContact();
                MessageBox.Show(contact.Name + " deleted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditOnAction(Contact contact)
        {
            if (!tabControl1.Controls.Contains(EditContactTab))
            {
                tabControl1.Controls.Add(EditContactTab);
            }
            tabControl1.SelectedTab = EditContactTab;

            EditName.Text = contact.Name;
            EditPhone.Text = contact.Phone;
            EditEmail.Text = contact.Email;
            EditAddress.Text = contact.Address;
            ContactToUpdate.Text = contact.Name;
        }

        
        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string phone = PhoneTextBox.Text;
            string email = EmailTextBox.Text;
            string address = AddressTextBox.Text;

            if (name != "" && phone != "")
            {
                if (contacts.Any(contact => contact.Name == name) )
                {
                    MessageBox.Show("Contact exists, please set a new name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Contact newContact = new Contact(name, phone, email, address);
                contacts.Add(newContact);
                InitializeDataGridView();
                addContactToFile(name, phone, email, address);

                NameTextBox.Clear();
                PhoneTextBox.Clear();
                EmailTextBox.Clear();
                AddressTextBox.Clear();
                MessageBox.Show("New contact added successfully.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl1.SelectedTab = MainTab;
                tabControl1.Controls.Remove(AddContactTab);
            }
            else
            {
                MessageBox.Show("Please enter name and phone number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void addContactToFile(string name, string phone, string email, string address)
        {
            string newLine = name + ";" + phone + ";" + email + ";" + address;

            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine(newLine);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            loadSearchContact();
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }

        private void AddTabBtn_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Controls.Contains(AddContactTab))
            {
                tabControl1.Controls.Add(AddContactTab);
            }

            tabControl1.SelectedTab = AddContactTab;
        }

        private bool isNewNameValid(string newName, string oldName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.Name == newName && contact.Name != oldName)
                {
                    return false;
                }
            }
            return true;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string oldName = ContactToUpdate.Text;
            
            string newName = EditName.Text;
            string phone = EditPhone.Text;
            string email = EditEmail.Text;
            string address = EditAddress.Text;

            foreach(Contact contact in contacts) 
            {
                if (contact.Name == oldName) 
                {
                    if (!isNewNameValid(newName, oldName)) 
                    {
                        MessageBox.Show("Contact name exists, please set another name.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    contact.Name = newName;
                    contact.Phone = phone;
                    contact.Email = email; 
                    contact.Address = address;
                    OverWriteContact();
                    MessageBox.Show(oldName + " updated.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    tabControl1.SelectedTab = MainTab;
                    tabControl1.Controls.Remove(EditContactTab);
                }
            }
        }
    }
}
