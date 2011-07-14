//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Customsearch.V1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Context {
        
        private IList<IList<Context.FacetsData>> facets;
        
        private string title;
        
        [Newtonsoft.Json.JsonPropertyAttribute("facets")]
        public virtual IList<IList<Context.FacetsData>> Facets {
            get {
                return this.facets;
            }
            set {
                this.facets = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title {
            get {
                return this.title;
            }
            set {
                this.title = value;
            }
        }
        
        public class FacetsData {
            
            private string anchor;
            
            private string label;
            
            [Newtonsoft.Json.JsonPropertyAttribute("anchor")]
            public virtual string Anchor {
                get {
                    return this.anchor;
                }
                set {
                    this.anchor = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("label")]
            public virtual string Label {
                get {
                    return this.label;
                }
                set {
                    this.label = value;
                }
            }
        }
    }
    
    public class Promotion {
        
        private IList<Promotion.BodyLinesData> bodyLines;
        
        private string displayLink;
        
        private Promotion.ImageData image;
        
        private string link;
        
        private string title;
        
        [Newtonsoft.Json.JsonPropertyAttribute("bodyLines")]
        public virtual IList<Promotion.BodyLinesData> BodyLines {
            get {
                return this.bodyLines;
            }
            set {
                this.bodyLines = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("displayLink")]
        public virtual string DisplayLink {
            get {
                return this.displayLink;
            }
            set {
                this.displayLink = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual Promotion.ImageData Image {
            get {
                return this.image;
            }
            set {
                this.image = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link {
            get {
                return this.link;
            }
            set {
                this.link = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title {
            get {
                return this.title;
            }
            set {
                this.title = value;
            }
        }
        
        public class BodyLinesData {
            
            private string link;
            
            private string title;
            
            private string url;
            
            [Newtonsoft.Json.JsonPropertyAttribute("link")]
            public virtual string Link {
                get {
                    return this.link;
                }
                set {
                    this.link = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("title")]
            public virtual string Title {
                get {
                    return this.title;
                }
                set {
                    this.title = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url {
                get {
                    return this.url;
                }
                set {
                    this.url = value;
                }
            }
        }
        
        public class ImageData {
            
            private long height;
            
            private string source;
            
            private long width;
            
            [Newtonsoft.Json.JsonPropertyAttribute("height")]
            public virtual long Height {
                get {
                    return this.height;
                }
                set {
                    this.height = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("source")]
            public virtual string Source {
                get {
                    return this.source;
                }
                set {
                    this.source = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual long Width {
                get {
                    return this.width;
                }
                set {
                    this.width = value;
                }
            }
        }
    }
    
    public class Query {
        
        private long count;
        
        private string cref;
        
        private string cx;
        
        private string inputEncoding;
        
        private string language;
        
        private string outputEncoding;
        
        private string safe;
        
        private string searchTerms;
        
        private string sort;
        
        private long startIndex;
        
        private long startPage;
        
        private string title;
        
        private long totalResults;
        
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual long Count {
            get {
                return this.count;
            }
            set {
                this.count = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("cref")]
        public virtual string Cref {
            get {
                return this.cref;
            }
            set {
                this.cref = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("cx")]
        public virtual string Cx {
            get {
                return this.cx;
            }
            set {
                this.cx = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("inputEncoding")]
        public virtual string InputEncoding {
            get {
                return this.inputEncoding;
            }
            set {
                this.inputEncoding = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language {
            get {
                return this.language;
            }
            set {
                this.language = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("outputEncoding")]
        public virtual string OutputEncoding {
            get {
                return this.outputEncoding;
            }
            set {
                this.outputEncoding = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("safe")]
        public virtual string Safe {
            get {
                return this.safe;
            }
            set {
                this.safe = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("searchTerms")]
        public virtual string SearchTerms {
            get {
                return this.searchTerms;
            }
            set {
                this.searchTerms = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("sort")]
        public virtual string Sort {
            get {
                return this.sort;
            }
            set {
                this.sort = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual long StartIndex {
            get {
                return this.startIndex;
            }
            set {
                this.startIndex = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("startPage")]
        public virtual long StartPage {
            get {
                return this.startPage;
            }
            set {
                this.startPage = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title {
            get {
                return this.title;
            }
            set {
                this.title = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual long TotalResults {
            get {
                return this.totalResults;
            }
            set {
                this.totalResults = value;
            }
        }
    }
    
    public class Result {
        
        private string cacheId;
        
        private string displayLink;
        
        private string htmlSnippet;
        
        private string htmlTitle;
        
        private string kind;
        
        private string link;
        
        private Result.PagemapData pagemap;
        
        private string snippet;
        
        private string title;
        
        [Newtonsoft.Json.JsonPropertyAttribute("cacheId")]
        public virtual string CacheId {
            get {
                return this.cacheId;
            }
            set {
                this.cacheId = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("displayLink")]
        public virtual string DisplayLink {
            get {
                return this.displayLink;
            }
            set {
                this.displayLink = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("htmlSnippet")]
        public virtual string HtmlSnippet {
            get {
                return this.htmlSnippet;
            }
            set {
                this.htmlSnippet = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("htmlTitle")]
        public virtual string HtmlTitle {
            get {
                return this.htmlTitle;
            }
            set {
                this.htmlTitle = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("link")]
        public virtual string Link {
            get {
                return this.link;
            }
            set {
                this.link = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("pagemap")]
        public virtual Result.PagemapData Pagemap {
            get {
                return this.pagemap;
            }
            set {
                this.pagemap = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("snippet")]
        public virtual string Snippet {
            get {
                return this.snippet;
            }
            set {
                this.snippet = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title {
            get {
                return this.title;
            }
            set {
                this.title = value;
            }
        }
        
        public class PagemapData : System.Collections.Generic.Dictionary<string, IList<PagemapData.PagemapDataSchema>> {
            
            public class PagemapDataSchema : System.Collections.Generic.Dictionary<string, string> {
            }
        }
    }
    
    public class Search : Google.Apis.Requests.IResponse {
        
        private Context context;
        
        private IList<Result> items;
        
        private string kind;
        
        private IList<Promotion> promotions;
        
        private Search.QueriesData queries;
        
        private Search.UrlData url;
        
        private Google.Apis.Requests.RequestError error;
        
        [Newtonsoft.Json.JsonPropertyAttribute("context")]
        public virtual Context Context {
            get {
                return this.context;
            }
            set {
                this.context = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Result> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("promotions")]
        public virtual IList<Promotion> Promotions {
            get {
                return this.promotions;
            }
            set {
                this.promotions = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("queries")]
        public virtual Search.QueriesData Queries {
            get {
                return this.queries;
            }
            set {
                this.queries = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual Search.UrlData Url {
            get {
                return this.url;
            }
            set {
                this.url = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public class QueriesData : System.Collections.Generic.Dictionary<string, IList<Query>> {
        }
        
        public class UrlData {
            
            private string template;
            
            private string type;
            
            [Newtonsoft.Json.JsonPropertyAttribute("template")]
            public virtual string Template {
                get {
                    return this.template;
                }
                set {
                    this.template = value;
                }
            }
            
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type {
                get {
                    return this.type;
                }
                set {
                    this.type = value;
                }
            }
        }
    }
}
namespace Google.Apis.Customsearch.V1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class CustomsearchService : Google.Apis.Discovery.IRequestExecutor, Google.Apis.Discovery.ISchemaAwareRequestExecutor {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1";
        
        private const string Name = "customsearch";
        
        private const string BaseUri = "https://www.googleapis.com/customsearch/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private CseResource cse;
        
        public CustomsearchService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.cse = new CseResource(this);
        }
        
        public CustomsearchService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.CachedWebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", CustomsearchService.Name, CustomsearchService.Version)))).GetService(CustomsearchService.Version, CustomsearchService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(CustomsearchService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        /// <summary>Sets the DeveloperKey which this service uses for all requests</summary>
        public virtual string DeveloperKey {
            get {
                return this.developerKey;
            }
            set {
                this.developerKey = value;
            }
        }
        
        public virtual CseResource Cse {
            get {
                return this.cse;
            }
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, string body, System.Collections.Generic.IDictionary<string, object> parameters) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (string.IsNullOrEmpty(DeveloperKey) == false) {
                request = request.WithDeveloperKey(this.DeveloperKey);
            }
            return request.WithParameters(parameters).WithAuthentication(authenticator).WithBody(body).ExecuteRequest();
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, object body, System.Collections.Generic.IDictionary<string, object> parameters) {
            return this.ExecuteRequest(resource, method, this.ObjectToJson(body), parameters);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string ObjectToJson(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T JsonToObject<T>(System.IO.Stream stream)
         {
            return genericService.DeserializeResponse<T>(stream);
        }
    }
    
    public class CseResource {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "cse";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(CseResource));
        
        public CseResource(CustomsearchService service) {
            this.service = service;
        }
        
        /// <summary>Returns metadata about the search performed, metadata about the custom search engine used for the search, and the search results.</summary>
        /// <param name="q">Required - Query</param>
        public virtual ListRequest List(string q) {
            return new ListRequest(service, q);
        }
        
        /// <summary>Returns metadata about the search performed, metadata about the custom search engine used for the search, and the search results.</summary>
        /// <param name="q">Required - Query</param>
        /// <param name="cref">Optional - The URL of a linked custom search engine</param>
        /// <param name="cx">Optional - The custom search engine ID to scope this search query</param>
        /// <param name="lr">Optional - Must be one of the following values [lang_ar, lang_bg, lang_ca, lang_cs, lang_da, lang_de, lang_el, lang_en, lang_es, lang_et, lang_fi, lang_fr, lang_hr, lang_hu, lang_id, lang_is, lang_it, lang_iw, lang_ja, lang_ko, lang_lt, lang_lv, lang_nl, lang_no, lang_pl, lang_pt, lang_ro, lang_ru, lang_sk, lang_sl, lang_sr, lang_sv, lang_tr, lang_zh-CN, lang_zh-TW] - The language restriction for the search results</param>
        /// <param name="num">Optional - Number of search results to return</param>
        /// <param name="safe">Optional - Must be one of the following values [high, medium, off] - Search safety level</param>
        /// <param name="sort">Optional - The sort expression to apply to the results</param>
        /// <param name="start">Optional - The index of the first result to return</param>
        public virtual ListRequest List(string q, [System.Runtime.InteropServices.OptionalAttribute()] string cref, [System.Runtime.InteropServices.OptionalAttribute()] string cx, [System.Runtime.InteropServices.OptionalAttribute()] Lr? lr, [System.Runtime.InteropServices.OptionalAttribute()] string num, [System.Runtime.InteropServices.OptionalAttribute()] Safe? safe, [System.Runtime.InteropServices.OptionalAttribute()] string sort, [System.Runtime.InteropServices.OptionalAttribute()] string start) {
            return new ListRequest(service, q, cref, cx, lr, num, safe, sort, start);
        }
        
        /// <summary>The language restriction for the search results</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Lr {
            
            /// <summary>Arabic</summary>
            [Google.Apis.Util.StringValueAttribute("lang_ar")]
            Lang_ar,
            
            /// <summary>Bulgarian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_bg")]
            Lang_bg,
            
            /// <summary>Catalan</summary>
            [Google.Apis.Util.StringValueAttribute("lang_ca")]
            Lang_ca,
            
            /// <summary>Czech</summary>
            [Google.Apis.Util.StringValueAttribute("lang_cs")]
            Lang_cs,
            
            /// <summary>Danish</summary>
            [Google.Apis.Util.StringValueAttribute("lang_da")]
            Lang_da,
            
            /// <summary>German</summary>
            [Google.Apis.Util.StringValueAttribute("lang_de")]
            Lang_de,
            
            /// <summary>Greek</summary>
            [Google.Apis.Util.StringValueAttribute("lang_el")]
            Lang_el,
            
            /// <summary>English</summary>
            [Google.Apis.Util.StringValueAttribute("lang_en")]
            Lang_en,
            
            /// <summary>Spanish</summary>
            [Google.Apis.Util.StringValueAttribute("lang_es")]
            Lang_es,
            
            /// <summary>Estonian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_et")]
            Lang_et,
            
            /// <summary>Finnish</summary>
            [Google.Apis.Util.StringValueAttribute("lang_fi")]
            Lang_fi,
            
            /// <summary>French</summary>
            [Google.Apis.Util.StringValueAttribute("lang_fr")]
            Lang_fr,
            
            /// <summary>Croatian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_hr")]
            Lang_hr,
            
            /// <summary>Hungarian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_hu")]
            Lang_hu,
            
            /// <summary>Indonesian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_id")]
            Lang_id,
            
            /// <summary>Icelandic</summary>
            [Google.Apis.Util.StringValueAttribute("lang_is")]
            Lang_is,
            
            /// <summary>Italian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_it")]
            Lang_it,
            
            /// <summary>Hebrew</summary>
            [Google.Apis.Util.StringValueAttribute("lang_iw")]
            Lang_iw,
            
            /// <summary>Japanese</summary>
            [Google.Apis.Util.StringValueAttribute("lang_ja")]
            Lang_ja,
            
            /// <summary>Korean</summary>
            [Google.Apis.Util.StringValueAttribute("lang_ko")]
            Lang_ko,
            
            /// <summary>Lithuanian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_lt")]
            Lang_lt,
            
            /// <summary>Latvian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_lv")]
            Lang_lv,
            
            /// <summary>Dutch</summary>
            [Google.Apis.Util.StringValueAttribute("lang_nl")]
            Lang_nl,
            
            /// <summary>Norwegian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_no")]
            Lang_no,
            
            /// <summary>Polish</summary>
            [Google.Apis.Util.StringValueAttribute("lang_pl")]
            Lang_pl,
            
            /// <summary>Portuguese</summary>
            [Google.Apis.Util.StringValueAttribute("lang_pt")]
            Lang_pt,
            
            /// <summary>Romanian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_ro")]
            Lang_ro,
            
            /// <summary>Russian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_ru")]
            Lang_ru,
            
            /// <summary>Slovak</summary>
            [Google.Apis.Util.StringValueAttribute("lang_sk")]
            Lang_sk,
            
            /// <summary>Slovenian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_sl")]
            Lang_sl,
            
            /// <summary>Serbian</summary>
            [Google.Apis.Util.StringValueAttribute("lang_sr")]
            Lang_sr,
            
            /// <summary>Swedish</summary>
            [Google.Apis.Util.StringValueAttribute("lang_sv")]
            Lang_sv,
            
            /// <summary>Turkish</summary>
            [Google.Apis.Util.StringValueAttribute("lang_tr")]
            Lang_tr,
            
            /// <summary>Chinese (Simplified)</summary>
            [Google.Apis.Util.StringValueAttribute("lang_zh-CN")]
            Lang_zhCN,
            
            /// <summary>Chinese (Traditional)</summary>
            [Google.Apis.Util.StringValueAttribute("lang_zh-TW")]
            Lang_zhTW,
        }
        
        /// <summary>Search safety level</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Safe {
            
            /// <summary>Enables highest level of safe search filtering.</summary>
            [Google.Apis.Util.StringValueAttribute("high")]
            High,
            
            /// <summary>Enables moderate safe search filtering.</summary>
            [Google.Apis.Util.StringValueAttribute("medium")]
            Medium,
            
            /// <summary>Disables safe search filtering.</summary>
            [Google.Apis.Util.StringValueAttribute("off")]
            Off,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Customsearch.V1.Data.Search> {
            
            private string cref;
            
            private string cx;
            
            private Lr? lr;
            
            private string num;
            
            private string q;
            
            private Safe? safe;
            
            private string sort;
            
            private string start;
            
            public ListRequest(Google.Apis.Discovery.ISchemaAwareRequestExecutor service, string q) : 
                    base(service) {
                this.q = q;
            }
            
            public ListRequest(Google.Apis.Discovery.ISchemaAwareRequestExecutor service, string q, [System.Runtime.InteropServices.OptionalAttribute()] string cref, [System.Runtime.InteropServices.OptionalAttribute()] string cx, [System.Runtime.InteropServices.OptionalAttribute()] Lr? lr, [System.Runtime.InteropServices.OptionalAttribute()] string num, [System.Runtime.InteropServices.OptionalAttribute()] Safe? safe, [System.Runtime.InteropServices.OptionalAttribute()] string sort, [System.Runtime.InteropServices.OptionalAttribute()] string start) : 
                    base(service) {
                this.q = q;
                this.cref = cref;
                this.cx = cx;
                this.lr = lr;
                this.num = num;
                this.safe = safe;
                this.sort = sort;
                this.start = start;
            }
            
            /// <summary>The URL of a linked custom search engine</summary>
            [Google.Apis.Util.RequestParameterAttribute("cref")]
            public virtual string Cref {
                get {
                    return this.cref;
                }
                set {
                    this.cref = value;
                }
            }
            
            /// <summary>The custom search engine ID to scope this search query</summary>
            [Google.Apis.Util.RequestParameterAttribute("cx")]
            public virtual string Cx {
                get {
                    return this.cx;
                }
                set {
                    this.cx = value;
                }
            }
            
            /// <summary>The language restriction for the search results</summary>
            [Google.Apis.Util.RequestParameterAttribute("lr")]
            public virtual Lr? Lr {
                get {
                    return this.lr;
                }
                set {
                    this.lr = value;
                }
            }
            
            /// <summary>Number of search results to return</summary>
            [Google.Apis.Util.RequestParameterAttribute("num")]
            public virtual string Num {
                get {
                    return this.num;
                }
                set {
                    this.num = value;
                }
            }
            
            /// <summary>Query</summary>
            [Google.Apis.Util.RequestParameterAttribute("q")]
            public virtual string Q {
                get {
                    return this.q;
                }
            }
            
            /// <summary>Search safety level</summary>
            [Google.Apis.Util.RequestParameterAttribute("safe")]
            public virtual Safe? Safe {
                get {
                    return this.safe;
                }
                set {
                    this.safe = value;
                }
            }
            
            /// <summary>The sort expression to apply to the results</summary>
            [Google.Apis.Util.RequestParameterAttribute("sort")]
            public virtual string Sort {
                get {
                    return this.sort;
                }
                set {
                    this.sort = value;
                }
            }
            
            /// <summary>The index of the first result to return</summary>
            [Google.Apis.Util.RequestParameterAttribute("start")]
            public virtual string Start {
                get {
                    return this.start;
                }
                set {
                    this.start = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "cse";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
}
