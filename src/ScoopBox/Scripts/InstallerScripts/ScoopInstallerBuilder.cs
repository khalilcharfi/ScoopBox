﻿using ScoopBox.Scripts.InstallerScripts.Abstract;
using System.Text;

namespace ScoopBox.Scripts.InstallerScripts
{
    public class ScoopInstallerBuilder : IScoopInstallerBuilder
    {
        public string Build()
        {
            StringBuilder installerBuilder = new StringBuilder();

            installerBuilder.Append("Invoke-Expression");
            installerBuilder.Append(" (New-Object");
            installerBuilder.Append(" System.Net.WebClient)");
            installerBuilder.Append(".DownloadString");
            installerBuilder.Append("('https://get.scoop.sh')");

            installerBuilder.AppendLine();
            return installerBuilder.ToString();
        }
    }
}
