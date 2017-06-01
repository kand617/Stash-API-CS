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
    public partial class AdminController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static AdminController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static AdminController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new AdminController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Update a user's password.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource, and may not update
        ///  the password of a user with greater permissions than themselves.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateUserPassword(object mdynamic)
        {
            Task<string> t = UpdateUserPasswordAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a user's password.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource, and may not update
        ///  the password of a user with greater permissions than themselves.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateUserPasswordAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users/credentials");


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

        /// <summary>
        /// Add a user to one or more groups.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string AddUserToGroups(object mdynamic)
        {
            Task<string> t = AddUserToGroupsAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add a user to one or more groups.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AddUserToGroupsAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users/add-groups");


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
        /// Add multiple users to a group.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string AddUsersToGroup(object mdynamic)
        {
            Task<string> t = AddUsersToGroupAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add multiple users to a group.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AddUsersToGroupAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/groups/add-users");


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
        /// Retrieve a page of groups.
        ///  <p>
        ///  The authenticated user must have <strong>LICENSED_USER</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetGroups(string filter = null)
        {
            Task<string> t = GetGroupsAsync(filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of groups.
        ///  <p>
        ///  The authenticated user must have <strong>LICENSED_USER</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetGroupsAsync(string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/groups");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Create a new group.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="name">Optional parameter: Name of the group.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateGroup(string name = null)
        {
            Task<string> t = CreateGroupAsync(name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new group.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="name">Optional parameter: Name of the group.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateGroupAsync(string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/groups");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
        /// Rename a user.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreateRenameUser(object mdynamic)
        {
            Task<string> t = CreateRenameUserAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Rename a user.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateRenameUserAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users/rename");


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
        /// Update a user's details.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateUserDetails(object mdynamic)
        {
            Task<string> t = UpdateUserDetailsAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update a user's details.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateUserDetailsAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users");


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

        /// <summary>
        /// Retrieve a page of users.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only users with usernames, display name or email addresses containing the supplied                string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetUsers(string filter = null)
        {
            Task<string> t = GetUsersAsync(filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of users.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only users with usernames, display name or email addresses containing the supplied                string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetUsersAsync(string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Updates the server email address
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetSenderAddress(object mdynamic)
        {
            Task<string> t = UpdateSetSenderAddressAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the server email address
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetSenderAddressAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/mail-server/sender-address");


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

        /// <summary>
        /// Retrieves the server email address
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetSenderAddress()
        {
            Task<dynamic> t = GetSenderAddressAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves the server email address
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetSenderAddressAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/mail-server/sender-address");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
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
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Clears the server email address.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic DeleteClearSenderAddress()
        {
            Task<dynamic> t = DeleteClearSenderAddressAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Clears the server email address.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> DeleteClearSenderAddressAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/mail-server/sender-address");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
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
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Updates the mail configuration
        ///  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetMailConfig(object mdynamic)
        {
            Task<string> t = UpdateSetMailConfigAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Updates the mail configuration
        ///  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetMailConfigAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/mail-server");


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

        /// <summary>
        /// Retrieves the current mail configuration.
        ///  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetMailConfig()
        {
            Task<dynamic> t = GetMailConfigAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves the current mail configuration.
        ///  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetMailConfigAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/mail-server");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
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
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Deletes the current mail configuration.
        ///  <p>
        ///  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic DeleteMailConfig()
        {
            Task<dynamic> t = DeleteMailConfigAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes the current mail configuration.
        ///  <p>
        ///  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> DeleteMailConfigAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/mail-server");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
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
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Gets information about the nodes that currently make up the stash cluster.
        ///  <p>
        ///  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetClusterInformation()
        {
            Task<dynamic> t = GetClusterInformationAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets information about the nodes that currently make up the stash cluster.
        ///  <p>
        ///  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetClusterInformationAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/cluster");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
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
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Decodes the provided encoded license and sets it as the active license. If no license was provided, a 400 is
        ///  returned. If the license cannot be decoded, or cannot be applied, a 409 is returned. Some possible reasons a
        ///  license may not be applied include:
        ///  <ul>
        ///      <li>It is for a different product</li>
        ///      <li>It is already expired</li>
        ///  </ul>
        ///  Otherwise, if the license is updated successfully, details for the new license are returned with a 200 response.
        ///  <p>
        ///  <b>Warning</b>: It is possible to downgrade the license during update, applying a license with a lower number
        ///  of permitted users. If the number of currently-licensed users exceeds the limits of the new license, pushing
        ///  will be disabled until the licensed user count is brought into compliance with the new license.
        ///  <p>
        ///  The authenticated user must have <b>SYS_ADMIN</b> permission. <b>ADMIN</b> users may <i>view</i> the current
        ///  license details, but they may not <i>update</i> the license.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateLicense(object mdynamic)
        {
            Task<string> t = UpdateLicenseAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Decodes the provided encoded license and sets it as the active license. If no license was provided, a 400 is
        ///  returned. If the license cannot be decoded, or cannot be applied, a 409 is returned. Some possible reasons a
        ///  license may not be applied include:
        ///  <ul>
        ///      <li>It is for a different product</li>
        ///      <li>It is already expired</li>
        ///  </ul>
        ///  Otherwise, if the license is updated successfully, details for the new license are returned with a 200 response.
        ///  <p>
        ///  <b>Warning</b>: It is possible to downgrade the license during update, applying a license with a lower number
        ///  of permitted users. If the number of currently-licensed users exceeds the limits of the new license, pushing
        ///  will be disabled until the licensed user count is brought into compliance with the new license.
        ///  <p>
        ///  The authenticated user must have <b>SYS_ADMIN</b> permission. <b>ADMIN</b> users may <i>view</i> the current
        ///  license details, but they may not <i>update</i> the license.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateLicenseAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/license");


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
        /// Retrieve a page of users that have no granted global permissions.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only user names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetUsersWithoutAnyPermission(string filter = null)
        {
            Task<string> t = GetUsersWithoutAnyPermissionAsync(filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of users that have no granted global permissions.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only user names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetUsersWithoutAnyPermissionAsync(string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/permissions/users/none");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Retrieve a page of groups that have been granted at least one global permission.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetGroupsWithAnyPermission(string filter = null)
        {
            Task<string> t = GetGroupsWithAnyPermissionAsync(filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of groups that have been granted at least one global permission.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetGroupsWithAnyPermissionAsync(string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/permissions/groups");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Promote or demote a user's global permission level. Available global permissions are:
        ///  <ul>
        ///      <li>LICENSED_USER</li>
        ///      <li>PROJECT_CREATE</li>
        ///      <li>ADMIN</li>
        ///      <li>SYS_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Global+permissions">Stash documentation</a> for
        ///  a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have:
        ///  <ul>
        ///      <li><strong>ADMIN</strong> permission or higher; and</li>
        ///      <li>the permission they are attempting to grant or higher; and</li>
        ///      <li>greater or equal permissions than the current permission level of the group (a user may not demote the
        ///      permission level of a group with higher permissions than them)</li>
        ///  </ul>
        ///  to call this resource. In addition, a user may not demote a group's permission level if their own permission
        ///  level would be reduced as a result.
        /// </summary>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <param name="name">Optional parameter: the names of the groups</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetPermissionForGroups(string permission = null, string name = null)
        {
            Task<string> t = UpdateSetPermissionForGroupsAsync(permission, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Promote or demote a user's global permission level. Available global permissions are:
        ///  <ul>
        ///      <li>LICENSED_USER</li>
        ///      <li>PROJECT_CREATE</li>
        ///      <li>ADMIN</li>
        ///      <li>SYS_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Global+permissions">Stash documentation</a> for
        ///  a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have:
        ///  <ul>
        ///      <li><strong>ADMIN</strong> permission or higher; and</li>
        ///      <li>the permission they are attempting to grant or higher; and</li>
        ///      <li>greater or equal permissions than the current permission level of the group (a user may not demote the
        ///      permission level of a group with higher permissions than them)</li>
        ///  </ul>
        ///  to call this resource. In addition, a user may not demote a group's permission level if their own permission
        ///  level would be reduced as a result.
        /// </summary>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <param name="name">Optional parameter: the names of the groups</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetPermissionForGroupsAsync(string permission = null, string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/permissions/groups");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "permission", permission },
                { "name", name }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
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
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Revoke all global permissions for a group.
        ///  <p>
        ///  The authenticated user must have:
        ///  <ul>
        ///      <li><strong>ADMIN</strong> permission or higher; and</li>
        ///      <li>greater or equal permissions than the current permission level of the group (a user may not demote the
        ///      permission level of a group with higher permissions than them)</li>
        ///  </ul>
        ///  to call this resource. In addition, a user may not revoke a group's permissions if their own permission level
        ///  would be reduced as a result.
        /// </summary>
        /// <param name="name">Optional parameter: the name of the group</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteRevokePermissionsForGroup(string name = null)
        {
            Task<string> t = DeleteRevokePermissionsForGroupAsync(name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Revoke all global permissions for a group.
        ///  <p>
        ///  The authenticated user must have:
        ///  <ul>
        ///      <li><strong>ADMIN</strong> permission or higher; and</li>
        ///      <li>greater or equal permissions than the current permission level of the group (a user may not demote the
        ///      permission level of a group with higher permissions than them)</li>
        ///  </ul>
        ///  to call this resource. In addition, a user may not revoke a group's permissions if their own permission level
        ///  would be reduced as a result.
        /// </summary>
        /// <param name="name">Optional parameter: the name of the group</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteRevokePermissionsForGroupAsync(string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/permissions/groups");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Retrieve a page of groups that have no granted global permissions.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetGroupsWithoutAnyPermission(string filter = null)
        {
            Task<string> t = GetGroupsWithoutAnyPermissionAsync(filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of groups that have no granted global permissions.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetGroupsWithoutAnyPermissionAsync(string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/permissions/groups/none");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Retrieve a page of users that have been granted at least one global permission.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only user names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetUsersWithAnyPermission(string filter = null)
        {
            Task<string> t = GetUsersWithAnyPermissionAsync(filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of users that have been granted at least one global permission.
        ///  <p>
        ///  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.
        /// </summary>
        /// <param name="filter">Optional parameter: if specified only user names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetUsersWithAnyPermissionAsync(string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/permissions/users");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Promote or demote the global permission level of a user. Available global permissions are:
        ///  <ul>
        ///      <li>LICENSED_USER</li>
        ///      <li>PROJECT_CREATE</li>
        ///      <li>ADMIN</li>
        ///      <li>SYS_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Global+permissions">Stash documentation</a> for
        ///  a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have:
        ///  <ul>
        ///      <li><strong>ADMIN</strong> permission or higher; and</li>
        ///      <li>the permission they are attempting to grant; and</li>
        ///      <li>greater or equal permissions than the current permission level of the user (a user may not demote the
        ///      permission level of a user with higher permissions than them)</li>
        ///  </ul>
        ///  to call this resource. In addition, a user may not demote their own permission level.
        /// </summary>
        /// <param name="name">Optional parameter: the names of the users</param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetPermissionForUsers(string name = null, string permission = null)
        {
            Task<string> t = UpdateSetPermissionForUsersAsync(name, permission);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Promote or demote the global permission level of a user. Available global permissions are:
        ///  <ul>
        ///      <li>LICENSED_USER</li>
        ///      <li>PROJECT_CREATE</li>
        ///      <li>ADMIN</li>
        ///      <li>SYS_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Global+permissions">Stash documentation</a> for
        ///  a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have:
        ///  <ul>
        ///      <li><strong>ADMIN</strong> permission or higher; and</li>
        ///      <li>the permission they are attempting to grant; and</li>
        ///      <li>greater or equal permissions than the current permission level of the user (a user may not demote the
        ///      permission level of a user with higher permissions than them)</li>
        ///  </ul>
        ///  to call this resource. In addition, a user may not demote their own permission level.
        /// </summary>
        /// <param name="name">Optional parameter: the names of the users</param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetPermissionForUsersAsync(string name = null, string permission = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/permissions/users");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name },
                { "permission", permission }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
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
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Revoke all global permissions for a user.
        ///  <p>
        ///  The authenticated user must have:
        ///  <ul>
        ///      <li><strong>ADMIN</strong> permission or higher; and</li>
        ///      <li>greater or equal permissions than the current permission level of the user (a user may not demote the
        ///      permission level of a user with higher permissions than them)</li>
        ///  </ul>
        ///  to call this resource. In addition, a user may not demote their own permission level.
        /// </summary>
        /// <param name="name">Optional parameter: the name of the user</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteRevokePermissionsForUser(string name = null)
        {
            Task<string> t = DeleteRevokePermissionsForUserAsync(name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Revoke all global permissions for a user.
        ///  <p>
        ///  The authenticated user must have:
        ///  <ul>
        ///      <li><strong>ADMIN</strong> permission or higher; and</li>
        ///      <li>greater or equal permissions than the current permission level of the user (a user may not demote the
        ///      permission level of a user with higher permissions than them)</li>
        ///  </ul>
        ///  to call this resource. In addition, a user may not demote their own permission level.
        /// </summary>
        /// <param name="name">Optional parameter: the name of the user</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteRevokePermissionsForUserAsync(string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/permissions/users");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Creates a new user from the assembled query parameters.
        ///  <p>
        ///  The default group can be used to control initial permissions for new users, such as granting users the ability
        ///  to login or providing read access to certain projects or repositories. If the user is not added to the default
        ///  group, they may not be able to login after their account is created until explicit permissions are configured.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="name">Optional parameter: the username for the new user</param>
        /// <param name="password">Optional parameter: the password for the new user</param>
        /// <param name="displayName">Optional parameter: the display name for the new user</param>
        /// <param name="emailAddress">Optional parameter: the e-mail address for the new user</param>
        /// <param name="addToDefaultGroup">Optional parameter: <code>true</code> to add the user to the default group, which can be used to grant them                           a set of initial permissions; otherwise, <code>false</code> to not add them to a group</param>
        /// <param name="notify">Optional parameter: if present and not <code>false</code> instead of requiring a password,                           the create user will be notified via email their account has been created and requires                           a password to be reset. This option can only be used if a mail server has been configured</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateUser(
                string name = null,
                string password = null,
                string displayName = null,
                string emailAddress = null,
                bool? addToDefaultGroup = true,
                string notify = null)
        {
            Task<string> t = CreateUserAsync(name, password, displayName, emailAddress, addToDefaultGroup, notify);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Creates a new user from the assembled query parameters.
        ///  <p>
        ///  The default group can be used to control initial permissions for new users, such as granting users the ability
        ///  to login or providing read access to certain projects or repositories. If the user is not added to the default
        ///  group, they may not be able to login after their account is created until explicit permissions are configured.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="name">Optional parameter: the username for the new user</param>
        /// <param name="password">Optional parameter: the password for the new user</param>
        /// <param name="displayName">Optional parameter: the display name for the new user</param>
        /// <param name="emailAddress">Optional parameter: the e-mail address for the new user</param>
        /// <param name="addToDefaultGroup">Optional parameter: <code>true</code> to add the user to the default group, which can be used to grant them                           a set of initial permissions; otherwise, <code>false</code> to not add them to a group</param>
        /// <param name="notify">Optional parameter: if present and not <code>false</code> instead of requiring a password,                           the create user will be notified via email their account has been created and requires                           a password to be reset. This option can only be used if a mail server has been configured</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateUserAsync(
                string name = null,
                string password = null,
                string displayName = null,
                string emailAddress = null,
                bool? addToDefaultGroup = true,
                string notify = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name },
                { "password", password },
                { "displayName", displayName },
                { "emailAddress", emailAddress },
                { "addToDefaultGroup", (null != addToDefaultGroup) ? addToDefaultGroup : true },
                { "notify", notify }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, null, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

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
        /// Deletes the specified user, removing them from the system. This also removes any permissions that may have been
        ///  granted to the user.
        ///  <p>
        ///  A user may not delete themselves, and a user with <strong>ADMIN</strong> permissions may not delete a user with
        ///  <strong>SYS_ADMIN</strong>permissions.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="name">Optional parameter: the username identifying the user to delete</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteUser(string name = null)
        {
            Task<string> t = DeleteUserAsync(name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes the specified user, removing them from the system. This also removes any permissions that may have been
        ///  granted to the user.
        ///  <p>
        ///  A user may not delete themselves, and a user with <strong>ADMIN</strong> permissions may not delete a user with
        ///  <strong>SYS_ADMIN</strong>permissions.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="name">Optional parameter: the username identifying the user to delete</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteUserAsync(string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Clears any CAPTCHA challenge that may constrain the user with the supplied username when they authenticate.
        ///  Additionally any counter or metric that contributed towards the user being issued the CAPTCHA challenge
        ///  (for instance too many consecutive failed logins) will also be reset.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource, and may not clear
        ///  the CAPTCHA of a user with greater permissions than themselves.
        /// </summary>
        /// <param name="name">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic DeleteClearUserCaptchaChallenge(string name = null)
        {
            Task<dynamic> t = DeleteClearUserCaptchaChallengeAsync(name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Clears any CAPTCHA challenge that may constrain the user with the supplied username when they authenticate.
        ///  Additionally any counter or metric that contributed towards the user being issued the CAPTCHA challenge
        ///  (for instance too many consecutive failed logins) will also be reset.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource, and may not clear
        ///  the CAPTCHA of a user with greater permissions than themselves.
        /// </summary>
        /// <param name="name">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> DeleteClearUserCaptchaChallengeAsync(string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users/captcha");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name }
            },ArrayDeserializationFormat,ParameterSeparator);


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
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
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Deletes the specified group, removing them from the system. This also removes any permissions that may have been
        ///  granted to the group.
        ///  <p>
        ///  A user may not delete the last group that is granting them administrative permissions, or a group with greater
        ///  permissions than themselves.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="name">Optional parameter: the name identifying the group to delete</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteGroup(string name = null)
        {
            Task<string> t = DeleteGroupAsync(name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Deletes the specified group, removing them from the system. This also removes any permissions that may have been
        ///  granted to the group.
        ///  <p>
        ///  A user may not delete the last group that is granting them administrative permissions, or a group with greater
        ///  permissions than themselves.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="name">Optional parameter: the name identifying the group to delete</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteGroupAsync(string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/groups");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// <p><strong>Deprecated since 2.10 for removal in 4.0</strong>. Use {@code /rest/users/add-groups} instead.</p>
        ///  Add a user to a group.
        ///  <p>
        ///  In the request entity, the <em>context</em> attribute is the group and the <em>itemName</em> is the user.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string AddUserToGroup(object mdynamic)
        {
            Task<string> t = AddUserToGroupAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// <p><strong>Deprecated since 2.10 for removal in 4.0</strong>. Use {@code /rest/users/add-groups} instead.</p>
        ///  Add a user to a group.
        ///  <p>
        ///  In the request entity, the <em>context</em> attribute is the group and the <em>itemName</em> is the user.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AddUserToGroupAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/groups/add-user");


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
        /// <p><strong>Deprecated since 2.10 for removal in 4.0</strong>. Use {@code /rest/users/add-groups} instead.</p>
        ///  Add a user to a group. This is very similar to <code>groups/add-user</code>, but with the <em>context</em> and
        ///  <em>itemName</em> attributes of the supplied request entity reversed. On the face of it this may appear
        ///  redundant, but it facilitates a specific UI component in Stash.
        ///  <p>
        ///  In the request entity, the <em>context</em> attribute is the user and the <em>itemName</em> is the group.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string AddGroupToUser(object mdynamic)
        {
            Task<string> t = AddGroupToUserAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// <p><strong>Deprecated since 2.10 for removal in 4.0</strong>. Use {@code /rest/users/add-groups} instead.</p>
        ///  Add a user to a group. This is very similar to <code>groups/add-user</code>, but with the <em>context</em> and
        ///  <em>itemName</em> attributes of the supplied request entity reversed. On the face of it this may appear
        ///  redundant, but it facilitates a specific UI component in Stash.
        ///  <p>
        ///  In the request entity, the <em>context</em> attribute is the user and the <em>itemName</em> is the group.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> AddGroupToUserAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users/add-group");


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
        /// <p><strong>Deprecated since 2.10 for removal in 3.0</strong>. Use {@code /rest/users/remove-groups} instead.</p>
        ///  Remove a user from a group.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        ///  <p>
        ///  In the request entity, the <em>context</em> attribute is the group and the <em>itemName</em> is the user.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreateRemoveUserFromGroup(object mdynamic)
        {
            Task<string> t = CreateRemoveUserFromGroupAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// <p><strong>Deprecated since 2.10 for removal in 3.0</strong>. Use {@code /rest/users/remove-groups} instead.</p>
        ///  Remove a user from a group.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        ///  <p>
        ///  In the request entity, the <em>context</em> attribute is the group and the <em>itemName</em> is the user.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateRemoveUserFromGroupAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/groups/remove-user");


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
        /// Remove a user from a group. This is very similar to <code>groups/remove-user</code>, but with the <em>context</em>
        ///  and <em>itemName</em> attributes of the supplied request entity reversed. On the face of it this may appear
        ///  redundant, but it facilitates a specific UI component in Stash.
        ///  <p>
        ///  In the request entity, the <em>context</em> attribute is the user and the <em>itemName</em> is the group.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreateRemoveGroupFromUser(object mdynamic)
        {
            Task<string> t = CreateRemoveGroupFromUserAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove a user from a group. This is very similar to <code>groups/remove-user</code>, but with the <em>context</em>
        ///  and <em>itemName</em> attributes of the supplied request entity reversed. On the face of it this may appear
        ///  redundant, but it facilitates a specific UI component in Stash.
        ///  <p>
        ///  In the request entity, the <em>context</em> attribute is the user and the <em>itemName</em> is the group.
        ///  <p>
        ///  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateRemoveGroupFromUserAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users/remove-group");


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
        /// Retrieves a list of users that are members of a specified group.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="context">Optional parameter: the group which should be used to locate members</param>
        /// <param name="filter">Optional parameter: if specified only users with usernames, display names or email addresses containing the                   supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string FindUsersInGroup(string context = null, string filter = null)
        {
            Task<string> t = FindUsersInGroupAsync(context, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a list of users that are members of a specified group.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="context">Optional parameter: the group which should be used to locate members</param>
        /// <param name="filter">Optional parameter: if specified only users with usernames, display names or email addresses containing the                   supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> FindUsersInGroupAsync(string context = null, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/groups/more-members");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "context", context },
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Retrieves a list of users that are <em>not</em> members of a specified group.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="context">Optional parameter: the group which should be used to locate non-members</param>
        /// <param name="filter">Optional parameter: if specified only users with usernames, display names or email addresses containing the                   supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string FindUsersNotInGroup(string context = null, string filter = null)
        {
            Task<string> t = FindUsersNotInGroupAsync(context, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a list of users that are <em>not</em> members of a specified group.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="context">Optional parameter: the group which should be used to locate non-members</param>
        /// <param name="filter">Optional parameter: if specified only users with usernames, display names or email addresses containing the                   supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> FindUsersNotInGroupAsync(string context = null, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/groups/more-non-members");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "context", context },
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Retrieves a list of groups the specified user is a member of.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="context">Optional parameter: the user which should be used to locate groups</param>
        /// <param name="filter">Optional parameter: if specified only groups with names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string FindGroupsForUser(string context = null, string filter = null)
        {
            Task<string> t = FindGroupsForUserAsync(context, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a list of groups the specified user is a member of.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="context">Optional parameter: the user which should be used to locate groups</param>
        /// <param name="filter">Optional parameter: if specified only groups with names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> FindGroupsForUserAsync(string context = null, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users/more-members");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "context", context },
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Retrieves a list of groups the specified user is <em>not</em> a member of.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="context">Optional parameter: the user which should be used to locate groups</param>
        /// <param name="filter">Optional parameter: if specified only groups with names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string FindOtherGroupsForUser(string context = null, string filter = null)
        {
            Task<string> t = FindOtherGroupsForUserAsync(context, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a list of groups the specified user is <em>not</em> a member of.
        ///  <p>
        ///  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.
        /// </summary>
        /// <param name="context">Optional parameter: the user which should be used to locate groups</param>
        /// <param name="filter">Optional parameter: if specified only groups with names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> FindOtherGroupsForUserAsync(string context = null, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/users/more-non-members");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "context", context },
                { "filter", filter }
            },ArrayDeserializationFormat,ParameterSeparator);


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
        /// Retrieves details about the current license, as well as the current status of the system with regards to the
        ///  installed license. The status includes the current number of users applied toward the license limit, as well
        ///  as any status messages about the license (warnings about expiry or user counts exceeding license limits).
        ///  <p>
        ///  The authenticated user must have <b>ADMIN</b> permission. Unauthenticated users, and non-administrators, are
        ///  not permitted to access license details.
        /// </summary>
        /// <return>Returns the string response from the API call</return>
        public string GetLicense()
        {
            Task<string> t = GetLicenseAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves details about the current license, as well as the current status of the system with regards to the
        ///  installed license. The status includes the current number of users applied toward the license limit, as well
        ///  as any status messages about the license (warnings about expiry or user counts exceeding license limits).
        ///  <p>
        ///  The authenticated user must have <b>ADMIN</b> permission. Unauthenticated users, and non-administrators, are
        ///  not permitted to access license details.
        /// </summary>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetLicenseAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/admin/license");


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