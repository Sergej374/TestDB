using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestsDB.TeacherForms
{
    public partial class TestStatisticsForm : Form
    {
        public TestStatisticsForm()
        {
            InitializeComponent();

            SqlCommand cmd = new SqlCommand("SELECT Tests.Name_test AS TestName, Students.Name_student AS StudentName," +
                "Results.Grade AS Grade, Results.Date_testing AS TestingDate FROM Tests INNER JOIN Results ON Tests.ID_test = Results.ID_test " +
                "INNER JOIN Students ON Results.ID_student = Students.ID_student " +
                "ORDER BY Results.Date_testing ASC, Tests.Name_test, Students.Name_student DESC", groupsTableAdapter1.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            statisticsDateView.DataSource = dataTable;
        }

    }
}
