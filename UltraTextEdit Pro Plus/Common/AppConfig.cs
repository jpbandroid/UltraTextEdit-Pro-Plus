﻿using Nucs.JsonSettings;
using Nucs.JsonSettings.Modulation;

namespace UltraTextEdit_Pro_Plus.Common;
public class AppConfig : JsonSettings, IVersionable
{
    [EnforcedVersion("1.0.0.0")]
    public virtual Version Version { get; set; } = new Version(1, 0, 0, 0);

    public override string FileName { get; set; } = Constants.AppConfigPath;


    // Docs: https://github.com/Nucs/JsonSettings
}
