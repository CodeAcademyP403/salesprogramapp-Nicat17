using MarketProgram.Model;
using MarketProgram.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProgram
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Form Form = new Form();
        public Login(Form form):this()
        {
            Form = form;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register register = new Register(Form,this);
            Hide();
            register.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                //get important information from textboxs
                LoginUser loginUser = new LoginUser()
                {
                    Name = txt_name.Text,
                    Password = txt_password.Text
                };

                //VALIDATE
                #region Validate
                ValidationContext context = new ValidationContext(loginUser, null, null);

                List<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(loginUser, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        if (result.MemberNames.Contains("Name"))
                            errorProvider_login.SetError(txt_name, result.ErrorMessage);
                        else if (result.MemberNames.Contains("Password"))
                            errorProvider_login.SetError(txt_password, result.ErrorMessage);
                        else
                        {
                            Clear();
                        }
                    }
                }
                #endregion
                else
                {
                    using (MarketDbContext marketDbContext = new MarketDbContext())
                    {
                        //do controll if user name and pasword equal with DB information
                        if (marketDbContext.Buyers.Any(x => x.Name == loginUser.Name) && marketDbContext.Buyers.Any(x => x.Password == loginUser.Password))
                        {
                            //get current user id send for BuyProduct form
                            Buyer buyer = marketDbContext.Buyers.Where(x=>x.Name==loginUser.Name).FirstOrDefault();
                            loginUser.Id = buyer.Id;

                            BuyProduct buyProduct = new BuyProduct(Form,loginUser, this);
                            Hide();
                            buyProduct.Show();
                        }
                        else
                            MessageBox.Show("Name or Password is Incorrect");
                    }

                    Clear(); 
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btn_go_main_Click(object sender, EventArgs e)
        {
            Hide();
            Form.Show();
        }
        private void Clear()
        {
            txt_name.Text = "";
            txt_password.Text = "";
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            errorProvider_login.Clear();
        }
    }
}
