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
    public partial class BuyProduct : Form
    {
        Form Form = new Form();
        LoginUser loginUser;
        Login Login = new Login();

        public BuyProduct()
        {
            InitializeComponent();
        }
        public BuyProduct(Form form,LoginUser _loginUser,Login _login):this()
        {
            loginUser = _loginUser;
            Form = form;
            Login = _login;
        }

        private void BuyProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Close();
        }

        private void BuyProduct_Load(object sender, EventArgs e)
        {
            txt_buyer.Text = loginUser.Name;
            SetToDataGridView();

            //Default Set All Category name
            using (MarketDbContext marketDbContext = new MarketDbContext())
            {
                cmbx_category.DataSource = marketDbContext.TopSellingStations
                                        .GroupBy(x => x.Category)
                                            .Where(g => g.Count() > 0)
                                                .Select(y => y.Key)
                                                     .ToList();
            }

            //to do visibility=false of some heder of Datagridview
            dataGridView_buyer.Columns[3].Visible = false;
            dataGridView_buyer.Columns[2].Visible = false;
            dataGridView_buyer.Columns[10].Visible = false;

        }

        private void cmbx_category_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = (sender as ComboBox).SelectedValue.ToString();

            using (MarketDbContext marketDbContext = new MarketDbContext())
            {
                //if Category,Name, Usage==true and Count!=0 then set all product name
                if (marketDbContext.TopSellingStations
                        .Where(x=>x.Category==value)
                            .Where(y => y.Usage == true)
                                .Where(z => z.Count != 0).Any())
                {
                    cmbx_Name.DataSource = marketDbContext.TopSellingStations
                                .Where(x => x.Category == value)
                                    .Where(y => y.Usage == true)
                                        .Where(z => z.Count != 0)
                                            .Select(y => y.Name)
                                                 .ToList();
                }
                else
                {
                    cmbx_Name.Text = "";
                }
            }
        }

        private void cmbx_Name_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = (sender as ComboBox).SelectedValue.ToString();

            using (MarketDbContext marketDbContext = new MarketDbContext())
            {
                //get percent if Buyers.Name equals to selected of product name
                decimal price = marketDbContext.TopSellingStations
                            .Where(x => x.Name == value)
                                    .SingleOrDefault()
                                         .Price;
                //get percent if Buyers.Name==login.Name
                decimal percent = marketDbContext.Buyers
                            .Where(x => x.Name == loginUser.Name)
                                    .SingleOrDefault()
                                         .Percent;
                //Percent Count
                txt_Price.Text = ((price * percent / 100) + price).ToString();

                //Set all Stock for User
                txt_stc_count.Text = marketDbContext.TopSellingStations
                            .Where(x => x.Name == value).
                                    SingleOrDefault()
                                         .Count
                                           .ToString();
                
                //Set all Currency for User
                txt_currency.Text = marketDbContext.TopSellingStations
                            .Where(x => x.Name == value).
                                    SingleOrDefault()
                                         .Currency
                                           .ToString();
                
                //Set all Weight for User
                txt_weight.Text = marketDbContext.TopSellingStations
                            .Where(x => x.Name == value).
                                    SingleOrDefault()
                                         .Weight
                                           .ToString();
            }
            
        }

        //Return Previous to Form
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Hide();
            Login.Show();
        }

        private void txt_Count_TextChanged(object sender, EventArgs e)
        {
            //Do Controll, the count must be only number
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_Count.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_Count.Text = txt_Count.Text.Remove(txt_Count.Text.Length - 1);
            }
            else
            {
                decimal stock = Convert.ToDecimal(txt_stc_count.Text);

                decimal count = Convert.ToDecimal(txt_Count.Text == "" ? null : txt_Count.Text);

                //Do Controll, if has the count then do count
                if (count<=stock)
                {
                    decimal price = Convert.ToDecimal(txt_Price.Text == "" ? null : txt_Price.Text);

                    txt_totalPrice.Text = (count * price).ToString();
                }
                else
                {
                    MessageBox.Show("There is not this scalable product in Stock");
                    Clear();
                }   
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            try
            { 
                using (MarketDbContext marketDbContext = new MarketDbContext())
                {
                    //Get from Input All Information
                    ShopProduct shopProduct = new ShopProduct()
                    {
                        Category = cmbx_category.Text,
                        Name = cmbx_Name.Text,
                        BuyingTime = Convert.ToDateTime(dateTime_buying.Text),
                        Count = Convert.ToInt16(txt_Count.Text == "" ? null : txt_Count.Text),
                        Currency = (Currency)Enum.Parse(typeof(Currency),txt_currency.Text),
                        Price = Convert.ToDecimal(txt_Price.Text == "" ? null : txt_Price.Text),
                        TotalPrice = Convert.ToDecimal(txt_totalPrice.Text == "" ? null : txt_totalPrice.Text),
                        Usage = true,
                        Weight = (Weight)Enum.Parse(typeof(Weight), txt_weight.Text),
                        BuyerId = loginUser.Id
                    };

                    //VALIDATE SECTION
                    #region Validate
                    ValidationContext context = new ValidationContext(shopProduct, null, null);

                    List<ValidationResult> errors = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(shopProduct, context, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            if (result.MemberNames.Contains("Currency"))
                                errorProvider_shop.SetError(txt_currency, result.ErrorMessage);
                            else if (result.MemberNames.Contains("Weight"))
                                errorProvider_shop.SetError(txt_weight, result.ErrorMessage);
                            else if (result.MemberNames.Contains("Price"))
                                errorProvider_shop.SetError(txt_Price, result.ErrorMessage);
                            else if (result.MemberNames.Contains("TotalPrice"))
                                errorProvider_shop.SetError(txt_totalPrice, result.ErrorMessage);
                            else if (result.MemberNames.Contains("Price"))
                                errorProvider_shop.SetError(txt_Count, result.ErrorMessage);
                            else if (result.MemberNames.Contains("Count"))
                                errorProvider_shop.SetError(txt_Price, result.ErrorMessage);
                            else if (result.MemberNames.Contains("Category"))
                                errorProvider_shop.SetError(cmbx_category, result.ErrorMessage);
                            else if (result.MemberNames.Contains("Name"))
                                errorProvider_shop.SetError(cmbx_Name, result.ErrorMessage);
                            else
                            {
                                Clear();
                            }
                        }
                    }
                    #endregion
                    else
                    {
                        //Current Stock Information
                        decimal stock = Convert.ToDecimal(txt_stc_count.Text);
                        //Input Count Information
                        decimal count = Convert.ToDecimal(txt_Count.Text == "" ? null : txt_Count.Text);
                        //Difference
                        decimal resultStock = stock - count;

                        //Controll stock information
                        if (stock>=count && count!=0)
                        {
                            //Do Controll if already have Category and Name of Product then do update  
                            if (marketDbContext.ShopProducts.Where(x=>x.BuyerId==loginUser.Id)
                                                                .Where(x=>x.Category==shopProduct.Category)
                                                                  .Where(y=>y.Name==shopProduct.Name)
                                                                    .Where(z=>z.Price==shopProduct.Price)
                                                                        .Any())
                            {
                                //Select which already have Category and Name 
                                var entryShops = marketDbContext.ShopProducts
                                        .Where(x=>x.BuyerId==loginUser.Id)
                                             .Where(x => x.Category == shopProduct.Category)
                                                 .Where(y=>y.Name==shopProduct.Name)
                                                    .Where(z => z.Price == shopProduct.Price)
                                                      .SingleOrDefault();

                                entryShops.Count += (short)count;
                                entryShops.TotalPrice += shopProduct.TotalPrice;

                                //Update
                                marketDbContext.ShopProducts.Attach(entryShops);

                                //Changed Stated Mode to Modified
                                marketDbContext.Entry(entryShops).State = System.Data.Entity.EntityState.Modified;

                            }
                            else
                            {
                                marketDbContext.ShopProducts.Add(shopProduct);
                            }
                            

                            //In TopSelling product count change
                            var entryTopSelling = marketDbContext.TopSellingStations
                                         .Where(x => x.Name == shopProduct.Name)
                                                .SingleOrDefault();

                            //Save Rest Product Count to Main TopSellingStation
                            entryTopSelling.Count = (short)(Convert.ToDecimal(txt_stc_count.Text) - Convert.ToDecimal(txt_Count.Text));

                            //If stock==0 then must be the same product Usage==false
                            if (resultStock==0)
                            {
                                entryTopSelling.Usage = false;
                            }

                            //Insert Update Information
                            marketDbContext.TopSellingStations.Attach(entryTopSelling);
                            //Changed Stated Mode to Modified
                            marketDbContext.Entry(entryTopSelling).State = System.Data.Entity.EntityState.Modified;

                            marketDbContext.SaveChanges();

                            //Show to user which will counted for update stock
                            txt_stc_count.Text = entryTopSelling.Count.ToString();

                            Clear();

                            SetToDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("There is not this scalable product in Stock");
                            Clear();
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void Clear()
        {
            txt_totalPrice.Text = "";
            txt_Count.Text = "";
        }

        //On DataGridView is Showed Buying Product
        private void SetToDataGridView()
        {
            using (MarketDbContext marketDbContext = new MarketDbContext())
            {
                dataGridView_buyer.DataSource = marketDbContext
                        .ShopProducts
                            .Where(x => x.BuyerId == loginUser.Id)
                                .ToList();
            }
        }
    }
}
