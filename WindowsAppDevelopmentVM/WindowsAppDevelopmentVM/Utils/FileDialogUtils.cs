using System;
using System.Windows;

namespace WindowsAppDevelopmentVM.Utils
{
    public class FileDialogUtils
    {
        public static void saveFileDialogueDataTable(DataGridTestVM vm)
        {
            var saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog.ShowDialog() == true)
            {
                string saveFilePath = saveFileDialog.FileName;
                // Save your file here or store the path
                ExcelUtils.saveToExcel(vm.Dt, saveFilePath);
                MessageBox.Show(saveFilePath+"\nFile successfully saved!");
            }
        }
    }
}