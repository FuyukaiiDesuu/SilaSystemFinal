﻿using System;
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
                            ad.paid_amount, ifnull(ad.payment_status, 'None')  as payment_status, ad.adid
                            from accountdetails as ad
                            left join studentprofile as sp
                            on (ad.spid = sp.idstudentprofile)
                            left join feevalues as fv
                            on (ad.fid = fv.fid)
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

        public void updatePayments(string trans_no, string payment_type, string cheque_no, string amount_paid, string date_paid, string eid, string adid)
        {
            string query = @"insert into payment(transaction_no, payment_type, cheque_no, amount_paid, date_paid, eid, adid)
                            values ('" + trans_no + "','" + payment_type + "','" + cheque_no + "', '" + amount_paid + "','" + date_paid + "','" + eid + "','" + adid + "')";
            con.executeQuery(query);
        }

        public void updateFee(string fee_type, string fee_description, string current_amount, string date_created, string school_year_start, string school_year_end)
        {
            string query = @"insert into feevalues(fee_type, fee_description, current_amount, date_created, school_year_start, school_year_end)
                            values ('" + fee_type + "', '" + fee_description + "', '" + current_amount + "', '" + date_created + "', '" + school_year_start + "', '" + school_year_end + "')";
            con.executeQuery(query);
        }

        public void updateNewFee(string id, string fee_type, string fee_description, string current_amount, string date_modified, string school_year_start, string school_year_end)
        {
            string query = @"update feevalues set fee_type = '" + fee_type + "', fee_description = '" + fee_description + "', current_amount = '" + current_amount + "', date_modified = '" + date_modified + @"'
                            , school_year_start = '" + school_year_start + "', school_year_end = '" + school_year_end + @"'
                            where feevalues.fid = '" + id + "'";
            con.executeQuery(query);
        }
    }
}
