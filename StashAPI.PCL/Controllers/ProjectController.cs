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
    public partial class ProjectController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ProjectController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ProjectController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ProjectController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve the project matching the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_VIEW</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetProject(string projectKey)
        {
            Task<string> t = GetProjectAsync(projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the project matching the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_VIEW</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetProjectAsync(string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
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
        /// Delete the project matching the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteProject(string projectKey)
        {
            Task<string> t = DeleteProjectAsync(projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete the project matching the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteProjectAsync(string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
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
        /// Retrieve a page of groups that have been granted at least one permission for the specified project.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetProjectGroupsWithAnyPermission(string projectKey, string filter = null)
        {
            Task<string> t = GetProjectGroupsWithAnyPermissionAsync(projectKey, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of groups that have been granted at least one permission for the specified project.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetProjectGroupsWithAnyPermissionAsync(string projectKey, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/groups");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

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
        /// Promote or demote a group's permission level for the specified project. Available project permissions are:
        ///  <ul>
        ///      <li>PROJECT_READ</li>
        ///      <li>PROJECT_WRITE</li>
        ///      <li>PROJECT_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+project">Stash documentation</a>
        ///  for a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource. In addition, a user may not demote a group's permission level if their
        ///  own permission level would be reduced as a result.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <param name="name">Optional parameter: the names of the groups</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetProjectPermissionForGroups(string projectKey, string permission = null, string name = null)
        {
            Task<string> t = UpdateSetProjectPermissionForGroupsAsync(projectKey, permission, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Promote or demote a group's permission level for the specified project. Available project permissions are:
        ///  <ul>
        ///      <li>PROJECT_READ</li>
        ///      <li>PROJECT_WRITE</li>
        ///      <li>PROJECT_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+project">Stash documentation</a>
        ///  for a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource. In addition, a user may not demote a group's permission level if their
        ///  own permission level would be reduced as a result.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <param name="name">Optional parameter: the names of the groups</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetProjectPermissionForGroupsAsync(string projectKey, string permission = null, string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/groups");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

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
        /// Revoke all permissions for the specified project for a group.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        ///  <p>
        ///  In addition, a user may not revoke a group's permissions if it will reduce their own permission level.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the name of the group</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteRevokeProjectPermissionsForGroup(string projectKey, string name = null)
        {
            Task<string> t = DeleteRevokeProjectPermissionsForGroupAsync(projectKey, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Revoke all permissions for the specified project for a group.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        ///  <p>
        ///  In addition, a user may not revoke a group's permissions if it will reduce their own permission level.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the name of the group</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteRevokeProjectPermissionsForGroupAsync(string projectKey, string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/groups");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

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
        /// Retrieve a page of groups that have no granted permissions for the specified project.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetProjectGroupsWithoutAnyPermission(string projectKey, string filter = null)
        {
            Task<string> t = GetProjectGroupsWithoutAnyPermissionAsync(projectKey, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of groups that have no granted permissions for the specified project.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetProjectGroupsWithoutAnyPermissionAsync(string projectKey, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/groups/none");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

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
        /// Retrieve a page of users that have been granted at least one permission for the specified project.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetProjectUsersWithAnyPermission(string projectKey, string filter = null)
        {
            Task<string> t = GetProjectUsersWithAnyPermissionAsync(projectKey, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of users that have been granted at least one permission for the specified project.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetProjectUsersWithAnyPermissionAsync(string projectKey, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/users");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

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
        /// Promote or demote a user's permission level for the specified project. Available project permissions are:
        ///  <ul>
        ///      <li>PROJECT_READ</li>
        ///      <li>PROJECT_WRITE</li>
        ///      <li>PROJECT_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+project">Stash documentation</a>
        ///  for a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource. In addition, a user may not reduce their own permission level unless
        ///  they have a global permission that already implies that permission.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the names of the users</param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetProjectPermissionForUsers(string projectKey, string name = null, string permission = null)
        {
            Task<string> t = UpdateSetProjectPermissionForUsersAsync(projectKey, name, permission);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Promote or demote a user's permission level for the specified project. Available project permissions are:
        ///  <ul>
        ///      <li>PROJECT_READ</li>
        ///      <li>PROJECT_WRITE</li>
        ///      <li>PROJECT_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+project">Stash documentation</a>
        ///  for a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource. In addition, a user may not reduce their own permission level unless
        ///  they have a global permission that already implies that permission.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the names of the users</param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetProjectPermissionForUsersAsync(string projectKey, string name = null, string permission = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/users");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

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
        /// Revoke all permissions for the specified project for a user.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        ///  <p>
        ///  In addition, a user may not revoke their own project permissions if they do not have a higher global permission.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the name of the user</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteRevokeProjectPermissionsForUser(string projectKey, string name = null)
        {
            Task<string> t = DeleteRevokeProjectPermissionsForUserAsync(projectKey, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Revoke all permissions for the specified project for a user.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        ///  <p>
        ///  In addition, a user may not revoke their own project permissions if they do not have a higher global permission.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the name of the user</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteRevokeProjectPermissionsForUserAsync(string projectKey, string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/users");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

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
        /// Retrieve a page of <i>licensed</i> users that have no granted permissions for the specified project.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetProjectUsersWithoutPermission(string projectKey, string filter = null)
        {
            Task<string> t = GetProjectUsersWithoutPermissionAsync(projectKey, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of <i>licensed</i> users that have no granted permissions for the specified project.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetProjectUsersWithoutPermissionAsync(string projectKey, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/users/none");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

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
        /// Check whether the specified permission is the default permission (granted to all users) for a project. Available
        ///  project permissions are:
        ///  <ul>
        ///      <li>PROJECT_READ</li>
        ///      <li>PROJECT_WRITE</li>
        ///      <li>PROJECT_ADMIN</li>
        ///  </ul>
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="permission">Required parameter: the permission to grant</param>
        /// <return>Returns the string response from the API call</return>
        public string GetHasProjectAllUserPermission(string projectKey, string permission)
        {
            Task<string> t = GetHasProjectAllUserPermissionAsync(projectKey, permission);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Check whether the specified permission is the default permission (granted to all users) for a project. Available
        ///  project permissions are:
        ///  <ul>
        ///      <li>PROJECT_READ</li>
        ///      <li>PROJECT_WRITE</li>
        ///      <li>PROJECT_ADMIN</li>
        ///  </ul>
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="permission">Required parameter: the permission to grant</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetHasProjectAllUserPermissionAsync(string projectKey, string permission)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/{permission}/all");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "permission", permission }
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
        /// Grant or revoke a project permission to all users, i.e. set the default permission. Available project permissions
        ///  are:
        ///  <ul>
        ///      <li>PROJECT_READ</li>
        ///      <li>PROJECT_WRITE</li>
        ///      <li>PROJECT_ADMIN</li>
        ///  </ul>
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="permission">Required parameter: the permission to grant</param>
        /// <param name="allow">Optional parameter: <em>true</em> to grant the specified permission to all users, or <em>false</em> to revoke it</param>
        /// <return>Returns the string response from the API call</return>
        public string ModifyProjectAllUserPermission(string projectKey, string permission, bool? allow = null)
        {
            Task<string> t = ModifyProjectAllUserPermissionAsync(projectKey, permission, allow);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Grant or revoke a project permission to all users, i.e. set the default permission. Available project permissions
        ///  are:
        ///  <ul>
        ///      <li>PROJECT_READ</li>
        ///      <li>PROJECT_WRITE</li>
        ///      <li>PROJECT_ADMIN</li>
        ///  </ul>
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
        ///  global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="permission">Required parameter: the permission to grant</param>
        /// <param name="allow">Optional parameter: <em>true</em> to grant the specified permission to all users, or <em>false</em> to revoke it</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ModifyProjectAllUserPermissionAsync(string projectKey, string permission, bool? allow = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/permissions/{permission}/all");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "permission", permission }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "allow", allow }
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
        /// Create a new project.
        ///  <p>
        ///  To include a custom avatar for the project, the project definition should contain an additional attribute with
        ///  the key <code>avatar</code> and the value a data URI containing Base64-encoded image data. The URI should be in
        ///  the following format:
        ///  <pre>
        ///      data:(content type, e.g. image/png);base64,(data)
        ///  </pre>
        ///  If the data is not Base64-encoded, or if a character set is defined in the URI, or the URI is otherwise invalid,
        ///  <em>project creation will fail</em>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_CREATE</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreateProject(object mdynamic)
        {
            Task<string> t = CreateProjectAsync(mdynamic);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new project.
        ///  <p>
        ///  To include a custom avatar for the project, the project definition should contain an additional attribute with
        ///  the key <code>avatar</code> and the value a data URI containing Base64-encoded image data. The URI should be in
        ///  the following format:
        ///  <pre>
        ///      data:(content type, e.g. image/png);base64,(data)
        ///  </pre>
        ///  If the data is not Base64-encoded, or if a character set is defined in the URI, or the URI is otherwise invalid,
        ///  <em>project creation will fail</em>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_CREATE</strong> permission to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateProjectAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects");


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
        /// Retrieve a page of projects.
        ///  <p>
        ///  Only projects for which the authenticated user has the <strong>PROJECT_VIEW</strong> permission will be returned.
        /// </summary>
        /// <param name="name">Optional parameter: Example: </param>
        /// <param name="permission">Optional parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetProjects(string name = null, string permission = null)
        {
            Task<string> t = GetProjectsAsync(name, permission);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of projects.
        ///  <p>
        ///  Only projects for which the authenticated user has the <strong>PROJECT_VIEW</strong> permission will be returned.
        /// </summary>
        /// <param name="name">Optional parameter: Example: </param>
        /// <param name="permission">Optional parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetProjectsAsync(string name = null, string permission = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects");

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
        /// Update the project matching the <strong>projectKey</strong> supplied in the resource path.
        ///  <p>
        ///  To include a custom avatar for the updated project, the project definition should contain an additional attribute
        ///  with the key <code>avatar</code> and the value a data URI containing Base64-encoded image data. The URI should be
        ///  in the following format:
        ///  <code>
        ///      data:(content type, e.g. image/png);base64,(data)
        ///  </code>
        ///  If the data is not Base64-encoded, or if a character set is defined in the URI, or the URI is otherwise invalid,
        ///  <em>project creation will fail</em>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateProject(object mdynamic, string projectKey)
        {
            Task<string> t = UpdateProjectAsync(mdynamic, projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the project matching the <strong>projectKey</strong> supplied in the resource path.
        ///  <p>
        ///  To include a custom avatar for the updated project, the project definition should contain an additional attribute
        ///  with the key <code>avatar</code> and the value a data URI containing Base64-encoded image data. The URI should be
        ///  in the following format:
        ///  <code>
        ///      data:(content type, e.g. image/png);base64,(data)
        ///  </code>
        ///  If the data is not Base64-encoded, or if a character set is defined in the URI, or the URI is otherwise invalid,
        ///  <em>project creation will fail</em>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateProjectAsync(object mdynamic, string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
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

        /// <summary>
        /// Retrieve the avatar for the project matching the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_VIEW</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="s">Optional parameter: The desired size of the image. The server will return an image as close as possible to the specified              size.</param>
        /// <return>Returns the string response from the API call</return>
        public string GetProjectAvatar(string projectKey, int? s = 0)
        {
            Task<string> t = GetProjectAvatarAsync(projectKey, s);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the avatar for the project matching the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_VIEW</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="s">Optional parameter: The desired size of the image. The server will return an image as close as possible to the specified              size.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetProjectAvatarAsync(string projectKey, int? s = 0)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/avatar.png");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "s", (null != s) ? s : 0 }
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
        /// Update the avatar for the project matching the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  This resource accepts POST multipart form data, containing a single image in a form-field named 'avatar'.
        ///  <p>
        ///  There are configurable server limits on both the dimensions (1024x1024 pixels by default) and uploaded file size
        ///  (1MB by default). Several different image formats are supported, but <strong>PNG</strong> and
        ///  <strong>JPEG</strong> are preferred due to the file size limit.
        ///  <p>
        ///  An example <a href="http://curl.haxx.se/">curl</a> request to upload an image name 'avatar.png' would be:
        ///  <pre>
        ///  curl -X POST -u username:password http://example.com/rest/api/1.0/projects/STASH/avatar.png -F avatar=@avatar.png
        ///  </pre>
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UploadProjectAvatar(string projectKey)
        {
            Task<string> t = UploadProjectAvatarAsync(projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the avatar for the project matching the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  This resource accepts POST multipart form data, containing a single image in a form-field named 'avatar'.
        ///  <p>
        ///  There are configurable server limits on both the dimensions (1024x1024 pixels by default) and uploaded file size
        ///  (1MB by default). Several different image formats are supported, but <strong>PNG</strong> and
        ///  <strong>JPEG</strong> are preferred due to the file size limit.
        ///  <p>
        ///  An example <a href="http://curl.haxx.se/">curl</a> request to upload an image name 'avatar.png' would be:
        ///  <pre>
        ///  curl -X POST -u username:password http://example.com/rest/api/1.0/projects/STASH/avatar.png -F avatar=@avatar.png
        ///  </pre>
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UploadProjectAvatarAsync(string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/avatar.png");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey }
            });


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

    }
} 