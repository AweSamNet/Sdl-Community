using AweSamNet.Integration.GithubReleaseAutoUpdater.Interfaces;
using AweSamNet.Integration.GithubReleaseAutoUpdater.Models;
using AweSamNet.Integration.GitHubReleaseAutoUpdater;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sdl.Community.MtEnhancedProvider
{
    public class MtPluginUpdaterProvider : IUpdaterProvider
    {
        public MtPluginUpdaterProvider(MtTranslationOptions options) : this(null, options)
        {
        }

        public MtPluginUpdaterProvider(IWin32Window owner, MtTranslationOptions options)
        {
            if (options == null) throw new ArgumentNullException("options", "You must pass a proper MtTranslationOptions.");

            Options = options;
            Owner = owner;
        }

        public MtTranslationOptions Options { get; private set; }
        public Uri VersionLocation => new Uri("https://raw.githubusercontent.com/AweSamNet/Sdl-Community/legacy_support/MT%20Enhanced%20Provider/Sdl.Community.MtEnhancedProvider/current.version");
        public string ApplicationName => "MtEnhancedProvider";
        public string RepositoryOwner => "AweSamNet";
        public string RepositoryName => "Sdl-Community";
        public IWin32Window Owner { get; private set; }

        public string DownloadLocation
        {
            get
            {
                string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                return Path.Combine(userPath, "Downloads");
            }
        }

        public Settings GetSettings()
        {
            return new Settings
            {
                EnableAutoUpdate = Options.EnablePluginAutoUpdate,
                LatestSkippedVersion = Options.LatestSkippedVersion,
            };
        }

        public void SaveSettings(Settings settings)
        {
            Options.EnablePluginAutoUpdate = settings.EnableAutoUpdate;
            Options.LatestSkippedVersion = settings.LatestSkippedVersion;
        }

        public NewVersionOptions PromptNewVersion(string latestVersion, string releaseNotes)
        {
            return PromptNewVersion(GetCurrentVersion().TagName, latestVersion, releaseNotes);
        }

        public NewVersionOptions PromptNewVersion(string currentVersion, string latestVersion, string releaseNotes)
        {
            var settings = GetSettings();
            var dialog = new MtPluginUpdateAvailableDialog(currentVersion, latestVersion, releaseNotes);
            dialog.ShowDialog(Owner);

            if (dialog.NewVersionOption == NewVersionOptions.RemindMeLater) Options.UpdateRemindMeLater = true;

            return dialog.NewVersionOption;
        }

        public void AfterDownload(string filePath)
        {
            var dialog = new MtPluginDownloadSuccessfulDialog(filePath);
            var result = dialog.ShowDialog(Owner);

            if(result == DialogResult.OK)
            {
                Process.Start("explorer.exe", "/select, \"" + filePath + "\"");
            }
        }

        public GitHubVersion GetCurrentVersion()
        {
            var currentAssembly = Assembly.GetAssembly(typeof(MtPluginUpdaterProvider));
            var path = Path.GetDirectoryName(currentAssembly.Location);
            var json = File.ReadAllText(Path.Combine(path, @"current.version"));
            var releases = JsonConvert.DeserializeObject<List<GitHubVersion>>(json);

            return releases?.LastOrDefault();
        }
    }
}
