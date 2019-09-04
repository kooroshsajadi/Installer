using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Installer
{
    public class Installation
    {
        public FrmFeaturesInstallation FrmFeaturesInstallationObj { set; get; }
        public FrmSoftwareInstallation FrmSoftwareInstallationObj { set; get; }

        public Installation(FrmFeaturesInstallation frmFeaturesInstallationObj)
        {
            FrmFeaturesInstallationObj = frmFeaturesInstallationObj;
        }

        public Installation(FrmSoftwareInstallation frmSoftwareInstallationObj)
        {
            FrmSoftwareInstallationObj = frmSoftwareInstallationObj;
        }

        // In this method the features that are needed to be installed are first gathered in an
        // array of strings called featureNames and then they are passed into the 'Run' method.
        // After the installation the log of the process is saved.
        public void InstallIISAndLog()
        {
            try
            {
                FrmFeaturesInstallationObj.TextAppend = DateTime.Now + "\r\nشروع نصب IIS...\r\n\r\n";
                string[] featureNames = new[] { "NetFx4-AdvSrvs", "NetFx4Extended-ASPNET45", "WCF-Services45", "WCF-HTTP-Activation45",
                                            "WCF-TCP-Activation45", "WCF-Pipe-Activation45", "WCF-MSMQ-Activation45",
                                            "WCF-TCP-PortSharing45", "IIS-WebServerRole", "IIS-WebServer",
                                            "IIS-CommonHttpFeatures", "IIS-HttpErrors", "IIS-HttpRedirect",
                                            "IIS-ApplicationDevelopment", "IIS-NetFxExtensibility", "IIS-NetFxExtensibility45",
                                            "IIS-HealthAndDiagnostics", "IIS-HealthAndDiagnostics", "IIS-HttpLogging",
                                            "IIS-LoggingLibraries", "IIS-RequestMonitor", "IIS-HttpTracing",
                                            "IIS-Security", "IIS-URLAuthorization", "IIS-RequestFiltering",
                                            "IIS-IPSecurity", "IIS-Performance", "IIS-HttpCompressionDynamic",
                                            "IIS-WebServerManagementTools", "IIS-ManagementScriptingTools", "IIS-IIS6ManagementCompatibility",
                                            "IIS-Metabase", "WAS-WindowsActivationService", "WAS-ProcessModel",
                                            "WAS-NetFxEnvironment", "WAS-ConfigurationAPI", "IIS-HostableWebCore",
                                            "WCF-HTTP-Activation", "WCF-NonHTTP-Activation", "IIS-CertProvider",
                                            "IIS-WindowsAuthentication", "IIS-DigestAuthentication", "IIS-ClientCertificateMappingAuthentication",
                                            "IIS-IISCertificateMappingAuthentication", "IIS-ODBCLogging", "IIS-StaticContent",
                                            "IIS-DefaultDocument", "IIS-DirectoryBrowsing", "IIS-WebDAV",
                                            "IIS-WebSockets", "IIS-ApplicationInit", "IIS-ASPNET",
                                            "IIS-ASPNET45", "IIS-ASP", "IIS-CGI", "IIS-ISAPIExtensions",
                                            "IIS-ISAPIFilter", "IIS-ServerSideIncludes", "IIS-CustomLogging",
                                            "IIS-BasicAuthentication", "IIS-HttpCompressionStatic", "IIS-ManagementConsole",
                                            "IIS-ManagementService", "IIS-WMICompatibility", "IIS-LegacyScripts",
                                            "IIS-LegacySnapIn","IIS-FTPServer", "IIS-FTPSvc", "IIS-FTPExtensibility" };
                foreach (string feature in featureNames)
                {
                    Run("DISM", string.Format("/Online /NoRestart /Quiet /Enable-Feature:{0}", feature));
                    FrmFeaturesInstallationObj.TextAppend = DateTime.Now + "\r\n" + feature + " نصب شد.\r\n\r\n";
                }
                FrmFeaturesInstallationObj.TextAppend = DateTime.Now + "\r\nنصب IIS با موفقیت تکمیل شد.\r\n\r\n";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // This method runs DISM. 'Filename' argument takes dism as a parameter in the caller and
        // the 'arguments' argument receives a string representing the feature that is intended to be enabled.
        private void Run(string fileName, string arguments)
        {
            try
            {
                using (var process = Process.Start(new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Normal,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                }))
                {
                    process.WaitForExit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InstallKeyAAndLog()
        {
            try
            {
                FrmFeaturesInstallationObj.TextAppend = DateTime.Now + "\r\nشروع فرایند نصب KeyA...\r\n\r\n";
                string installerFilePath = FrmFeaturesInstallationObj.PublishPath + @"\Prerequisities\{6DE182B3-906D-4DEB-86B2-3F277CEFA73C}\KeyA2COMSetup.msi";
                Process installerProcess = Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    //indicate progress to user 
                    System.Windows.Forms.Application.DoEvents();
                }
                // Log that KeyaA has been installed.
                FrmFeaturesInstallationObj.TextAppend = DateTime.Now + "\r\nنصب KeyA با موفقیت تکمیل شد.\r\n\r\n";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InstallKasraPrintServiceAndLog()
        {
            try
            {
                FrmFeaturesInstallationObj.TextAppend = DateTime.Now + "\r\nشروع فرایند نصب Kasra Print Service...\r\n\r\n";
                string installerFilePath = FrmFeaturesInstallationObj.PublishPath + @"\Prerequisities\{5557871D-1688-440D-9376-1C05C96E3D4F}\KasraServiceSetup.msi";
                Process installerProcess = Process.Start(installerFilePath, "/q");
                while (installerProcess.HasExited == false)
                {
                    // Indicate the progress to user. 
                    System.Windows.Forms.Application.DoEvents();
                }
                // Log that the Kasra Point Service has been installed.
                FrmFeaturesInstallationObj.TextAppend = DateTime.Now + "\r\nنصب Kasra Print Service با موفقیت انجام شد.\r\n\r\n";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InstallFlashPlayer()
        {

        }

        public void ConfigureWebsite()
        {
            try
            {
                // We make a sever manager to get access to the IIS.
                ServerManager serverManager = new ServerManager();

                // Create a pool in order to add the upcoming application to it. The pool's name is the same as the website name.
                ApplicationPool appPool = serverManager.ApplicationPools.Add(FrmSoftwareInstallationObj.WebsiteName);

                // Enable 32-bit applications.
                appPool.Enable32BitAppOnWin64 = true;

                // Create the customized website where the app files are stored(in the 'websitePhysicalPath').
                string websitePhysicalPath = FrmSoftwareInstallationObj.ProjectPath + @"Kasra\Project\" + FrmSoftwareInstallationObj.WebsiteName;
                Site mySite = serverManager.Sites.Add(FrmSoftwareInstallationObj.WebsiteName, "http", "*:" + FrmSoftwareInstallationObj.PortNumber + ":", websitePhysicalPath);

                // Add the website and its application to the pool.
                mySite.ApplicationDefaults.ApplicationPoolName = FrmSoftwareInstallationObj.WebsiteName;

                // Add the 'FrmPresentation' app.
                string appPhysicalPath = websitePhysicalPath + @"\Framework\FrmPresentation\FrmPresentation";
                mySite.Applications.Add("/Framework/FrmPresentation/FrmPresentation", appPhysicalPath);
                // Add the previous app again in order to add it to the root directory.
                mySite.Applications.Add("/FrmPresentation", appPhysicalPath);
                // Add the proper values to its web config file.
                ChangeWebConfig(appPhysicalPath + "\\Web.config", FrmSoftwareInstallationObj.DatabaseName, FrmSoftwareInstallationObj.InstanceName);
                
                // Do the same for the other apps. Framework2003 app.
                appPhysicalPath = websitePhysicalPath + @"\Framework2003";
                mySite.Applications.Add("/Framework2003", appPhysicalPath);
                // Add the proper values to its web config file.
                ChangeWebConfig(appPhysicalPath + "\\Web.config", FrmSoftwareInstallationObj.DatabaseName, FrmSoftwareInstallationObj.InstanceName);

                // TAPresentation app.
                appPhysicalPath = websitePhysicalPath + @"\TA\TAPresentation\TAPresentation";
                mySite.Applications.Add("/TA/TAPresentation/TAPresentation", appPhysicalPath);
                mySite.Applications.Add("/TAPresentation", appPhysicalPath);
                ChangeWebConfig(appPhysicalPath + "\\web.config", FrmSoftwareInstallationObj.DatabaseName, FrmSoftwareInstallationObj.InstanceName);

                // Lego.Web app.
                appPhysicalPath = websitePhysicalPath + @"\Lego.Web";
                mySite.Applications.Add("/Lego.Web", appPhysicalPath);
                ChangeWebConfig(appPhysicalPath + "\\Web.config", FrmSoftwareInstallationObj.DatabaseName, FrmSoftwareInstallationObj.InstanceName);


                // Add the restaurant app if its check box is enabled.
                if (FrmSoftwareInstallationObj.RestaurantCheckBox)
                {
                    appPhysicalPath = websitePhysicalPath + @"\Restaurant\RstPresentation\RstPresentation";
                    mySite.Applications.Add("/Restaurant/RstPresentation/RstPresentation", appPhysicalPath);
                    mySite.Applications.Add("/Restaurant", appPhysicalPath);
                    ChangeWebConfig(appPhysicalPath + "\\Web.config", FrmSoftwareInstallationObj.DatabaseName, FrmSoftwareInstallationObj.InstanceName);
                }

                // Add the web services app if its check box is enabled.
                if (FrmSoftwareInstallationObj.WebServiceCheckBox)
                {
                    appPhysicalPath = websitePhysicalPath + @"\WebServices\KasraWebServices";
                    mySite.Applications.Add("/WebServices/KasraWebServices", appPhysicalPath);
                    mySite.Applications.Add("/KasraWebServices", appPhysicalPath);
                    ChangeWebConfig(appPhysicalPath + "\\Web.config", FrmSoftwareInstallationObj.DatabaseName, FrmSoftwareInstallationObj.InstanceName);
                }

                serverManager.CommitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddToAppSettings(Dictionary<string, string> keyValuePairs, string webConfigAddress)
        {
            try
            {
                // Open the web.config.
                System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap() { ExeConfigFilename = webConfigAddress }, ConfigurationUserLevel.None);

                KeyValueConfigurationElement element;
                foreach(KeyValuePair<string, string> entry in keyValuePairs)
                {
                    // Now that we have our config, grab the element out of the settings.
                    element = config.AppSettings.Settings[entry.Key];

                    // It may be null if its not there already.
                    if (element == null)
                    {
                        // We'll handle it not being there by adding it with the new value.
                        config.AppSettings.Settings.Add(entry.Key, entry.Value);
                    }
                    else
                    {
                        // Note: If you wanted to you could inspect the current value via element.Value
                        // In this case, its already present, just update the value.
                        element.Value = entry.Value;
                    }
                }
                
                // Save the config, minimal is key here if you don't want huge web.config bloat.
                config.Save(ConfigurationSaveMode.Modified, true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ChangeWebConfig(string PathToWebConfig, string databaseName, string databaseInstance)
        {
            try
            {
                XDocument config = XDocument.Load(PathToWebConfig);
                XElement targetNode = config.Root.Element("appSettings").Elements("add").SingleOrDefault(x => x.FirstAttribute.Value == "DataSource");
                targetNode.LastAttribute.Value = databaseInstance;
                XElement targetNodePw = config.Root.Element("appSettings").Elements("add").SingleOrDefault(x => x.FirstAttribute.Value == "InitialCatalog");
                targetNodePw.LastAttribute.Value = databaseName;
                var targetNodeAddress = config.Root.Element("appSettings").Elements("add").SingleOrDefault(x => x.FirstAttribute.Value == "BaseCatalog");
                targetNodeAddress.LastAttribute.Value = databaseName;

                config.Save(PathToWebConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
/*
 ServerManager serverManager1 = new ServerManager();

                // Add the 'FrmPresentation' app.
                string appPhysicalPath = websitePhysicalPath + @"\Framework\FrmPresentation\FrmPresentation";
                mySite.Applications.Add("/Framework/FrmPresentation/FrmPresentation", appPhysicalPath);
                // Add the previous app again in order to add it to the root directory.
                mySite.Applications.Add("/FrmPresentation", appPhysicalPath);
                // Add the connection string to its web config.
                AddToAppSettings(keyValuePairs, appPhysicalPath + @"\Web.config");

                // Do the same for the other apps. Framework2003 app.
                appPhysicalPath = websitePhysicalPath + @"\Framework2003";
                mySite.Applications.Add("/Framework2003", appPhysicalPath);
                AddToAppSettings(keyValuePairs, appPhysicalPath + @"\Web.config");

                // TAPresentation app.
                appPhysicalPath = websitePhysicalPath + @"\TA\TAPresentation\TAPresentation";
                mySite.Applications.Add("/TA/TAPresentation/TAPresentation", appPhysicalPath);
                mySite.Applications.Add("/TAPresentation", appPhysicalPath);
                AddToAppSettings(keyValuePairs, appPhysicalPath + @"\web.config");

                // Lego.Web app.
                appPhysicalPath = websitePhysicalPath + @"\Lego.Web";
                mySite.Applications.Add("/Lego.Web", appPhysicalPath);
                AddToAppSettings(keyValuePairs, appPhysicalPath + @"\Web.config");

                // Add the restaurant app if its check box is enabled.
                if (FrmSoftwareInstallationObj.RestaurantCheckBox)
                {
                    appPhysicalPath = websitePhysicalPath + @"\Restaurant\RstPresentation\RstPresentation";
                    mySite.Applications.Add("/Restaurant/RstPresentation/RstPresentation", appPhysicalPath);
                    mySite.Applications.Add("/Restaurant", appPhysicalPath);
                    AddToAppSettings(keyValuePairs, appPhysicalPath + @"\Web.config");
                }
                serverManager.CommitChanges();*/
