using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Mapping;
using Client.Remote;

namespace Client
{
    public partial class ClientForm : Form
    {
        //https://www.youtube.com/watch?v=0flYZTNE7RU

        private int selectedRowIndex;
        private DataGridViewRow selectedRow;

        private BindingSource B_ClientGridSource;
        private BindingSource B_ProductGridSource;
        private BindingSource B_EmployeeGridSource;



        public ClientForm(BindingSource p_GridSource, BindingSource p_ProductGridSource, BindingSource p_hrGridSource)
        {
            this.B_ClientGridSource = p_GridSource;
            this.B_ProductGridSource = p_ProductGridSource;
            this.B_EmployeeGridSource = p_hrGridSource;


            this.selectedRowIndex = -1;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void dataGridViewClient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.selectedRowIndex = e.RowIndex;
                this.selectedRow = dataGridViewClient.Rows[this.selectedRowIndex];

                this.textBoxFamilyName.Text = this.selectedRow.Cells[1].Value.ToString();
                this.textBoxName.Text = this.selectedRow.Cells[2].Value.ToString();
                this.textBoxCompany.Text = this.selectedRow.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private async void buttonCreateClient_Click(object sender, EventArgs e)
        {
            //Créer un client et le valider dans la foulée.
            var hello = new Mapping.Client(this.textBoxFamilyName.Text, this.textBoxName.Text, this.textBoxCompany.Text).Validate();

            //Send new user to WebService
            if (hello != null)
            {
                try
                {
                    var response = await Communication.SendNewClient(hello);

                    if (response != null)
                    {
                        this.B_ClientGridSource.Add(response);

                        this.textBoxFamilyName.Clear();
                        this.textBoxName.Clear();
                        this.textBoxCompany.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Server was succesfully contacted but sent back an empty response.", "Error receiving new client 'buttonCreateOrUpdate_Click'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal Error: Add Client" + ex.Message, "ERROR Creating client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valide Client");
            }
        }

        //changement d'onglet
        private async void TabMenu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            var selectedTab = this.TabMenu.SelectedTab.Controls;

            switch (selectedTab.Owner.Name)
            {
                case "tabPage1":

                    this.B_ClientGridSource.DataSource = await Communication.GetClients();

                    break;

                case "tabPage2":

                    this.B_ProductGridSource.DataSource = await Communication.GetProducts();
                    break;

                case "tabPage3":

                    this.B_EmployeeGridSource.DataSource = await Communication.GetEmployees();
                    break;

                default:
                    MessageBox.Show("Invalid tab name: selectedTab.Owner.Name");
                    break;
            }
            //MessageBox.Show("Index selected: " + e.TabPage.Name);
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            //check if row exists
            if (this.selectedRow != null && this.selectedRow.Cells[0].Value != null && (Int32)this.selectedRow.Cells[0].Value != -1)
            {
                try
                {
                    var response = await Communication.UpdateClients(new Mapping.Client()
                    {
                        id = (Int32)this.selectedRow.Cells[0].Value,
                        lastName = this.textBoxFamilyName.Text.ToString(),
                        firstName = this.textBoxName.Text.ToString(),
                        company = this.textBoxCompany.Text.ToString(),
                    });
                    if (response != null && response.id != -1)
                    {
                        this.B_ClientGridSource.DataSource = await Communication.GetClients();
                        this.dataGridViewClient.Rows[this.selectedRowIndex].Selected = true;
                        this.textBoxCompany.Clear(); this.textBoxFamilyName.Clear(); this.textBoxName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Could not update client");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FATAL ERROR: Could not update client: " + ex.Message, "ERROR: update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row before trying to edit.", "Cell Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //check if row exists
            if (e.RowIndex != -1 && this.dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value != null)
            {
                var coucou = this.dataGridViewProduct.Rows[e.RowIndex].Cells;

                try
                {
                    var response = await Communication.GetParts(e.RowIndex);
                    this.dataGridViewParts.DataSource = response;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("FATAL ERROR: Could not get Parts: " + ex.Message, "ERROR: Fetch Parts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw ex;
                }
                //this.dataGridViewProduct.Rows[e.RowIndex].Selected = true;
            }
            else
            {
                MessageBox.Show("Please select a row before trying to edit.", "Cell error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Employee

        private void Click_EmployeeDataGrid(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.selectedRowIndex = e.RowIndex;
                this.selectedRow = dataGridViewEmployee.Rows[this.selectedRowIndex];

                this.textBoxEmployeeFamilyName.Text = this.selectedRow.Cells[1].Value.ToString();
                this.textBoxEmployeeName.Text = this.selectedRow.Cells[2].Value.ToString();
                this.textBoxEmployeePhone.Text = this.selectedRow.Cells[3].Value.ToString();
                this.textBoxEmployeeService.Text = this.selectedRow.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }

        private async void buttonEmployeeCreate_Click(object sender, EventArgs e)
        {
            //Créer un client et le valider dans la foulée.
            var employeeToCreate = new Employee()
            {
                lastName = this.textBoxEmployeeFamilyName.Text,
                firstName = this.textBoxEmployeeName.Text,
                service = this.textBoxEmployeeService.Text,
                phone = this.textBoxEmployeePhone.Text,
            }.Validate();

            //Send new user to WebService
            if (employeeToCreate != null)
            {
                try
                {
                    var response = await Communication.SendNewEmployee(employeeToCreate);

                    if (response != null)
                    {
                        this.B_EmployeeGridSource.Add(response);
                        this.textBoxEmployeeFamilyName.Clear();
                        this.textBoxEmployeeName.Clear();
                        this.textBoxEmployeeService.Clear();
                        this.textBoxEmployeePhone.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Server was successfully contacted but sent back an empty response.", "Error receiving new client 'buttonCreateOrUpdate_Click'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal Error: " + ex.Message, "Error de communication au WS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("Check for mistakes in fields");
            }
        }

        private async void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (this.selectedRow != null && this.selectedRow.Cells[0].Value != null && (Int32)this.selectedRow.Cells[0].Value != -1)
            {
                var coucou = this.selectedRow.Cells;

                try
                {
                    var response = await Communication.UpdateEmployee(new Mapping.Employee()
                    {
                        lastName = coucou[1].Value.ToString(),
                        firstName = coucou[2].Value.ToString(),
                        phone = coucou[3].Value.ToString(),
                        service = coucou[4].Value.ToString(),
                    });

                    if (response != null && response.id != -1)
                    {
                        this.B_EmployeeGridSource.DataSource = await Communication.GetEmployees();

                        this.textBoxEmployeeFamilyName.Clear();
                        this.textBoxEmployeeName.Clear();
                        this.textBoxEmployeePhone.Clear();
                        this.textBoxEmployeeService.Clear();

                        this.dataGridViewEmployee.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Could not update Employee", "Updating Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fatal Error: " + ex.Message, "Updating Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show("Please select a row before trying to edit.", "Cell error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void buttonEmployeeDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}

