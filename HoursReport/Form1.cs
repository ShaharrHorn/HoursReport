using System;
using System.IO;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;

namespace HoursReport
{
    public partial class Form1 : Form
    {
        Companies companies = new Companies();
        bool isFileExist;
        string fileName;
        string currentCompanyName;

        public Form1()
        {
            InitializeComponent();
            checkOrCreateFile();
        }

        private void checkOrCreateFile()
        {
            DateTime now = DateTime.Now;
            DateTime dateName = DateTime.Now;

            for (int i = 0; i < 7; i++)
            {
                dateName = now.AddDays(-i);
                if (dateName.DayOfWeek == DayOfWeek.Sunday)
                {
                    fileName = dateName.ToString("yyyyMMdd") + ".xls";
                    isFileExist = File.Exists(fileName);
                    break;
                }
            }

            if (isFileExist)
            {
                papulateFile(this.fileName);
            }

        }

        private void papulateFile(string fileName)
        {
            var workbook = Workbook.Load(fileName);
            string x = workbook.ToString();
            var worksheet = workbook.Worksheets[0]; // assuming only 1 worksheet
            var cells = worksheet.Cells;
            string companyName, startTime, endTime, totalTime, currentDay = null;
            Company temp = null;

            for (int rowIndex = cells.FirstRowIndex; rowIndex <= cells.LastRowIndex; rowIndex++)
            {
                Row row = cells.GetRow(rowIndex);
                if (!row.GetCell(2).ToString().Equals("end") && !string.IsNullOrEmpty((row.GetCell(2)).ToString()))
                {
                    companyName = row.GetCell(0).ToString();
                    startTime = row.GetCell(1).ToString();
                    endTime = row.GetCell(2).ToString();
                    totalTime = row.GetCell(3).ToString();
                    if (!companies.companies.ContainsKey(companyName))      // if we need to create a new company.
                    {
                        temp = new Company(companyName);
                        companies.companies.Add(companyName, temp);
                    }
                    else
                    {
                        companies.companies.TryGetValue(companyName, out temp);
                    }
                    WorkingHours wh = new WorkingHours(startTime, endTime, totalTime, currentDay);
                    temp.workingHours.Add(wh);
                    if (!companies_listbox.Items.Contains(companyName))
                    {
                        try
                        {
                            companies_listbox.Items.Add(companyName);
                        }
                        catch (Exception ex)
                        {
                            string y = ex.Message;
                        }
                    }

                }
                else
                {
                    if (!string.IsNullOrEmpty((row.GetCell(2)).ToString()))
                        currentDay = row.GetCell(0).ToString();
                }
            }
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(company_textBox.Text.Trim()))
                MessageBox.Show("Fill the company name");
            else
            {
                if (companies_listbox.Items.Contains(company_textBox.Text))
                    MessageBox.Show("Company is allready listed");
                else
                {
                    try
                    {
                        companies_listbox.Items.Add(company_textBox.Text);
                        Company company = new Company(company_textBox.Text);
                        companies.addCompany(company);
                    }
                    catch (Exception ex)
                    {
                        string x = ex.Message;

                    }
                }
            }
            company_textBox.Text = string.Empty;
        }

