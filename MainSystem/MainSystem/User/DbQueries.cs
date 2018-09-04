﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MainSystem.User
{
    class DbQueries
    {
        DbConnect con = new DbConnect();

        public DataTable EmployeeDisplay()
        {
            string query = @"SELECT *, concat(emp.last_name, ', ' , emp.first_name, ' ', emp.middle_name) as 'fullname'
                            FROM employee as emp
                            where status = 1
                            order by empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable UserDisplay()
        {
            string query = @"SELECT *, concat(emp.last_name, ', ' , emp.first_name, ' ', emp.middle_name) as 'fullname'
                             FROM usertable INNER JOIN employee as emp on usertable.idemp = emp.empID
                             WHERE usertable.status = 1 AND emp.status = 1";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable searchEmployee(string lastname)
        {
            string query = @"SELECT *, concat(emp.last_name, ', ' , emp.first_name, ' ', emp.middle_name) as 'fullname'
                            FROM employee as emp
                            where status = 1 AND last_name 
                            like '" + lastname + "%'" +
                            "order by empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable countUserID()
        {
            string query = @"SELECT userID from usertable";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable User(string uname)
        {
            string query = "SELECT * FROM usertable INNER JOIN employee on usertable.idemp = employee.empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public void addUser(string username, string password, string idemp, string restrictions, string status)
        {
            string query = @"INSERT INTO usertable(username, password, idemp, restrictions, status)
                            VALUES ('" + username + "', '" + password + "', '" + idemp + "', '" + restrictions + "', '" + status + "')";
            con.executeQuery(query);
        }

        public void updatUser(string username, string password, string idemp, string restrictions, string status, string userID)
        {
            string query = "UPDATE usertable SET username='" + username +
                "',password='" + password +
                "',idemp='" + idemp +
                "',restrictions='" + restrictions +
                "',status='" + status +
                "' WHERE userID='" + userID + "'";
            con.executeQuery(query);
        }
    }
}