﻿// <auto-generated />

using Data.Core.GameObjects;
using Newtonsoft.Json;

namespace Data.Core.ModObjects
{
    public partial class ManifestEntryGroup : JsonObjectBase
    {
        [JsonProperty("Type")] public string Type { get; set; }

        [JsonProperty("Path")] public string Path { get; set; }

        [JsonProperty("AddToDB", NullValueHandling = NullValueHandling.Ignore)]
        public bool AddToDb { get; set; } = true;

        [JsonProperty("ShouldMergeJSON", NullValueHandling = NullValueHandling.Ignore)]
        public bool ShouldMergeJson { get; set; } = false;

        [JsonProperty("AssetBundleName", NullValueHandling = NullValueHandling.Ignore)] public string AssetBundleName { get; set; } = string.Empty;

        [JsonProperty("ShouldAppendText", NullValueHandling = NullValueHandling.Ignore)] 
        public bool ShouldAppendText { get; set; } = false;
    }
}