using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace MainSystem.Employee
{
    class DbQueries
    {
        DbConnect con = new DbConnect();

        public DataTable EmployeeDisplay()
        {
            string query = @"SELECT *, concat(emp.last_name, ', ' , emp.first_name, ' ', emp.middle_name) as 'fullname' 
                            FROM employee as emp LEFT JOIN usertable on usertable.idemp = emp.empID
                            where (emp.status = 1 AND usertable.status = 1 OR usertable.userID IS NULL)
                            order by empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable ArchiveEmployeeDisplay()
        {
            string query = @"SELECT *, concat(emp.last_name, ', ' , emp.first_name, ' ', emp.middle_name) as 'fullname'
                            FROM employee as emp LEFT JOIN usertable on usertable.idemp = emp.empID
                            where (emp.status = 0 AND usertable.status = 0 OR usertable.userID IS NULL)
                            order by empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable searchEmployee(string lastname)
        {
            string query = @"SELECT *, concat(emp.last_name, ', ' , emp.first_name, ' ', emp.middle_name) as 'fullname' 
                            FROM employee as emp LEFT JOIN usertable ON emp.empID = usertable.idemp
                            where (emp.status = 1 AND emp.last_name AND usertable.status = 1)
                            LIKE '" + lastname + "%'" +
                            @"order by empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable searcArchivedhEmployee(string lastname)
        {
            string query = @"SELECT *, concat(emp.last_name, ', ' , emp.first_name, ' ', emp.middle_name) as 'fullname'
                            FROM employee as emp
                            where status = 0 AND last_name 
                            like '" + lastname + "%'" +
                            "order by empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public DataTable User(string uname)
        {
            string query = "SELECT * FROM usertable INNER JOIN employee on usertable.idemp = employee.empID";
            DataTable itmContainer = con.Select(query);
            return itmContainer;
        }

        public void addEmployee(string first_name, string last_name, string middle_name, string birth_date, string birth_place, string contactNo, string sex, string religion, string marital_status, string status)
        {
            string query = @"INSERT INTO employee(first_name, last_name, middle_name, birth_date, birth_place, contactNo, sex, religion, marital_status, status)
                            VALUES ('" + first_name + "', '" + last_name + "', '" + middle_name + "', '" + birth_date + "', '" + birth_place + "', '" + contactNo + "', '" + sex + "', '" + religion + "', '" + marital_status + "', '" + status + "')";
            con.executeQuery(query);
        }

        public void updateEmployee(string first_name, string last_name, string middle_name, string birth_date, string birth_place, string contactNo, string sex, string religion, string marital_status, string status, string empID)
        {
            string query = "UPDATE employee SET first_name='" + first_name +
                "',last_name='" + last_name +
                "',middle_name='" + middle_name +
                "',birth_date='" + birth_date +
                "',birth_place='" + birth_place +
                "',contactNo='" + contactNo +
                "',sex='" + sex +
                "',religion='" + religion +
                "',marital_status='" + marital_status +
                "',status='" + status +
                "' WHERE empID='" + empID + "'";
            con.executeQuery(query);
        }
        public void updateAccountStatus(string idemp, string status, string userID)
        {
            string query = "UPDATE usertable SET idemp='" + idemp + "',status='" + status + "'WHERE userID='" + userID + "'";
            con.executeQuery(query);
        }

    }
}
