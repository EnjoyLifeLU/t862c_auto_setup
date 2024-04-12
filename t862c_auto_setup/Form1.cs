using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;


namespace Layout1
{
    public partial class frmMain : Form
    {
        [DllImport("kernel32.dll")]
        private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);

        private Dictionary<string, string> condDict;
        private bool startOpen;
        private string output, error;
        private string commandWithArgs;

        string version = "Version 1.00  (2024-04-10)";
        private string condFilePath = "C:\\AutoSetup\\AutoSetupSH\\cond.asc";
        private string handlerId;

        private string ProgramName;
        private string DatalogName;
        //private string TempDataPath = "D:\\T216Data\\temp";
        private string tempPgmPath = "D:\\test";
        private string ServerPgmPath = "Q:\\T862C_PGM\\AC\\";
        private string TestDataPath = "D:\\DATA";
        private string ServerDataPath = "X:\\AC\\Datalog";
        private string Headers_ini = "D:/QA8T/System/Bin/Headers.ini";

        private string currTime;

        public frmMain()
        {

            string path = "cfg.ini";

            // 读取 INI 文件的内容
            Dictionary<string, Dictionary<string, string>> iniData = new Dictionary<string, Dictionary<string, string>>();
            string currentSection = "";

            foreach (string line in File.ReadLines(path))
            {
                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    currentSection = line.Substring(1, line.Length - 2);
                    iniData[currentSection] = new Dictionary<string, string>();
                }
                else
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        iniData[currentSection][parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }

            // 读取Handler_Id的值
            if (iniData.ContainsKey("GV_Config_Info") && iniData["GV_Config_Info"].ContainsKey("Handler_Id"))
            {
                handlerId = iniData["GV_Config_Info"]["Handler_Id"];
            }
            else
            {
                Console.WriteLine("Handler_Id not found in the INI file.");
                return;
            }

            InitializeComponent();

            toolStripStatusLabel2.Text = version;
            toolStripStatusLabel2.Alignment = ToolStripItemAlignment.Right;

            if (!Directory.Exists(ServerDataPath))
            {
                txtInfo.AppendText("X:\\未连接\r\n");
            }
            if (!Directory.Exists(ServerPgmPath))
            {
                txtInfo.AppendText("Q:\\未连接\r\n");
            }

            startOpen = false;

            // 
            btnLoadProd.Enabled = true;
            btnStartTest.Enabled = false;
            btnEndLot.Enabled = false;
        }

        private void tsBtnStart_Click(object sender, EventArgs e)
        {
            if (!startOpen 
                && !string.IsNullOrWhiteSpace(tbLot.Text) 
                && !string.IsNullOrWhiteSpace(cbCurrentFlow.Text))
            {
                // TODO: 完成开启状态的相应操作
                if (GetLotInfo(tbLot.Text, handlerId))
                {
                    // 更新Start按钮图标状态
                    tsBtnStart.Image = Properties.Resources.connected_48;
                    tsBtnStart.ToolTipText = "End lot";
                    startOpen = true;
                    btnLoadProd.Enabled = true;
                    tsBtnStart.Enabled = false;
                }
                else
                {
                    txtInfo.AppendText("get lot information error, please call the PE\r\n");
                }
            }
            else
            {
                // 更新Start按钮图标状态
                tsBtnStart.Image = Properties.Resources.disconnected_48;
                tsBtnStart.ToolTipText = "Start Lot";
                startOpen = false;

                tbLot.Text = "";
                tbCustomer.Text = "";
                tbLotID.Text = "";
                tbCLotID.Text = "";
                tbProduct.Text = "";
                tbOperatorID.Text = "";
                tbTestFlow.Text = "";
                tbRecipeName.Text = "";
                tbPgmName.Text = "";
                tbPgmPath.Text = "";
                tbTamperature.Text = "";
                tbHifix.Text = "";
                tbTesterID.Text = "";
                tbHandlerID.Text = "";
            }
        }


