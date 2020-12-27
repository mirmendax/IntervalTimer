using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Net;
using System.Threading;
using Newtonsoft.Json;

namespace IntervalTimerLib
{
    public class SettingsContext
    {
        private readonly string fileSettings = "settings.json";
        public Settings Settings = new Settings();

        private SettingsContext()
        {
            Load();
        }
        
        public static SettingsContext GetSettings() => new SettingsContext();
        
        public void Save()
        {
            try
            {
                var strJson = JsonConvert.SerializeObject(Settings, Formatting.Indented);
                File.WriteAllText(fileSettings, strJson);
            }
            catch
            {
                throw new Exception("Ошибка сериализации");
            }
        }

        private void DefaultSettings()
        {
            Settings = new Settings();
            Settings.CurrentSound = -1;
            Settings.ListSound = new List<string>();
            Settings.ListTimers = new List<Time>();
            Settings.IsTransitTimer = false;
            Settings.TransitTimer = new Time();
            Save();
        }

        public void Load()
        {
            if (File.Exists(fileSettings))
            {
                
                try
                {
                    var fJson = File.ReadAllText(fileSettings);
                    Settings = JsonConvert.DeserializeObject<Settings>(fJson);
                }
                catch
                {
                    throw new Exception("Ошибка десериализации");
                }
                
            }
            else
            {
                DefaultSettings();
            }
        }
    }
}