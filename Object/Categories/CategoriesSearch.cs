﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using WebservicesSage.Object.Categories;
//
//    var categoriesSearch = CategoriesSearch.FromJson(jsonString);

namespace WebservicesSage.Object.Categories
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CategoriesSearch
    {
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("search_criteria")]
        public SearchCriteria SearchCriteria { get; set; }

        [JsonProperty("total_count")]
        public long TotalCount { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parent_id")]
        public long ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("children")]
        public string Children { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("available_sort_by")]
        public List<object> AvailableSortBy { get; set; }

        [JsonProperty("include_in_menu")]
        public bool IncludeInMenu { get; set; }

        [JsonProperty("custom_attributes")]
        public List<CustomAttribute> CustomAttributes { get; set; }
    }

    public partial class CustomAttribute
    {
        [JsonProperty("attribute_code")]
        public string AttributeCode { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class SearchCriteria
    {
        [JsonProperty("filter_groups")]
        public List<FilterGroup> FilterGroups { get; set; }
    }

    public partial class FilterGroup
    {
        [JsonProperty("filters")]
        public List<Filter> Filters { get; set; }
    }

    public partial class Filter
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("condition_type")]
        public string ConditionType { get; set; }
    }

    public partial class CategoriesSearch
    {
        public static CategoriesSearch FromJson(string json) => JsonConvert.DeserializeObject<CategoriesSearch>(json, WebservicesSage.Object.Categories.ConverterCategoriesSearch.Settings);
    }

     public static class SerializeCategoriesSearch
     {
         public static string ToJson(this CategoriesSearch self) => JsonConvert.SerializeObject(self, WebservicesSage.Object.Categories.ConverterCategoriesSearch.Settings);
     }

     internal static class ConverterCategoriesSearch
     {
         public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
         {
             MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
             DateParseHandling = DateParseHandling.None,
             Converters =
             {
                 new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
             },
         };
     }
}
