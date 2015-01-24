using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;

namespace PayPalIpnWebFormsDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ConnectionStringSettingsCollection connectionStrings = WebConfigurationManager.ConnectionStrings;
            //string connectionString = connectionStrings["xyz"].ConnectionString;

            using (SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection1))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "addPayPalPayment";

                    string strVal = null;
                    decimal decVal = default(decimal);

                    if ((Request.Form["verify_sign"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["verify_sign"];
                    }
                    cmd.Parameters.AddWithValue("@verify_sign", strVal);

                    if ((Request.Form["address_city"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["address_city"];
                    }
                    cmd.Parameters.AddWithValue("@address_city", strVal);

                    if ((Request.Form["address_country"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["address_country"];
                    }
                    cmd.Parameters.AddWithValue("@address_country", strVal);

                    if ((Request.Form["address_name"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["address_name"];
                    }
                    cmd.Parameters.AddWithValue("@address_name", strVal);

                    if ((Request.Form["address_state"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["address_state"];
                    }
                    cmd.Parameters.AddWithValue("@address_state", strVal);

                    if ((Request.Form["address_status"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["address_status"];
                    }
                    cmd.Parameters.AddWithValue("@address_status", strVal);

                    if ((Request.Form["address_street"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["address_street"];
                    }
                    cmd.Parameters.AddWithValue("@address_street", strVal);

                    if ((Request.Form["address_zip"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["address_zip"];
                    }
                    cmd.Parameters.AddWithValue("@address_zip", strVal);

                    if ((Request.Form["first_name"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["first_name"];
                    }
                    cmd.Parameters.AddWithValue("@first_name", strVal);

                    if ((Request.Form["last_name"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["last_name"];
                    }
                    cmd.Parameters.AddWithValue("@last_name", strVal);

                    if ((Request.Form["payer_business_name"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["payer_business_name"];
                    }
                    cmd.Parameters.AddWithValue("@payer_business_name", strVal);

                    if ((Request.Form["payer_email"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["payer_email"];
                    }
                    cmd.Parameters.AddWithValue("@payer_email", strVal);

                    if ((Request.Form["payer_id"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["payer_id"];
                    }
                    cmd.Parameters.AddWithValue("@payer_id", strVal);

                    if ((Request.Form["payer_status"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["payer_status"];
                    }
                    cmd.Parameters.AddWithValue("@payer_status", strVal);

                    if ((Request.Form["residence_country"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["residence_country"];
                    }
                    cmd.Parameters.AddWithValue("@residence_country", strVal);

                    if ((Request.Form["business"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["business"];
                    }
                    cmd.Parameters.AddWithValue("@business", strVal);

                    if ((Request.Form["item_name1"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["item_name1"];
                    }
                    cmd.Parameters.AddWithValue("@item_name1", strVal);

                    if ((Request.Form["quantity1"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["quantity1"];
                    }
                    cmd.Parameters.AddWithValue("@quantity1", strVal);

                    if ((Request.Form["item_name2"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["item_name2"];
                    }
                    cmd.Parameters.AddWithValue("@item_name2", strVal);

                    if ((Request.Form["quantity2"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["quantity2"];
                    }
                    cmd.Parameters.AddWithValue("@quantity2", strVal);

                    if ((Request.Form["item_name3"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["item_name3"];
                    }
                    cmd.Parameters.AddWithValue("@item_name3", strVal);

                    if ((Request.Form["quantity3"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["quantity3"];
                    }
                    cmd.Parameters.AddWithValue("@quantity3", strVal);

                    if ((Request.Form["item_name4"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["item_name4"];
                    }
                    cmd.Parameters.AddWithValue("@item_name4", strVal);

                    if ((Request.Form["quantity4"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["quantity4"];
                    }
                    cmd.Parameters.AddWithValue("@quantity4", strVal);

                    if ((Request.Form["item_name5"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["item_name5"];
                    }
                    cmd.Parameters.AddWithValue("@item_name5", strVal);

                    if ((Request.Form["quantity5"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["quantity5"];
                    }
                    cmd.Parameters.AddWithValue("@quantity5", strVal);

                    if ((Request.Form["item_name6"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["item_name6"];
                    }
                    cmd.Parameters.AddWithValue("@item_name6", strVal);

                    if ((Request.Form["quantity6"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["quantity6"];
                    }
                    cmd.Parameters.AddWithValue("@quantity6", strVal);

                    if ((Request.Form["receiver_email"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["receiver_email"];
                    }
                    cmd.Parameters.AddWithValue("@receiver_email", strVal);

                    if ((Request.Form["receiver_id"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["receiver_id"];
                    }
                    cmd.Parameters.AddWithValue("@receiver_id", strVal);

                    if ((Request.Form["custom"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["custom"];
                    }
                    cmd.Parameters.AddWithValue("@custom", strVal);

                    if ((Request.Form["invoice"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["invoice"];
                    }
                    cmd.Parameters.AddWithValue("@invoice", strVal);

                    if ((Request.Form["memo"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["memo"];
                    }
                    cmd.Parameters.AddWithValue("@memo", strVal);

                    if ((Request.Form["auth_id"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["auth_id"];
                    }
                    cmd.Parameters.AddWithValue("@auth_id", strVal);

                    if ((Request.Form["auth_exp"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["auth_exp"];
                    }
                    cmd.Parameters.AddWithValue("@auth_exp", strVal);

                    if ((Request.Form["auth_amount"] == null))
                    {
                        decVal = 0;
                    }
                    else
                    {
                        decVal = Convert.ToDecimal(Request.Form["auth_amount"]);
                    }
                    cmd.Parameters.AddWithValue("@auth_amount", decVal);

                    if ((Request.Form["auth_status"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["auth_status"];
                    }
                    cmd.Parameters.AddWithValue("@auth_status", strVal);

                    if ((Request.Form["num_cart_items"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["num_cart_items"];
                    }
                    cmd.Parameters.AddWithValue("@num_cart_items", strVal);

                    if ((Request.Form["parent_txn_id"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["parent_txn_id"];
                    }
                    cmd.Parameters.AddWithValue("@parent_txn_id", strVal);

                    if ((Request.Form["payment_date"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["payment_date"];
                    }
                    cmd.Parameters.AddWithValue("@payment_date", strVal);

                    if ((Request.Form["payment_status"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["payment_status"];
                    }
                    cmd.Parameters.AddWithValue("@payment_status", strVal);

                    if ((Request.Form["payment_type"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["payment_type"];
                    }
                    cmd.Parameters.AddWithValue("@payment_type", strVal);

                    if ((Request.Form["pending_reason"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["pending_reason"];
                    }
                    cmd.Parameters.AddWithValue("@pending_reason", strVal);

                    if ((Request.Form["transaction_entity"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["transaction_entity"];
                    }
                    cmd.Parameters.AddWithValue("@transaction_entity", strVal);

                    if ((Request.Form["txn_id"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["txn_id"];
                    }
                    cmd.Parameters.AddWithValue("@txn_id", strVal);

                    if ((Request.Form["txn_type"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["txn_type"];
                    }
                    cmd.Parameters.AddWithValue("@txn_type", strVal);

                    if ((Request.Form["mc_fee"] == null))
                    {
                        decVal = 0;
                    }
                    else
                    {
                        decVal = Convert.ToDecimal(Request.Form["mc_fee"]);
                    }
                    cmd.Parameters.AddWithValue("@mc_fee", decVal);

                    if ((Request.Form["mc_gross"] == null))
                    {
                        decVal = 0;
                    }
                    else
                    {
                        decVal = Convert.ToDecimal(Request.Form["mc_gross"]);
                    }
                    cmd.Parameters.AddWithValue("@mc_gross", decVal);

                    if ((Request.Form["settle_amount"] == null))
                    {
                        decVal = 0;
                    }
                    else
                    {
                        decVal = Convert.ToDecimal(Request.Form["settle_amount"]);
                    }
                    cmd.Parameters.AddWithValue("@settle_amount", decVal);

                    if ((Request.Form["settle_currency"] == null))
                    {
                        strVal = "";
                    }
                    else
                    {
                        strVal = Request.Form["settle_currency"];
                    }
                    cmd.Parameters.AddWithValue("@settle_currency", strVal);

                    cmd.ExecuteNonQuery();
                }
                cn.Close();
            }

            

        }
    }
}