        // DateTime.Now.ToString("hh:mm:ss")
        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (companies.companies[companies_listbox.SelectedItem.ToString()].workingHours.Count == 0)
                {
                    companies.companies.Remove(companies_listbox.SelectedItem.ToString());
                    companies_listbox.Items.Remove(companies_listbox.SelectedItem);
                    companies.companies.Remove(companies_listbox.SelectedItem.ToString());
                }
                else
                {
                    DialogResult dialog = MessageBox.Show($@"Do you really want to delete {companies_listbox.SelectedItem.ToString()} ? The working hours will be deleted. ",
                        "Delete", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.No)
                    {

                    }
                    else if (dialog == DialogResult.Yes)
                    {
                        companies.companies.Remove(companies_listbox.SelectedItem.ToString());
                        companies_listbox.Items.Remove(companies_listbox.SelectedItem);
                        timeListView.Items.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                string x = ex.Message;
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (companies_listbox.SelectedItem == null)
            {
                MessageBox.Show("You have to choose company first.");
            }
            else
            {
                currentCompanyName = companies_listbox.SelectedItem.ToString();
                companies.companies[currentCompanyName].workingHours
                .Add(new WorkingHours(DateTime.Now.ToString("HH:mm:ss")));
                start_button.Enabled = false;
                end_button.Enabled = true;
            }
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            if (companies_listbox.SelectedItem == null)
            {
                MessageBox.Show("You have to choose company first.");
            }
            else
            {
                try
                {
                    WorkingHours temp = companies.companies[currentCompanyName]
                    .workingHours[companies.companies[currentCompanyName].workingHours.Count - 1];

                    temp.endTime = DateTime.Now.ToString("HH:mm:ss");
                    DateTime endTime = DateTime.Parse(temp.endTime);
                    DateTime startingTime = DateTime.Parse(temp.startTime);
                    temp.sum = (endTime - startingTime).ToString();
                    start_button.Enabled = true;
                    end_button.Enabled = false;

                    if (currentCompanyName.Equals(companies_listbox.SelectedItem.ToString()))
                    {
                        ListViewItem x = new ListViewItem(temp.startTime);
                        x.SubItems.Add(temp.endTime);
                        x.SubItems.Add(temp.sum);
                        x.SubItems.Add(DateTime.Now.DayOfWeek.ToString());
                        timeListView.Items.Add(x);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void companies_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Company temp = null;
            try
            {
                timeListView.Items.Clear();
                if (companies_listbox.SelectedItem != null)
                    temp = companies.companies[companies_listbox.SelectedItem.ToString()];
                if (temp != null)
                {
                    for (int i = 0; i < temp.workingHours.Count; i++)
                    {
                        ListViewItem x = new ListViewItem(temp.workingHours[i].startTime);
                        x.SubItems.Add(temp.workingHours[i].endTime);
                        x.SubItems.Add(temp.workingHours[i].sum);
                        x.SubItems.Add(temp.workingHours[i].day.ToString());
                        timeListView.Items.Add(x);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Queue q = new Queue();
            Workbook excelFile = new Workbook();
            Worksheet workingHours = new Worksheet("firstSheet");
            DateTime sumForEachCompanyDay = new DateTime(2014, 06, 21, 0, 0, 0);        // not including days counting
            DateTime sumOfWeek = new DateTime(2014, 06, 21, 0, 0, 0);                   // not including days counting
            bool thereIsTotal = false;
            int row = 0;
            for (int i = 0; i < 6; i++)
            {
                Worksheet s = new Worksheet(":sd");
                workingHours.Cells[row, 0] = new Cell(((DayOfWeek)(i)).ToString());
                workingHours.Cells[row, 1] = new Cell("start");
                workingHours.Cells[row, 2] = new Cell("end");
                workingHours.Cells[row, 3] = new Cell("sum");
                row++;
                try
                {
                    foreach (Company c in companies.companies.Values)
                    {

                        foreach (WorkingHours wh in c.workingHours)
                        {
                            if (wh.day == (DayOfWeek)(i))
                            {
                                q.Enqueue(wh);
                            }
                        }
                        while (q.Count != 0)
                        {
                            thereIsTotal = true;
                            WorkingHours temp = (WorkingHours)q.Dequeue();
                            workingHours.Cells[row, 0] = new Cell(c.name);
                            workingHours.Cells[row, 1] = new Cell(temp.startTime);
                            workingHours.Cells[row, 2] = new Cell(temp.endTime);
                            workingHours.Cells[row, 3] = new Cell(temp.sum);
                            DateTime d1 = DateTime.Parse(temp.sum);
                            sumForEachCompanyDay = sumForEachCompanyDay.Add(d1.TimeOfDay);
                            row++;
                        }
                        if (thereIsTotal)
                        {
                        workingHours.Cells[row, 0] = new Cell("total:");
                        workingHours.Cells[row, 3] = new Cell(sumForEachCompanyDay.ToString("HH: mm:ss "));
                        row++;
                        }
                        thereIsTotal = false;
                        sumOfWeek = sumOfWeek.Add(sumForEachCompanyDay.TimeOfDay);
                        sumForEachCompanyDay = new DateTime(2014, 06, 21, 0, 0, 0);
                    }
                    //            first.Cells.ColumnWidth[0, 0] = 100;
                    workingHours.Cells[row, 0] = new Cell("Week Total:");
                    workingHours.Cells[row, 3] = new Cell(sumOfWeek.ToString("HH: mm:ss "));
                    excelFile.Worksheets.Clear();
                    excelFile.Worksheets.Add(workingHours);
                    excelFile.Save(fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
