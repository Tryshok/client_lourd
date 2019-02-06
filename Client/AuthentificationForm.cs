using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AuthentificationForm : Form
    {

        private Client.Mapping.User obj_login;
        public BindingList<Mapping.Client> DataGridListBinding { get; set; }

        public AuthentificationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.label3.Text = Environment.UserName;
        }

        private async void buttonLoginLDAP_Click(object sender, EventArgs e)
        {
           if ((this.obj_login = new Mapping.User(Environment.UserName, this.textBoxPassword.Text)).CheckLogin())
            {
                try
                {
                    var answerLogin = await Client.Remote.Communication.SendUser(obj_login);
                    LoadTabs();
                }
                catch (Exception)
                {
                    MessageBox.Show("Authentification failed, please retry", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           else
            {
                MessageBox.Show("The LDAP server refused your connection, this computer might not be part of the Active Directory", "Remote access", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // MessageBox.Show("Authentification failed, please retry", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void button_AdminClick(object sender, EventArgs e)
        {
            try
            {
                var answerLogin = await Remote.Communication.SendUser(new Mapping.User("toto", "toto"));

                if (answerLogin != null)
                {
                    Business.Security.token = answerLogin.token.ToString();
                    LoadTabs();
                }
                else
                {
                    MessageBox.Show("Token Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't join the API");
               // throw ex;
            }
        }

        private async void LoadTabs()
        {
            try
            {
                var answer_L_Clients = await Client.Remote.Communication.GetClients();
                var answer_L_Employees = await Client.Remote.Communication.GetEmployees();
                var answer_L_Products = await Client.Remote.Communication.GetProducts();


                if (answer_L_Clients != null && answer_L_Clients.Count > 0)
                {
                    this.Hide();

                    //Récupérer le contenu des trois GridView aprés authentification

                    var bindingListClient = new BindingList<Mapping.Client>(answer_L_Clients);
                    var sourceClientBinding = new BindingSource(bindingListClient, null);

                    var bindingListEmployee = new BindingList<Mapping.Employee>(answer_L_Employees);
                    var sourceEmployeeBinding = new BindingSource(bindingListEmployee, null);

                    var bindingListProduct = new BindingList<Mapping.Product>(answer_L_Products);
                    var sourceProductBinding = new BindingSource(bindingListProduct, null);

                    var clientForm = new ClientForm(sourceClientBinding, sourceProductBinding, sourceEmployeeBinding);

                    clientForm.Show();
                    clientForm.GetDataGridViewClient().DataSource = sourceClientBinding;
                    clientForm.GetDataGridViewEmployee().DataSource = sourceEmployeeBinding;
                    clientForm.GetDataGridViewProduct().DataSource = sourceProductBinding;
                }
                else
                {
                    MessageBox.Show("Remote access Error: The API returned an empty list", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't communicate with the API: " + ex.Message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
