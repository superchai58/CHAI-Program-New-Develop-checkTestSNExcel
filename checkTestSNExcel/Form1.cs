using Connect.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkTestSNExcel
{
    public partial class Form1 : Form
    {
        ConnectDB oCon = new ConnectDB();
        DataTable dt = new DataTable();
        IOException ex = new IOException();
        DialogResult result = new DialogResult();
        int flage = 0, flageChk = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbReult.Text = "";
        }

        //--Upload Excel file--
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (!bgwUpload.IsBusy)
            {
                flage = 0;
                pcbLoad.Visible = true;
                int size = -1;
                result = ofdExcel.ShowDialog(); // Show the dialog.

                bgwUpload.RunWorkerAsync();
            }            
        }

        /// <summary>
        /// Provides method to read excel file.
        /// </summary>
        /// <param name="filePath">The file path to be read.</param>
        /// <param name="sheetName">Excel file sheet name for gets data.</param>
        /// <param name="selectFields">Select fields like * or fields with comma separated.</param>
        /// <param name="tableName">The name of return DataTable.</param>
        /// <param name="fileIncludesHeaders">Indicates whether file includes headers.</param>
        /// <returns>DataTable</returns>
        public static DataTable ReadExcelFile(String filePath,
                                          String sheetName,
                                          String selectFields,
                                          String tableName,
                                          Boolean fileIncludesHeaders)
        {
            DataSet dataSet = null;
            DataTable dtReturn = null;
            string connectionString = string.Empty;
            string commandText = string.Empty;

            // Indicates the Excel file with header or not.
            string headerYesNo = string.Empty;
            string fileExtension = string.Empty;
            try
            {
                if (fileIncludesHeaders == true)
                {
                    // Set YES if excel WithHeader is TRUE.
                    headerYesNo = "YES";
                }
                else
                {
                    // Set NO if excel WithHeader is FALSE.
                    headerYesNo = "NO";
                }

                // Gets file extension for checking.
                fileExtension = Path.GetExtension(filePath);

                switch (fileExtension.ToUpper())
                {
                    case ".XLS":

                        //Take Connection For Microsoft Excel File.
                        connectionString =
                          string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;IMEX=2.0;HDR={1}""",
                                        filePath,
                                        headerYesNo);

                        break;

                    case ".XLSX":

                        //Take Connection For Microsoft Excel File.
                        connectionString =
                          string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;IMEX=2.0;HDR={1}""",
                                        filePath,
                                        headerYesNo);

                        break;

                    default:

                        throw new Exception("File is invalid.");
                }

                commandText = string.Format("SELECT {0} FROM [{1}$]",
                                            selectFields,
                                            sheetName);

                dataSet = new DataSet();
                using (OleDbConnection dbConnection = new OleDbConnection(connectionString))
                {
                    OleDbCommand dbCommand = new OleDbCommand(commandText, dbConnection);
                    dbCommand.CommandType = CommandType.Text;
                    OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(dbCommand);
                    dbDataAdapter.Fill(dataSet);
                }

                if (dataSet != null &&
                    dataSet.Tables.Count > 0)
                {
                    dataSet.Tables[0].TableName = tableName;

                    // Sets reference of data table.
                    dtReturn = dataSet.Tables[tableName];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtReturn;
        }

        private void bgwUpload_DoWork(object sender, DoWorkEventArgs e)
        {
            if (result == DialogResult.OK) // Test result.
            {
                string file = ofdExcel.FileName;
                try
                {
                    dt = ReadExcelFile(file, "Sheet1", "*", "dt", true);
                    flage = 0;
                }
                catch (IOException ex1)
                {
                    ex = ex1;
                    flage = 1;
                }
            }
        }

        private void bgwUpload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            if (flage == 0)
            {
                if (dt.Rows.Count > 0)
                {
                    //--Show message in label--
                    lbReult.BackColor = Color.Green;
                    lbReult.Text = "Upload excel successed.";
                    playOK();
                    txtScanSN.Text = "";
                    txtScanSN.Focus();
                }
                else
                {
                    //--Show message in label--
                    lbReult.BackColor = Color.Red;
                    lbReult.Text = "Upload file not correct or Excel no data or Sheet name != 'Sheet1', Please rename 'Sheet1' in excel file upload.";
                    playNG();
                    txtScanSN.Text = "";
                    txtScanSN.Focus();
                }
            }
            else
            {
                lbReult.BackColor = Color.Red;
                lbReult.Text = ex.ToString().Trim();
                playNG();
                txtScanSN.Text = "";
                txtScanSN.Focus();
            }
        }

        private void bgwChkSN_DoWork(object sender, DoWorkEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (txtScanSN.Text.Trim() == row["Unit"].ToString().Trim())
                    {
                        flageChk = 1;
                        break;
                    }
                }
            }
            else //flageChk == -1
            {
                flageChk = -1;
            }
        }

        private void bgwChkSN_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pcbLoad.Visible = false;
            if (flageChk == -1)
            {
                //--Show message in label--
                lbReult.BackColor = Color.Red;
                lbReult.Text = "No data upload, Please upload file again.";
                playNG();
                txtScanSN.Text = "";
                txtScanSN.Focus();
            }
            else if (flageChk == 0)
            {
                lbReult.BackColor = Color.Green;
                lbReult.Text = "OK, Serial number not found duplicate.";
                playOK();
                txtScanSN.Text = "";
                txtScanSN.Focus();
            }
            else if (flageChk == 1)
            {
                lbReult.BackColor = Color.Red;
                lbReult.Text = "NG, Serial number found duplicate.";
                playNG();
                txtScanSN.Text = "";
                txtScanSN.Focus();
            }
        }


        //--Scan SN for check--
        private void txtScanSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtScanSN.Text.Length == 23)
            {
                if (!bgwChkSN.IsBusy)
                {
                    flageChk = 0;
                    pcbLoad.Visible = true;
                    bgwChkSN.RunWorkerAsync();
                }
            }
        }

        public void playOK()
        {
            string exePath = Application.StartupPath + "\\OK.wav";
            SoundPlayer simpleSound = new SoundPlayer(exePath);
            simpleSound.Play();            
            return;
        }

        public void playNG()
        {
            string exePath = Application.StartupPath + "\\OO.wav";
            SoundPlayer simpleSound = new SoundPlayer(exePath);
            simpleSound.Play();            
            return;
        }
    }
}
