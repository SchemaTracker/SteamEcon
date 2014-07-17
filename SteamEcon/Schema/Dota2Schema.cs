﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Dota2Schema;

namespace SteamEcon.Schema.Dota2Schema
{
    public class Dota2Schema
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
        public IList<Dota2SchemaAttribute> Attributes { get; set; }

        [JsonProperty("item_sets")]
        public IList<ItemSetInfo> ItemSets { get; set; }

        [JsonProperty("attribute_controlled_attached_particles")]
        public IList<AttributeControlledAttachedParticle> AttributeControlledAttachedParticles { get; set; }

        [JsonProperty("item_levels")]
        public IList<ItemLevel> ItemLevels { get; set; }

        [JsonProperty("kill_eater_score_types")]
        public IList<KillEaterScoreType> KillEaterScoreTypes { get; set; }
    }
}

namespace Dota2Schema
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

        [JsonProperty("favored")]
        public int Favored { get; set; }

        [JsonProperty("ascendant")]
        public int Ascendant { get; set; }

        [JsonProperty("autographed")]
        public int Autographed { get; set; }

        [JsonProperty("legacy")]
        public int Legacy { get; set; }

        [JsonProperty("exalted")]
        public int Exalted { get; set; }

        [JsonProperty("frozen")]
        public int Frozen { get; set; }

        [JsonProperty("corrupted")]
        public int Corrupted { get; set; }

        [JsonProperty("lucky")]
        public int Lucky { get; set; }
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

        [JsonProperty("favored")]
        public string Favored { get; set; }

        [JsonProperty("ascendant")]
        public string Ascendant { get; set; }

        [JsonProperty("autographed")]
        public string Autographed { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("exalted")]
        public string Exalted { get; set; }

        [JsonProperty("frozen")]
        public string Frozen { get; set; }

        [JsonProperty("corrupted")]
        public string Corrupted { get; set; }

        [JsonProperty("lucky")]
        public string Lucky { get; set; }
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

        [JsonProperty("capabilities")]
        public Capabilities Capabilities { get; set; }

        [JsonProperty("item_description")]
        public string ItemDescription { get; set; }

        [JsonProperty("attributes")]
        public IList<Attribute> Attributes { get; set; }

        [JsonProperty("item_set")]
        public string ItemSet { get; set; }

        [JsonProperty("tool")]
        public Tool Tool { get; set; }

        [JsonProperty("styles")]
        public IList<Style> Styles { get; set; }
    }
    public class Capabilities
    {

        [JsonProperty("can_craft_mark")]
        public bool CanCraftMark { get; set; }

        [JsonProperty("can_be_restored")]
        public bool CanBeRestored { get; set; }

        [JsonProperty("strange_parts")]
        public bool StrangeParts { get; set; }

        [JsonProperty("paintable_unusual")]
        public bool PaintableUnusual { get; set; }

        [JsonProperty("autograph")]
        public bool Autograph { get; set; }

        [JsonProperty("can_consume")]
        public bool CanConsume { get; set; }

        [JsonProperty("nameable")]
        public bool? Nameable { get; set; }

        [JsonProperty("can_have_sockets")]
        public bool? CanHaveSockets { get; set; }

        [JsonProperty("usable")]
        public bool? Usable { get; set; }

        [JsonProperty("usable_gc")]
        public bool? UsableGc { get; set; }

        [JsonProperty("usable_out_of_game")]
        public bool? UsableOutOfGame { get; set; }

        [JsonProperty("decodable")]
        public bool? Decodable { get; set; }

        [JsonProperty("can_increment")]
        public bool? CanIncrement { get; set; }

        [JsonProperty("uses_essence")]
        public bool? UsesEssence { get; set; }

        [JsonProperty("no_key_required")]
        public bool? NoKeyRequired { get; set; }

        [JsonProperty("can_have_signatures")]
        public bool? CanHaveSignatures { get; set; }
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

        [JsonProperty("use_string")]
        public string UseString { get; set; }

        [JsonProperty("restriction")]
        public string Restriction { get; set; }

        [JsonProperty("usage_capabilities")]
        public UsageCapabilities UsageCapabilities { get; set; }
    }
    public class UsageCapabilities
    {

        [JsonProperty("can_increment")]
        public bool CanIncrement { get; set; }

        [JsonProperty("can_consume")]
        public bool? CanConsume { get; set; }

        [JsonProperty("nameable")]
        public bool? Nameable { get; set; }

        [JsonProperty("decodable")]
        public bool? Decodable { get; set; }

        [JsonProperty("uses_essence")]
        public bool? UsesEssence { get; set; }

        [JsonProperty("can_have_sockets")]
        public bool? CanHaveSockets { get; set; }
    }
    public class Style
    {

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public class Dota2SchemaAttribute
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("defindex")]
        public int Defindex { get; set; }

        [JsonProperty("attribute_class")]
        public string AttributeClass { get; set; }

        [JsonProperty("description_format")]
        public string DescriptionFormat { get; set; }

        [JsonProperty("effect_type")]
        public string EffectType { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("stored_as_integer")]
        public bool StoredAsInteger { get; set; }

        [JsonProperty("description_string")]
        public string DescriptionString { get; set; }
    }
    public class ItemSetInfo
    {

        [JsonProperty("item_set")]
        public string ItemSet { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("store_bundle")]
        public string StoreBundle { get; set; }

        [JsonProperty("items")]
        public IList<string> Items { get; set; }

        [JsonProperty("attributes")]
        public IList<ItemSetInfoAttribute> Attributes { get; set; }
    }
    public class ItemSetInfoAttribute
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
    public class AttributeControlledAttachedParticle
    {

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("attach_to_rootbone")]
        public bool AttachToRootbone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
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
    public class KillEaterScoreType
    {

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("type_name")]
        public string TypeName { get; set; }
    }
}
