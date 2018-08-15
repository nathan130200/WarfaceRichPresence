using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarfaceRichPresence.Entities
{
	public class Asset
	{
		[JsonProperty("key"), JsonRequired]
		public string AssetKey { get; set; }

		[JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
		public string AssetText { get; set; }

		public override string ToString()
		{
			return AssetText ?? AssetKey;
		}
	}
}
