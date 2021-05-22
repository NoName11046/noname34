using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adyga_bot.Forms
{
    public partial class LoginForm : Form
    {
        private class Login
        {
            public bool Remember { get; set; }
            public string Hwid { get; set; }
            public string Password { get; set; }

            public void Save()
            {
                var json = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText("Configs\\Settings.json", json);
            }
        }
        public LoginForm()
        {
            InitializeComponent();

            textBox_hwid.Text = $"Ваш ключ: {GetHWID()}";

            Directory.CreateDirectory("Configs");

            if (File.Exists("Configs\\settings.json"))
            {
                var login = JsonConvert.DeserializeObject<Login>
                    (File.ReadAllText("Configs\\settings.json"));
                checkBox_RememberMe.Checked = login.Remember;
                textBox_password.Text = login.Password;
            }
        }
        private void SaveEvent(object sender, FormClosedEventArgs e)
        {
            var login = new Login();
            login.Remember = checkBox_RememberMe.Checked;
            if (checkBox_RememberMe.Checked)
            {
                login.Hwid = GetHWID();
                login.Password = textBox_password.Text;
            }
            login.Save();
        }
        public static string GetHWID()
        {
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            return id;
        }
        public static string GET(string link, CookieContainer cc = null)
        {
            var http = (HttpWebRequest)WebRequest.Create(link);
            if (cc != null)
                http.CookieContainer = cc;
            http.UserAgent = "bot";
            return new StreamReader(http.GetResponse().GetResponseStream()).ReadToEnd();
        }
        private void Server()
        {
            var password = textBox_password.Text;

            try
            {
                SaveEvent(null, null);

                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Заполните поле пароль", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var response =
                    GET($"http://f0537530.xsph.ru/check.php?hwid={GetHWID()}&password={password}");
                if (response.Contains("success"))
                {
                    var form = new MainForm();
                    form.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Пользователь не найден", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_enter_Click(object sender, EventArgs e)
        {
            new Task(() => Invoke(new Action(() => Server()))).Start();
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_enter_Click(null, null);
        }

        private void checkBox_passwordChar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_passwordChar.Checked)
                textBox_password.PasswordChar = new char();
            else
                textBox_password.PasswordChar = '•';
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            MainForm.ReleaseCapture();
            MainForm.SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
