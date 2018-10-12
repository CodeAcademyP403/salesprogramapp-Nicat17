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
    public partial class TopSellingStation : Form
    {
        Form Form = new Form();
        
        private int _Id=-1;

        public TopSellingStation()
        {
            InitializeComponent();

            using (MarketDbContext marketDbContext = new MarketDbContext())
            {
                //set all product to datagridview
                dataGrid_allProduct.DataSource = marketDbContext.TopSellingStations.ToList();
                dataGrid_allProduct.Columns[1].Visible = false;

                //set all buyer to combobox
                cmbx_all_buyer.DataSource = marketDbContext.Buyers.ToList();

                //set all user to datagridview
                dataGridView_user.DataSource = marketDbContext.Buyers.ToList();
                dataGridView_user.Columns[0].Visible = false;
                dataGridView_user.Columns[2].Visible = false;
                dataGridView_user.Columns[3].Visible = false;

                cmbx_all_buyer.DisplayMember = "Name";
                cmbx_all_buyer.ValueMember = "Id";
            }
        }
        public TopSellingStation(Form form):this()
        {
            Form = form;
        }

        private void TopSellingStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Close();
        }

        private void btn_go_main_Click(object sender, EventArgs e)
        {
            Hide();
            Form.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                //add all product information from User
                Model.TopSellingStation topSellingStation = new Model.TopSellingStation()
                {
                    Name = txt_Name.Text,
                    Category = txt_Category.Text,
                    Price = Convert.ToDecimal(txt_Price.Text==""?null:txt_Price.Text),
                    Count = Convert.ToInt16(txt_Count.Text==""?null:txt_Count.Text),
                    SellingTime = Convert.ToDateTime(date_time.Text),
                    Currency = (Currency)cmbx_Currency.SelectedIndex,
                    Usage = Convert.ToBoolean(cmbx_Usage.Text),
                    Weight = (Weight)cmbx_Weight.SelectedIndex
                };

                //VALIDATE
                #region Validate
                ValidationContext context = new ValidationContext(topSellingStation, null, null);

                List<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(topSellingStation, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        if (result.MemberNames.Contains("Name"))
                            errorProvider_Name.SetError(txt_Name, result.ErrorMessage);
                        else if (result.MemberNames.Contains("Category"))
                            errorProvider_Name.SetError(txt_Category, result.ErrorMessage);
                        else if (result.MemberNames.Contains("Price"))
                            errorProvider_Name.SetError(txt_Price, result.ErrorMessage);
                        else if (result.MemberNames.Contains("Count"))
                            errorProvider_Name.SetError(txt_Count, result.ErrorMessage);
                        else
                        {
                            Clear();
                        }
                    }    
                }
                #endregion
                else
                {
                    //save all product to DB
                    using (MarketDbContext marketDbContext = new MarketDbContext())
                    {
                        marketDbContext.TopSellingStations.Add(topSellingStation);

                        marketDbContext.SaveChanges();

                        dataGrid_allProduct.DataSource = marketDbContext.TopSellingStations.ToList();
                    }
                    Clear();
                } 
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void TopSellingStation_Load(object sender, EventArgs e)
        {
            try
            {
                //on Load combobox loading
                cmbx_Currency.DataSource = Enum.GetNames(typeof(Currency));
                cmbx_Weight.DataSource = Enum.GetNames(typeof(Weight));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //when will occur error then again enter input so will delete error
        private void txt_Name_Enter(object sender, EventArgs e)
        {
            errorProvider_Name.Clear();
        }

        //when double click to datagridview so set information again txtbox and so on
        private void dataGrid_allProduct_DoubleClick(object sender, EventArgs e)
        {
            if (dataGrid_allProduct.CurrentRow.Index!=-1)
            {
                _Id = (int)dataGrid_allProduct.CurrentRow.Cells["Id"].Value;

                using (MarketDbContext marketDbContext = new MarketDbContext())
                {
                    Model.TopSellingStation _TopSellingStation = marketDbContext.TopSellingStations
                            .Where(x => x.Id == _Id)
                                .FirstOrDefault();

                    txt_Name.Text = _TopSellingStation.Name;
                    txt_Category.Text = _TopSellingStation.Category;
                    txt_Count.Text = _TopSellingStation.Count.ToString();
                    txt_Price.Text = _TopSellingStation.Price.ToString();
                }
                btn_add.Enabled = false;
            };
        }

        //delete buttun: delete any product in DB
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Id != -1)
                {
                    using (MarketDbContext marketDbContext = new MarketDbContext())
                    {
                        Model.TopSellingStation _TopSellingStation = marketDbContext.TopSellingStations.Where(x => x.Id == _Id).FirstOrDefault();
                        marketDbContext.TopSellingStations.Remove(_TopSellingStation);
                        marketDbContext.SaveChanges();
                        dataGrid_allProduct.DataSource = marketDbContext.TopSellingStations.ToList();
                        _Id = -1;
                    }
                    //on double click 'add button' will visibility=false. So must be now visibility=true
                    btn_add.Enabled = true;

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                Clear();
            }
        }
        private void Clear()
        {
            txt_Name.Text = "";
            txt_Category.Text = "";
            txt_Count.Text = "";
            txt_Price.Text = "";
        }

        private void dataGrid_allProduct_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_messageforuser.Text = "Please, Double Click to Row For Update Or Delete";
        }

        private void dataGrid_allProduct_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            lbl_messageforuser.Text = "";
        }

        //update button: select current products and change any information
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Id != -1)
                {
                    using (MarketDbContext marketDbContext = new MarketDbContext())
                    {
                        Model.TopSellingStation _TopSellingStation = marketDbContext.TopSellingStations.Where(x => x.Id == _Id).FirstOrDefault();

                        _TopSellingStation.Name = txt_Name.Text;
                        _TopSellingStation.Category = txt_Category.Text;
                        _TopSellingStation.Price = Convert.ToDecimal(txt_Price.Text == "" ? null : txt_Price.Text);
                        _TopSellingStation.Count = Convert.ToInt16(txt_Count.Text == "" ? null : txt_Count.Text);
                        _TopSellingStation.SellingTime = Convert.ToDateTime(date_time.Text);
                        _TopSellingStation.Currency = (Currency)cmbx_Currency.SelectedIndex;
                        _TopSellingStation.Usage = Convert.ToBoolean(cmbx_Usage.Text);
                        _TopSellingStation.Weight = (Weight)cmbx_Weight.SelectedIndex;

                        marketDbContext.SaveChanges();
                        dataGrid_allProduct.DataSource = marketDbContext.TopSellingStations.ToList();
                        _Id = -1;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                Clear();
                btn_add.Enabled = true;
            }
        }

        //buyer's name selected value 
        private void cmbx_all_buyer_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string val = (sender as ComboBox).SelectedValue.ToString();
                int selectedVal = Convert.ToInt32((val == "" ? null : val));

                //select current buyer with Id
                using (MarketDbContext marketDb = new MarketDbContext())
                {
                    Buyer buyer = marketDb.Buyers.Where(x => x.Id == selectedVal).SingleOrDefault();
                    txt_percent.Text = buyer.Percent.ToString();
                };
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //mention user information to DB
        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                int val = (int)cmbx_all_buyer.SelectedValue;

                using (MarketDbContext marketDb = new MarketDbContext())
                {
                    //get which id==selected user id so change or update percent
                    Buyer buyer = marketDb.Buyers.Where(x=>x.Id==val).SingleOrDefault();
                    buyer.Percent = Convert.ToDecimal(txt_percent.Text == "" ? null : txt_percent.Text);

                    //VALIDATE
                    #region Validate
                    ValidationContext context = new ValidationContext(buyer, null, null);

                    List<ValidationResult> errors = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(buyer, context, errors, true))
                    {
                        foreach (ValidationResult result in errors)
                        {
                            if (result.MemberNames.Contains("Percent"))
                            {
                                errorProvider_Percent.SetError(txt_percent, result.ErrorMessage);
                                txt_percent.Text = "";
                            }
                        }
                    }
                    #endregion
                    else
                    {
                        //Insert Update Information
                        marketDb.Buyers.Attach(buyer);
                        //Changed Stated Mode to Modified
                        marketDb.Entry(buyer).State = System.Data.Entity.EntityState.Modified;

                        marketDb.SaveChanges();
                        //set all user to datagridview
                        dataGridView_user.DataSource = marketDb.Buyers.ToList();
                    }
                };   
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }

        private void txt_percent_Enter(object sender, EventArgs e)
        {
            txt_percent.Text = "";
        }
    }
}
