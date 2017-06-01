/*
 * StashAPI.PCL
 *
 * This file was automatically generated for DS by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using StashAPI.PCL.Controllers;
using StashAPI.PCL.Http.Client;

namespace StashAPI.PCL
{
    public partial class StashAPIClient
    {

        /// <summary>
        /// Singleton access to User controller
        /// </summary>
        public UserController User
        {
            get
            {
                return UserController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Log controller
        /// </summary>
        public LogController Log
        {
            get
            {
                return LogController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Admin controller
        /// </summary>
        public AdminController Admin
        {
            get
            {
                return AdminController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Application controller
        /// </summary>
        public ApplicationController Application
        {
            get
            {
                return ApplicationController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Group controller
        /// </summary>
        public GroupController Group
        {
            get
            {
                return GroupController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Project controller
        /// </summary>
        public ProjectController Project
        {
            get
            {
                return ProjectController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Task controller
        /// </summary>
        public TaskController Task
        {
            get
            {
                return TaskController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to PullRequest controller
        /// </summary>
        public PullRequestController PullRequest
        {
            get
            {
                return PullRequestController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Hook controller
        /// </summary>
        public HookController Hook
        {
            get
            {
                return HookController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Repository controller
        /// </summary>
        public RepositoryController Repository
        {
            get
            {
                return RepositoryController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Profile controller
        /// </summary>
        public ProfileController Profile
        {
            get
            {
                return ProfileController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Markup controller
        /// </summary>
        public MarkupController Markup
        {
            get
            {
                return MarkupController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public StashAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public StashAPIClient(string stashDomain, string basicAuthUserName, string basicAuthPassword)
        {
            Configuration.StashDomain = stashDomain;
            Configuration.BasicAuthUserName = basicAuthUserName;
            Configuration.BasicAuthPassword = basicAuthPassword;
        }
    }
}