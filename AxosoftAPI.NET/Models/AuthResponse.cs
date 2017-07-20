using Newtonsoft.Json;

namespace AxosoftAPI.NET.Models
{
	public class AuthResponse
	{
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		[JsonProperty("token_type")]
		public string TokenType { get; set; }
	}
}
