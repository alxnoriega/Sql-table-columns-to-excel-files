using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
        }

        private void btnConectarDB_Click(object sender, EventArgs e)
        {
            dgvTables.DataSource = null; 
            ConectarADB();
        }

         void ConectarADB()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(txtConnectionString.Text))
                {
                    connection.Open();
                    DataTable schema = connection.GetSchema("Tables");

                    DataColumnCollection colection = connection.GetSchema("Tables").Columns;

                    foreach (DataRow row in schema.Rows)
                    {
                        DataTable schemaColumns = connection.GetSchema("Columns", new[] { connection.Database, null, row["TABLE_NAME"].ToString() });
                        string columnas = string.Empty;

                        foreach (DataRow row2 in schemaColumns.Rows)
                            columnas += row2["COLUMN_NAME"].ToString() + ",";

                        dgvTables.Rows.Add(new object[] { row["TABLE_NAME"].ToString(), columnas, false });
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }

         private void btnCrearDocs_Click(object sender, EventArgs e)
         {

             foreach (DataGridViewRow row in dgvTables.Rows)
             {
               
               //int value =  int.Parse(row.Cells[1].Value.ToString());

                 if (!row.IsNewRow)
                 {
                     bool isChecked = bool.Parse(row.Cells[2].Value.ToString());

                     if (isChecked)
                         CreateDoc(row.Cells[0].Value.ToString(),row.Cells[1].Value.ToString());
                     else
                         continue;
                 }
             }

             MessageBox.Show("Finalizo exitosamente");
         }

         void CreateDoc(string tableName,string celdas)
         {
             Microsoft.Office.Interop.Excel.Application excel;
             Microsoft.Office.Interop.Excel.Workbook excelworkBook;
             Microsoft.Office.Interop.Excel.Worksheet excelSheet;
             Microsoft.Office.Interop.Excel.Range excelCellrange;

             // Start Excel and get Application object.
             excel = new Microsoft.Office.Interop.Excel.Application();

             // for making Excel visible
             excel.Visible = false;
             excel.DisplayAlerts = false;

             // Creation a new Workbook
             excelworkBook = excel.Workbooks.Add(Type.Missing);

             // Workk sheet
             excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
             excelSheet.Name = "tabla";

             int columnCount = celdas.Split(',').Count();
             int i = 1;
            foreach (string columna in celdas.Split(','))
            {
                excelSheet.Cells[1, i] = columna;
                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[i, columnCount]];
                excelCellrange.EntireColumn.AutoFit();
                i++;
            }

             excelworkBook.SaveAs(txtOutPutFolder.Text + "\\"+ tableName + ".xls");
             excel.Quit();


             //using (SqlConnection connection = new SqlConnection(txtConnectionString.Text))
             //{
             //    connection.Open();
             //    DataTable schema = connection.GetSchema("Tables");


             //    foreach (DataRow row in schema.Rows)
             //    {
             //        dgvTables.Rows.Add(new object[] { row["TABLE_NAME"].ToString(), false });
             //    }

             //}


         }

         private void btnOutPutFolder_Click(object sender, EventArgs e)
         {
             DialogResult resultado =  folderBrowserDialog1.ShowDialog();


             if (resultado == System.Windows.Forms.DialogResult.OK)
                 txtOutPutFolder.Text = folderBrowserDialog1.SelectedPath;
         }

        
    }
}
