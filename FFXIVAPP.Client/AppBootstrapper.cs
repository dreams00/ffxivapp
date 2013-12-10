﻿// FFXIVAPP.Client
// AppBootstrapper.cs
// 
// © 2013 Ryan Wilson

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FFXIVAPP.Common.Utilities;
using NLog;
using SmartAssembly.Attributes;

namespace FFXIVAPP.Client
{
    [DoNotObfuscate]
    internal class AppBootstrapper : INotifyPropertyChanged
    {
        #region Property Bindings

        private static AppBootstrapper _instance;

        public static AppBootstrapper Instance
        {
            get { return _instance ?? (_instance = new AppBootstrapper()); }
        }

        #endregion

        #region Declarations

        #endregion

        /*main entry to app
         * used for:
         *  initializing settings
         *  configuring collections
         *  setting up dependencies
         */

        private AppBootstrapper()
        {
            if (App.MArgs != null)
            {
                foreach (var s in App.MArgs)
                {
                    Logging.Log(LogManager.GetCurrentClassLogger(), String.Format("ArgumentProvided : {0}", s));
                }
            }
            Constants.IsOpen = false;
            Constants.ProcessID = -1;
            //initialize application data
            AppViewModel.Instance.ConfigurationsPath = "./Configurations/";
            AppViewModel.Instance.LogsPath = "./Logs/";
            AppViewModel.Instance.SavedLogsDirectoryList = new List<string>
            {
                "Say",
                "Shout",
                "Party",
                "Tell",
                "LS1",
                "LS2",
                "LS3",
                "LS4",
                "LS5",
                "LS6",
                "LS7",
                "LS8",
                "FC",
                "Yell"
            };
            AppViewModel.Instance.ScreenShotsPath = "./ScreenShots/";
            AppViewModel.Instance.SoundsPath = "./Sounds/";
            AppViewModel.Instance.SettingsPath = "./Settings/";
            Initializer.SetupCurrentUICulture();
            Initializer.LoadChatCodes();
            Initializer.LoadAutoTranslate();
            Initializer.LoadColors();
            Initializer.LoadPlugins();
        }

        #region Loading Functions

        #endregion

        #region Utility Functions

        #endregion

        #region Command Bindings

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}
