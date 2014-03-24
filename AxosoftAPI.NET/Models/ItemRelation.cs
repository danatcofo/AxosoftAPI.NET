﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxosoftAPI.NET.Models
{
	public class ItemRelation : BaseModel
	{
		[JsonProperty("relation_type")]
		public RelationType RelationType { get; set; }

		[JsonProperty("parent_item")]
		public Item ParentItem { get; set; }

		[JsonProperty("child_item")]
		public Item ChildItem { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("date_time")]
		public DateTime? DateTime { get; set; }

		[JsonProperty("user")]
		public User User { get; set; }
	}
}
