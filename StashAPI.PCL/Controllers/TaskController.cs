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
    public partial class TaskController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TaskController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TaskController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TaskController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve a existing task.
        /// </summary>
        /// <param name="taskId">Required parameter: the id identifying the task to delete</param>
        /// <return>Returns the string response from the API call</return>
        public string GetTask(long taskId)
        {
            Task<string> t = GetTaskAsync(taskId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a existing task.
        /// </summary>
        /// <param name="taskId">Required parameter: the id identifying the task to delete</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetTaskAsync(long taskId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/tasks/{taskId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "taskId", taskId }
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
        /// Create a new task.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreateTask(object mdynamic)
        {
            Task<string> t = CreateTaskAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new task.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateTaskAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/tasks");


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

        /// <summary>
        /// Delete a task.
        ///  <p>
        ///  Note that only the task's creator, the context's author or an admin of the context's repository can delete a
        ///  task. (For a pull request task, those are the task's creator, the pull request's author or an admin on the
        ///  repository containing the pull request). Additionally a task cannot be deleted if it has already been resolved.
        /// </summary>
        /// <param name="taskId">Required parameter: the id identifying the task to delete</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteTask(long taskId)
        {
            Task<string> t = DeleteTaskAsync(taskId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete a task.
        ///  <p>
        ///  Note that only the task's creator, the context's author or an admin of the context's repository can delete a
        ///  task. (For a pull request task, those are the task's creator, the pull request's author or an admin on the
        ///  repository containing the pull request). Additionally a task cannot be deleted if it has already been resolved.
        /// </summary>
        /// <param name="taskId">Required parameter: the id identifying the task to delete</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteTaskAsync(long taskId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/tasks/{taskId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "taskId", taskId }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
        /// Update a existing task.
        ///  <p>
        ///  As of Stash 3.3, only the state and text of a task can be updated.
        ///  <p>
        ///  Updating the state of a task is allowed for any user having <em>READ</em> access to the repository.
        ///  However only the task's creator, the context's author or an admin of the context's repository can update the
        ///  task's text. (For a pull request task, those are the task's creator, the pull request's author or an admin on the
        ///  repository containing the pull request). Additionally the task's text cannot be updated if it has been resolved.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="taskId">Required parameter: the id identifying the task to delete</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateTask(object mdynamic, long taskId)
        {
            Task<string> t = UpdateTaskAsync(mdynamic, taskId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a existing task.
        ///  <p>
        ///  As of Stash 3.3, only the state and text of a task can be updated.
        ///  <p>
        ///  Updating the state of a task is allowed for any user having <em>READ</em> access to the repository.
        ///  However only the task's creator, the context's author or an admin of the context's repository can update the
        ///  task's text. (For a pull request task, those are the task's creator, the pull request's author or an admin on the
        ///  repository containing the pull request). Additionally the task's text cannot be updated if it has been resolved.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="taskId">Required parameter: the id identifying the task to delete</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateTaskAsync(object mdynamic, long taskId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/tasks/{taskId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "taskId", taskId }
            });


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
            HttpRequest _request = ClientInstance.PutBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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