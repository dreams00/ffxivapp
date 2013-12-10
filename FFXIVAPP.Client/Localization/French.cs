﻿// FFXIVAPP.Client
// French.cs
// 
// © 2013 Ryan Wilson

using System.Windows;
using SmartAssembly.Attributes;

namespace FFXIVAPP.Client.Localization
{
    [DoNotObfuscate]
    public static partial class French
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            SetClientLocale();
            SetParseLocale();
            return Dictionary;
        }
    }
}
