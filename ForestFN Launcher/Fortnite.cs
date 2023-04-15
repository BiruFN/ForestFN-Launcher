using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestFN_Launcher
{
    public class RunCheck
    {
        public static bool CheckShipping()
        {
            try
            {
                var process = Process.GetProcessesByName("FortniteClient-Win64-Shipping")[0];
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckShippingBE()
        {
            try
            {
                var process = Process.GetProcessesByName("FortniteClient-Win64-Shipping_BE")[0];
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckShippingEAC()
        {
            try
            {
                var process = Process.GetProcessesByName("FortniteClient-Win64-Shipping_EAC")[0];
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckLauncher()
        {
            try
            {
                var process = Process.GetProcessesByName("FortniteLauncher")[0];
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class Installed
    {
        public static string GetFNLocation()
        {
            var launcherInstalledDat = @"C:\ProgramData\Epic\UnrealEngineLauncher\LauncherInstalled.dat";
            var installationList = JsonConvert.DeserializeObject<EpicInstallLocations>(File.ReadAllText(launcherInstalledDat)).InstallationList;
            var installation = installationList.FirstOrDefault((Installation i) => i.AppName == "Fortnite");
            return installation.InstallLocation;
        }

        public static string GetFNVersion()
        {
            var launcherInstalledDat = @"C:\ProgramData\Epic\UnrealEngineLauncher\LauncherInstalled.dat";
            var installationList = JsonConvert.DeserializeObject<EpicInstallLocations>(File.ReadAllText(launcherInstalledDat)).InstallationList;
            var installation = installationList.FirstOrDefault((Installation i) => i.AppName == "Fortnite");
            return installation.AppVersion;
        }
    }

    public class EpicInstallLocations
    {
        public List<Installation> InstallationList { get; set; }
    }

    public class Installation
    {
        public string InstallLocation { get; set; }
        public string NamespaceId { get; set; }
        public string ItemId { get; set; }
        public string ArtifactId { get; set; }
        public string AppVersion { get; set; }
        public string AppName { get; set; }
    }
}
