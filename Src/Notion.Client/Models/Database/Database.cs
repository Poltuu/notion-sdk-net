﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Notion.Client
{
    public class Database : IObject, IObjectModificationData
    {
        [JsonProperty("title")]
        public List<RichTextBase> Title { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, Property> Properties { get; set; }

        [JsonProperty("parent")]
        public IDatabaseParent Parent { get; set; }

        [JsonProperty("icon")]
        public IPageIcon Icon { get; set; }

        [JsonProperty("cover")]
        public FileObject Cover { get; set; }

        /// <summary>
        ///     The URL of the Notion database.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        ///     The archived status of the database.
        /// </summary>
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("is_inline")]
        public bool IsInline { get; set; }

        [JsonProperty("description")]
        public IEnumerable<RichTextBase> Description { get; set; }

        public ObjectType Object => ObjectType.Database;

        public string Id { get; set; }

        [JsonProperty("created_time")]
        public DateTime CreatedTime { get; set; }

        [JsonProperty("last_edited_time")]
        public DateTime LastEditedTime { get; set; }

        public PartialUser CreatedBy { get; set; }

        public PartialUser LastEditedBy { get; set; }
    }
}
