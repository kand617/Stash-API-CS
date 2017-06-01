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
    public partial class LogController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static LogController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static LogController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new LogController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve the current log level for a given logger.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="loggerName">Required parameter: the name of the logger.</param>
        /// <return>Returns the string response from the API call</return>
        public string GetLevel(string loggerName)
        {
            Task<string> t = GetLevelAsync(loggerName);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the current log level for a given logger.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="loggerName">Required parameter: the name of the logger.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetLevelAsync(string loggerName)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/logs/logger/{loggerName}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "loggerName", loggerName }
            });


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

        /// <summary>
        /// Set the current log level for the root logger.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="levelName">Required parameter: the level to set the logger to. Either TRACE, DEBUG, INFO, WARN or ERROR</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic UpdateSetRootLevel(string levelName)
        {
            Task<dynamic> t = UpdateSetRootLevelAsync(levelName);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Set the current log level for the root logger.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="levelName">Required parameter: the level to set the logger to. Either TRACE, DEBUG, INFO, WARN or ERROR</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> UpdateSetRootLevelAsync(string levelName)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/logs/rootLogger/{levelName}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "levelName", levelName }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Put(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve the current log level for the root logger.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <return>Returns the string response from the API call</return>
        public string GetRootLevel()
        {
            Task<string> t = GetRootLevelAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the current log level for the root logger.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRootLevelAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/logs/rootLogger");


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

        /// <summary>
        /// Set the current log level for a given logger.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="levelName">Required parameter: the level to set the logger to. Either TRACE, DEBUG, INFO, WARN or ERROR</param>
        /// <param name="loggerName">Required parameter: the name of the logger.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic UpdateSetLevel(string levelName, string loggerName)
        {
            Task<dynamic> t = UpdateSetLevelAsync(levelName, loggerName);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Set the current log level for a given logger.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="levelName">Required parameter: the level to set the logger to. Either TRACE, DEBUG, INFO, WARN or ERROR</param>
        /// <param name="loggerName">Required parameter: the name of the logger.</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> UpdateSetLevelAsync(string levelName, string loggerName)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/logs/logger/{loggerName}/{levelName}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "levelName", levelName },
                { "loggerName", loggerName }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Put(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 