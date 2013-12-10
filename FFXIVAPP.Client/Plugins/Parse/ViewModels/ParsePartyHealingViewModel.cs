﻿// FFXIVAPP.Client
// ParsePartyHealingViewModel.cs
// 
// © 2013 Ryan Wilson

using System.ComponentModel;
using System.Runtime.CompilerServices;
using SmartAssembly.Attributes;

namespace FFXIVAPP.Client.Plugins.Parse.ViewModels
{
    [DoNotObfuscate]
    internal sealed class ParsePartyHealingViewModel : INotifyPropertyChanged
    {
        #region Property Bindings

        private static ParsePartyHealingViewModel _instance;

        public static ParsePartyHealingViewModel Instance
        {
            get { return _instance ?? (_instance = new ParsePartyHealingViewModel()); }
        }

        #endregion

        #region Declarations

        #endregion

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
