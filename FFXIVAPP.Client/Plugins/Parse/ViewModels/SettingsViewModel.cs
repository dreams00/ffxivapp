﻿// FFXIVAPP.Client
// SettingsViewModel.cs
// 
// © 2013 Ryan Wilson

using System.ComponentModel;
using System.Runtime.CompilerServices;
using SmartAssembly.Attributes;

namespace FFXIVAPP.Client.Plugins.Parse.ViewModels
{
    [DoNotObfuscate]
    internal sealed class SettingsViewModel : INotifyPropertyChanged
    {
        #region Property Bindings

        private static SettingsViewModel _instance;

        public static SettingsViewModel Instance
        {
            get { return _instance ?? (_instance = new SettingsViewModel()); }
        }

        #endregion

        #region Declarations

        #endregion

        #region Loading Functions

        #endregion

        public SettingsViewModel()
        {
        }

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
