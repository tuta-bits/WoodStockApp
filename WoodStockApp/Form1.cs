using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Xsl;

namespace WoodStockApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void browseBtn_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///open dialog box and allowing file name to display in the text box
            /// </summary>

            openFileDialog1.ShowDialog();

            txtFilePath.Text = openFileDialog1.FileName;
            BindDataCSV(txtFilePath.Text);
        }

        private void BindDataCSV(string filePath)
        {
            ///<summary></summary>
            ///Binding data table and reading all data on the imported csv file
            ///</summary>

            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                ///<summary>
                /// generating header, spliting string into substrings & return array in the substring
                /// adds data column to the data coloumn collection
                /// </summary>

                string openingLine = lines[0];

                string[] woodApp = openingLine.Split(',');

                foreach (string txtFilePath in woodApp)
                {

                    dt.Columns.Add(new DataColumn(txtFilePath));
                }


                for (int r = 1; r < lines.Length; r++)
                {

                    ///<summary>
                    /// sorting the data
                    /// returns data row collection that contains data row object
                    /// </summary>

                    string[] dataMine = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string txtFilePath in woodApp)
                    {
                        dr[txtFilePath] = dataMine[columnIndex++];
                    }

                    ///<summary>
                    ///Adds specified data row to dr collection
                    ///</summary>

                    dt.Rows.Add(dr);
                }
            }

            if (dt.Rows.Count > 0)
            {
                ///<summary>
                ///Gets the objects in the data row and sets it to display on the datagridview</summary>

                dvgStocklist.DataSource = dt;
            }

        }

        public void saveBtn_Click(object sender, EventArgs e)
        {

            ///<summary>
            ///creates new instance of sfd, file name & filter. Delete same file name if present and replace it with new one
            /// pops error message if it fails
            /// </summary>

            if (dvgStocklist.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    FileName = "Stockfile.csv",
                    Filter = "CSV (*.csv)|*.csv"
                };
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    else if (!fileError)
                    {
                        try
                        {
                            int columnCount = dvgStocklist.Columns.Count;
                            string columnNames = "";
                            string[] saveCsv = new string[dvgStocklist.Rows.Count + 1];

                            ///<summary>
                            ///gets text on column header and collections contained in the columns & returns the instance of the current object
                            ///</summary>

                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dvgStocklist.Columns[i].HeaderText.ToString() + ",";
                            }
                            saveCsv[0] += columnNames;

                            for (int k = 1; k < dvgStocklist.Rows.Count; k++)
                            {
                                for (int s = 0; s < columnCount; s++)
                                {
                                    saveCsv[k] += dvgStocklist.Rows[k - 1].Cells[s].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, saveCsv, Encoding.UTF8);
                            MessageBox.Show("File Successfully Saved in *.CSV Format", "Notification");

                            ///<summary>
                            ///creates a new new file with a specified name, save it as *.csv and confirmation message
                            ///</summary>

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File did not save !!!", "Notification");
            }





        }

        public void dvgStocklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ///<summary>
            /// making columns 0,1 & 3 readonly
            ///</summary>


            foreach (DataGridViewColumn dgvc in dvgStocklist.Columns)
            {
                dvgStocklist.Columns[0].ReadOnly = true;
                dvgStocklist.Columns[1].ReadOnly = true;
                dvgStocklist.Columns[3].ReadOnly = true;
            }

        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            //Creating a new instance of Data table based on what was displayed on the dgv
            //and giving the new table a name "Inventory"

            DataTable table = GetDataTableOnDisplay(dvgStocklist);
            DataSet ds = new DataSet("Inventory");
            
            ds.Tables.Add(table);
            
            
           
            // writing text.xml file to the debug folder
            table.WriteXml(@"E:\WoodStockApp\WoodStockApp\bin\Debug\text.xml");
            MessageBox.Show("File Successfully Saved in *.XML Format", "Notification");

        }

        // Adding the columns and its associated contents displayed on the datagridview to the data table 
        private DataTable GetDataTableOnDisplay(DataGridView dgv)
        {
            var dt = new DataTable();
            

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
               
            }

            // creating cell values as new objects to be exported and saved as xml file
            object[] cellValues = new object[dgv.Columns.Count];

            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }

       
        // transforming .xsl stylesheet file to .html file, 
        //applying to .xml file and displaying the end result on IE web-browser
        private void btnStyle_Click(object sender, EventArgs e)
        {
            var myXslTrans = new XslCompiledTransform();
            myXslTrans.Load("FormIt.xsl");
            myXslTrans.Transform("text.xml", "FormIt.html");


            string FormIt = Path.GetFullPath("FormIt.html");
            System.Diagnostics.Process.Start(@"iexplore.exe", FormIt);
        }

        //transforming the second .xsl stylesheet file to .html file, 
        //applying to .xml file and displaying the end result on IE web-browser
        private void btnStyle1_Click(object sender, EventArgs e)
        {
            var myXslTrans = new XslCompiledTransform();
            myXslTrans.Load("FormIt1.xsl");
            myXslTrans.Transform("text.xml", "FormIt1.html");


            string FormIt1 = Path.GetFullPath("FormIt1.html");
            System.Diagnostics.Process.Start(@"iexplore.exe", FormIt1);
        }
    }
    
}