        private bool GetLotInfo(string lotID, string entityID)
        {
            commandWithArgs = "C:/AutoSetup/AutoSetupSH/AutoSetupSH.bat " + entityID + " " + lotID;
            ExecuteCommand(commandWithArgs, out output, out error);
            if (!string.IsNullOrWhiteSpace(error))
            {
                // TODO: error operation
                txtInfo.AppendText(error + "\r\n");
                return false;
            }
            else
            {
                condDict = ParseCondAsc(condFilePath);

                txtInfo.AppendText("Movin Data Fetch a=>{ call auto_setup_sts8200('" + tbLot.Text + "','" + handlerId + "')}\r\n");
                txtInfo.AppendText("sysMsg:" + condDict["sysMsg"] + "\r\n");
                txtInfo.AppendText("owner:" + condDict["owner"] + "\r\n");
                txtInfo.AppendText("lotid:" + condDict["lotid"] + "\r\n");
                txtInfo.AppendText("prodid:" + condDict["prodid"] + "\r\n");
                txtInfo.AppendText("OPID:" + condDict["OPID"] + "\r\n");
                txtInfo.AppendText("step:" + condDict["step"] + "\r\n");
                txtInfo.AppendText("Program:" + condDict["Program"] + "\r\n");
                txtInfo.AppendText("temperature:" + condDict["temperature"] + "\r\n");
                txtInfo.AppendText("clotid:" + condDict["clotid"] + "\r\n");
                txtInfo.AppendText("curr_hifix:" + condDict["curr_hifix"] + "\r\n");
                txtInfo.AppendText("handlerId:" + handlerId + "\r\n");

                if (condDict["sysMsg"] == "Y")
                {
                    tbCustomer.Text = condDict["owner"];
                    tbLotID.Text = condDict["lotid"];
                    tbProduct.Text = condDict["prodid"];
                    tbOperatorID.Text = condDict["OPID"];
                    tbTestFlow.Text = condDict["step"];
                    tbPgmName.Text = condDict["Program"];
                    tbTamperature.Text = condDict["temperature"];
                    tbCLotID.Text = condDict["clotid"];
                    tbHifix.Text = condDict["curr_hifix"];
                    tbTesterID.Text = condDict["testerModel"];
                    tbHandlerID.Text = handlerId;
                    tbPgmPath.Text = tempPgmPath + "\\" + condDict["Program"] + "\\Programs\\" + condDict["Program"] + ".prg";

                    string serverPgmPath = "Q:\\T862C_PGM\\AC\\" + condDict["externalno"] + "\\" + condDict["step"] + "\\SWR\\" + condDict["Program"] + ".zip";

                    if (File.Exists(serverPgmPath))
                    {
                        // File.Copy(serverPgmPath, tbPgmPath.Text, true);
                        txtInfo.AppendText("Server test Pgm file:" + serverPgmPath + "\r\n");
                        commandWithArgs = "7z.exe x " + serverPgmPath + " -o" + tempPgmPath + " -y";
                        //ExecuteCommand2(commandWithArgs);
                        ExecuteCommand(commandWithArgs, out output, out error);
                        if (!string.IsNullOrWhiteSpace(error))
                        {
                            txtInfo.AppendText(error + "\r\n");
                        }
                        if (File.Exists(tbPgmPath.Text))
                        {
                            return true;
                        }
                        txtInfo.AppendText("Server test Pgm file -> Temp test Pgm file : Error!!\r\n");
                        return false;
                    }
                    else
                    {
                        txtInfo.AppendText("Server test file is not exists: " + serverPgmPath + "\r\n");
                        return false;
                    }
                }
                else 
                {
                    return false;
                }
            }
        }

        static void ExecuteCommand(string commandWithArgs, out string output, out string error)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C" + commandWithArgs;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                output = process.StandardOutput.ReadToEnd();
                error = process.StandardError.ReadToEnd();

