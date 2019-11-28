﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Data.Core.ModObjects;
//
//    var mod = Mod.FromJson(jsonString);

using System;
using System.Collections.Generic;
using System.Globalization;
using Data.Core.GameObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Data.Core.ModObjects
{
    public partial class Mod : JsonObjectBase
    {
        [JsonProperty("Name")] public string Name { get; set; }

        [JsonProperty("Enabled")] public bool Enabled { get; set; }

        [JsonProperty("Version")] public string Version { get; set; }

        [JsonProperty("Description")] public string Description { get; set; }

        [JsonProperty("Author")] public string Author { get; set; }

        [JsonProperty("Website")] public string Website { get; set; }

        [JsonProperty("Contact")] public string Contact { get; set; }

        [JsonProperty("PackagedOn")] public DateTimeOffset PackagedOn { get; set; }

        [JsonProperty("BattleTechVersion")] public string BattleTechVersion { get; set; }

        [JsonProperty("BattleTechVersionMin")] public string BattleTechVersionMin { get; set; }

        [JsonProperty("BattleTechVersionMax")] public string BattleTechVersionMax { get; set; }

        [JsonProperty("DependsOn")] public List<string> DependsOnModNames { get; set; } = new List<string>();

        [JsonProperty("ConflictsWith")] public List<string> ConflictsWithModNames { get; set; } = new List<string>();

        [JsonProperty("OptionallyDependsOn")] public List<string> OptionallyDependsOnModNames { get; set; } = new List<string>();

        [JsonProperty("DLL")] public string DllName { get; set; }

        [JsonProperty("DLLEntryPoint")] public string DllEntryPoint { get; set; }

        [JsonProperty("EnableAssemblyVersionCheck")]
        public bool EnableAssemblyVersionCheck { get; set; }

        [JsonProperty("Settings")] public object Settings { get; set; }

        [JsonProperty("CustomResourceTypes")] public List<string> CustomResourceTypes { get; set; } = new List<string>();

        [JsonProperty("Manifest")] public List<ManifestEntryGroup> ManifestEntryGroups { get; set; } = new List<ManifestEntryGroup>();

        [JsonProperty("LoadImplicitManifest")] public bool LoadImplicitManifest { get; set; }

        [JsonProperty("IgnoreLoadFailure")] public bool IgnoreLoadFailure { get; set; }
    }

    public partial class Mod
    {
        public static Mod FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Mod>(json, Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this Mod self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            }
        };
    }
}