using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace MainSystem.Accounting
{
    class DbQueries
    {
        DbConnect con = new DbConnect();

        public DataTable studentProfileDisplay()
        {
            string query = @"SELECT *, concat(sp.LastName, ', ' , sp.FirstName, ' ', sp.MiddleName) as 'fullname'
                            FROM studentprofile as sp
                            order by sp.idstudentprofile";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable balanceDetails(string student_id)
        {
            string query = @"select  concat(sp.LastName, ', ', sp.FirstName) as 'Name', fv.fee_type, ad.current_balance,
                            ad.paid_amount, ifnull(ad.payment_status, 'None')  as payment_status, ad.adid, ad.fid
                            from accountdetails as ad
                            left join studentprofile as sp
                            on (ad.spid = sp.idstudentprofile)
                            left join feevalues as fv
                            on (ad.fid = fv.f_key)
                            where ad.spid = '" + student_id + @"'
                            group by ad.spid";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable paymentHistory(string adid)
        {
            string query = @"select pt.amount_paid, ad.current_balance, pt.date_paid
                            from payment as pt
                            left join accountdetails as ad
                            on (pt.adid = ad.adid)
                            where pt.adid = '" + adid + "'";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable feevalues()
        {
            string query = @"Select * 
                             from feevalues";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable countPayment()
        {
            string query = "SELECT pid FROM payment";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable getAdid(string id)
        {
            string query = @"SELECT *
                            FROM accountdetails
                            WHERE accountdetails.spid = '" + id + "'";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable StudentPaymentLog()
        {
            string query = "SELECT * FROM student_payment_logs";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public void updatePayments(string trans_no, string payment_type, string cheque_no, string amount_paid, string date_paid, string eid, string adid, string additional_details, string payment_to, string f_key)
        {
            string query = @"insert into payment(transaction_no, payment_type, cheque_no, amount_paid, date_paid, eid, adid, additional_details, payment_to, fid)
                            values ('" + trans_no + "','" + payment_type + "','" + cheque_no + "', '" + amount_paid + "','" + date_paid + "','" + eid + "','" + adid + "','" + additional_details + "','" + payment_to + "','" + f_key + "')";
            con.executeQuery(query);
        }

        public void updateFee(string fee_type, string fee_description, string current_amount, string date_created, string school_year_start, string school_year_end, string f_key)
        {
            string query = @"insert into feevalues(fee_type, fee_description, current_amount, date_created, school_year_start, school_year_end, f_key)
                            values ('" + fee_type + "', '" + fee_description + "', '" + current_amount + "', '" + date_created + "', '" + school_year_start + "', '" + school_year_end + "','" + f_key + "')";
            con.executeQuery(query);
        }

        public void updateNewFee(string id, string fee_type, string fee_description, string current_amount, string date_modified, string school_year_start, string school_year_end)
        {
            string query = @"update feevalues set fee_type = '" + fee_type + "', fee_description = '" + fee_description + "', current_amount = '" + current_amount + "', date_modified = '" + date_modified + @"'
                            , school_year_start = '" + school_year_start + "', school_year_end = '" + school_year_end + @"'
                            where feevalues.f_key = '" + id + "'";
            con.executeQuery(query);
        }

        public void updateAccountDetails(string adid, string current_balance, string paid_amount, string payment_status)
        {
            string query = @"update accountdetails set current_balance = '" + current_balance + "', paid_amount = '" + paid_amount + "', payment_status = '" + payment_status + @"'
                            where accountdetails.adid = '" + adid + "'";
            con.executeQuery(query);
        }


        public DataTable totalFeeAmount(string fee_type)
        {
            string query = @"select Sum(current_amount)
                            from feevalues
                            where fee_type = '" + fee_type + "'";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public void updateAccountDetailsFee(string total_amount, string current_balance, string f_key)
        {
            string query = @"update accountdetails set total_amount = '" + total_amount + "', current_balance = '" + current_balance + @"'
                            where accountdetails.fid = '" + f_key + "'";
            con.executeQuery(query);
        }

        public DataTable accountDetails(string f_key)
        {
            string query = @"Select *
                            from accountdetails
                            where accountdetails.fid = '" + f_key + "'";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public void updatePaymentLog(string student_id, string payment_id, string date_created, string grade_level, string current_balance, string amount_paid, string payment_status)
        {
            string query = @"insert into student_payment_logs(student_id, payment_id, date_created, grade_level, current_balance, amount_paid, payment_status)
                            values ('" + student_id + "','" + payment_id + "','" + date_created + "', '" + grade_level + "','" + current_balance + "','" + amount_paid + "','" + payment_status + "')";
            con.executeQuery(query);
        }

        public DataTable User(string uname)
        {
            string query = "SELECT * FROM usertable INNER JOIN employee on usertable.idemp = employee.empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable SearchStudent(string lastname)
        {
            string query = @"SELECT *, concat(sp.LastName, ', ' , sp.FirstName, ' ', sp.MiddleName) as 'fullname'
                            FROM studentprofile as sp
                            where LastName 
                            like '" + lastname + "%'";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable SearchPayment(string student_id)
        {
            string query = "SELECT * FROM student_payment_logs WHERE student_id LIKE '" + student_id + "%'";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

    }
}