                process.WaitForExit();
            }
        }

        static void ExecuteCommand2(string commandWithArgs)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C" + commandWithArgs;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();
            }
        }

        static Dictionary<string, string> ParseCondAsc(string filePath)
        {
            Dictionary<string, int> itemDic = new Dictionary<string, int>();
            Dictionary<string, string> condDic = new Dictionary<string, string>();

            string fileContent = File.ReadAllText(filePath);
            string fisrtLine = File.ReadAllLines(filePath)[0];

            string pattern = @"(?<param>[a-zA-Z0-9_]+)\((?<value>[^)]+)\)";
            MatchCollection matches = Regex.Matches(fileContent, pattern);

            foreach (Match match in matches)
            {
                string key = match.Groups["param"].Value;
                int value = int.Parse(match.Groups["value"].Value);

                itemDic[key] = value;
            }
            
            int count = 0;
            foreach (var item in itemDic)
            {
                string value = fisrtLine.Substring(count, item.Value);
                value = value.Trim();
                condDic[item.Key] = value;
                count += item.Value;
            }

            return condDic;
        }

        private bool SaveTest()
        {
            //string Headers_ini = Directory.GetCurrentDirectory() + "\\Headers.ini";
            output = "";
            commandWithArgs = "hostname";
            ExecuteCommand(commandWithArgs, out output, out error);
            if (output == "")
            {
                txtInfo.AppendText("Get Hostname Err\r\n");
                return false;
            }

            ProgramName = tbPgmPath.Text;
            DatalogName = condDict["Program"] + "-" + condDict["lotid"] + "-" + condDict["step"]+ "-" +
                            cbCurrentFlow.Text + "-" + output.Trim() + "-" + condDict["curr_hifix"] + "-" + currTime;

            WritePrivateProfileString("MIR",   "FLOW_ID",   condDict["step"],         Headers_ini);
            WritePrivateProfileString("MIR",   "LOT_ID",    condDict["lotid"],        Headers_ini);
            WritePrivateProfileString("MIR",   "MODE_COD",  condDict["testerModel"],  Headers_ini);
            WritePrivateProfileString("MIR",   "PART_TYP",  "",                       Headers_ini);
            WritePrivateProfileString("MIR",   "OPER_FRQ",  condDict["OPID"],         Headers_ini);
            WritePrivateProfileString("MIR",   "PKG_TYP",   "",                       Headers_ini);
            WritePrivateProfileString("MIR",   "PROC_ID",   condDict["prodid"],       Headers_ini);
            WritePrivateProfileString("MIR",   "TST_TEMP",  condDict["temperature"],  Headers_ini);
                                                                                     
            WritePrivateProfileString("NFME",  "prg_file",  condDict["Program"],      Headers_ini);
            WritePrivateProfileString("NFME",  "limits",    "",                       Headers_ini);
            WritePrivateProfileString("NFME",  "DLOG_NAM",  DatalogName,              Headers_ini);
                                                                                     
            WritePrivateProfileString("SDR",   "HAND_ID",   handlerId,                Headers_ini);
            WritePrivateProfileString("SDR",   "HAND_TYP",  "",                       Headers_ini);
            WritePrivateProfileString("SDR",   "DIB_ID",    condDict["curr_hifix"],   Headers_ini);

            return true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
        }

        private void btnLoadProd_Click(object sender, EventArgs e)
        {
            currTime = System.DateTime.Now.ToString("yyyyMMdd_HHmmss");

            try 
            {
                if (SaveTest())
                {
                    commandWithArgs = "D:/QA8T/System/Bin/hbOper.exe LOAD " + Headers_ini;
                    ExecuteCommand(commandWithArgs, out output, out error);
                    if (output == "NG")
                    {
                        txtInfo.AppendText("LOAD:" + output + "\r\n");
                        return;
                    }
                }
                else
                {
                    txtInfo.AppendText("LOAD Err: SaveTest() return false!!\r\n");
                    return;
                }
            }
            catch (Exception error)
            {
                txtInfo.AppendText(error.Message + "\r\n");
                return;
            }

            File.Copy(condFilePath, condFilePath + currTime);

            btnStartTest_Click(sender, e);
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            try
            {
                commandWithArgs = "D:/QA8T/System/Bin/hbOper.exe START";
                ExecuteCommand(commandWithArgs, out output, out error);
                if (output == "NG")
                {
                    txtInfo.AppendText("START:" + output + "\r\n");
                    return;
                }
            }
            catch (Exception error)
            {
                txtInfo.AppendText(error.Message + "\r\n");
                return;
            }

            btnEndLot.Enabled = true;
            btnLoadProd.Enabled = false;
            btnStartTest.Enabled = false;
            btnStopTest.Enabled = true;
        }

        private void btnEndLot_Click(object sender, EventArgs e)
        {
            try
            {
                commandWithArgs = "D:/QA8T/System/Bin/hbOper.exe STOP";
                ExecuteCommand(commandWithArgs, out output, out error);
                if (output == "NG")
                {
                    txtInfo.AppendText("STOP:" + output + "\r\n");
                    return;
                }

                Thread.Sleep(500);
                commandWithArgs = "D:/QA8T/System/Bin/hbOper.exe END";
                ExecuteCommand(commandWithArgs, out output, out error);
                if (output == "NG")
                {
                    txtInfo.AppendText("END:" + output + "\r\n");
                    return;
                }

                Thread.Sleep(500);
                commandWithArgs = "D:/QA8T/System/Bin/hbOper.exe CLOSEUI";
                ExecuteCommand(commandWithArgs, out output, out error);
                if (output == "NG")
                {
                    txtInfo.AppendText("CLOSEUI:" + output + "\r\n");
                    return;
                }

                txtInfo.AppendText("文件正在上传中请等待......\r\n");
                Thread.Sleep(10000);

                string[] dataFiles = Directory.GetFiles(TestDataPath, DatalogName + "*");
                if (dataFiles.Length == 5)
                {
                    commandWithArgs = "7z.exe a " + ServerDataPath + "\\" + DatalogName + ".7z " + dataFiles[0] + " " +
                        dataFiles[1] + " " + dataFiles[2] + " " + dataFiles[3] + " " + dataFiles[4] + " -y";
                    txtInfo.AppendText(commandWithArgs + "\r\n");
                    
                    ExecuteCommand(commandWithArgs, out output, out error);
                    if (!string.IsNullOrWhiteSpace(error))
                    {
                        txtInfo.AppendText(error + "\r\n");
                    }
                    else
                    {
                        if (!File.Exists(ServerDataPath + "\\" + DatalogName + ".7z"))
                        {
                            File.Delete(ServerDataPath + "\\" + DatalogName + ".7z");
                            txtInfo.AppendText("文件上传失败，网络盘文件不存在!!\r\n");
                        }
                        else
                        {
                            txtInfo.AppendText("文件上传成功!!\r\n");
                        }
                    }
                }
                else
                {
                    txtInfo.AppendText("文件不存在。上传异常!!\r\n");
                }
            }
            catch (Exception error)
            {
                txtInfo.AppendText(error.Message + "\r\n");
                return;
            }


            btnLoadProd.Enabled = false;
            btnStartTest.Enabled = false;
            btnEndLot.Enabled = false;
            tsBtnStart.Enabled = true;
            tsBtnStart_Click(sender, e);
            tbLot.Clear();
            cbCurrentFlow.SelectedIndex = -1;
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStopTest_Click(object sender, EventArgs e)
        {
            commandWithArgs = "D:/QA8T/System/Bin/hbOper.exe STOP";
            ExecuteCommand(commandWithArgs, out output, out error);
            if (output == "NG")
            {
                txtInfo.AppendText("STOP:" + output + "\r\n");
                return;
            }

            btnStartTest.Enabled = true;
        }
    }
}
