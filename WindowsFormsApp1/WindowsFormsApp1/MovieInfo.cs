﻿//
// using System;
// using System.Collections.Generic;
//
// namespace WindowsFormsApp1
// {
//
//
//
//     using System;
//     using System.Collections.Generic;
//
//     using System.Globalization;
//     using Newtonsoft.Json;
//     using Newtonsoft.Json.Converters;
//
//     public partial class Welcome
//     {
//         [JsonProperty("status")]
//         public string Status { get; set; }
//
//         [JsonProperty("status_message")]
//         public string StatusMessage { get; set; }
//
//         [JsonProperty("data")]
//         public Data Data { get; set; }
//
//         [JsonProperty("@meta")]
//         public Meta Meta { get; set; }
//     }
//
//     public partial class Data
//     {
//         [JsonProperty("movie")]
//         public Movie Movie { get; set; }
//     }
//
//     public partial class Movie
//     {
//         [JsonProperty("id")]
//         public long Id { get; set; }
//
//         [JsonProperty("url")]
//         public Uri Url { get; set; }
//
//         [JsonProperty("imdb_code")]
//         public string ImdbCode { get; set; }
//
//         [JsonProperty("title")]
//         public string Title { get; set; }
//
//         [JsonProperty("title_english")]
//         public string TitleEnglish { get; set; }
//
//         [JsonProperty("title_long")]
//         public string TitleLong { get; set; }
//
//         [JsonProperty("slug")]
//         public string Slug { get; set; }
//
//         [JsonProperty("year")]
//         public long Year { get; set; }
//
//         [JsonProperty("rating")]
//         public double Rating { get; set; }
//
//         [JsonProperty("runtime")]
//         public long Runtime { get; set; }
//
//         [JsonProperty("genres")]
//         public string[] Genres { get; set; }
//
//         [JsonProperty("download_count")]
//         public long DownloadCount { get; set; }
//
//         [JsonProperty("like_count")]
//         public long LikeCount { get; set; }
//
//         [JsonProperty("description_intro")]
//         public string DescriptionIntro { get; set; }
//
//         [JsonProperty("description_full")]
//         public string DescriptionFull { get; set; }
//
//         [JsonProperty("yt_trailer_code")]
//         public string YtTrailerCode { get; set; }
//
//         [JsonProperty("language")]
//         public string Language { get; set; }
//
//         [JsonProperty("mpa_rating")]
//         public string MpaRating { get; set; }
//
//         [JsonProperty("background_image")]
//         public Uri BackgroundImage { get; set; }
//
//         [JsonProperty("background_image_original")]
//         public Uri BackgroundImageOriginal { get; set; }
//
//         [JsonProperty("small_cover_image")]
//         public Uri SmallCoverImage { get; set; }
//
//         [JsonProperty("medium_cover_image")]
//         public Uri MediumCoverImage { get; set; }
//
//         [JsonProperty("large_cover_image")]
//         public Uri LargeCoverImage { get; set; }
//
//         [JsonProperty("torrents")]
//         public Torrent[] Torrents { get; set; }
//
//         [JsonProperty("date_uploaded")]
//         public DateTimeOffset DateUploaded { get; set; }
//
//         [JsonProperty("date_uploaded_unix")]
//         public long DateUploadedUnix { get; set; }
//     }
//
//     public partial class Torrent
//     {
//         [JsonProperty("url")]
//         public Uri Url { get; set; }
//
//         [JsonProperty("hash")]
//         public string Hash { get; set; }
//
//         [JsonProperty("quality")]
//         public string Quality { get; set; }
//
//         [JsonProperty("type")]
//         public string Type { get; set; }
//
//         [JsonProperty("seeds")]
//         public long Seeds { get; set; }
//
//         [JsonProperty("peers")]
//         public long Peers { get; set; }
//
//         [JsonProperty("size")]
//         public string Size { get; set; }
//
//         [JsonProperty("size_bytes")]
//         public long SizeBytes { get; set; }
//
//         [JsonProperty("date_uploaded")]
//         public DateTimeOffset DateUploaded { get; set; }
//
//         [JsonProperty("date_uploaded_unix")]
//         public long DateUploadedUnix { get; set; }
//     }
//
//     public partial class Meta
//     {
//         [JsonProperty("server_time")]
//         public long ServerTime { get; set; }
//
//         [JsonProperty("server_timezone")]
//         public string ServerTimezone { get; set; }
//
//         [JsonProperty("api_version")]
//         public long ApiVersion { get; set; }
//
//         [JsonProperty("execution_time")]
//         public string ExecutionTime { get; set; }
//     }
//     public partial class Welcome
//     {
//         public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, WindowsFormsApp1.Converter.Settings);
//     }
//
//     public static class Serialize
//     {
//         public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, WindowsFormsApp1.Converter.Settings);
//     }
//
//     internal static class Converter
//     {
//         public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
//         {
//             MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
//             DateParseHandling = DateParseHandling.None,
//             Converters =
//             {
//                 new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
//             },
//         };
//     }
// }
//
//
