﻿using Newtonsoft.Json;

namespace PostcodeAPI.V2.Wrappers.Postcode
{
    public class ApiHalResultWrapper
    {
        [JsonProperty("_embedded")]
        public HalEmbeddedResult Embedded { get; set; }

        [JsonProperty("_links")]
        public HalNavigator Links { get; set; }
    }
}