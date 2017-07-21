using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AxosoftAPI.NET.Models
{
	public class BaseModel
	{
		[JsonProperty("id")]
		public int? Id { get; set; }

		[JsonProperty("created_date_time")]
		public DateTime? CreatedDateTime { get; set; }

		[JsonProperty("created_by")]
		public User CreatedBy { get; set; }

		[JsonProperty("created_by_id")]
		public int CreatedById { get; set; }

		[JsonProperty("created_by_user_type")]
		public int CreatedByUserType { get; set; }

		[JsonProperty("last_updated_date_time")]
		public DateTime? LastUpdatedDateTime { get; set; }

		[JsonProperty("last_updated_by")]
		public User LastUpdatedBy { get; set; }

		[JsonExtensionData(ReadData = true, WriteData = true)]
		public Dictionary<string, JToken> ExtensionData { get; set; }
	}
}
