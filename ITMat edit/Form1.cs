using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stiig;

namespace ITMat_edit
{
    public partial class Form1 : Form
    {
        int orderID;

        public Form1()
        {
            InitializeComponent();
            statusLineLabel.Text = String.Empty;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();

            switch (((Button)sender).Name)
            {
                case "btnSetPickedUp":
                    dal.AddParameter("@ID", orderID, DbType.Int32);
                    string DatePickedUpSet = dal.ExecuteScalar("IF ((SELECT [DatePickedUp] FROM [Loans] WHERE [ID] = @ID) IS NULL) SELECT 0 ELSE SELECT 1").ToString();
                    dal.ClearParameters();

                    if (DatePickedUpSet == "1")
                    {
                        SetMsg("Dato allerede sat", true);
                    }
                    else
                    {
                        dal.AddParameter("@ID", orderID, DbType.Int32);
                        dal.ExecuteNonQuery("UPDATE [Loans] SET [DatePickedUp] = GETDATE() WHERE [ID] = @ID;EXEC dbo.WriteLog 3, 10, @ID, '00000000-0000-0000-0000-000000000000', 'ITMat Edit - Afhentet'");
                        dal.ClearParameters();
                        SetMsg("Dato opdateret på ordre " + orderID, false);
                        UpdateInfo();
                    }
                    break;
                case "btnSetReturned":
                    dal.AddParameter("@ID", orderID, DbType.Int32);
                    string DateReturnedSet = dal.ExecuteScalar("IF ((SELECT [DateReturned] FROM [Loans] WHERE [ID] = @ID) IS NULL) SELECT 0 ELSE SELECT 1").ToString();
                    dal.ClearParameters();

                    if (DateReturnedSet == "1")
                    {
                        SetMsg("Dato allerede sat", true);
                    }
                    else
                    {
                        dal.AddParameter("@ID", orderID, DbType.Int32);
                        dal.ExecuteNonQuery("UPDATE [Loans] SET [DateReturned] = GETDATE() WHERE [ID] = @ID;EXEC dbo.WriteLog 3, 10, @ID, '00000000-0000-0000-0000-000000000000', 'ITMat Edit - Afleveret'");
                        dal.ClearParameters();
                        SetMsg("Dato opdateret på ordre " + orderID, false);
                        UpdateInfo();
                    }
                    break;
                default:
                    break;
            }
        }

        private void SetMsg(string msg, bool error)
        {
            statusLineLabel.Text = msg;
            statusLineLabel.ForeColor = error ? Color.Red : Color.Black;
            statusLineLabel.Visible = true;
        }

        private static bool CheckIfExists(int OrderID)
        {
            bool result = false;

            DataAccessLayer dal = new DataAccessLayer();

            dal.AddParameter("@ID", OrderID, DbType.Int32);
            string exists = dal.ExecuteScalar("IF EXISTS(SELECT DISTINCT * FROM [Loans] WHERE [ID] = @ID) SELECT 1 ELSE SELECT 0").ToString();
            dal.ClearParameters();

            if (exists == "1")
            {
                result = true;
            }
            return result;
        }
        private void KeyPressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (int.TryParse(txtOrderID.Text, out orderID))
            {
                if (CheckIfExists(orderID))
                {
                    UpdateInfo();
                    btnSetPickedUp.Enabled = true;
                    btnSetReturned.Enabled = true;
                }
                else
                {
                    SetMsg("Ordre findes ikke", true);
                    ClearFields();
                }
            }
            else
            {
                SetMsg("Indtast korrekt ID", true);
                ClearFields();
            }
        }

        private void ClearMessage()
        {
            statusLineLabel.Text = "";
        }

        private void ClearFields()
        {
            btnSetPickedUp.Enabled = false;
            btnSetReturned.Enabled = false;

            txtOutlookName.Text = "";
            txtDatePickedUp.Text = "";
            txtDateReturned.Text = "";
        }

        private void UpdateInfo()
        {
            DataAccessLayer dal = new DataAccessLayer();

            dal.AddParameter("@ID", orderID, DbType.Int32);
            DataTable tb = dal.ExecuteDataTable("SELECT dbo.GetOutlookName([CustomerRefID]) AS OutlookName, [DatePickedUp], [DateReturned] FROM LoansCustomers WHERE ID = @ID");
            dal.ClearParameters();

            txtOutlookName.Text = tb.Rows[0]["OutlookName"].ToString();

            object objDatePickedUp = tb.Rows[0]["DatePickedUp"];
            object objDateReturned = tb.Rows[0]["DateReturned"];

            if (objDatePickedUp != DBNull.Value)
                txtDatePickedUp.Text = ((DateTime)objDatePickedUp).ToShortDateString();
            else
                txtDatePickedUp.Text = "";

            if (objDateReturned != DBNull.Value)
                txtDateReturned.Text = ((DateTime)objDateReturned).ToShortDateString();
            else
                txtDateReturned.Text = "";
        }
    }
}