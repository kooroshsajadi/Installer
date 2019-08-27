using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace Installer
{
    class Prerequisite
    {
        public List<PrerequisiteViewModel> GetPrerequisitesList()
        {
            List<PrerequisiteViewModel> list = new List<PrerequisiteViewModel>();
            list.Add(WindowsEditionObjBuilder());
            list.Add(DotnetEditionObjBuilder());
            list.Add(FirewallStatusObjBuilder());
            return list;
        }

        // This method finds out whether the firewall is on(true) or off(false).
        public bool GetFirewallStatus()
        {
            // Create the firewall type.
            Type FWManagerType = Type.GetTypeFromProgID("HNetCfg.FwMgr");

            // Use the firewall type to create a firewall manager object.
            dynamic FWManager = Activator.CreateInstance(FWManagerType);

            // Check the status of the firewall.
            return FWManager.LocalPolicy.CurrentProfile.FirewallEnabled;
        }
        public string GetWindowsEdition()
        {
            string result = "";
            // Receive a collection of ManagementObjects based on the specified querey.
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            string[] arr = result.Split(' ');
            return arr[arr.Length - 1];
        }

        // This method checks wether the DotNET Framework is installed(true) or not(false).
        public bool CheckDotNETFramework3_5()
        {
            // Get access to Regedit.
            RegistryKey installed_versions = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP");
            string[] versionNames = installed_versions.GetSubKeyNames();
            if (versionNames.Contains("v3.5"))
                return true;
            return false;
        }

        // This method create an object which for the windows edition prereqiusite.
        public PrerequisiteViewModel WindowsEditionObjBuilder()
        {
            PrerequisiteViewModel obj = new PrerequisiteViewModel();
            obj.Name = "ویندوز شما نباید Standard باشد.";
            if (GetWindowsEdition().Equals("Standard"))
            {
                obj.Status = false;
                obj.Description = ".است Standard ویندوز شما";
            }
            else
            {
                obj.Status = true;
                obj.Description = "";
            }
            return obj;
        }
        public PrerequisiteViewModel DotnetEditionObjBuilder()
        {
            PrerequisiteViewModel obj = new PrerequisiteViewModel();
            obj.Name = "NET Framework 3.5. باید نصب باشد.";
            obj.Status = CheckDotNETFramework3_5();
            if (!obj.Status)
                obj.Description = ".NET Framwork 3.5 .بر روی سیستم شما نصب نیست";
            else
                obj.Description = "";
            return obj;
        }

        // This method creates an object that holds the values related to the firewall prerequisite.
        public PrerequisiteViewModel FirewallStatusObjBuilder()
        {
            PrerequisiteViewModel obj = new PrerequisiteViewModel();
            obj.Name = "Firewall باید غیر فعال باشد.";
            obj.Status = !GetFirewallStatus();
            if (!obj.Status)
                obj.Description = "Firewall بر روی سیستم شما فعال است.";
            else
                obj.Description = "";
            return obj;
        }
    }
}