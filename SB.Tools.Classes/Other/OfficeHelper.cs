using System;
using System.Collections.Generic;
using System.Data;
//using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace SB.Tools.Classes.Other
{
    public class OfficeHelper
    {
        

        //public static DataTable ReadOf_Excel2003_2007(string filePath, string sheetName)
        //{
        //    DataTable tbl = new DataTable(sheetName);
        //        string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + @";Extended Properties='Excel 8.0;HDR=Yes;'";
        //        using (OleDbConnection connection = new OleDbConnection(con))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("select * from [" + sheetName + "$]", connection);

        //                dataAdapter.Fill(tbl);
        //            }
        //            finally
        //            {
        //                connection.Close();
        //            }
        //    }


        //    return tbl;

        //}

        public static DataTable ReadOf_Excel2010(string filePath, string sheetName)
        {
            //string fileName = @"c:\path\to\my\file.xlsx";

            DataTable dt = new DataTable();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (SpreadsheetDocument doc = SpreadsheetDocument.Open(fs, false))
                {
                    WorkbookPart workbookPart = doc.WorkbookPart;
                    SharedStringTablePart sstpart = workbookPart.GetPartsOfType<SharedStringTablePart>().First();
                    SharedStringTable sst = sstpart.SharedStringTable;

                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    Worksheet sheet = worksheetPart.Worksheet;

                    var rows = sheet.Descendants<Row>();


                    if (rows.Any())
                    {
                        var row = rows.First();
                        for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                        {
                            dt.Columns.Add("C" + i);
                        }
                    }

                    int indexCol = 0;
                    int indexRow = 0;
                    foreach (Row row in rows)
                    {
                        dt.Rows.Add();
                        indexCol = 0;
                        foreach (Cell c in row.Elements<Cell>())
                        {
                            if ((c.DataType != null) && (c.DataType == CellValues.SharedString))
                            {
                                int ssid = int.Parse(c.CellValue.Text);
                                dt.Rows[indexRow][indexCol] = sst.ChildElements[ssid].InnerText;
                            }
                            else if (c.CellValue != null)
                            {
                                dt.Rows[indexRow][indexCol] = c.CellValue.Text;
                            }

                            indexCol++;
                        }
                        indexRow++;

                    }
                }
            }

            return dt;
        }

    }
}
