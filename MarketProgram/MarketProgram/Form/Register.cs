using MarketProgram.Model;
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
    public partial class Register : Form
    {
        Form Form = new Form();
        Form Login = new Form();
        public Register()
        {
            InitializeComponent();
        }
        public Register(Form form,Form login):this()
        {
            Login = login;
            Form = form;
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Close();
        }

        private void btn_login_go_Click(object sender, EventArgs e)
        {
            Hide();
            Login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (MarketDbContext marketDbContext = new MarketDbContext())
                {
                    if (!marketDbContext.Buyers.Any(x => x.Name == txt_name.Text))
                    {
                        //get user information from txtbox
                        Buyer buyer = new Buyer()
                        {
                            Name = txt_name.Text,
                            Password = txt_password.Text,
                            ConfirmPassword = txt_con_password.Text
                        };

                        //VALIDATE
                        #region
                        ValidationContext context = new ValidationContext(buyer, null, null);

                        List<ValidationResult> errors = new List<ValidationResult>();

                        if (!Validator.TryValidateObject(buyer, context, errors, true))
                        {
                            foreach (ValidationResult result in errors)
                            {
                                if (result.MemberNames.Contains("Name"))
                                    errorProvider_register.SetError(txt_name, result.ErrorMessage);
                                else if (result.MemberNames.Contains("Password"))
                                    errorProvider_register.SetError(txt_password, result.ErrorMessage);
                                else if (result.MemberNames.Contains("ConfirmPassword"))
                                    errorProvider_register.SetError(txt_con_password, result.ErrorMessage);
                                else if (txt_password.Text != txt_con_password.Text)
                                {
                                    errorProvider_register.SetError(txt_con_password, result.ErrorMessage);
                                    Clear();
                                }

                                else
                                {
                                    Clear();
                                }
                            }
                        }
                        #endregion
                        else
                        {
                            //add new user information to DB
                            marketDbContext.Buyers.Add(buyer);
                            marketDbContext.SaveChanges();

                            MessageBox.Show(buyer.Name + " Successfylly is Signed");
                            Clear();
                            Hide();
                            Login.Show();
                        }
                    }
                    else
                        MessageBox.Show(txt_name.Text+" Already is Using");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void Clear()
        {
            txt_name.Text = "";
            txt_password.Text = "";
            txt_con_password.Text = "";
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            errorProvider_register.Clear();
        }
    }
}
