/*
 * StashAPI.PCL
 *
 * This file was automatically generated for DS by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using StashAPI.PCL;
using StashAPI.PCL.Utilities;
using StashAPI.PCL.Http.Request;
using StashAPI.PCL.Http.Response;
using StashAPI.PCL.Http.Client;
using StashAPI.PCL.Exceptions;

namespace StashAPI.PCL.Controllers
{
    public partial class MarkupController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static MarkupController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static MarkupController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new MarkupController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Preview the generated html for given markdown contents.
        ///  <p>
        ///  Only authenticated users may call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="urlMode">Optional parameter: Example: </param>
        /// <param name="hardwrap">Optional parameter: Example: </param>
        /// <param name="htmlEscape">Optional parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreatePreviewMarkup(
                object mdynamic,
                string urlMode = null,
                bool? hardwrap = null,
                bool? htmlEscape = null)
        {
            Task<string> t = CreatePreviewMarkupAsync(mdynamic, urlMode, hardwrap, htmlEscape);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Preview the generated html for given markdown contents.
        ///  <p>
        ///  Only authenticated users may call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="urlMode">Optional parameter: Example: </param>
        /// <param name="hardwrap">Optional parameter: Example: </param>
        /// <param name="htmlEscape">Optional parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreatePreviewMarkupAsync(
                object mdynamic,
                string urlMode = null,
                bool? hardwrap = null,
                bool? htmlEscape = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/markup/preview");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "urlMode", urlMode },
                { "hardwrap", hardwrap },
                { "htmlEscape", htmlEscape }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(mdynamic);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 