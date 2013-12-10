// FFXIVAPP.Client
// MaxStat.cs
// 
// � 2013 Ryan Wilson

using System;
using FFXIVAPP.Client.Plugins.Parse.Models.Stats;
using SmartAssembly.Attributes;

namespace FFXIVAPP.Client.Plugins.Parse.Models.LinkedStats
{
    [DoNotObfuscate]
    public sealed class MaxStat : LinkedStat
    {
        public MaxStat(string name, params Stat<decimal>[] dependencies) : base(name, 0m)
        {
            AddDependency(dependencies[0]);
        }

        public MaxStat(string name, decimal value) : base(name, 0m)
        {
        }

        public MaxStat(string name) : base(name, 0m)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="previousValue"> </param>
        /// <param name="newValue"> </param>
        public override void DoDependencyValueChanged(object sender, object previousValue, object newValue)
        {
            var ovalue = (decimal) previousValue;
            var nvalue = (decimal) newValue;
            var delta = Math.Max(ovalue, nvalue) - Math.Min(ovalue, nvalue);
            if (delta > Value)
            {
                Value = delta;
            }
        }
    }
}
