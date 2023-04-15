using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ForestFN_Launcher
{
    public partial class Form1 : Form
    {
        public static bool LoggedIn = false;

        public static Process Shipping = null;
        public static Process Shipping_EAC = null;
        public static Process Launcher = null;

        public static string LaunchType = "Hybrid";
        public static string Arguments = null;

        public static string FLToken = "5360b1637173878a5a9a4938";
        public static string Caldera = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiIiwiZ2VuZXJhdGVkIjoxNjY5MjY2MzA5LCJjYWxkZXJhR3VpZCI6Ijk4OTJkNzA4LWE5ODItNDczYy04MzBiLTYyYzU2MDBjYTFkMyIsImFjUHJvdmlkZXIiOiJFYXN5QW50aUNoZWF0Iiwibm90ZXMiOiIiLCJmYWxsYmFjayI6dHJ1ZX0.G6MZNH54MvImdJ_kcYkKJShJXjGZSP58aACy7pUYac8";

        public static Image IconImage = null;

        public static string LocalApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public static string FNVersion = Installed.GetFNVersion();
        public static string FNLocation = Installed.GetFNLocation();

        public static string DisplayName = null;

        public static string DeviceId = null;
        public static string AccountId = null;
        public static string Secret = null;

        public static string AccessToken = null;
        public static string CredentialsToken = null;

        public static string DeviceCode = null;
        public static string VerificationUrl = null;

        public static string ExchangeCode = null;

        private void FNLaunch()
        {
            if (LoggedIn == false)
            {
                MessageBox.Show("Not Logged In Your Epic Account!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LaunchType == "Hybrid")
            {
                if (HybridName.Text == "")
                {
                    MessageBox.Show("User Name Not Entered!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var exchange = Auth.GetExchange(AccessToken);
                ExchangeCode = JObject.Parse(exchange)["code"].ToString();

                new WebClient().DownloadFile("https://forestbackendv2.birufn.repl.co/download/hybrid/ForestFN.dll", $@"{FNLocation}\FortniteGame\Binaries\Win64\ForestFN.dll");
                Arguments = $"-AUTH_LOGIN=unused -AUTH_PASSWORD={ExchangeCode} -AUTH_TYPE=exchangecode -epicapp=Fortnite -epicenv=Prod -EpicPortal -skippatchcheck -nobe -fromfl=eac -fltoken={FLToken} -caldera={Caldera}";
            }
            else
            {
                if (PrivateName.Text == "")
                {
                    MessageBox.Show("User Name Not Entered!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Forest.ExistsPort(5595) == false)
                {
                    MessageBox.Show("Backend Server Does Not Exist!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                new WebClient().DownloadFile("https://forestbackendv2.birufn.repl.co/download/private/ForestFN.dll", $@"{FNLocation}\FortniteGame\Binaries\Win64\ForestFN.dll");
                Arguments = $"-AUTH_LOGIN={PrivateName.Text}@fn.dev -AUTH_PASSWORD=unused -AUTH_TYPE=epic -epicapp=Fortnite -epicenv=Prod -EpicPortal -skippatchcheck -nobe -fromfl=eac -fltoken={FLToken} -caldera={Caldera}";
            }

            new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/1088063112344764517/1089404450919153674/Injector.exe", $@"{FNLocation}\FortniteGame\Binaries\Win64\Injector.exe");

            Launcher = new Process
            {
                StartInfo =
                {
                    FileName = $@"{FNLocation}\FortniteGame\Binaries\Win64\FortniteLauncher.exe",
                    Arguments = Arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            try
            {
                Launcher.Start();
                foreach (ProcessThread thread in Launcher.Threads)
                {
                    Win32.SuspendThread(Win32.OpenThread(0x0002, false, thread.Id));
                }
            }
            catch
            {
                MessageBox.Show("Failed To Start \"FortniteLauncher.exe\"!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Shipping_EAC = new Process
            {
                StartInfo =
                {
                    FileName = $@"{FNLocation}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping_EAC.exe",
                    Arguments = Arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            try
            {
                Shipping_EAC.Start();
                foreach (ProcessThread thread in Shipping_EAC.Threads)
                {
                    Win32.SuspendThread(Win32.OpenThread(0x0002, false, thread.Id));
                }
            }
            catch
            {
                MessageBox.Show("Failed To Start \"FortniteClient-Win64-Shipping_EAC.exe\"!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Shipping = new Process
            {
                StartInfo =
                {
                    FileName = $@"{FNLocation}\FortniteGame\Binaries\Win64\FortniteClient-Win64-Shipping.exe",
                    Arguments = Arguments,
                    UseShellExecute = false
                }
            };
            try
            {
                Shipping.Start();
            }
            catch
            {
                MessageBox.Show("Failed To Start Fortnite!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    Shipping_EAC.Kill();
                }
                catch
                {

                }
                try
                {
                    Launcher.Kill();
                }
                catch
                {

                }
                return;
            }

            try
            {
                new Process
                {
                    StartInfo =
                    {
                        FileName = $@"{FNLocation}\FortniteGame\Binaries\Win64\Injector.exe",
                        Arguments = $"\"{Shipping.Id}\" \"{$@"{FNLocation}\FortniteGame\Binaries\Win64\ForestFN.dll"}\"",
                         UseShellExecute = false,
                        CreateNoWindow = true
                    }
                }.Start();
            }
            catch
            {
                MessageBox.Show("Failed To Inject \"ForestFN.dll\"!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                Shipping.WaitForExit();
            }
            catch
            {

            }
            try
            {
                Shipping_EAC.Kill();
            }
            catch
            {

            }
            try
            {
                Launcher.Kill();
            }
            catch
            {

            }
        }

        private void FNLogin()
        {
            var credentials = Auth.GetCredentials();
            CredentialsToken = JObject.Parse(credentials)["access_token"].ToString();

            var deviceAuthorization = Auth.GetDeviceAuthorization(CredentialsToken);
            VerificationUrl = JObject.Parse(deviceAuthorization)["verification_uri_complete"].ToString();
            DeviceCode = JObject.Parse(deviceAuthorization)["device_code"].ToString();

            Process.Start(VerificationUrl);

            var access = Auth.GetAccessWithDeviceCode(DeviceCode);
            if (access == "authorization_canceled")
            {
                MessageBox.Show("Authorization Canceled!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DisplayName = JObject.Parse(access)["displayName"].ToString();
            AccountId = JObject.Parse(access)["account_id"].ToString();
            AccessToken = JObject.Parse(access)["access_token"].ToString();

            var deviceAuth = Auth.GetDeviceAuth(AccountId, AccessToken);
            DeviceId = JObject.Parse(deviceAuth)["deviceId"].ToString();
            AccountId = JObject.Parse(deviceAuth)["accountId"].ToString();
            Secret = JObject.Parse(deviceAuth)["secret"].ToString();

            StreamWriter sw = File.CreateText($@"{LocalApplicationData}\ForestFN\Account.json");
            sw.WriteLine(new JObject { ["DeviceId"] = DeviceId, ["AccountId"] = AccountId, ["Secret"] = Secret });
            sw.Close();

            var Character = Forest.GetCharacter(AccountId, AccessToken);
            var Icon = JObject.Parse(Character)["Character"].ToString();

            new WebClient().DownloadFile(Icon, $@"{LocalApplicationData}\ForestFN\Icon.png");
            IconImage = Image.FromFile($@"{LocalApplicationData}\ForestFN\Icon.png");

            UserIcon.Image = IconImage;
            UserName.Text = DisplayName;

            HybridName.Text = DisplayName;

            Login.Text = "Logout";
            Login.FillColor = Color.Red;

            LoggedIn = true;
        }

        private void FNLogout()
        {
            UserIcon.Image = null;
            UserName.Text = null;

            HybridName.Text = null;

            IconImage.Dispose();
            File.Delete($@"{LocalApplicationData}\ForestFN\Account.json");
            File.Delete($@"{LocalApplicationData}\ForestFN\Icon.png");

            Login.Text = "Login";
            Login.FillColor = Color.Green;

            LoggedIn = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists($@"{LocalApplicationData}\ForestFN"))
            {
                Directory.CreateDirectory($@"{LocalApplicationData}\ForestFN");
            }

            if (File.Exists($@"{LocalApplicationData}\ForestFN\Account.json"))
            {
                StreamReader sr = new StreamReader($@"{LocalApplicationData}\ForestFN\Account.json");
                var deviceAuth = sr.ReadToEnd();
                sr.Close();

                DeviceId = JObject.Parse(deviceAuth)["DeviceId"].ToString();
                AccountId = JObject.Parse(deviceAuth)["AccountId"].ToString();
                Secret = JObject.Parse(deviceAuth)["Secret"].ToString();

                var access = Auth.GetAccessWithDeviceAuth(DeviceId, AccountId, Secret);
                DisplayName = JObject.Parse(access)["displayName"].ToString();
                AccountId = JObject.Parse(access)["account_id"].ToString();
                AccessToken = JObject.Parse(access)["access_token"].ToString();

                var Character = Forest.GetCharacter(AccountId, AccessToken);
                var Icon = JObject.Parse(Character)["Character"].ToString();

                new WebClient().DownloadFile(Icon, $@"{LocalApplicationData}\ForestFN\Icon.png");
                IconImage = Image.FromFile($@"{LocalApplicationData}\ForestFN\Icon.png");

                UserIcon.Image = IconImage;
                UserName.Text = DisplayName;

                HybridName.Text = DisplayName;
                PrivateName.Text = "ForestServer";

                Login.Text = "Logout";
                Login.FillColor = Color.Red;

                LoggedIn = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Shipping.Kill();
            }
            catch
            {

            }
            try
            {
                Shipping_EAC.Kill();
            }
            catch
            {

            }
            try
            {
                Launcher.Kill();
            }
            catch
            {

            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Login.Text == "Login")
            {
                Forest.ThreadStart(FNLogin);
            }
            else
            {
                Forest.ThreadStart(FNLogout);
            }
        }

        private void HybridLaunch_Click(object sender, EventArgs e)
        {
            if (RunCheck.CheckShipping() == false
                && RunCheck.CheckShippingBE() == false
                && RunCheck.CheckShippingEAC() == false
                && RunCheck.CheckLauncher() == false)
            {
                LaunchType = "Hybrid";
                Forest.ThreadStart(FNLaunch);
            }
            else
            {
                MessageBox.Show("Fortnite Is Already Running!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrivateLaunch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Private Server Is Currently Disabled!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

            if (RunCheck.CheckShipping() == false
                && RunCheck.CheckShippingBE() == false
                && RunCheck.CheckShippingEAC() == false
                && RunCheck.CheckLauncher() == false)
            {
                LaunchType = "Private";
                Forest.ThreadStart(FNLaunch);
            }
            else
            {
                MessageBox.Show("Fortnite Is Already Running!", "ForestFN Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
