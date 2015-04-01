﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CSGOSchema;

namespace SteamEcon.Schema.CSGOSchema
{
    public class CSGOSchema
    {

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("items_game_url")]
        public string ItemsGameUrl { get; set; }

        [JsonProperty("qualities")]
        public Qualities Qualities { get; set; }

        [JsonProperty("qualityNames")]
        public QualityNames QualityNames { get; set; }

        [JsonProperty("originNames")]
        public IList<OriginName> OriginNames { get; set; }

        [JsonProperty("items")]
        public IList<Item> Items { get; set; }

        [JsonProperty("attributes")]
        public IList<CSGOSchemaAttribute> Attributes { get; set; }

        [JsonProperty("item_sets")]
        public IList<ItemSetInfo> ItemSets { get; set; }

        [JsonProperty("attribute_controlled_attached_particles")]
        public IList<object> AttributeControlledAttachedParticles { get; set; }

        [JsonProperty("item_levels")]
        public IList<ItemLevel> ItemLevels { get; set; }

        [JsonProperty("kill_eater_ranks")]
        public IList<KillEaterRank> KillEaterRanks { get; set; }

        [JsonProperty("kill_eater_score_types")]
        public IList<KillEaterScoreType> KillEaterScoreTypes { get; set; }
    }
}

namespace CSGOSchema
{
    public class Qualities
    {

        [JsonProperty("normal")]
        public int Normal { get; set; }

        [JsonProperty("genuine")]
        public int Genuine { get; set; }

        [JsonProperty("vintage")]
        public int Vintage { get; set; }

        [JsonProperty("unusual")]
        public int Unusual { get; set; }

        [JsonProperty("unique")]
        public int Unique { get; set; }

        [JsonProperty("community")]
        public int Community { get; set; }

        [JsonProperty("developer")]
        public int Developer { get; set; }

        [JsonProperty("selfmade")]
        public int Selfmade { get; set; }

        [JsonProperty("customized")]
        public int Customized { get; set; }

        [JsonProperty("strange")]
        public int Strange { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }

        [JsonProperty("haunted")]
        public int Haunted { get; set; }

        [JsonProperty("tournament")]
        public int Tournament { get; set; }
    }
    public class QualityNames
    {

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("genuine")]
        public string Genuine { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("unusual")]
        public string Unusual { get; set; }

        [JsonProperty("unique")]
        public string Unique { get; set; }

        [JsonProperty("community")]
        public string Community { get; set; }

        [JsonProperty("developer")]
        public string Developer { get; set; }

        [JsonProperty("selfmade")]
        public string Selfmade { get; set; }

        [JsonProperty("customized")]
        public string Customized { get; set; }

        [JsonProperty("strange")]
        public string Strange { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("haunted")]
        public string Haunted { get; set; }

        [JsonProperty("tournament")]
        public string Tournament { get; set; }
    }
    public class OriginName
    {

        [JsonProperty("origin")]
        public int Origin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public class Item
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("defindex")]
        public int Defindex { get; set; }

        [JsonProperty("item_class")]
        public string ItemClass { get; set; }

        [JsonProperty("item_type_name")]
        public string ItemTypeName { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("item_description")]
        public string ItemDescription { get; set; }

        [JsonProperty("proper_name")]
        public bool ProperName { get; set; }

        [JsonProperty("item_quality")]
        public int ItemQuality { get; set; }

        [JsonProperty("image_inventory")]
        public string ImageInventory { get; set; }

        [JsonProperty("min_ilevel")]
        public int MinIlevel { get; set; }

        [JsonProperty("max_ilevel")]
        public int MaxIlevel { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("image_url_large")]
        public string ImageUrlLarge { get; set; }

        [JsonProperty("craft_class")]
        public string CraftClass { get; set; }

        [JsonProperty("craft_material_type")]
        public string CraftMaterialType { get; set; }

        [JsonProperty("capabilities")]
        public Capabilities Capabilities { get; set; }

        [JsonProperty("attributes")]
        public IList<Attribute> Attributes { get; set; }

        [JsonProperty("tool")]
        public Tool Tool { get; set; }
    }
    public class Capabilities
    {

        [JsonProperty("paintable")]
        public bool Paintable { get; set; }

        [JsonProperty("nameable")]
        public bool Nameable { get; set; }

        [JsonProperty("can_sticker")]
        public bool CanSticker { get; set; }

        [JsonProperty("can_stattrack_swap")]
        public bool CanStattrackSwap { get; set; }

        [JsonProperty("usable_gc")]
        public bool? UsableGc { get; set; }

        [JsonProperty("usable_out_of_game")]
        public bool? UsableOutOfGame { get; set; }

        [JsonProperty("can_delete")]
        public bool? CanDelete { get; set; }

        [JsonProperty("decodable")]
        public bool? Decodable { get; set; }
    }
    public class Attribute
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
    public class Tool
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usage_capabilities")]
        public UsageCapabilities UsageCapabilities { get; set; }

        [JsonProperty("use_string")]
        public string UseString { get; set; }

        [JsonProperty("restriction")]
        public string Restriction { get; set; }
    }
    public class UsageCapabilities
    {

        [JsonProperty("usable_out_of_game")]
        public bool UsableOutOfGame { get; set; }

        [JsonProperty("recipe")]
        public bool Recipe { get; set; }

        [JsonProperty("nameable")]
        public bool? Nameable { get; set; }

        [JsonProperty("decodable")]
        public bool? Decodable { get; set; }

        [JsonProperty("can_sticker")]
        public bool? CanSticker { get; set; }

        [JsonProperty("can_stattrack_swap")]
        public bool? CanStattrackSwap { get; set; }
    }
    public class CSGOSchemaAttribute
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("defindex")]
        public int Defindex { get; set; }

        [JsonProperty("attribute_class")]
        public string AttributeClass { get; set; }

        [JsonProperty("effect_type")]
        public string EffectType { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("stored_as_integer")]
        public bool StoredAsInteger { get; set; }

        [JsonProperty("description_string")]
        public string DescriptionString { get; set; }

        [JsonProperty("description_format")]
        public string DescriptionFormat { get; set; }
    }
    public class ItemSetInfo
    {

        [JsonProperty("item_set")]
        public string ItemSet { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("items")]
        public IList<string> Items { get; set; }
    }
    public class ItemLevel
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("levels")]
        public IList<LevelInfo> Levels { get; set; }
    }
    public class LevelInfo
    {

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("required_score")]
        public int RequiredScore { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public class KillEaterRank
    {

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("required_score")]
        public int RequiredScore { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public class KillEaterScoreType
    {

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("type_name")]
        public string TypeName { get; set; }
    }
}
