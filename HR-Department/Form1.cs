using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace HR_Department
{
    public partial class Form1 : Form
    {
        private string path1;
        private string path2;
        private XDocument doc1;
        private XDocument doc2;

        public Form1()
        {
            InitializeComponent();
            path1 = @"..\..\Data\Departments.xml";
            path2 = @"..\..\Data\Employees.xml";
            doc1 = XDocument.Load(path1);
            doc2 = XDocument.Load(path2);
        }

        private string GetDepName(string title, string action, string depName = "")
        {
            Departments depForm = new Departments();
            depForm.Title = title;
            depForm.Action = action;
            depForm.DepName = depName;

            if (depForm.ShowDialog() == DialogResult.OK)
                return depForm.DepName;
            else
                return "Failed";
        }

        private void LoadDepartments()
        {
            var deps = doc1.Element("root").Elements("department").ToList();
            DepartmentsList.Items.Clear();
            foreach (var dep in deps)
                DepartmentsList.Items.Add(dep.Attribute("name").Value);
            DepartmentsList.SelectedIndex = 0;
        }

        private void AddDepartmentItem_Click(object sender, EventArgs e)
        {
            string result = GetDepName("Добавление департамента", "Добавить");
            if (result != "Failed")
            {
                doc1.Element("root").Add(new XElement("department",
                    new XAttribute("name", result)));
                doc1.Save(path1);
                MessageBox.Show("Департамент успешно добавлен!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDepartments();
            }
            else
            {
                MessageBox.Show("Не удалось добавить департамент!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DelDepartmentItem_Click(object sender, EventArgs e)
        {
            string result = GetDepName("Удаление департамента", "Удалить");
            if (result != "Failed")
            {
                var dep = doc1.Element("root").Elements("department")
                    .Where(d => d.Attribute("name").Value == result).FirstOrDefault();
                if (dep == null)
                {
                    MessageBox.Show("Департамент не найден!", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dep.Remove();
                    doc1.Save(path1);
                    MessageBox.Show("Департамент успешно удален!", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDepartments();
                }
            }
            else
            {
                MessageBox.Show("Не удалось удалить департамент!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditDepartmentItem_Click(object sender, EventArgs e)
        {
            string depName = DepartmentsList.SelectedItem.ToString();
            var dep = doc1.Element("root").Elements("department")
                .Where(d => d.Attribute("name").Value == depName).FirstOrDefault();

            string result = GetDepName("Изменение департамента", "Сохранить", depName);
            if (result != "Failed")
            {
                dep.Attribute("name").Value = result;
                doc1.Save(path1);
                MessageBox.Show("Департамент успешно изменен", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDepartments();
            }
            else
            {
                MessageBox.Show("Не удалось изменить департамент!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void DepartmentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string depName = DepartmentsList.SelectedItem.ToString();
            var emps = doc2.Element("root").Elements("employee")
                .Where(emp => emp.Attribute("dep").Value == depName).ToList();
            EmployeesList.Items.Clear();
            foreach (var emp in emps)
            {
                EmployeesList.Items.Add(emp.Attribute("name").Value);
            }
        }

        private void EmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var empName = EmployeesList.SelectedItem.ToString();
            var emp = doc2.Element("root").Elements("employee")
                .Where(x => x.Attribute("name").Value == empName).FirstOrDefault();
            string photoPath = @"..\..\Images\" + emp.Attribute("photo").Value;
            if (File.Exists(photoPath))
                PhotoBox.Image = Image.FromFile(photoPath);
            else
                PhotoBox.Image = Image.FromFile(@"..\..\Images\profile.png");

            NameField.Text = emp.Attribute("name").Value;            
        }
    }
}
