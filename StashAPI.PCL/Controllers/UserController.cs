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
    public partial class UserController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static UserController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static UserController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new UserController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Retrieve a map of user setting key values for a specific user identified by the user slug.
        ///  <p>
        /// </summary>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetUserSettings(string userSlug)
        {
            Task<string> t = GetUserSettingsAsync(userSlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a map of user setting key values for a specific user identified by the user slug.
        ///  <p>
        /// </summary>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetUserSettingsAsync(string userSlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/users/{userSlug}/settings");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "userSlug", userSlug }
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
        /// Update the currently authenticated user's password.
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
        /// Update the currently authenticated user's password.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateUserPasswordAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/users/credentials");


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
        /// Retrieve the user matching the supplied <strong>userSlug</strong>.
        ///  <p>
        /// </summary>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetUser(string userSlug)
        {
            Task<string> t = GetUserAsync(userSlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the user matching the supplied <strong>userSlug</strong>.
        ///  <p>
        /// </summary>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetUserAsync(string userSlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/users/{userSlug}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "userSlug", userSlug }
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
        /// Update the currently authenticated user's details. Note that <em>the name attribute is ignored</em>, the update
        ///  will always be applied to the currently authenticated user.
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
        /// Update the currently authenticated user's details. Note that <em>the name attribute is ignored</em>, the update
        ///  will always be applied to the currently authenticated user.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateUserDetailsAsync(object mdynamic)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/users");


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
        /// Retrieve a page of users, optionally run through provided filters.
        ///  <p>
        ///  Only authenticated users may call this resource.
        ///  <h3>Supported Filters</h3>
        ///  <p>
        ///  Filters are provided in query parameters in a standard <code>name=value</code> fashion. The following filters are
        ///  currently supported:
        ///  <ul>
        ///      <li>
        ///          {@code filter} - return only users, whose username, name or email address <i>contain</i> the
        ///          {@code filter} value
        ///      </li>
        ///      <li>
        ///          {@code permission} - the "root" of a permission filter, whose value must be a valid global,
        ///          project, or repository permission. Additional filter parameters referring to this filter that specify the
        ///          resource (project or repository) to apply the filter to must be prefixed with <code>permission.</code>. See the
        ///          section "Permission Filters" below for more details.
        ///      </li>
        ///      <li>
        ///          {@code permission.N} - the "root" of a single permission filter, similar to the {@code permission}
        ///          parameter, where "N" is a natural number starting from 1. This allows clients to specify multiple permission
        ///          filters, by providing consecutive filters as {@code permission.1}, {@code permission.2} etc. Note that
        ///          the filters numbering has to start with 1 and be continuous for all filters to be processed. The total allowed
        ///          number of permission filters is 50 and all filters exceeding that limit will be dropped. See the section
        ///          "Permission Filters" below for more details on how the permission filters are processed.
        ///      </li>
        ///  </ul>
        ///  
        ///  <h3>Permission Filters</h3>
        ///  <p>
        ///  The following three sub-sections list parameters supported for permission filters (where <code>[root]</code> is
        ///  the root permission filter name, e.g. {@code permission}, {@code permission.1} etc.) depending on the
        ///  permission resource. The system determines which filter to apply (Global, Project or Repository permission)
        ///  based on the <code>[root]</code> permission value. E.g. {@code ADMIN} is a global permission,
        ///  {@code PROJECT_ADMIN} is a project permission and {@code REPO_ADMIN} is a repository permission. Note
        ///  that the parameters for a given resource will be looked up in the order as they are listed below, that is e.g.
        ///  for a project resource, if both {@code projectId} and {@code projectKey} are provided, the system will
        ///  use {@code projectId} for the lookup.
        ///  <h4>Global permissions</h4>
        ///  <p>
        ///  The permission value under <code>[root]</code> is the only required and recognized parameter, as global
        ///  permissions do not apply to a specific resource.
        ///  <p>
        ///  Example valid filter: <code>permission=ADMIN</code>.
        ///  <h4>Project permissions</h4>
        ///  <ul>
        ///      <li><code>[root]</code>- specifies the project permission</li>
        ///      <li><code>[root].projectId</code> - specifies the project ID to lookup the project by</li>
        ///      <li><code>[root].projectKey</code> - specifies the project key to lookup the project by</li>
        ///  </ul>
        ///  <p>
        ///  Example valid filter: <code>permission.1=PROJECT_ADMIN&permission.1.projectKey=TEST_PROJECT</code>.
        ///  <h4>Repository permissions</h4>
        ///  <ul>
        ///      <li><code>[root]</code>- specifies the repository permission</li>
        ///      <li><code>[root].projectId</code> - specifies the repository ID to lookup the repository by</li>
        ///      <li><code>[root].projectKey</code> and <code>[root].repositorySlug</code>- specifies the project key and
        ///      repository slug to lookup the repository by; both values <i>need to</i> be provided for this look up to be
        ///      triggered</li>
        ///  </ul>
        ///  Example valid filter: <code>permission.2=REPO_ADMIN&permission.2.projectKey=TEST_PROJECT&permission.2.repositorySlug=test_repo</code>.
        /// </summary>
        /// <return>Returns the string response from the API call</return>
        public string GetUsers()
        {
            Task<string> t = GetUsersAsync();
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of users, optionally run through provided filters.
        ///  <p>
        ///  Only authenticated users may call this resource.
        ///  <h3>Supported Filters</h3>
        ///  <p>
        ///  Filters are provided in query parameters in a standard <code>name=value</code> fashion. The following filters are
        ///  currently supported:
        ///  <ul>
        ///      <li>
        ///          {@code filter} - return only users, whose username, name or email address <i>contain</i> the
        ///          {@code filter} value
        ///      </li>
        ///      <li>
        ///          {@code permission} - the "root" of a permission filter, whose value must be a valid global,
        ///          project, or repository permission. Additional filter parameters referring to this filter that specify the
        ///          resource (project or repository) to apply the filter to must be prefixed with <code>permission.</code>. See the
        ///          section "Permission Filters" below for more details.
        ///      </li>
        ///      <li>
        ///          {@code permission.N} - the "root" of a single permission filter, similar to the {@code permission}
        ///          parameter, where "N" is a natural number starting from 1. This allows clients to specify multiple permission
        ///          filters, by providing consecutive filters as {@code permission.1}, {@code permission.2} etc. Note that
        ///          the filters numbering has to start with 1 and be continuous for all filters to be processed. The total allowed
        ///          number of permission filters is 50 and all filters exceeding that limit will be dropped. See the section
        ///          "Permission Filters" below for more details on how the permission filters are processed.
        ///      </li>
        ///  </ul>
        ///  
        ///  <h3>Permission Filters</h3>
        ///  <p>
        ///  The following three sub-sections list parameters supported for permission filters (where <code>[root]</code> is
        ///  the root permission filter name, e.g. {@code permission}, {@code permission.1} etc.) depending on the
        ///  permission resource. The system determines which filter to apply (Global, Project or Repository permission)
        ///  based on the <code>[root]</code> permission value. E.g. {@code ADMIN} is a global permission,
        ///  {@code PROJECT_ADMIN} is a project permission and {@code REPO_ADMIN} is a repository permission. Note
        ///  that the parameters for a given resource will be looked up in the order as they are listed below, that is e.g.
        ///  for a project resource, if both {@code projectId} and {@code projectKey} are provided, the system will
        ///  use {@code projectId} for the lookup.
        ///  <h4>Global permissions</h4>
        ///  <p>
        ///  The permission value under <code>[root]</code> is the only required and recognized parameter, as global
        ///  permissions do not apply to a specific resource.
        ///  <p>
        ///  Example valid filter: <code>permission=ADMIN</code>.
        ///  <h4>Project permissions</h4>
        ///  <ul>
        ///      <li><code>[root]</code>- specifies the project permission</li>
        ///      <li><code>[root].projectId</code> - specifies the project ID to lookup the project by</li>
        ///      <li><code>[root].projectKey</code> - specifies the project key to lookup the project by</li>
        ///  </ul>
        ///  <p>
        ///  Example valid filter: <code>permission.1=PROJECT_ADMIN&permission.1.projectKey=TEST_PROJECT</code>.
        ///  <h4>Repository permissions</h4>
        ///  <ul>
        ///      <li><code>[root]</code>- specifies the repository permission</li>
        ///      <li><code>[root].projectId</code> - specifies the repository ID to lookup the repository by</li>
        ///      <li><code>[root].projectKey</code> and <code>[root].repositorySlug</code>- specifies the project key and
        ///      repository slug to lookup the repository by; both values <i>need to</i> be provided for this look up to be
        ///      triggered</li>
        ///  </ul>
        ///  Example valid filter: <code>permission.2=REPO_ADMIN&permission.2.projectKey=TEST_PROJECT&permission.2.repositorySlug=test_repo</code>.
        /// </summary>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetUsersAsync()
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/users");


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
        /// Delete the avatar associated to a user.
        ///  <p>
        ///  Users are always allowed to delete their own avatar. To delete someone else's avatar the authenticated user must
        ///  have global <strong>ADMIN</strong> permission, or global <strong>SYS_ADMIN</strong> permission to update a
        ///  <strong>SYS_ADMIN</strong> user's avatar.
        /// </summary>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteUserAvatar(string userSlug)
        {
            Task<string> t = DeleteUserAvatarAsync(userSlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete the avatar associated to a user.
        ///  <p>
        ///  Users are always allowed to delete their own avatar. To delete someone else's avatar the authenticated user must
        ///  have global <strong>ADMIN</strong> permission, or global <strong>SYS_ADMIN</strong> permission to update a
        ///  <strong>SYS_ADMIN</strong> user's avatar.
        /// </summary>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteUserAvatarAsync(string userSlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/users/{userSlug}/avatar.png");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "userSlug", userSlug }
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
        /// Update the avatar for the user with the supplied <strong>slug</strong>.
        ///  <p>
        ///  This resource accepts POST multipart form data, containing a single image in a form-field named 'avatar'.
        ///  <p>
        ///  There are configurable server limits on both the dimensions (1024x1024 pixels by default) and uploaded
        ///  file size (1MB by default). Several different image formats are supported, but <strong>PNG</strong> and
        ///  <strong>JPEG</strong> are preferred due to the file size limit.
        ///  <p>
        ///  This resource has Cross-Site Request Forgery (XSRF) protection. To allow the request to
        ///  pass the XSRF check the caller needs to send an <code>X-Atlassian-Token</code> HTTP header with the
        ///  value <code>no-check</code>.
        ///  <p>
        ///  An example <a href="http://curl.haxx.se/">curl</a> request to upload an image name 'avatar.png' would be:
        ///  <pre>
        ///  curl -X POST -u username:password -H "X-Atlassian-Token: no-check" http://example.com/rest/api/latest/users/jdoe/avatar.png -F avatar=@avatar.png
        ///  </pre>
        ///  <p>
        ///  Users are always allowed to update their own avatar. To update someone else's avatar the authenticated user must
        ///  have global <strong>ADMIN</strong> permission, or global <strong>SYS_ADMIN</strong> permission to update a
        ///  <strong>SYS_ADMIN</strong> user's avatar.
        /// </summary>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UploadUserAvatar(string userSlug)
        {
            Task<string> t = UploadUserAvatarAsync(userSlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the avatar for the user with the supplied <strong>slug</strong>.
        ///  <p>
        ///  This resource accepts POST multipart form data, containing a single image in a form-field named 'avatar'.
        ///  <p>
        ///  There are configurable server limits on both the dimensions (1024x1024 pixels by default) and uploaded
        ///  file size (1MB by default). Several different image formats are supported, but <strong>PNG</strong> and
        ///  <strong>JPEG</strong> are preferred due to the file size limit.
        ///  <p>
        ///  This resource has Cross-Site Request Forgery (XSRF) protection. To allow the request to
        ///  pass the XSRF check the caller needs to send an <code>X-Atlassian-Token</code> HTTP header with the
        ///  value <code>no-check</code>.
        ///  <p>
        ///  An example <a href="http://curl.haxx.se/">curl</a> request to upload an image name 'avatar.png' would be:
        ///  <pre>
        ///  curl -X POST -u username:password -H "X-Atlassian-Token: no-check" http://example.com/rest/api/latest/users/jdoe/avatar.png -F avatar=@avatar.png
        ///  </pre>
        ///  <p>
        ///  Users are always allowed to update their own avatar. To update someone else's avatar the authenticated user must
        ///  have global <strong>ADMIN</strong> permission, or global <strong>SYS_ADMIN</strong> permission to update a
        ///  <strong>SYS_ADMIN</strong> user's avatar.
        /// </summary>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UploadUserAvatarAsync(string userSlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/users/{userSlug}/avatar.png");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "userSlug", userSlug }
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

        /// <summary>
        /// Update the entries of a map of user setting key/values for a specific user identified by the user slug.
        ///  <p>
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateUserSettings(object mdynamic, string userSlug)
        {
            Task<string> t = UpdateUserSettingsAsync(mdynamic, userSlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the entries of a map of user setting key/values for a specific user identified by the user slug.
        ///  <p>
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="userSlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateUserSettingsAsync(object mdynamic, string userSlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/users/{userSlug}/settings");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "userSlug", userSlug }
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