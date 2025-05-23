﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Shapes;
using WindowsAppDevelopmentVM.Utils;
using Path = System.IO.Path;

namespace WindowsAppDevelopmentVM
{
    public partial class DataGridTestWindow : Window
    {
        private DataGridTestVM _vm;
        public DataGridTestWindow()
        {
            InitializeComponent();
            _vm = new DataGridTestVM();
            DataContext = _vm;

            //init();
            //DataTableUtils.Add(prn1, _vm.Dt);
            //DataTableUtils.Add(prn2, _vm.Dt);

            //DataTableUtils.Add(new Cat("Hello Kitty", "Red"), _vm.Dt);
            /*var dataTable = _vm.Dt;
            var row = dataTable.NewRow();
            row["No"] = 1;
            row["Name"] = prn1.Name;
            row["Age"] = prn2.Age;

            _vm.Dt.Rows.Add(row);*/
            
        }

        public void anotherTest()
        {
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = Path.Combine(systemPath, "test-excel.xlsx");

            var dt = ExcelUtils.readExcelToDataTable(filePath);
            _vm.Dt = dt;

            var ppl = new List<Person>();
            foreach (DataRow row in dt.Rows)
            {
                var name = row["NAME"].ToString();
                var age = row["AGE"].ToString();
                var prn = new Person
                {
                    Name = name,
                    Age = Int32.Parse(age)
                };
                ppl.Add(prn);
            }

            foreach (var prn in ppl)
            {
                MessageBox.Show($"{prn.Name}-{prn.Age}");
            }
        }

        public void init()
        {
            Person prn1 = new Person();
            prn1.Name = "Mg Mg";
            prn1.Age = 30;

            Person prn2 = new Person();
            prn2.Name = "Ma Ma";
            prn2.Age = 45;

            var people = new List<Person>();
            people.Add(prn1);
            people.Add(prn2);

            var dt = DataTableUtils.toDataTable<Person>(people);
            _vm.Dt = dt;

            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = Path.Combine(systemPath, "test-excel.xlsx"); //C:\Users\
            ExcelUtils.saveToExcel(dt, filePath);
        }
        
        public DataGridTestVM getVM()
        {
            return _vm;
        }

        private void MenuItem_OnClickSaveExcel(object sender, RoutedEventArgs e)
        {
            /*var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filePath = Path.Combine(systemPath, "test-excel.xlsx"); //C:\Users\
            ExcelUtils.saveToExcel(_vm.Dt, filePath);

            MessageBox.Show($"{filePath}\nSuccessfully saved to Excel file!");*/
            FileDialogUtils.saveFileDialogueDataTable(getVM());
        }

        private void MenuItem_OnClickDeleteSelectedRow(object sender, RoutedEventArgs e)
        {
            var selectedIndices = myDataGrid.SelectedItems
                .Cast<object>()
                .Select(item => myDataGrid.Items.IndexOf(item))
                .ToList();

            if (selectedIndices.Count <= 0) return;

            var rowToDelete = new List<DataRow>();
            
            foreach (var index in selectedIndices)
            {
                var dataRow = getVM().Dt.Rows[index];
                rowToDelete.Add(dataRow);
            }

            foreach (var row in rowToDelete)
            {
                getVM().Dt.Rows.Remove(row);
            }
            getVM().Ppl.Clear();
        }
    }
}