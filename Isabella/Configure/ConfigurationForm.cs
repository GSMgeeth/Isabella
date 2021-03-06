﻿using Isabella.Role;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isabella.Configure
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            CurrentDeptDataGridView.DataSource = getCurrentDept();
            currentIssueDataGridView.DataSource = getCurrentIssue();

            CurrentDeptDataGridView.Columns[0].Visible = false;
            currentIssueDataGridView.Columns[0].Visible = false;
        }

        private System.Data.DataTable getCurrentIssue()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from issuedTo");

            table.Load(reader);

            return table;
        }

        private System.Data.DataTable getCurrentDept()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            MySqlDataReader reader = DBConnection.getData("select * from department");

            table.Load(reader);

            return table;
        }

        private void addNewDeptBtn_Click(object sender, EventArgs e)
        {
            string newDept = newDeptTxtBox.Text;

            if ((newDept != null) && (!newDept.Equals("")))
            {
                Department dept = new Department(newDept);

                MySqlDataReader reader = DBConnection.getData("select * from department where deptName='" + newDept + "'");

                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("This department already exists!", "Add department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    reader.Close();
                    Database.saveDepartment(dept);

                    CurrentDeptDataGridView.DataSource = getCurrentDept();
                    /*
                    Form1 mainFrm = new Form1();
                    ReportForm repFrm = new ReportForm();

                    mainFrm.fillDeptComboBox();
                    repFrm.fillDeptCmb();
                    */
                    newDeptTxtBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter the new department name!", "Add department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CurrentDeptDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string tmp = CurrentDeptDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            int deptNo = Int32.Parse(tmp);

            try
            {
                Department dept = new Department(deptNo);

                DialogResult result = MessageBox.Show("Are you sure?", "Delete Department", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Database.deleteDepartment(dept);

                    CurrentDeptDataGridView.DataSource = getCurrentDept();
                    /*
                    Form1 mainFrm = new Form1();
                    ReportForm repFrm = new ReportForm();

                    mainFrm.fillDeptComboBox();
                    repFrm.fillDeptCmb();
                    */
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Delete Department", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewIssuePlaceBtn_Click(object sender, EventArgs e)
        {
            string newIssuedPlace = newIssuePlaceTxtBox.Text;

            if ((newIssuedPlace != null) && (!newIssuedPlace.Equals("")))
            {
                IssuedTo place = new IssuedTo(newIssuedPlace);

                MySqlDataReader reader = DBConnection.getData("select * from issuedTo where place='" + newIssuedPlace + "'");

                if (reader.HasRows)
                {
                    reader.Close();
                    MessageBox.Show("This place already exists!", "Add issueing place", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    reader.Close();
                    Database.saveIssuedPlace(place);

                    currentIssueDataGridView.DataSource = getCurrentIssue();

                    //Form1 mainFrm = new Form1();
                    //ReportForm repFrm = new ReportForm();

                    //mainFrm.fillDeptComboBox();
                    //repFrm.fillIssuedPlace();

                    newIssuePlaceTxtBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter the new issueing place name!", "Add issueing place", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
