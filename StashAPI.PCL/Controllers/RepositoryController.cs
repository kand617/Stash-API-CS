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
    public partial class RepositoryController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static RepositoryController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static RepositoryController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new RepositoryController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Gets a diff of the changes available in the {@code from} changeset but not in the {@code to} changeset.
        ///  <p>
        ///  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
        ///  default branch of their containing repository.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the path to the file to diff (optional)</param>
        /// <param name="mfrom">Optional parameter: the source changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="to">Optional parameter: the target changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="fromRepo">Optional parameter: an optional parameter specifying the source repository containing the source changeset                  if that changeset is not present in the current repository; the repository can be specified                  by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by                  a slash: <em>fromRepo=projectKey/repoSlug</em></param>
        /// <param name="srcPath">Optional parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: an optional number of context lines to include around each added or removed lines in the diff</param>
        /// <param name="whitespace">Optional parameter: an optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryCompareDiffByPath(
                string projectKey,
                string repositorySlug,
                string path,
                string mfrom = null,
                string to = null,
                string fromRepo = null,
                string srcPath = null,
                int? contextLines = -1,
                string whitespace = null)
        {
            Task<string> t = GetRepositoryCompareDiffByPathAsync(projectKey, repositorySlug, path, mfrom, to, fromRepo, srcPath, contextLines, whitespace);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets a diff of the changes available in the {@code from} changeset but not in the {@code to} changeset.
        ///  <p>
        ///  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
        ///  default branch of their containing repository.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the path to the file to diff (optional)</param>
        /// <param name="mfrom">Optional parameter: the source changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="to">Optional parameter: the target changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="fromRepo">Optional parameter: an optional parameter specifying the source repository containing the source changeset                  if that changeset is not present in the current repository; the repository can be specified                  by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by                  a slash: <em>fromRepo=projectKey/repoSlug</em></param>
        /// <param name="srcPath">Optional parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: an optional number of context lines to include around each added or removed lines in the diff</param>
        /// <param name="whitespace">Optional parameter: an optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryCompareDiffByPathAsync(
                string projectKey,
                string repositorySlug,
                string path,
                string mfrom = null,
                string to = null,
                string fromRepo = null,
                string srcPath = null,
                int? contextLines = -1,
                string whitespace = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/compare/diff/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "path", path }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "from", mfrom },
                { "to", to },
                { "fromRepo", fromRepo },
                { "srcPath", srcPath },
                { "contextLines", (null != contextLines) ? contextLines : -1 },
                { "whitespace", whitespace }
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
        /// Gets the file changes available in the {@code from} changeset but not in the {@code to} changeset.
        ///  <p>
        ///  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
        ///  default branch of their containing repository.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="mfrom">Optional parameter: the source changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="to">Optional parameter: the target changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="fromRepo">Optional parameter: an optional parameter specifying the source repository containing the source changeset                  if that changeset is not present in the current repository; the repository can be specified                  by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by                  a slash: <em>fromRepo=projectKey/repoSlug</em></param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryCompareChanges(
                string projectKey,
                string repositorySlug,
                string mfrom = null,
                string to = null,
                string fromRepo = null)
        {
            Task<string> t = GetRepositoryCompareChangesAsync(projectKey, repositorySlug, mfrom, to, fromRepo);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets the file changes available in the {@code from} changeset but not in the {@code to} changeset.
        ///  <p>
        ///  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
        ///  default branch of their containing repository.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="mfrom">Optional parameter: the source changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="to">Optional parameter: the target changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="fromRepo">Optional parameter: an optional parameter specifying the source repository containing the source changeset                  if that changeset is not present in the current repository; the repository can be specified                  by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by                  a slash: <em>fromRepo=projectKey/repoSlug</em></param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryCompareChangesAsync(
                string projectKey,
                string repositorySlug,
                string mfrom = null,
                string to = null,
                string fromRepo = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/compare/changes");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "from", mfrom },
                { "to", to },
                { "fromRepo", fromRepo }
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
        /// Gets the commits accessible from the {@code from} changeset but not in the {@code to} changeset.
        ///  <p>
        ///  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
        ///  default branch of their containing repository.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="mfrom">Optional parameter: the source changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="to">Optional parameter: the target changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="fromRepo">Optional parameter: an optional parameter specifying the source repository containing the source changeset                  if that changeset is not present in the current repository; the repository can be specified                  by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by                  a slash: <em>fromRepo=projectKey/repoSlug</em></param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryCompareCommits(
                string projectKey,
                string repositorySlug,
                string mfrom = null,
                string to = null,
                string fromRepo = null)
        {
            Task<string> t = GetRepositoryCompareCommitsAsync(projectKey, repositorySlug, mfrom, to, fromRepo);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets the commits accessible from the {@code from} changeset but not in the {@code to} changeset.
        ///  <p>
        ///  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
        ///  default branch of their containing repository.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="mfrom">Optional parameter: the source changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="to">Optional parameter: the target changeset (can be a partial/full changeset id or qualified/unqualified ref name)</param>
        /// <param name="fromRepo">Optional parameter: an optional parameter specifying the source repository containing the source changeset                  if that changeset is not present in the current repository; the repository can be specified                  by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by                  a slash: <em>fromRepo=projectKey/repoSlug</em></param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryCompareCommitsAsync(
                string projectKey,
                string repositorySlug,
                string mfrom = null,
                string to = null,
                string fromRepo = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/compare/commits");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "from", mfrom },
                { "to", to },
                { "fromRepo", fromRepo }
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
        /// Retrieve the branches matching the supplied <strong>filterText</strong> param.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="mbase">Optional parameter: base branch or tag to compare each branch to (for the metadata providers that uses that information)</param>
        /// <param name="details">Optional parameter: whether to retrieve plugin-provided metadata about each branch</param>
        /// <param name="filterText">Optional parameter: the text to match on</param>
        /// <param name="orderBy">Optional parameter: ordering of refs either ALPHABETICAL (by name) or MODIFICATION (last updated)</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryBranches(
                string projectKey,
                string repositorySlug,
                string mbase = null,
                bool? details = null,
                string filterText = null,
                string orderBy = null)
        {
            Task<string> t = GetRepositoryBranchesAsync(projectKey, repositorySlug, mbase, details, filterText, orderBy);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the branches matching the supplied <strong>filterText</strong> param.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="mbase">Optional parameter: base branch or tag to compare each branch to (for the metadata providers that uses that information)</param>
        /// <param name="details">Optional parameter: whether to retrieve plugin-provided metadata about each branch</param>
        /// <param name="filterText">Optional parameter: the text to match on</param>
        /// <param name="orderBy">Optional parameter: ordering of refs either ALPHABETICAL (by name) or MODIFICATION (last updated)</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryBranchesAsync(
                string projectKey,
                string repositorySlug,
                string mbase = null,
                bool? details = null,
                string filterText = null,
                string orderBy = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/branches");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "base", mbase },
                { "details", details },
                { "filterText", filterText },
                { "orderBy", orderBy }
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
        /// Get the default branch of the repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryDefaultBranch(string projectKey, string repositorySlug)
        {
            Task<string> t = GetRepositoryDefaultBranchAsync(projectKey, repositorySlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Get the default branch of the repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryDefaultBranchAsync(string projectKey, string repositorySlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/branches/default");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Update the default branch of a repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetRepositoryDefaultBranch(object mdynamic, string projectKey, string repositorySlug)
        {
            Task<string> t = UpdateSetRepositoryDefaultBranchAsync(mdynamic, projectKey, repositorySlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the default branch of a repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetRepositoryDefaultBranchAsync(object mdynamic, string projectKey, string repositorySlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/branches/default");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Promote or demote a group's permission level for the specified repository. Available repository permissions are:
        ///  <ul>
        ///      <li>REPO_READ</li>
        ///      <li>REPO_WRITE</li>
        ///      <li>REPO_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+repository">Stash documentation</a>
        ///  for a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource. In addition, a user may not demote a group's permission level if their
        ///  own permission level would be reduced as a result.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <param name="name">Optional parameter: the names of the groups</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetRepositoryPermissionForGroup(
                string projectKey,
                string repositorySlug,
                string permission = null,
                string name = null)
        {
            Task<string> t = UpdateSetRepositoryPermissionForGroupAsync(projectKey, repositorySlug, permission, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Promote or demote a group's permission level for the specified repository. Available repository permissions are:
        ///  <ul>
        ///      <li>REPO_READ</li>
        ///      <li>REPO_WRITE</li>
        ///      <li>REPO_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+repository">Stash documentation</a>
        ///  for a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource. In addition, a user may not demote a group's permission level if their
        ///  own permission level would be reduced as a result.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <param name="name">Optional parameter: the names of the groups</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetRepositoryPermissionForGroupAsync(
                string projectKey,
                string repositorySlug,
                string permission = null,
                string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/permissions/groups");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Retrieve a page of groups that have been granted at least one permission for the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryGroupsWithAnyPermission(string projectKey, string repositorySlug, string filter = null)
        {
            Task<string> t = GetRepositoryGroupsWithAnyPermissionAsync(projectKey, repositorySlug, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of groups that have been granted at least one permission for the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryGroupsWithAnyPermissionAsync(string projectKey, string repositorySlug, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/permissions/groups");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Revoke all permissions for the specified repository for a group.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        ///  <p>
        ///  In addition, a user may not revoke a group's permissions if it will reduce their own permission level.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the name of the group</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteRevokeRepositoryPermissionsForGroup(string projectKey, string repositorySlug, string name = null)
        {
            Task<string> t = DeleteRevokeRepositoryPermissionsForGroupAsync(projectKey, repositorySlug, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Revoke all permissions for the specified repository for a group.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        ///  <p>
        ///  In addition, a user may not revoke a group's permissions if it will reduce their own permission level.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the name of the group</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteRevokeRepositoryPermissionsForGroupAsync(string projectKey, string repositorySlug, string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/permissions/groups");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Promote or demote a user's permission level for the specified repository. Available repository permissions are:
        ///  <ul>
        ///      <li>REPO_READ</li>
        ///      <li>REPO_WRITE</li>
        ///      <li>REPO_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+repository">Stash documentation</a>
        ///  for a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource. In addition, a user may not reduce their own permission level unless
        ///  they have a project or global permission that already implies that permission.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the names of the users</param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetRepositoryPermissionForUser(
                string projectKey,
                string repositorySlug,
                string name = null,
                string permission = null)
        {
            Task<string> t = UpdateSetRepositoryPermissionForUserAsync(projectKey, repositorySlug, name, permission);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Promote or demote a user's permission level for the specified repository. Available repository permissions are:
        ///  <ul>
        ///      <li>REPO_READ</li>
        ///      <li>REPO_WRITE</li>
        ///      <li>REPO_ADMIN</li>
        ///  </ul>
        ///  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+repository">Stash documentation</a>
        ///  for a detailed explanation of what each permission entails.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource. In addition, a user may not reduce their own permission level unless
        ///  they have a project or global permission that already implies that permission.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the names of the users</param>
        /// <param name="permission">Optional parameter: the permission to grant</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetRepositoryPermissionForUserAsync(
                string projectKey,
                string repositorySlug,
                string name = null,
                string permission = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/permissions/users");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Retrieve a page of users that have been granted at least one permission for the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryUsersWithAnyPermission(string projectKey, string repositorySlug, string filter = null)
        {
            Task<string> t = GetRepositoryUsersWithAnyPermissionAsync(projectKey, repositorySlug, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of users that have been granted at least one permission for the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryUsersWithAnyPermissionAsync(string projectKey, string repositorySlug, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/permissions/users");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Revoke all permissions for the specified repository for a user.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        ///  <p>
        ///  In addition, a user may not revoke their own repository permissions if they do not have a higher
        ///  project or global permission.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the name of the user</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteRevokeRepositoryPermissionsForUser(string projectKey, string repositorySlug, string name = null)
        {
            Task<string> t = DeleteRevokeRepositoryPermissionsForUserAsync(projectKey, repositorySlug, name);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Revoke all permissions for the specified repository for a user.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        ///  <p>
        ///  In addition, a user may not revoke their own repository permissions if they do not have a higher
        ///  project or global permission.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="name">Optional parameter: the name of the user</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteRevokeRepositoryPermissionsForUserAsync(string projectKey, string repositorySlug, string name = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/permissions/users");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Retrieve a page of groups that have no granted permissions for the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryGroupsWithoutAnyPermission(string projectKey, string repositorySlug, string filter = null)
        {
            Task<string> t = GetRepositoryGroupsWithoutAnyPermissionAsync(projectKey, repositorySlug, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of groups that have no granted permissions for the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryGroupsWithoutAnyPermissionAsync(string projectKey, string repositorySlug, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/permissions/groups/none");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Retrieve a page of <i>licensed</i> users that have no granted permissions for the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryUsersWithoutPermission(string projectKey, string repositorySlug, string filter = null)
        {
            Task<string> t = GetRepositoryUsersWithoutPermissionAsync(projectKey, repositorySlug, filter);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of <i>licensed</i> users that have no granted permissions for the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
        ///  project or global permission to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filter">Optional parameter: if specified only group names containing the supplied string will be returned</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryUsersWithoutPermissionAsync(string projectKey, string repositorySlug, string filter = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/permissions/users/none");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Retrieve a page of commits from a given starting commit or "between" two commits. If no explicit commit is
        ///  specified, the tip of the repository's default branch is assumed. commits may be identified by branch or tag
        ///  name or by ID. A path may be supplied to restrict the returned commits to only those which affect that path.
        ///  <p>
        ///  The authenticated user must have <b>REPO_READ</b> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Optional parameter: an optional path to filter commits by</param>
        /// <param name="since">Optional parameter: the commit ID or ref (exclusively) to retrieve commits after</param>
        /// <param name="until">Optional parameter: the commit ID (SHA1) or ref (inclusively) to retrieve commits before</param>
        /// <param name="withCounts">Optional parameter: optionally include the total number of commits and total number of unique authors</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryCommits(
                string projectKey,
                string repositorySlug,
                string path = null,
                string since = null,
                string until = null,
                bool? withCounts = false)
        {
            Task<string> t = GetRepositoryCommitsAsync(projectKey, repositorySlug, path, since, until, withCounts);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of commits from a given starting commit or "between" two commits. If no explicit commit is
        ///  specified, the tip of the repository's default branch is assumed. commits may be identified by branch or tag
        ///  name or by ID. A path may be supplied to restrict the returned commits to only those which affect that path.
        ///  <p>
        ///  The authenticated user must have <b>REPO_READ</b> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Optional parameter: an optional path to filter commits by</param>
        /// <param name="since">Optional parameter: the commit ID or ref (exclusively) to retrieve commits after</param>
        /// <param name="until">Optional parameter: the commit ID (SHA1) or ref (inclusively) to retrieve commits before</param>
        /// <param name="withCounts">Optional parameter: optionally include the total number of commits and total number of unique authors</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryCommitsAsync(
                string projectKey,
                string repositorySlug,
                string path = null,
                string since = null,
                string until = null,
                bool? withCounts = false)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "path", path },
                { "since", since },
                { "until", until },
                { "withCounts", (null != withCounts) ? withCounts : false }
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
        /// Retrieve the tags matching the supplied <strong>filterText</strong> param.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the context repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filterText">Optional parameter: the text to match on</param>
        /// <param name="orderBy">Optional parameter: ordering of refs either ALPHABETICAL (by name) or MODIFICATION (last updated)</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryTags(
                string projectKey,
                string repositorySlug,
                string filterText = null,
                string orderBy = null)
        {
            Task<string> t = GetRepositoryTagsAsync(projectKey, repositorySlug, filterText, orderBy);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the tags matching the supplied <strong>filterText</strong> param.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the context repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="filterText">Optional parameter: the text to match on</param>
        /// <param name="orderBy">Optional parameter: ordering of refs either ALPHABETICAL (by name) or MODIFICATION (last updated)</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryTagsAsync(
                string projectKey,
                string repositorySlug,
                string filterText = null,
                string orderBy = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/tags");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "filterText", filterText },
                { "orderBy", orderBy }
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
        /// Retrieve a page of repositories based on query parameters that control the search. See the documentation of the
        ///  parameters for more details.
        ///  <p>
        ///  This resource is anonymously accessible.
        ///  <p>
        ///  <b>Note on permissions.</b> In absence of the {@code permission} query parameter the implicit 'read' permission
        ///  is assumed. Please note that this permission is lower than the REPO_READ permission rather than being equal to
        ///  it. The implicit 'read' permission for a given repository is assigned to any user that has any of the higher
        ///  permissions, such as <tt>REPO_READ</tt>, as well as to anonymous users if the repository is marked as public.
        ///  The important implication of the above is that an anonymous request to this resource with a permission level
        ///  <tt>REPO_READ</tt> is guaranteed to receive an empty list of repositories as a result. For anonymous requests
        ///  it is therefore recommended to not specify the <tt>permission</tt> parameter at all.
        /// </summary>
        /// <param name="name">Optional parameter: (optional) if specified, this will limit the resulting repository list to ones whose name                     matches this parameter's value. The match will be done case-insensitive and any leading                     and/or trailing whitespace characters on the <code>name</code> parameter will be stripped.</param>
        /// <param name="projectname">Optional parameter: (optional) if specified, this will limit the resulting repository list to ones whose project's                     name matches this parameter's value. The match will be done case-insensitive and any leading                     and/or trailing whitespace characters on the <code>projectname</code> parameter will                     be stripped.</param>
        /// <param name="permission">Optional parameter: (optional) if specified, it must be a valid repository permission level name and will limit                     the resulting repository list to ones that the requesting user has the specified permission                     level to. If not specified, the default implicit 'read' permission level will be assumed. The                     currently supported explicit permission values are <tt>REPO_READ</tt>, <tt>REPO_WRITE</tt>                     and <tt>REPO_ADMIN</tt>.</param>
        /// <param name="visibility">Optional parameter: (optional) if specified, this will limit the resulting repository list based on the                     repositories visibility. Valid values are <em>public</em> or <em>private</em>.</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositories(
                string name = null,
                string projectname = null,
                string permission = null,
                string visibility = null)
        {
            Task<string> t = GetRepositoriesAsync(name, projectname, permission, visibility);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of repositories based on query parameters that control the search. See the documentation of the
        ///  parameters for more details.
        ///  <p>
        ///  This resource is anonymously accessible.
        ///  <p>
        ///  <b>Note on permissions.</b> In absence of the {@code permission} query parameter the implicit 'read' permission
        ///  is assumed. Please note that this permission is lower than the REPO_READ permission rather than being equal to
        ///  it. The implicit 'read' permission for a given repository is assigned to any user that has any of the higher
        ///  permissions, such as <tt>REPO_READ</tt>, as well as to anonymous users if the repository is marked as public.
        ///  The important implication of the above is that an anonymous request to this resource with a permission level
        ///  <tt>REPO_READ</tt> is guaranteed to receive an empty list of repositories as a result. For anonymous requests
        ///  it is therefore recommended to not specify the <tt>permission</tt> parameter at all.
        /// </summary>
        /// <param name="name">Optional parameter: (optional) if specified, this will limit the resulting repository list to ones whose name                     matches this parameter's value. The match will be done case-insensitive and any leading                     and/or trailing whitespace characters on the <code>name</code> parameter will be stripped.</param>
        /// <param name="projectname">Optional parameter: (optional) if specified, this will limit the resulting repository list to ones whose project's                     name matches this parameter's value. The match will be done case-insensitive and any leading                     and/or trailing whitespace characters on the <code>projectname</code> parameter will                     be stripped.</param>
        /// <param name="permission">Optional parameter: (optional) if specified, it must be a valid repository permission level name and will limit                     the resulting repository list to ones that the requesting user has the specified permission                     level to. If not specified, the default implicit 'read' permission level will be assumed. The                     currently supported explicit permission values are <tt>REPO_READ</tt>, <tt>REPO_WRITE</tt>                     and <tt>REPO_ADMIN</tt>.</param>
        /// <param name="visibility">Optional parameter: (optional) if specified, this will limit the resulting repository list based on the                     repositories visibility. Valid values are <em>public</em> or <em>private</em>.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoriesAsync(
                string name = null,
                string projectname = null,
                string permission = null,
                string visibility = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/repos");

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "name", name },
                { "projectname", projectname },
                { "permission", permission },
                { "visibility", visibility }
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
        /// Retrieve a page of files from particular directory of a repository. The search is done recursively, so all files
        ///  from any sub-directory of the specified directory will be returned.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="at">Optional parameter: the changeset id or ref (e.g. a branch or tag) to list the files at.              If not specified the default branch will be used instead.</param>
        /// <return>Returns the string response from the API call</return>
        public string ListRepositoryFiles(string projectKey, string repositorySlug, string at = null)
        {
            Task<string> t = ListRepositoryFilesAsync(projectKey, repositorySlug, at);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of files from particular directory of a repository. The search is done recursively, so all files
        ///  from any sub-directory of the specified directory will be returned.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="at">Optional parameter: the changeset id or ref (e.g. a branch or tag) to list the files at.              If not specified the default branch will be used instead.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListRepositoryFilesAsync(string projectKey, string repositorySlug, string at = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/files");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "at", at }
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
        /// Retrieve a page of files from particular directory of a repository. The search is done recursively, so all files
        ///  from any sub-directory of the specified directory will be returned.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the directory to list files for.</param>
        /// <param name="at">Optional parameter: the changeset id or ref (e.g. a branch or tag) to list the files at.              If not specified the default branch will be used instead.</param>
        /// <return>Returns the string response from the API call</return>
        public string ListRepositoryFilesByPath(
                string projectKey,
                string repositorySlug,
                string path,
                string at = null)
        {
            Task<string> t = ListRepositoryFilesByPathAsync(projectKey, repositorySlug, path, at);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of files from particular directory of a repository. The search is done recursively, so all files
        ///  from any sub-directory of the specified directory will be returned.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the directory to list files for.</param>
        /// <param name="at">Optional parameter: the changeset id or ref (e.g. a branch or tag) to list the files at.              If not specified the default branch will be used instead.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListRepositoryFilesByPathAsync(
                string projectKey,
                string repositorySlug,
                string path,
                string at = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/files/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "path", path }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "at", at }
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
        /// Create a new repository. Requires an existing project in which this repository will be created.
        ///  The only parameters which will be used are name and scmId.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the context project to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateRepository(object mdynamic, string projectKey)
        {
            Task<string> t = CreateRepositoryAsync(mdynamic, projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new repository. Requires an existing project in which this repository will be created.
        ///  The only parameters which will be used are name and scmId.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the context project to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateRepositoryAsync(object mdynamic, string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos");

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
        /// Schedule the repository matching the supplied <strong>projectKey</strong> and <strong>repositorySlug</strong> to
        ///  be deleted. If the request repository is not present
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="repositorySlug">Required parameter: the repository slug</param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteRepository(string repositorySlug, string projectKey)
        {
            Task<string> t = DeleteRepositoryAsync(repositorySlug, projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Schedule the repository matching the supplied <strong>projectKey</strong> and <strong>repositorySlug</strong> to
        ///  be deleted. If the request repository is not present
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="repositorySlug">Required parameter: the repository slug</param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteRepositoryAsync(string repositorySlug, string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "repositorySlug", repositorySlug },
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
        /// Create a new repository forked from an existing repository.
        ///  <p>
        ///  The JSON body for this {@code POST} is not required to contain <i>any</i> properties. Even the name may be
        ///  omitted. The following properties will be used, if provided:
        ///  <ul>
        ///      <li>{@code "name":"Fork name"} - Specifies the forked repository's name
        ///      <ul>
        ///          <li>Defaults to the name of the origin repository if not specified</li>
        ///      </ul>
        ///      </li>
        ///      <li>{@code "project":{"key":"TARGET_KEY"}} - Specifies the forked repository's target project by key
        ///      <ul>
        ///          <li>Defaults to the current user's personal project if not specified</li>
        ///      </ul>
        ///      </li>
        ///  </ul>
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository and
        ///  <strong>PROJECT_ADMIN</strong> on the target project to call this resource. Note that users <i>always</i>
        ///  have <b>PROJECT_ADMIN</b> permission on their personal projects.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: the repository slug</param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateForkRepository(object mdynamic, string repositorySlug, string projectKey)
        {
            Task<string> t = CreateForkRepositoryAsync(mdynamic, repositorySlug, projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new repository forked from an existing repository.
        ///  <p>
        ///  The JSON body for this {@code POST} is not required to contain <i>any</i> properties. Even the name may be
        ///  omitted. The following properties will be used, if provided:
        ///  <ul>
        ///      <li>{@code "name":"Fork name"} - Specifies the forked repository's name
        ///      <ul>
        ///          <li>Defaults to the name of the origin repository if not specified</li>
        ///      </ul>
        ///      </li>
        ///      <li>{@code "project":{"key":"TARGET_KEY"}} - Specifies the forked repository's target project by key
        ///      <ul>
        ///          <li>Defaults to the current user's personal project if not specified</li>
        ///      </ul>
        ///      </li>
        ///  </ul>
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository and
        ///  <strong>PROJECT_ADMIN</strong> on the target project to call this resource. Note that users <i>always</i>
        ///  have <b>PROJECT_ADMIN</b> permission on their personal projects.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: the repository slug</param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateForkRepositoryAsync(object mdynamic, string repositorySlug, string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "repositorySlug", repositorySlug },
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
        /// Retrieve the repository matching the supplied <strong>projectKey</strong> and <strong>repositorySlug</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="repositorySlug">Required parameter: the repository slug</param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepository(string repositorySlug, string projectKey)
        {
            Task<string> t = GetRepositoryAsync(repositorySlug, projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the repository matching the supplied <strong>projectKey</strong> and <strong>repositorySlug</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="repositorySlug">Required parameter: the repository slug</param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryAsync(string repositorySlug, string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "repositorySlug", repositorySlug },
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
        /// Update the repository matching the <strong>repositorySlug</strong> supplied in the resource path.
        ///  <p>
        ///  The repository's slug is derived from its name. If the name changes the slug may also change.
        ///  <p>
        ///  This API can be used to move the repository to a different project by setting the new project in the request,
        ///  example: {@code {"project":{"key":"NEW_KEY"}}} .
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: the repository slug</param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateRepository(object mdynamic, string repositorySlug, string projectKey)
        {
            Task<string> t = UpdateRepositoryAsync(mdynamic, repositorySlug, projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the repository matching the <strong>repositorySlug</strong> supplied in the resource path.
        ///  <p>
        ///  The repository's slug is derived from its name. If the name changes the slug may also change.
        ///  <p>
        ///  This API can be used to move the repository to a different project by setting the new project in the request,
        ///  example: {@code {"project":{"key":"NEW_KEY"}}} .
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: the repository slug</param>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateRepositoryAsync(object mdynamic, string repositorySlug, string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "repositorySlug", repositorySlug },
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
        /// Retrieve repositories which have been forked from this one. Unlike {@link #getRelatedRepositories(Repository,
        ///  PageRequest) related repositories}, this only looks at a given repository's direct forks. If those forks have
        ///  themselves been the origin of more forks, such "grandchildren" repositories will not be retrieved.
        ///  <p>
        ///  Only repositories to which the authenticated user has <b>REPO_READ</b> permission will be included, even
        ///  if other repositories have been forked from this one.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetForkedRepositories(string projectKey, string repositorySlug)
        {
            Task<string> t = GetForkedRepositoriesAsync(projectKey, repositorySlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve repositories which have been forked from this one. Unlike {@link #getRelatedRepositories(Repository,
        ///  PageRequest) related repositories}, this only looks at a given repository's direct forks. If those forks have
        ///  themselves been the origin of more forks, such "grandchildren" repositories will not be retrieved.
        ///  <p>
        ///  Only repositories to which the authenticated user has <b>REPO_READ</b> permission will be included, even
        ///  if other repositories have been forked from this one.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetForkedRepositoriesAsync(string projectKey, string repositorySlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/forks");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Retrieve repositories which are related to this one. Related repositories are from the same
        ///  {@link Repository#getHierarchyId() hierarchy} as this repository.
        ///  <p>
        ///  Only repositories to which the authenticated user has <b>REPO_READ</b> permission will be included, even
        ///  if more repositories are part of this repository's hierarchy.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetRelatedRepositories(string projectKey, string repositorySlug)
        {
            Task<string> t = GetRelatedRepositoriesAsync(projectKey, repositorySlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve repositories which are related to this one. Related repositories are from the same
        ///  {@link Repository#getHierarchyId() hierarchy} as this repository.
        ///  <p>
        ///  Only repositories to which the authenticated user has <b>REPO_READ</b> permission will be included, even
        ///  if more repositories are part of this repository's hierarchy.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRelatedRepositoriesAsync(string projectKey, string repositorySlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/related");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// If a create or fork operation fails, calling this method will clean up the broken repository and try again. The
        ///  repository must be in an INITIALISATION_FAILED state.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreateRetryCreateRepository(string projectKey, string repositorySlug)
        {
            Task<string> t = CreateRetryCreateRepositoryAsync(projectKey, repositorySlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// If a create or fork operation fails, calling this method will clean up the broken repository and try again. The
        ///  repository must be in an INITIALISATION_FAILED state.
        ///  <p>
        ///  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateRetryCreateRepositoryAsync(string projectKey, string repositorySlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/recreate");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
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
        /// Retrieve the diff for a specified file path between two provided revisions.
        ///  <p>
        ///  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
        ///  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
        ///  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
        ///  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="since">Optional parameter: the base revision to diff from. If omitted the parent revision of the until revision is used</param>
        /// <param name="srcPath">Optional parameter: the source path for the file, if it was copied, moved or renamed</param>
        /// <param name="until">Optional parameter: the target revision to diff to (required)</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryShowDiff(
                string projectKey,
                string repositorySlug,
                int? contextLines = -1,
                string since = null,
                string srcPath = null,
                string until = null,
                string whitespace = null)
        {
            Task<string> t = GetRepositoryShowDiffAsync(projectKey, repositorySlug, contextLines, since, srcPath, until, whitespace);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the diff for a specified file path between two provided revisions.
        ///  <p>
        ///  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
        ///  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
        ///  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
        ///  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="since">Optional parameter: the base revision to diff from. If omitted the parent revision of the until revision is used</param>
        /// <param name="srcPath">Optional parameter: the source path for the file, if it was copied, moved or renamed</param>
        /// <param name="until">Optional parameter: the target revision to diff to (required)</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryShowDiffAsync(
                string projectKey,
                string repositorySlug,
                int? contextLines = -1,
                string since = null,
                string srcPath = null,
                string until = null,
                string whitespace = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/diff");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "contextLines", (null != contextLines) ? contextLines : -1 },
                { "since", since },
                { "srcPath", srcPath },
                { "until", until },
                { "whitespace", whitespace }
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
        /// Retrieve the diff for a specified file path between two provided revisions.
        ///  <p>
        ///  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
        ///  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
        ///  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
        ///  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the path to the file which should be diffed (required)</param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="since">Optional parameter: the base revision to diff from. If omitted the parent revision of the until revision is used</param>
        /// <param name="srcPath">Optional parameter: the source path for the file, if it was copied, moved or renamed</param>
        /// <param name="until">Optional parameter: the target revision to diff to (required)</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryShowDiffByPath(
                string projectKey,
                string repositorySlug,
                string path,
                int? contextLines = -1,
                string since = null,
                string srcPath = null,
                string until = null,
                string whitespace = null)
        {
            Task<string> t = GetRepositoryShowDiffByPathAsync(projectKey, repositorySlug, path, contextLines, since, srcPath, until, whitespace);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the diff for a specified file path between two provided revisions.
        ///  <p>
        ///  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
        ///  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
        ///  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
        ///  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the path to the file which should be diffed (required)</param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="since">Optional parameter: the base revision to diff from. If omitted the parent revision of the until revision is used</param>
        /// <param name="srcPath">Optional parameter: the source path for the file, if it was copied, moved or renamed</param>
        /// <param name="until">Optional parameter: the target revision to diff to (required)</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryShowDiffByPathAsync(
                string projectKey,
                string repositorySlug,
                string path,
                int? contextLines = -1,
                string since = null,
                string srcPath = null,
                string until = null,
                string whitespace = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/diff/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "path", path }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "contextLines", (null != contextLines) ? contextLines : -1 },
                { "since", since },
                { "srcPath", srcPath },
                { "until", until },
                { "whitespace", whitespace }
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
        /// Retrieve a page of content for a file path at a specified revision.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="at">Optional parameter: the changeset id or ref to retrieve the content for.</param>
        /// <param name="type">Optional parameter: if true only the type will be returned for the file path instead of the contents.</param>
        /// <param name="blame">Optional parameter: if present the blame will be returned for the file as well.</param>
        /// <param name="noContent">Optional parameter: if present and used with blame only the blame is retrieved instead of the contents.</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryContent(
                string projectKey,
                string repositorySlug,
                string at = null,
                bool? type = false,
                string blame = null,
                string noContent = null)
        {
            Task<string> t = GetRepositoryContentAsync(projectKey, repositorySlug, at, type, blame, noContent);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of content for a file path at a specified revision.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="at">Optional parameter: the changeset id or ref to retrieve the content for.</param>
        /// <param name="type">Optional parameter: if true only the type will be returned for the file path instead of the contents.</param>
        /// <param name="blame">Optional parameter: if present the blame will be returned for the file as well.</param>
        /// <param name="noContent">Optional parameter: if present and used with blame only the blame is retrieved instead of the contents.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryContentAsync(
                string projectKey,
                string repositorySlug,
                string at = null,
                bool? type = false,
                string blame = null,
                string noContent = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/browse");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "at", at },
                { "type", (null != type) ? type : false },
                { "blame", blame },
                { "noContent", noContent }
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
        /// Retrieve a page of content for a file path at a specified revision.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the file path to retrieve content from</param>
        /// <param name="at">Optional parameter: the changeset id or ref to retrieve the content for.</param>
        /// <param name="type">Optional parameter: if true only the type will be returned for the file path instead of the contents.</param>
        /// <param name="blame">Optional parameter: if present the blame will be returned for the file as well.</param>
        /// <param name="noContent">Optional parameter: if present and used with blame only the blame is retrieved instead of the contents.</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryContentByPath(
                string projectKey,
                string repositorySlug,
                string path,
                string at = null,
                bool? type = false,
                string blame = null,
                string noContent = null)
        {
            Task<string> t = GetRepositoryContentByPathAsync(projectKey, repositorySlug, path, at, type, blame, noContent);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of content for a file path at a specified revision.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the file path to retrieve content from</param>
        /// <param name="at">Optional parameter: the changeset id or ref to retrieve the content for.</param>
        /// <param name="type">Optional parameter: if true only the type will be returned for the file path instead of the contents.</param>
        /// <param name="blame">Optional parameter: if present the blame will be returned for the file as well.</param>
        /// <param name="noContent">Optional parameter: if present and used with blame only the blame is retrieved instead of the contents.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryContentByPathAsync(
                string projectKey,
                string repositorySlug,
                string path,
                string at = null,
                bool? type = false,
                string blame = null,
                string noContent = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/browse/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "path", path }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "at", at },
                { "type", (null != type) ? type : false },
                { "blame", blame },
                { "noContent", noContent }
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
        /// Add a new comment.
        ///  <p>
        ///  Comments can be added in a few places by setting different attributes:
        ///  <p>
        ///  General commit comment:
        ///  <pre>
        ///      {
        ///          "text": "An insightful general comment on a commit."
        ///      }
        ///      </pre>
        ///  Reply to a comment:
        ///  <pre>
        ///      {
        ///          "text": "A measured reply.",
        ///          "parent": {
        ///              "id": 1
        ///          }
        ///      }
        ///      </pre>
        ///  General file comment:
        ///  <pre>
        ///      {
        ///          "text": "An insightful general comment on a file.",
        ///          "anchor": {
        ///              "path": "path/to/file",
        ///              "srcPath": "path/to/file"
        ///          }
        ///      }
        ///      </pre>
        ///  File line comment:
        ///  <pre>
        ///      {
        ///          "text": "A pithy comment on a particular line within a file.",
        ///          "anchor": {
        ///              "line": 1,
        ///              "lineType": "CONTEXT",
        ///              "fileType": "FROM"
        ///              "path": "path/to/file",
        ///              "srcPath": "path/to/file"
        ///      }
        ///      }
        ///      </pre>
        ///  <strong>Note: general file comments are an experimental feature and may change in the near future!</strong>
        ///  <p>
        ///  For file and line comments, 'path' refers to the path of the file to which the comment should be applied and
        ///  'srcPath' refers to the path the that file used to have (only required for copies and moves).
        ///  <p>
        ///  For line comments, 'line' refers to the line in the diff that the comment should apply to. 'lineType' refers to
        ///  the type of diff hunk, which can be:
        ///  <ul>
        ///      <li>'ADDED' - for an added line;</li>
        ///      <li>'REMOVED' - for a removed line; or</li>
        ///      <li>'CONTEXT' - for a line that was unmodified but is in the vicinity of the diff.</li>
        ///  </ul>
        ///  'fileType' refers to the file of the diff to which the anchor should be attached - which is of relevance when
        ///  displaying the diff in a side-by-side way. Currently the supported values are:
        ///  <ul>
        ///      <li>'FROM' - the source file of the diff</li>
        ///      <li>'TO' - the destination file of the diff</li>
        ///  </ul>
        ///  If the current user is not a participant the user is added as one and updated to watch the commit.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
        ///  is in to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: Example: </param>
        /// <param name="since">Optional parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreateRepositoryCommitComment(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                string commitId,
                string since = null)
        {
            Task<string> t = CreateRepositoryCommitCommentAsync(mdynamic, projectKey, repositorySlug, commitId, since);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add a new comment.
        ///  <p>
        ///  Comments can be added in a few places by setting different attributes:
        ///  <p>
        ///  General commit comment:
        ///  <pre>
        ///      {
        ///          "text": "An insightful general comment on a commit."
        ///      }
        ///      </pre>
        ///  Reply to a comment:
        ///  <pre>
        ///      {
        ///          "text": "A measured reply.",
        ///          "parent": {
        ///              "id": 1
        ///          }
        ///      }
        ///      </pre>
        ///  General file comment:
        ///  <pre>
        ///      {
        ///          "text": "An insightful general comment on a file.",
        ///          "anchor": {
        ///              "path": "path/to/file",
        ///              "srcPath": "path/to/file"
        ///          }
        ///      }
        ///      </pre>
        ///  File line comment:
        ///  <pre>
        ///      {
        ///          "text": "A pithy comment on a particular line within a file.",
        ///          "anchor": {
        ///              "line": 1,
        ///              "lineType": "CONTEXT",
        ///              "fileType": "FROM"
        ///              "path": "path/to/file",
        ///              "srcPath": "path/to/file"
        ///      }
        ///      }
        ///      </pre>
        ///  <strong>Note: general file comments are an experimental feature and may change in the near future!</strong>
        ///  <p>
        ///  For file and line comments, 'path' refers to the path of the file to which the comment should be applied and
        ///  'srcPath' refers to the path the that file used to have (only required for copies and moves).
        ///  <p>
        ///  For line comments, 'line' refers to the line in the diff that the comment should apply to. 'lineType' refers to
        ///  the type of diff hunk, which can be:
        ///  <ul>
        ///      <li>'ADDED' - for an added line;</li>
        ///      <li>'REMOVED' - for a removed line; or</li>
        ///      <li>'CONTEXT' - for a line that was unmodified but is in the vicinity of the diff.</li>
        ///  </ul>
        ///  'fileType' refers to the file of the diff to which the anchor should be attached - which is of relevance when
        ///  displaying the diff in a side-by-side way. Currently the supported values are:
        ///  <ul>
        ///      <li>'FROM' - the source file of the diff</li>
        ///      <li>'TO' - the destination file of the diff</li>
        ///  </ul>
        ///  If the current user is not a participant the user is added as one and updated to watch the commit.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
        ///  is in to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: Example: </param>
        /// <param name="since">Optional parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateRepositoryCommitCommentAsync(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                string commitId,
                string since = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/comments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "commitId", commitId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "since", since }
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

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: Example: </param>
        /// <param name="path">Optional parameter: Example: </param>
        /// <param name="since">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetRepositoryCommitComments(
                string projectKey,
                string repositorySlug,
                string commitId,
                string path = null,
                string since = null)
        {
            Task<dynamic> t = GetRepositoryCommitCommentsAsync(projectKey, repositorySlug, commitId, path, since);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: Example: </param>
        /// <param name="path">Optional parameter: Example: </param>
        /// <param name="since">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetRepositoryCommitCommentsAsync(
                string projectKey,
                string repositorySlug,
                string commitId,
                string path = null,
                string since = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/comments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "commitId", commitId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "path", path },
                { "since", since }
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
        /// Update the text of a comment. Only the user who created a comment may update it.
        ///  <p>
        ///  <strong>Note:</strong> the supplied supplied JSON object must contain a <code>version</code> that must match
        ///  the server's version of the comment or the update will fail. To determine the current version of the comment,
        ///  the comment should be fetched from the server prior to the update. Look for the 'version' attribute in the
        ///  returned JSON structure.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
        ///  is in to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <param name="commentId">Required parameter: the ID of the comment to retrieve</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateRepositoryCommitComment(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                string commitId,
                long commentId)
        {
            Task<string> t = UpdateRepositoryCommitCommentAsync(mdynamic, projectKey, repositorySlug, commitId, commentId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the text of a comment. Only the user who created a comment may update it.
        ///  <p>
        ///  <strong>Note:</strong> the supplied supplied JSON object must contain a <code>version</code> that must match
        ///  the server's version of the comment or the update will fail. To determine the current version of the comment,
        ///  the comment should be fetched from the server prior to the update. Look for the 'version' attribute in the
        ///  returned JSON structure.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
        ///  is in to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <param name="commentId">Required parameter: the ID of the comment to retrieve</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateRepositoryCommitCommentAsync(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                string commitId,
                long commentId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/comments/{commentId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "commitId", commitId },
                { "commentId", commentId }
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
        /// Delete a commit comment. Anyone can delete their own comment. Only users with <strong>REPO_ADMIN</strong>
        ///  and above may delete comments created by other users. Comments which have replies <i>may not be deleted</i>,
        ///  regardless of the user's granted permissions.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
        ///  is in to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <param name="commentId">Required parameter: the ID of the comment to retrieve</param>
        /// <param name="version">Optional parameter: The expected version of the comment. This must match the server's version of the comment or                   the delete will fail. To determine the current version of the comment, the comment should be                   fetched from the server prior to the delete. Look for the 'version' attribute in the returned                   JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteRepositoryCommitComment(
                string projectKey,
                string repositorySlug,
                string commitId,
                long commentId,
                int? version = -1)
        {
            Task<string> t = DeleteRepositoryCommitCommentAsync(projectKey, repositorySlug, commitId, commentId, version);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete a commit comment. Anyone can delete their own comment. Only users with <strong>REPO_ADMIN</strong>
        ///  and above may delete comments created by other users. Comments which have replies <i>may not be deleted</i>,
        ///  regardless of the user's granted permissions.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
        ///  is in to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <param name="commentId">Required parameter: the ID of the comment to retrieve</param>
        /// <param name="version">Optional parameter: The expected version of the comment. This must match the server's version of the comment or                   the delete will fail. To determine the current version of the comment, the comment should be                   fetched from the server prior to the delete. Look for the 'version' attribute in the returned                   JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteRepositoryCommitCommentAsync(
                string projectKey,
                string repositorySlug,
                string commitId,
                long commentId,
                int? version = -1)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/comments/{commentId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "commitId", commitId },
                { "commentId", commentId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "version", (null != version) ? version : -1 }
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
        /// Retrieves a commit discussion comment.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
        ///  is in to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <param name="commentId">Required parameter: the ID of the comment to retrieve</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryCommitComment(
                string projectKey,
                string repositorySlug,
                string commitId,
                long commentId)
        {
            Task<string> t = GetRepositoryCommitCommentAsync(projectKey, repositorySlug, commitId, commentId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a commit discussion comment.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
        ///  is in to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <param name="commentId">Required parameter: the ID of the comment to retrieve</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryCommitCommentAsync(
                string projectKey,
                string repositorySlug,
                string commitId,
                long commentId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/comments/{commentId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "commitId", commitId },
                { "commentId", commentId }
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
        /// Retrieve a page of repository hooks for this repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="type">Optional parameter: the optional type to filter by. Valid values are <code>PRE_RECEIVE</code> or <code>POST_RECEIVE</code></param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryHooks(string projectKey, string repositorySlug, string type = null)
        {
            Task<string> t = GetRepositoryHooksAsync(projectKey, repositorySlug, type);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of repository hooks for this repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="type">Optional parameter: the optional type to filter by. Valid values are <code>PRE_RECEIVE</code> or <code>POST_RECEIVE</code></param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryHooksAsync(string projectKey, string repositorySlug, string type = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/settings/hooks");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "type", type }
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
        /// Modify the settings for a repository hook for this repositories.
        ///  <p>
        ///  The service will reject any settings which are too large, the current limit is 32KB once serialized.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateSetRepositoryHookSettings(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                string hookKey)
        {
            Task<string> t = UpdateSetRepositoryHookSettingsAsync(mdynamic, projectKey, repositorySlug, hookKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Modify the settings for a repository hook for this repositories.
        ///  <p>
        ///  The service will reject any settings which are too large, the current limit is 32KB once serialized.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateSetRepositoryHookSettingsAsync(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                string hookKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/settings/hooks/{hookKey}/settings");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "hookKey", hookKey }
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
        /// Retrieve the settings for a repository hook for this repositories.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryHookSettings(string projectKey, string repositorySlug, string hookKey)
        {
            Task<string> t = GetRepositoryHookSettingsAsync(projectKey, repositorySlug, hookKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the settings for a repository hook for this repositories.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryHookSettingsAsync(string projectKey, string repositorySlug, string hookKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/settings/hooks/{hookKey}/settings");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "hookKey", hookKey }
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
        /// Retrieve a repository hook for this repositories.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryHook(string projectKey, string repositorySlug, string hookKey)
        {
            Task<string> t = GetRepositoryHookAsync(projectKey, repositorySlug, hookKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a repository hook for this repositories.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryHookAsync(string projectKey, string repositorySlug, string hookKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/settings/hooks/{hookKey}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "hookKey", hookKey }
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
        /// Enable a repository hook for this repositories and optionally applying new configuration.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <param name="contentLength">Optional parameter: Example: 0</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdateEnableRepositoryHook(
                string projectKey,
                string repositorySlug,
                string hookKey,
                int? contentLength = 0)
        {
            Task<string> t = UpdateEnableRepositoryHookAsync(projectKey, repositorySlug, hookKey, contentLength);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Enable a repository hook for this repositories and optionally applying new configuration.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <param name="contentLength">Optional parameter: Example: 0</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdateEnableRepositoryHookAsync(
                string projectKey,
                string repositorySlug,
                string hookKey,
                int? contentLength = 0)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/settings/hooks/{hookKey}/enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "hookKey", hookKey }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "Content-Length", (null != contentLength) ? contentLength : 0 }
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
        /// Disable a repository hook for this repositories.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteDisableRepositoryHook(string projectKey, string repositorySlug, string hookKey)
        {
            Task<string> t = DeleteDisableRepositoryHookAsync(projectKey, repositorySlug, hookKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Disable a repository hook for this repositories.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="hookKey">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteDisableRepositoryHookAsync(string projectKey, string repositorySlug, string hookKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/settings/hooks/{hookKey}/enabled");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "hookKey", hookKey }
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
        /// Retrieve a page of changes made in a specified commit.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="since">Optional parameter: the commit to which <code>until</code> should be compared to produce a page of changes.                      If not specified the commit's first parent is assumed (if one exists)</param>
        /// <param name="until">Optional parameter: the commit to retrieve changes for</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryChanges(
                string projectKey,
                string repositorySlug,
                string since = null,
                string until = null)
        {
            Task<string> t = GetRepositoryChangesAsync(projectKey, repositorySlug, since, until);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of changes made in a specified commit.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="since">Optional parameter: the commit to which <code>until</code> should be compared to produce a page of changes.                      If not specified the commit's first parent is assumed (if one exists)</param>
        /// <param name="until">Optional parameter: the commit to retrieve changes for</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryChangesAsync(
                string projectKey,
                string repositorySlug,
                string since = null,
                string until = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/changes");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "since", since },
                { "until", until }
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
        /// Removes the authenticated user as a watcher for the specified commit.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository containing the commit
        ///  to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteUnwatchRepositoryCommit(string projectKey, string repositorySlug, string commitId)
        {
            Task<string> t = DeleteUnwatchRepositoryCommitAsync(projectKey, repositorySlug, commitId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Removes the authenticated user as a watcher for the specified commit.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository containing the commit
        ///  to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteUnwatchRepositoryCommitAsync(string projectKey, string repositorySlug, string commitId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/watch");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "commitId", commitId }
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
        /// Adds the authenticated user as a watcher for the specified commit.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository containing the commit
        ///  to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateWatchRepositoryCommit(string projectKey, string repositorySlug, string commitId)
        {
            Task<string> t = CreateWatchRepositoryCommitAsync(projectKey, repositorySlug, commitId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Adds the authenticated user as a watcher for the specified commit.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository containing the commit
        ///  to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateWatchRepositoryCommitAsync(string projectKey, string repositorySlug, string commitId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/watch");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "commitId", commitId }
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
        /// Retrieve the diff between two provided revisions.
        ///  <p>
        ///  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
        ///  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
        ///  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
        ///  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="since">Optional parameter: the base revision to diff from. If omitted the parent revision of the until revision is used</param>
        /// <param name="srcPath">Optional parameter: the source path for the file, if it was copied, moved or renamed</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <param name="withComments">Optional parameter: <code>true</code> to embed comments in the diff (the default); otherwise <code>false</code>                      to stream the diff without comments</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryCommitDiff(
                string projectKey,
                string repositorySlug,
                string commitId,
                int? contextLines = -1,
                string since = null,
                string srcPath = null,
                string whitespace = null,
                bool? withComments = true)
        {
            Task<string> t = GetRepositoryCommitDiffAsync(projectKey, repositorySlug, commitId, contextLines, since, srcPath, whitespace, withComments);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the diff between two provided revisions.
        ///  <p>
        ///  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
        ///  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
        ///  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
        ///  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="commitId">Required parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="since">Optional parameter: the base revision to diff from. If omitted the parent revision of the until revision is used</param>
        /// <param name="srcPath">Optional parameter: the source path for the file, if it was copied, moved or renamed</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <param name="withComments">Optional parameter: <code>true</code> to embed comments in the diff (the default); otherwise <code>false</code>                      to stream the diff without comments</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryCommitDiffAsync(
                string projectKey,
                string repositorySlug,
                string commitId,
                int? contextLines = -1,
                string since = null,
                string srcPath = null,
                string whitespace = null,
                bool? withComments = true)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/diff");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "commitId", commitId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "contextLines", (null != contextLines) ? contextLines : -1 },
                { "since", since },
                { "srcPath", srcPath },
                { "whitespace", whitespace },
                { "withComments", (null != withComments) ? withComments : true }
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
        /// Retrieve the diff between two provided revisions.
        ///  <p>
        ///  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
        ///  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
        ///  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
        ///  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the path to the file which should be diffed (optional)</param>
        /// <param name="commitId">Required parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="since">Optional parameter: the base revision to diff from. If omitted the parent revision of the until revision is used</param>
        /// <param name="srcPath">Optional parameter: the source path for the file, if it was copied, moved or renamed</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <param name="withComments">Optional parameter: <code>true</code> to embed comments in the diff (the default); otherwise <code>false</code>                      to stream the diff without comments</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositoryCommitDiffByPath(
                string projectKey,
                string repositorySlug,
                string path,
                string commitId,
                int? contextLines = -1,
                string since = null,
                string srcPath = null,
                string whitespace = null,
                bool? withComments = true)
        {
            Task<string> t = GetRepositoryCommitDiffByPathAsync(projectKey, repositorySlug, path, commitId, contextLines, since, srcPath, whitespace, withComments);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the diff between two provided revisions.
        ///  <p>
        ///  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
        ///  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
        ///  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
        ///  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the path to the file which should be diffed (optional)</param>
        /// <param name="commitId">Required parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="since">Optional parameter: the base revision to diff from. If omitted the parent revision of the until revision is used</param>
        /// <param name="srcPath">Optional parameter: the source path for the file, if it was copied, moved or renamed</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <param name="withComments">Optional parameter: <code>true</code> to embed comments in the diff (the default); otherwise <code>false</code>                      to stream the diff without comments</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoryCommitDiffByPathAsync(
                string projectKey,
                string repositorySlug,
                string path,
                string commitId,
                int? contextLines = -1,
                string since = null,
                string srcPath = null,
                string whitespace = null,
                bool? withComments = true)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/commits/{commitId}/diff/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "path", path },
                { "commitId", commitId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "contextLines", (null != contextLines) ? contextLines : -1 },
                { "since", since },
                { "srcPath", srcPath },
                { "whitespace", whitespace },
                { "withComments", (null != withComments) ? withComments : true }
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
        /// Retrieve repositories from the project corresponding to the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public string GetRepositories(string projectKey)
        {
            Task<string> t = GetRepositoriesAsync(projectKey);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve repositories from the project corresponding to the supplied <strong>projectKey</strong>.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified project to call this
        ///  resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: the parent project key</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetRepositoriesAsync(string projectKey)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos");

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

    }
} 