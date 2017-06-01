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
    public partial class ApplicationController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ApplicationController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ApplicationController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ApplicationController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve version information and other application properties.
        ///  <p>
        ///  No authentication is required to call this resource.
        /// </summary>
        /// <return>Returns the string response from the API call</return>
        public string GetApplicationProperties()
        {
            Task<string> t = GetApplicationPropertiesAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve version information and other application properties.
        ///  <p>
        ///  No authentication is required to call this resource.
        /// </summary>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetApplicationPropertiesAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/application-properties");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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