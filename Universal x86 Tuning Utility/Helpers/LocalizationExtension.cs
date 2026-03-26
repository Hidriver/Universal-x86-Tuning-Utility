using System;
using System.Windows;
using System.Windows.Data;
using Universal_x86_Tuning_Utility.Services;

namespace Universal_x86_Tuning_Utility.Helpers
{
    public class LocalizationExtension : Binding
    {
        public LocalizationExtension(string key) : base($"[{key}]")
        {
            Mode = BindingMode.OneWay;
            Source = LocalizationService.Instance;
        }
    }

    public class LocalizedString
    {
        private readonly string _key;

        public LocalizedString(string key)
        {
            _key = key;
        }

        public string Value => LocalizationService.Instance[_key];

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(LocalizedString localizedString)
        {
            return localizedString?.Value ?? string.Empty;
        }
    }
}
