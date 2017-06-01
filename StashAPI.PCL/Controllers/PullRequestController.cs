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
    public partial class PullRequestController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PullRequestController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PullRequestController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PullRequestController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Make the authenticated user stop watching the specified pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteUnwatchPullRequest(string projectKey, string repositorySlug, long pullRequestId)
        {
            Task<string> t = DeleteUnwatchPullRequestAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Make the authenticated user stop watching the specified pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteUnwatchPullRequestAsync(string projectKey, string repositorySlug, long pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/watch");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Make the authenticated user watch the specified pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateWatchPullRequest(string projectKey, string repositorySlug, long pullRequestId)
        {
            Task<string> t = CreateWatchPullRequestAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Make the authenticated user watch the specified pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateWatchPullRequestAsync(string projectKey, string repositorySlug, long pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/watch");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Streams a diff within a pull request.
        ///  <p>
        ///  If the specified file has been copied, moved or renamed, the <code>srcPath</code> must also be specified to
        ///  produce the correct diff.
        ///  <p>
        ///  Note: This RESTful endpoint is currently <i>not paged</i>. The server will internally apply a hard cap to the
        ///  streamed lines, and it is not possible to request subsequent pages if that cap is exceeded.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="srcPath">Optional parameter: the previous path to the file, if the file has been copied, moved or renamed</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <param name="withComments">Optional parameter: <code>true</code> to embed comments in the diff (the default); otherwise, <code>false</code>                      to stream the diff without comments</param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequestDiff(
                string projectKey,
                string repositorySlug,
                string pullRequestId,
                int? contextLines = -1,
                string srcPath = null,
                string whitespace = null,
                bool? withComments = true)
        {
            Task<string> t = GetPullRequestDiffAsync(projectKey, repositorySlug, pullRequestId, contextLines, srcPath, whitespace, withComments);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Streams a diff within a pull request.
        ///  <p>
        ///  If the specified file has been copied, moved or renamed, the <code>srcPath</code> must also be specified to
        ///  produce the correct diff.
        ///  <p>
        ///  Note: This RESTful endpoint is currently <i>not paged</i>. The server will internally apply a hard cap to the
        ///  streamed lines, and it is not possible to request subsequent pages if that cap is exceeded.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="srcPath">Optional parameter: the previous path to the file, if the file has been copied, moved or renamed</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <param name="withComments">Optional parameter: <code>true</code> to embed comments in the diff (the default); otherwise, <code>false</code>                      to stream the diff without comments</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestDiffAsync(
                string projectKey,
                string repositorySlug,
                string pullRequestId,
                int? contextLines = -1,
                string srcPath = null,
                string whitespace = null,
                bool? withComments = true)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/diff");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "contextLines", (null != contextLines) ? contextLines : -1 },
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
        /// Streams a diff within a pull request.
        ///  <p>
        ///  If the specified file has been copied, moved or renamed, the <code>srcPath</code> must also be specified to
        ///  produce the correct diff.
        ///  <p>
        ///  Note: This RESTful endpoint is currently <i>not paged</i>. The server will internally apply a hard cap to the
        ///  streamed lines, and it is not possible to request subsequent pages if that cap is exceeded.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the path to the file which should be diffed (optional)</param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="srcPath">Optional parameter: the previous path to the file, if the file has been copied, moved or renamed</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <param name="withComments">Optional parameter: <code>true</code> to embed comments in the diff (the default); otherwise, <code>false</code>                      to stream the diff without comments</param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequestDiffByPath(
                string projectKey,
                string repositorySlug,
                string pullRequestId,
                string path,
                int? contextLines = -1,
                string srcPath = null,
                string whitespace = null,
                bool? withComments = true)
        {
            Task<string> t = GetPullRequestDiffByPathAsync(projectKey, repositorySlug, pullRequestId, path, contextLines, srcPath, whitespace, withComments);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Streams a diff within a pull request.
        ///  <p>
        ///  If the specified file has been copied, moved or renamed, the <code>srcPath</code> must also be specified to
        ///  produce the correct diff.
        ///  <p>
        ///  Note: This RESTful endpoint is currently <i>not paged</i>. The server will internally apply a hard cap to the
        ///  streamed lines, and it is not possible to request subsequent pages if that cap is exceeded.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="path">Required parameter: the path to the file which should be diffed (optional)</param>
        /// <param name="contextLines">Optional parameter: the number of context lines to include around added/removed lines in the diff</param>
        /// <param name="srcPath">Optional parameter: the previous path to the file, if the file has been copied, moved or renamed</param>
        /// <param name="whitespace">Optional parameter: optional whitespace flag which can be set to <code>ignore-all</code></param>
        /// <param name="withComments">Optional parameter: <code>true</code> to embed comments in the diff (the default); otherwise, <code>false</code>                      to stream the diff without comments</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestDiffByPathAsync(
                string projectKey,
                string repositorySlug,
                string pullRequestId,
                string path,
                int? contextLines = -1,
                string srcPath = null,
                string whitespace = null,
                bool? withComments = true)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/diff/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId },
                { "path", path }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "contextLines", (null != contextLines) ? contextLines : -1 },
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
        /// Retrieve changesets for the specified pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="withCounts">Optional parameter: if set to true, the service will add "authorCount" and "totalCount" at the end of the page.                      "authorCount" is the number of different authors and "totalCount" is the total number of changesets.</param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequestCommits(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                bool? withCounts = null)
        {
            Task<string> t = GetPullRequestCommitsAsync(projectKey, repositorySlug, pullRequestId, withCounts);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve changesets for the specified pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="withCounts">Optional parameter: if set to true, the service will add "authorCount" and "totalCount" at the end of the page.                      "authorCount" is the number of different authors and "totalCount" is the total number of changesets.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestCommitsAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                bool? withCounts = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/commits");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "withCounts", withCounts }
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
        /// Retrieve the tasks associated with a pull request.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequestTasks(string projectKey, string repositorySlug, string pullRequestId)
        {
            Task<string> t = GetPullRequestTasksAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the tasks associated with a pull request.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestTasksAsync(string projectKey, string repositorySlug, string pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/tasks");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Retrieve the total number of {@link com.atlassian.stash.task.TaskState#OPEN open} and
        ///  {@link com.atlassian.stash.task.TaskState#RESOLVED resolved} tasks associated with a pull request.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetCountPullRequestTasks(string projectKey, string repositorySlug, string pullRequestId)
        {
            Task<string> t = GetCountPullRequestTasksAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the total number of {@link com.atlassian.stash.task.TaskState#OPEN open} and
        ///  {@link com.atlassian.stash.task.TaskState#RESOLVED resolved} tasks associated with a pull request.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetCountPullRequestTasksAsync(string projectKey, string repositorySlug, string pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/tasks/count");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Add a new comment.
        ///  <p>
        ///  Comments can be added in a few places by setting different attributes:
        ///  <p>
        ///  General pull request comment:
        ///  <pre>
        ///      {
        ///          "text": "An insightful general comment on a pull request."
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
        ///          }
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
        ///  If the current user is not a participant the user is added as a watcher of the pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreatePullRequestComment(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                long pullRequestId)
        {
            Task<string> t = CreatePullRequestCommentAsync(mdynamic, projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Add a new comment.
        ///  <p>
        ///  Comments can be added in a few places by setting different attributes:
        ///  <p>
        ///  General pull request comment:
        ///  <pre>
        ///      {
        ///          "text": "An insightful general comment on a pull request."
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
        ///          }
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
        ///  If the current user is not a participant the user is added as a watcher of the pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreatePullRequestCommentAsync(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                long pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/comments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="path">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetPullRequestComments(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                string path = null)
        {
            Task<dynamic> t = GetPullRequestCommentsAsync(projectKey, repositorySlug, pullRequestId, path);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="path">Optional parameter: Example: </param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetPullRequestCommentsAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                string path = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/comments");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "path", path }
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
        ///  <strong>Note:</strong> the supplied supplied JSON object must contain a <code>version</code> that must match the
        ///  server's version of the comment or the update will fail. To determine the current version of
        ///  the comment, the comment should be fetched from the server prior to the update. Look for the
        ///  'version' attribute in the returned JSON structure.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="commentId">Required parameter: the id of the comment to retrieve</param>
        /// <return>Returns the string response from the API call</return>
        public string UpdatePullRequestComment(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                long commentId)
        {
            Task<string> t = UpdatePullRequestCommentAsync(mdynamic, projectKey, repositorySlug, pullRequestId, commentId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the text of a comment. Only the user who created a comment may update it.
        ///  <p>
        ///  <strong>Note:</strong> the supplied supplied JSON object must contain a <code>version</code> that must match the
        ///  server's version of the comment or the update will fail. To determine the current version of
        ///  the comment, the comment should be fetched from the server prior to the update. Look for the
        ///  'version' attribute in the returned JSON structure.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="commentId">Required parameter: the id of the comment to retrieve</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdatePullRequestCommentAsync(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                long commentId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/comments/{commentId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId },
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
        /// Delete a pull request comment. Anyone can delete their own comment. Only users with <strong>REPO_ADMIN</strong>
        ///  and above may delete comments created by other users.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="commentId">Required parameter: the id of the comment to retrieve</param>
        /// <param name="version">Optional parameter: The expected version of the comment. This must match the server's version of the comment or                       the delete will fail. To determine the current version of the comment, the comment should be                       fetched from the server prior to the delete. Look for the 'version' attribute in the                       returned JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public string DeletePullRequestComment(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                long commentId,
                int? version = -1)
        {
            Task<string> t = DeletePullRequestCommentAsync(projectKey, repositorySlug, pullRequestId, commentId, version);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Delete a pull request comment. Anyone can delete their own comment. Only users with <strong>REPO_ADMIN</strong>
        ///  and above may delete comments created by other users.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="commentId">Required parameter: the id of the comment to retrieve</param>
        /// <param name="version">Optional parameter: The expected version of the comment. This must match the server's version of the comment or                       the delete will fail. To determine the current version of the comment, the comment should be                       fetched from the server prior to the delete. Look for the 'version' attribute in the                       returned JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeletePullRequestCommentAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                long commentId,
                int? version = -1)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/comments/{commentId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId },
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
        /// Retrieves a pull request comment.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="commentId">Required parameter: the id of the comment to retrieve</param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequestComment(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                long commentId)
        {
            Task<string> t = GetPullRequestCommentAsync(projectKey, repositorySlug, pullRequestId, commentId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a pull request comment.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="commentId">Required parameter: the id of the comment to retrieve</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestCommentAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                long commentId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/comments/{commentId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId },
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
        /// Gets changes for the specified PullRequest.
        ///  <p>
        ///  Note: This resource is currently <i>not paged</i>. The server will return at most one page. The server will
        ///  truncate the number of changes to either the request's page limit or an internal maximum, whichever is smaller.
        ///  The start parameter of the page request is also ignored.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="withComments">Optional parameter: {@code true} to apply comment counts in the changes (the default); otherwise, {@code false}                      to stream changes without comment counts</param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequestChanges(
                string projectKey,
                string repositorySlug,
                string pullRequestId,
                bool? withComments = true)
        {
            Task<string> t = GetPullRequestChangesAsync(projectKey, repositorySlug, pullRequestId, withComments);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Gets changes for the specified PullRequest.
        ///  <p>
        ///  Note: This resource is currently <i>not paged</i>. The server will return at most one page. The server will
        ///  truncate the number of changes to either the request's page limit or an internal maximum, whichever is smaller.
        ///  The start parameter of the page request is also ignored.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="withComments">Optional parameter: {@code true} to apply comment counts in the changes (the default); otherwise, {@code false}                      to stream changes without comment counts</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestChangesAsync(
                string projectKey,
                string repositorySlug,
                string pullRequestId,
                bool? withComments = true)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/changes");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
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
        /// Retrieve a page of pull requests to or from the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call
        ///  this resource.
        ///  Optionally clients can specify PR participant filters. Each filter has a mandatory {@code username.N}
        ///  parameter, and the optional {@code role.N} and {@code approved.N} parameters.
        ///  <ul>
        ///      <li>
        ///          {@code username.N} - the "root" of a single participant filter, where "N" is a natural number
        ///          starting from 1. This allows clients to specify multiple participant filters, by providing consecutive
        ///          filters as {@code username.1}, {@code username.2} etc. Note that the filters numbering has to start
        ///          with 1 and be continuous for all filters to be processed. The total allowed number of participant
        ///          filters is 10 and all filters exceeding that limit will be dropped.
        ///      </li>
        ///      <li>
        ///          {@code role.N}(optional) the role associated with {@code username.N}.
        ///          This must be one of {@code AUTHOR}, {@code REVIEWER}, or{@code PARTICIPANT}
        ///      </li>
        ///      <li>
        ///          {@code approved.N}(optional) the approved status associated with {@code username.N}.
        ///          That is whether {@code username.N} has approved the PR. Either {@code true}, or {@code false}
        ///      </li>
        ///  </ul>
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="direction">Optional parameter: (optional, defaults to <strong>INCOMING</strong>) the direction relative to the specified                   repository. Either <strong>INCOMING</strong> or <strong>OUTGOING</strong>.</param>
        /// <param name="at">Optional parameter: (optional) a <i>fully-qualified</i> branch ID to find pull requests to or from,            such as {@code refs/heads/master}</param>
        /// <param name="state">Optional parameter: (optional, defaults to <strong>OPEN</strong>). Supply <strong>ALL</strong> to return pull request                in any state. If a state is supplied only pull requests in the specified state will be returned.                Either <strong>OPEN</strong>, <strong>DECLINED</strong> or <strong>MERGED</strong>.</param>
        /// <param name="order">Optional parameter: (optional) the order to return pull requests in, either <strong>OLDEST</strong> (as in: "oldest               first") or <strong>NEWEST</strong>.</param>
        /// <param name="withAttributes">Optional parameter: (optional) defaults to true, whether to return additional pull request attributes</param>
        /// <param name="withProperties">Optional parameter: (optional) defaults to true, whether to return additional pull request properties</param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequests(
                string projectKey,
                string repositorySlug,
                string direction = "incoming",
                string at = null,
                string state = null,
                string order = null,
                bool? withAttributes = true,
                bool? withProperties = true)
        {
            Task<string> t = GetPullRequestsAsync(projectKey, repositorySlug, direction, at, state, order, withAttributes, withProperties);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of pull requests to or from the specified repository.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call
        ///  this resource.
        ///  Optionally clients can specify PR participant filters. Each filter has a mandatory {@code username.N}
        ///  parameter, and the optional {@code role.N} and {@code approved.N} parameters.
        ///  <ul>
        ///      <li>
        ///          {@code username.N} - the "root" of a single participant filter, where "N" is a natural number
        ///          starting from 1. This allows clients to specify multiple participant filters, by providing consecutive
        ///          filters as {@code username.1}, {@code username.2} etc. Note that the filters numbering has to start
        ///          with 1 and be continuous for all filters to be processed. The total allowed number of participant
        ///          filters is 10 and all filters exceeding that limit will be dropped.
        ///      </li>
        ///      <li>
        ///          {@code role.N}(optional) the role associated with {@code username.N}.
        ///          This must be one of {@code AUTHOR}, {@code REVIEWER}, or{@code PARTICIPANT}
        ///      </li>
        ///      <li>
        ///          {@code approved.N}(optional) the approved status associated with {@code username.N}.
        ///          That is whether {@code username.N} has approved the PR. Either {@code true}, or {@code false}
        ///      </li>
        ///  </ul>
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="direction">Optional parameter: (optional, defaults to <strong>INCOMING</strong>) the direction relative to the specified                   repository. Either <strong>INCOMING</strong> or <strong>OUTGOING</strong>.</param>
        /// <param name="at">Optional parameter: (optional) a <i>fully-qualified</i> branch ID to find pull requests to or from,            such as {@code refs/heads/master}</param>
        /// <param name="state">Optional parameter: (optional, defaults to <strong>OPEN</strong>). Supply <strong>ALL</strong> to return pull request                in any state. If a state is supplied only pull requests in the specified state will be returned.                Either <strong>OPEN</strong>, <strong>DECLINED</strong> or <strong>MERGED</strong>.</param>
        /// <param name="order">Optional parameter: (optional) the order to return pull requests in, either <strong>OLDEST</strong> (as in: "oldest               first") or <strong>NEWEST</strong>.</param>
        /// <param name="withAttributes">Optional parameter: (optional) defaults to true, whether to return additional pull request attributes</param>
        /// <param name="withProperties">Optional parameter: (optional) defaults to true, whether to return additional pull request properties</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestsAsync(
                string projectKey,
                string repositorySlug,
                string direction = "incoming",
                string at = null,
                string state = null,
                string order = null,
                bool? withAttributes = true,
                bool? withProperties = true)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "direction", (null != direction) ? direction : "incoming" },
                { "at", at },
                { "state", state },
                { "order", order },
                { "withAttributes", (null != withAttributes) ? withAttributes : true },
                { "withProperties", (null != withProperties) ? withProperties : true }
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
        /// Create a new pull request between two branches. The branches may be in the same repository, or different ones.
        ///  When using different repositories, they must still be in the same {@link Repository#getHierarchyId() hierarchy}.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the "from" and "to"repositories to
        ///  call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string CreatePullRequest(object mdynamic, string projectKey, string repositorySlug)
        {
            Task<string> t = CreatePullRequestAsync(mdynamic, projectKey, repositorySlug);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Create a new pull request between two branches. The branches may be in the same repository, or different ones.
        ///  When using different repositories, they must still be in the same {@link Repository#getHierarchyId() hierarchy}.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the "from" and "to"repositories to
        ///  call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreatePullRequestAsync(object mdynamic, string projectKey, string repositorySlug)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests");

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
        /// Decline a pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="version">Optional parameter: the current version of the pull request. If the server's version isn't the same as the specified                 version the operation will fail. To determine the current version of the pull request it should be                 fetched from the server prior to this operation. Look for the 'version' attribute in the returned                 JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateDeclinePullRequest(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                int? version = -1)
        {
            Task<string> t = CreateDeclinePullRequestAsync(projectKey, repositorySlug, pullRequestId, version);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Decline a pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <param name="version">Optional parameter: the current version of the pull request. If the server's version isn't the same as the specified                 version the operation will fail. To determine the current version of the pull request it should be                 fetched from the server prior to this operation. Look for the 'version' attribute in the returned                 JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateDeclinePullRequestAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                int? version = -1)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/decline");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Retrieve a page of activity associated with a pull request.
        ///  <p>
        ///  Activity items include comments, approvals, rescopes (i.e. adding and removing of commits), merges and more.
        ///  <p>
        ///  Different types of activity items may be introduced in newer versions of Stash or by user installed plugins, so
        ///  clients should be flexible enough to handle unexpected entity shapes in the returned page.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="fromId">Optional parameter: (optional) the id of the activity item to use as the first item in the returned page</param>
        /// <param name="fromType">Optional parameter: (required if <strong>fromId</strong> is present) the type of the activity item specified by                  <strong>fromId</strong> (either <strong>COMMENT</strong> or <strong>ACTIVITY</strong>)</param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequestActivities(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                long? fromId = null,
                string fromType = null)
        {
            Task<string> t = GetPullRequestActivitiesAsync(projectKey, repositorySlug, pullRequestId, fromId, fromType);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a page of activity associated with a pull request.
        ///  <p>
        ///  Activity items include comments, approvals, rescopes (i.e. adding and removing of commits), merges and more.
        ///  <p>
        ///  Different types of activity items may be introduced in newer versions of Stash or by user installed plugins, so
        ///  clients should be flexible enough to handle unexpected entity shapes in the returned page.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="fromId">Optional parameter: (optional) the id of the activity item to use as the first item in the returned page</param>
        /// <param name="fromType">Optional parameter: (required if <strong>fromId</strong> is present) the type of the activity item specified by                  <strong>fromId</strong> (either <strong>COMMENT</strong> or <strong>ACTIVITY</strong>)</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestActivitiesAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                long? fromId = null,
                string fromType = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/activities");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "fromId", fromId },
                { "fromType", fromType }
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
        /// Re-open a declined pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="version">Optional parameter: the current version of the pull request. If the server's version isn't the same as the specified                 version the operation will fail. To determine the current version of the pull request it should be                 fetched from the server prior to this operation. Look for the 'version' attribute in the returned                 JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateReopenPullRequest(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                int? version = -1)
        {
            Task<string> t = CreateReopenPullRequestAsync(projectKey, repositorySlug, pullRequestId, version);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Re-open a declined pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="version">Optional parameter: the current version of the pull request. If the server's version isn't the same as the specified                 version the operation will fail. To determine the current version of the pull request it should be                 fetched from the server prior to this operation. Look for the 'version' attribute in the returned                 JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateReopenPullRequestAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                int? version = -1)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/reopen");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Test whether a pull request can be merged.
        ///  <p>
        ///  A pull request may not be merged if:
        ///  <ul>
        ///      <li>there are conflicts that need to be manually resolved before merging; and/or</li>
        ///      <li>one or more merge checks have vetoed the merge.</li>
        ///  </ul>
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string GetCanMergePullRequest(string projectKey, string repositorySlug, long pullRequestId)
        {
            Task<string> t = GetCanMergePullRequestAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Test whether a pull request can be merged.
        ///  <p>
        ///  A pull request may not be merged if:
        ///  <ul>
        ///      <li>there are conflicts that need to be manually resolved before merging; and/or</li>
        ///      <li>one or more merge checks have vetoed the merge.</li>
        ///  </ul>
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetCanMergePullRequestAsync(string projectKey, string repositorySlug, long pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/merge");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Merge the specified pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="version">Optional parameter: the current version of the pull request. If the server's version isn't the same as the specified                 version the operation will fail. To determine the current version of the pull request it should be                 fetched from the server prior to this operation. Look for the 'version' attribute in the returned                 JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateMergePullRequest(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                int? version = -1)
        {
            Task<string> t = CreateMergePullRequestAsync(projectKey, repositorySlug, pullRequestId, version);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Merge the specified pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="version">Optional parameter: the current version of the pull request. If the server's version isn't the same as the specified                 version the operation will fail. To determine the current version of the pull request it should be                 fetched from the server prior to this operation. Look for the 'version' attribute in the returned                 JSON structure.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateMergePullRequestAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                int? version = -1)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/merge");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Retrieve a pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string GetPullRequest(string projectKey, string repositorySlug, string pullRequestId)
        {
            Task<string> t = GetPullRequestAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> GetPullRequestAsync(string projectKey, string repositorySlug, string pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Update the title, description, reviewers or destination branch of an existing pull request.
        ///  <p>
        ///  <strong>Note:</strong> the <em>reviewers</em> list may be updated using this resource. However the
        ///  <em>author</em> and <em>participants</em> list may not.
        ///  <p>
        ///  The authenticated user must either:
        ///  <ul>
        ///      <li>be the author of the pull request and have the <strong>REPO_READ</strong> permission for the repository
        ///      that this pull request targets; or</li>
        ///      <li>have the <strong>REPO_WRITE</strong> permission for the repository that this pull request targets</li>
        ///  </ul>
        ///  to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public string UpdatePullRequest(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                string pullRequestId)
        {
            Task<string> t = UpdatePullRequestAsync(mdynamic, projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Update the title, description, reviewers or destination branch of an existing pull request.
        ///  <p>
        ///  <strong>Note:</strong> the <em>reviewers</em> list may be updated using this resource. However the
        ///  <em>author</em> and <em>participants</em> list may not.
        ///  <p>
        ///  The authenticated user must either:
        ///  <ul>
        ///      <li>be the author of the pull request and have the <strong>REPO_READ</strong> permission for the repository
        ///      that this pull request targets; or</li>
        ///      <li>have the <strong>REPO_WRITE</strong> permission for the repository that this pull request targets</li>
        ///  </ul>
        ///  to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: Example: </param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> UpdatePullRequestAsync(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                string pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Assigns a participant to an explicit role in pull request. Currently only the REVIEWER role may be assigned.
        ///  <p>
        ///  If the user is not yet a participant in the pull request, they are made one and assigned the supplied role.
        ///  <p>
        ///  If the user is already a participant in the pull request, their previous role is replaced with the supplied role
        ///  unless they are already assigned the AUTHOR role which cannot be changed and will result in a Bad Request (400)
        ///  response code.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateAssignPullRequestParticipantRole(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                long pullRequestId)
        {
            Task<string> t = CreateAssignPullRequestParticipantRoleAsync(mdynamic, projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Assigns a participant to an explicit role in pull request. Currently only the REVIEWER role may be assigned.
        ///  <p>
        ///  If the user is not yet a participant in the pull request, they are made one and assigned the supplied role.
        ///  <p>
        ///  If the user is already a participant in the pull request, their previous role is replaced with the supplied role
        ///  unless they are already assigned the AUTHOR role which cannot be changed and will result in a Bad Request (400)
        ///  response code.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="mdynamic">Required parameter: Example: </param>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateAssignPullRequestParticipantRoleAsync(
                object mdynamic,
                string projectKey,
                string repositorySlug,
                long pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/participants");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Unassigns a participant from the REVIEWER role they may have been given in a pull request.
        ///  <p>
        ///  If the participant has no explicit role this method has no effect.
        ///  <p>
        ///  Afterwards, the user will still remain a participant in the pull request but their role will be reduced to
        ///  PARTICIPANT. This is because once made a participant of a pull request,
        ///  a user will forever remain a participant. Only their role may be altered.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="username">Optional parameter: the participant's user name</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteUnassignPullRequestParticipantRole(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                string username = null)
        {
            Task<string> t = DeleteUnassignPullRequestParticipantRoleAsync(projectKey, repositorySlug, pullRequestId, username);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Unassigns a participant from the REVIEWER role they may have been given in a pull request.
        ///  <p>
        ///  If the participant has no explicit role this method has no effect.
        ///  <p>
        ///  Afterwards, the user will still remain a participant in the pull request but their role will be reduced to
        ///  PARTICIPANT. This is because once made a participant of a pull request,
        ///  a user will forever remain a participant. Only their role may be altered.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <param name="username">Optional parameter: the participant's user name</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteUnassignPullRequestParticipantRoleAsync(
                string projectKey,
                string repositorySlug,
                long pullRequestId,
                string username = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/participants");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "username", username }
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
        /// Retrieves a page of the participants for a given pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string ListPullRequestParticipants(string projectKey, string repositorySlug, long pullRequestId)
        {
            Task<string> t = ListPullRequestParticipantsAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieves a page of the participants for a given pull request.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> ListPullRequestParticipantsAsync(string projectKey, string repositorySlug, long pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/participants");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Approve a pull request as the current user. Implicitly adds the user as a participant if they are not already.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateApprovePullRequest(string projectKey, string repositorySlug, long pullRequestId)
        {
            Task<string> t = CreateApprovePullRequestAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Approve a pull request as the current user. Implicitly adds the user as a participant if they are not already.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateApprovePullRequestAsync(string projectKey, string repositorySlug, long pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/approve");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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
        /// Remove approval from a pull request as the current user. This does not remove the user as a participant.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public string DeleteWithdrawPullRequestApproval(string projectKey, string repositorySlug, long pullRequestId)
        {
            Task<string> t = DeleteWithdrawPullRequestApprovalAsync(projectKey, repositorySlug, pullRequestId);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove approval from a pull request as the current user. This does not remove the user as a participant.
        ///  <p>
        ///  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
        ///  targets to call this resource.
        /// </summary>
        /// <param name="projectKey">Required parameter: Example: </param>
        /// <param name="repositorySlug">Required parameter: Example: </param>
        /// <param name="pullRequestId">Required parameter: the id of the pull request within the repository</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> DeleteWithdrawPullRequestApprovalAsync(string projectKey, string repositorySlug, long pullRequestId)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.StashDomain);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/1.0/projects/{projectKey}/repos/{repositorySlug}/pull-requests/{pullRequestId}/approve");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "projectKey", projectKey },
                { "repositorySlug", repositorySlug },
                { "pullRequestId", pullRequestId }
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

    }
} 