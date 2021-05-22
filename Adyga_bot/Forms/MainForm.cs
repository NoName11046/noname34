using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Adyga_bot
{
    public partial class MainForm : Form
    {
        #region MouseDown
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        public MainForm()
        {
            InitializeComponent();
            accounts = new List<Api>();

            CONFIGAPI.CConfig.Get();

            if (!Directory.Exists("Data"))
                Directory.CreateDirectory("Data");
            if (!Directory.Exists("Txts"))
                Directory.CreateDirectory("Txts");
            if (!Directory.Exists("Configs"))
                Directory.CreateDirectory("Configs");
            if (!File.Exists("Txts\\accounts.txt"))
                File.Create("Txts\\accounts.txt").Close();
            if (!File.Exists("Txts\\captcha.txt"))
                File.Create("Txts\\captcha.txt").Close();
            if (!File.Exists("Txts\\phrases.txt"))
                File.Create("Txts\\phrases.txt").Close();
        }


        #region Captcha
        private bool rc_Active_state = false;

        private void LoadManualCapt_TT()
        {
            fl_b_kChange.Text = "Rucaptcha";
            VkCaptchaWorks.Enabled = false;
            //Visible false
            fl_lkey.Visible = false;
            ApiKeyTextBox.Visible = false;
            fl_b_kGet.Visible = false;
            fl_b_kSave.Visible = false;
            fl_lBalance.Visible = false;
            CurrBalance.Visible = false;
            //Visible true
            ManualCaptBox.Visible = true;
            CaptPic.Visible = true;
            fl_b_kSend.Visible = true;
        }

        private void LoadRucaptCapt_TT()
        {
            string get_key = File.ReadAllText("Txts\\captcha.txt");
            fl_b_kChange.Text = "Вручную";
            VkCaptchaWorks.Enabled = true;
            VkCaptchaWorks.SetKeyAndProv(CaptchaWorksProvder.rucaptcha, get_key);
            ApiKeyTextBox.Text = get_key;
            //Visible false
            fl_lkey.Visible = true;
            ApiKeyTextBox.Visible = true;
            fl_b_kGet.Visible = true;
            fl_b_kSave.Visible = true;
            fl_lBalance.Visible = true;
            CurrBalance.Visible = true;
            //Visible true
            ManualCaptBox.Visible = false;
            CaptPic.Visible = false;
            fl_b_kSend.Visible = false;
        }

        private void LoadCaptKeyIn()
        {
            string get_key = File.ReadAllText("Txts\\captcha.txt");
            if (get_key.Length > 20)
            {
                LoadRucaptCapt_TT();
            }
            else
            {
                LoadManualCapt_TT();
            }
        }
        #endregion

        #region Auto

        public void OpenMain()
        {
        }

        public void OpenF()
        {
        }

        public void OpenKey()
        {
        }

        public void DeleteF()
        {
            if (fl_AutoDeleteText.Text == "")
            {
                targetsGridFLText.Rows.Clear();
            }
            else
            {
                for (int i = 0; i <= targetsGridFLText.Rows.Count - 1; i++)
                {
                    if (targetsGridFLText.Rows[i].Cells[1].FormattedValue.ToString().
                        Contains(fl_AutoDeleteText.Text.Trim()))
                    {
                        targetsGridFLText.Rows[i].Selected = true;
                        targetsGridFLText.Rows.Remove(targetsGridFLText.Rows[i]);
                    }
                    else
                    {
                        targetsGridFLText.Rows[i].Selected = false;
                    }
                }
            }

            fl_AutoDeleteText.Text = "";
        }

        public void UpdateContent()
        {
            phrases = File.ReadAllLines("Txts\\phrases.txt", Encoding.GetEncoding("windows-1251"));
        }
        #endregion

        #region Other
        public void LogTimer_Tick(object sender, EventArgs e)
        {
            while (Log.toPush.Count != 0)
            {
                richTextBox1.Text = Log.toPush.Dequeue() + "\n" + richTextBox1.Text;
            }
        }

        private void ManualCaptTimer_Tick(object sender, EventArgs e)
        {
            if (CaptPic.Image == null && VkCaptchaWorks.toSolve.Count != 0)
            {
                currManId = VkCaptchaWorks.toSolve.Dequeue();
                FileStream fileStream = new FileStream(currManId + ".png", FileMode.Open);
                CaptPic.Image = Image.FromStream(fileStream);
                fileStream.Close();
                File.Delete(currManId + ".png");
            }
        }

        private void CurrAccComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrAccComboBox.SelectedIndex != -1)
            {
                numericDelayTextFL.Value = 
                    accounts[CurrAccComboBox.SelectedIndex].FloodDelay < 333 ? 333 : accounts[CurrAccComboBox.SelectedIndex].FloodDelay;
                targetsGridFLText.Rows.Clear();

                foreach (var item in accounts[CurrAccComboBox.SelectedIndex].TargetFlooder)
                    targetsGridFLText.Rows.Add(item.name, item.target);
                AccEnabledFL.Checked = accounts[CurrAccComboBox.SelectedIndex].EnabledFlooder;
            }
        }

        private void Fl_cmdLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manualJson = "Manual";
            string OffJson = "Off";

            if (fl_cmdLog.SelectedItem.ToString() == "Вручную")
            {
                fl_bLogClear.Enabled = true;
                MemoryCleaner.Enabled = false;
                LogTimer.Enabled = true;
                Log.enabled = true;
                CONFIGAPI.CConfig.LogChangers.CGetSetLogType = manualJson;
                CONFIGAPI.CConfig.LogChangers.Save();
                Log.Push("Режим логирования: Вручную");
            }
            else if (fl_cmdLog.SelectedItem.ToString() == "Отключить")
            {
                fl_bLogClear.Enabled = false;
                MemoryCleaner.Enabled = false;
                LogTimer.Enabled = false;
                Log.enabled = false;
                CONFIGAPI.CConfig.LogChangers.CGetSetLogType = OffJson;
                CONFIGAPI.CConfig.LogChangers.Save();
                Log.Push("Режим логирования: Отключить");
            }
        }

        private void MemoryCleaner_Tick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            CONFIGAPI.CConfig.Get();

           // Width = 455; // Высота
            //Height = 393; // Ширина


            File.WriteAllText("Configs\\SaveLoadLogType.json", "{\"CGetSetLogType\":\"Manual\"}");

            if (CONFIGAPI.CConfig.LogChangers.CGetSetLogType == "Manual")
            {
                fl_cmdLog.SelectedIndex = 0;
            }
            else if (CONFIGAPI.CConfig.LogChangers.CGetSetLogType == "Off")
            {
                fl_cmdLog.SelectedIndex = 1;
            }
            phrases = File.ReadAllLines("Txts\\phrases.txt", Encoding.GetEncoding("windows-1251"));
            string[] read = File.ReadAllLines("Txts\\accounts.txt", Encoding.GetEncoding("windows-1251"));
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Api));
            string[] read_calc = read;
            for (int i = 0; i < read_calc.Length; i++)
            {
                var array4 = read_calc[i].Split(':');

                if (array4.Length > 2)
                {
                    Log.Push("Ошибка загрузки аккаунта из accounts.txt - неверный формат");
                }
                else
                {
                    Api api;
                    if (!File.Exists("Data\\" + array4[0] + ".xml"))
                    {
                        api = new Api(array4[0], array4[1]);
                    }
                    else
                    {
                        FileStream fileStream = new FileStream("Data\\" + array4[0] + ".xml", FileMode.Open);
                        XmlReader xmlReader = XmlReader.Create(fileStream);
                        api = (Api)xmlSerializer.Deserialize(xmlReader);
                        fileStream.Close();
                    }

                    accounts.Add(api);
                    CurrAccComboBox.Items.Add(api.Login + " (" + api.Informations + ")");
                }
            }
            if (CurrAccComboBox.Items.Count != 0)
            {
                CurrAccComboBox.SelectedIndex = 0;
                CurrAccComboBox_SelectedIndexChanged(null, null);
            }

            LoadCaptKeyIn();
        }

        #region Variables

        public List<Api> accounts;

        public static string[] phrases;

        private string currManId;
        #endregion

        #region Buttons
        private void Fl_bStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Api.Working)
                {
                    Api.Working = false;
                    fl_bStart.Text = "Запуск";
                }
                else
                {
                    fl_bStart.Text = "Стоп";
                    Api.Working = true;

                    foreach (var api in accounts)
                    {
                        if (api.EnabledFlooder)
                        {
                            if (api.TokenStatus)
                            {
                                api.AsyncWorker();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Push("[Ошибка запуска]: " + ex.Message);
            }
        }

        private void Fl_bGetToken_Click(object sender, EventArgs e)
        {
            Log.Push("Авторизация...");

            foreach (var api in accounts)
            {
                int token = api.GetToken();

                if (token != -1)
                {
                    if (token == 0)
                    {
                        Log.Push($"Успешная авторизация {api.Login}");

                        CurrAccComboBox.Items.Clear();

                        foreach (var item in accounts)
                        {
                            CurrAccComboBox.Items.Add(item.Login + " (" + item.Informations + ")");
                        }

                        CurrAccComboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    Log.Push($"Ошибка авторизации");
                }
            }
            foreach (Api api2 in accounts)
            {
                api2.SaveToDisk();
            }
        }

        private void Fl_b_kSend_Click(object sender, EventArgs e)
        {
            if (ManualCaptBox.Text == "" || currManId == null)
            {
                return;
            }
            VkCaptchaWorks.RegisterManual(currManId, ManualCaptBox.Text);
            CaptPic.Image.Dispose();
            CaptPic.Image = null;
            currManId = null;
            ManualCaptBox.Clear();
        }

        private void Fl_b_kChange_Click(object sender, EventArgs e)
        {
            if (rc_Active_state == false)
            {
                rc_Active_state = true;
                LoadRucaptCapt_TT();
            }
            else
            {
                rc_Active_state = false;
                LoadManualCapt_TT();
            }
        }

        private void Fl_b_kGet_Click(object sender, EventArgs e)
        {
            try
            {
                CurrBalance.Text = VkCaptchaWorks.GetBalance() + " ₽";
            }
            catch (Exception ex)
            {
                Log.Push("[Ошибка запроса баланса]: " + ex.Message);
            }
        }

        private void Fl_b_kSave_Click(object sender, EventArgs e)
        {
            if (ApiKeyTextBox.Text != "")
            {
                string t_get_key = ApiKeyTextBox.Text;
                VkCaptchaWorks.SetKeyAndProv(CaptchaWorksProvder.rucaptcha, ApiKeyTextBox.Text);
                File.WriteAllText("Txts\\captcha.txt", t_get_key);
            }
        }

        private void Fl_bAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(fl_Auto1.Text) || string.IsNullOrEmpty(fl_Auto2.Text))
                {
                    Log.Push($"Поля не заполнены");
                    return;
                }

                int getMin = Convert.ToInt32(fl_Auto1.Text);
                int getMax = Convert.ToInt32(fl_Auto2.Text);
                var text = targetsGridFLText.CurrentRow.Cells[0].Value + "";
                targetsGridFLText.Rows.Clear();
                for (int i = getMin; i <= getMax; i++)
                    targetsGridFLText.Rows.Add(text, $"im?sel=c{i}");
                fl_Auto1.Text = fl_Auto2.Text = "";
            }
            catch 
            {
            }
        }

        private void Fl_bSave_Click(object sender, EventArgs e)
        {
            if (CurrAccComboBox.SelectedIndex != -1)
            {
                var api = accounts[CurrAccComboBox.SelectedIndex];
                api.EnabledFlooder = AccEnabledFL.Checked;
                api.FloodDelay = Convert.ToInt32(numericDelayTextFL.Text);
                api.ParseDataGridViewFlooder(targetsGridFLText.Rows);
                api.SaveToDisk();
            }
        }

        private void Fl_bInfo_Click(object sender, EventArgs e)
        {
            OpenMain();
        }

        private void Fl_bFl_Click(object sender, EventArgs e)
        {
            OpenF();
        }

        private void Fl_bCapt_Click(object sender, EventArgs e)
        {
            OpenKey();
        }

        private void Fl_bAutoDelete_Click(object sender, EventArgs e)
        {
            DeleteF();
        }

        private void Fl_bTextUpdate_Click(object sender, EventArgs e)
        {
            Log.Push("Перезагрузка .txt");
            UpdateContent();
        }

        private void Fl_bLogClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Process.GetCurrentProcess().Kill();
            }
            catch
            {

            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_minimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TargetsGridFLText_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
