# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (StashAPIPCL.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Stash%20API-CSharp&workspaceName=StashAPIPCL&projectName=StashAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the StashAPIPCL library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Stash%20API-CSharp&workspaceName=StashAPIPCL&projectName=StashAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Stash%20API-CSharp&workspaceName=StashAPIPCL&projectName=StashAPI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Stash%20API-CSharp&workspaceName=StashAPIPCL&projectName=StashAPI.PCL)

### 3. Add reference of the library project

In order to use the StashAPIPCL library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Stash%20API-CSharp&workspaceName=StashAPIPCL&projectName=StashAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` StashAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```StashAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Stash%20API-CSharp&workspaceName=StashAPIPCL&projectName=StashAPI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Stash%20API-CSharp&workspaceName=StashAPIPCL&projectName=StashAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| stashDomain | TODO: add a description |
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string stashDomain = "stashDomain";
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

StashAPIPCLClient client = new StashAPIPCLClient(stashDomain, basicAuthUserName, basicAuthPassword);
```

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [UserController](#user_controller)
* [LogController](#log_controller)
* [AdminController](#admin_controller)
* [ApplicationController](#application_controller)
* [GroupController](#group_controller)
* [ProjectController](#project_controller)
* [TaskController](#task_controller)
* [PullRequestController](#pull_request_controller)
* [HookController](#hook_controller)
* [RepositoryController](#repository_controller)
* [ProfileController](#profile_controller)
* [MarkupController](#markup_controller)

## <a name="user_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.UserController") UserController

### Get singleton instance

The singleton instance of the ``` UserController ``` class can be accessed from the API Client.

```csharp
UserController user = client.User;
```

### <a name="get_user_settings"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.UserController.GetUserSettings") GetUserSettings

> Retrieve a map of user setting key values for a specific user identified by the user slug.
>  <p>


```csharp
Task<string> GetUserSettings(string userSlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userSlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string userSlug = "userSlug";

string result = await user.GetUserSettings(userSlug);

```


### <a name="update_user_password"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.UserController.UpdateUserPassword") UpdateUserPassword

> Update the currently authenticated user's password.


```csharp
Task<string> UpdateUserPassword(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await user.UpdateUserPassword(mdynamic);

```


### <a name="get_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.UserController.GetUser") GetUser

> Retrieve the user matching the supplied <strong>userSlug</strong>.
>  <p>


```csharp
Task<string> GetUser(string userSlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userSlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string userSlug = "userSlug";

string result = await user.GetUser(userSlug);

```


### <a name="update_user_details"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.UserController.UpdateUserDetails") UpdateUserDetails

> Update the currently authenticated user's details. Note that <em>the name attribute is ignored</em>, the update
>  will always be applied to the currently authenticated user.


```csharp
Task<string> UpdateUserDetails(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await user.UpdateUserDetails(mdynamic);

```


### <a name="get_users"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.UserController.GetUsers") GetUsers

> Retrieve a page of users, optionally run through provided filters.
>  <p>
>  Only authenticated users may call this resource.
> 
>  <h3>Supported Filters</h3>
>  <p>
>  Filters are provided in query parameters in a standard <code>name=value</code> fashion. The following filters are
>  currently supported:
>  <ul>
>      <li>
>          {@code filter} - return only users, whose username, name or email address <i>contain</i> the
>          {@code filter} value
>      </li>
>      <li>
>          {@code permission} - the "root" of a permission filter, whose value must be a valid global,
>          project, or repository permission. Additional filter parameters referring to this filter that specify the
>          resource (project or repository) to apply the filter to must be prefixed with <code>permission.</code>. See the
>          section "Permission Filters" below for more details.
>      </li>
>      <li>
>          {@code permission.N} - the "root" of a single permission filter, similar to the {@code permission}
>          parameter, where "N" is a natural number starting from 1. This allows clients to specify multiple permission
>          filters, by providing consecutive filters as {@code permission.1}, {@code permission.2} etc. Note that
>          the filters numbering has to start with 1 and be continuous for all filters to be processed. The total allowed
>          number of permission filters is 50 and all filters exceeding that limit will be dropped. See the section
>          "Permission Filters" below for more details on how the permission filters are processed.
>      </li>
>  </ul>
>  
> 
>  <h3>Permission Filters</h3>
>  <p>
>  The following three sub-sections list parameters supported for permission filters (where <code>[root]</code> is
>  the root permission filter name, e.g. {@code permission}, {@code permission.1} etc.) depending on the
>  permission resource. The system determines which filter to apply (Global, Project or Repository permission)
>  based on the <code>[root]</code> permission value. E.g. {@code ADMIN} is a global permission,
>  {@code PROJECT_ADMIN} is a project permission and {@code REPO_ADMIN} is a repository permission. Note
>  that the parameters for a given resource will be looked up in the order as they are listed below, that is e.g.
>  for a project resource, if both {@code projectId} and {@code projectKey} are provided, the system will
>  use {@code projectId} for the lookup.
>  <h4>Global permissions</h4>
>  <p>
>  The permission value under <code>[root]</code> is the only required and recognized parameter, as global
>  permissions do not apply to a specific resource.
>  <p>
>  Example valid filter: <code>permission=ADMIN</code>.
>  <h4>Project permissions</h4>
>  <ul>
>      <li><code>[root]</code>- specifies the project permission</li>
>      <li><code>[root].projectId</code> - specifies the project ID to lookup the project by</li>
>      <li><code>[root].projectKey</code> - specifies the project key to lookup the project by</li>
>  </ul>
>  <p>
>  Example valid filter: <code>permission.1=PROJECT_ADMIN&permission.1.projectKey=TEST_PROJECT</code>.
>  <h4>Repository permissions</h4>
>  <ul>
>      <li><code>[root]</code>- specifies the repository permission</li>
>      <li><code>[root].projectId</code> - specifies the repository ID to lookup the repository by</li>
>      <li><code>[root].projectKey</code> and <code>[root].repositorySlug</code>- specifies the project key and
>      repository slug to lookup the repository by; both values <i>need to</i> be provided for this look up to be
>      triggered</li>
>  </ul>
>  Example valid filter: <code>permission.2=REPO_ADMIN&permission.2.projectKey=TEST_PROJECT&permission.2.repositorySlug=test_repo</code>.


```csharp
Task<string> GetUsers()
```

#### Example Usage

```csharp

string result = await user.GetUsers();

```


### <a name="delete_user_avatar"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.UserController.DeleteUserAvatar") DeleteUserAvatar

> Delete the avatar associated to a user.
>  <p>
>  Users are always allowed to delete their own avatar. To delete someone else's avatar the authenticated user must
>  have global <strong>ADMIN</strong> permission, or global <strong>SYS_ADMIN</strong> permission to update a
>  <strong>SYS_ADMIN</strong> user's avatar.


```csharp
Task<string> DeleteUserAvatar(string userSlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userSlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string userSlug = "userSlug";

string result = await user.DeleteUserAvatar(userSlug);

```


### <a name="upload_user_avatar"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.UserController.UploadUserAvatar") UploadUserAvatar

> Update the avatar for the user with the supplied <strong>slug</strong>.
>  <p>
>  This resource accepts POST multipart form data, containing a single image in a form-field named 'avatar'.
>  <p>
>  There are configurable server limits on both the dimensions (1024x1024 pixels by default) and uploaded
>  file size (1MB by default). Several different image formats are supported, but <strong>PNG</strong> and
>  <strong>JPEG</strong> are preferred due to the file size limit.
>  <p>
>  This resource has Cross-Site Request Forgery (XSRF) protection. To allow the request to
>  pass the XSRF check the caller needs to send an <code>X-Atlassian-Token</code> HTTP header with the
>  value <code>no-check</code>.
>  <p>
>  An example <a href="http://curl.haxx.se/">curl</a> request to upload an image name 'avatar.png' would be:
>  <pre>
>  curl -X POST -u username:password -H "X-Atlassian-Token: no-check" http://example.com/rest/api/latest/users/jdoe/avatar.png -F avatar=@avatar.png
>  </pre>
>  <p>
>  Users are always allowed to update their own avatar. To update someone else's avatar the authenticated user must
>  have global <strong>ADMIN</strong> permission, or global <strong>SYS_ADMIN</strong> permission to update a
>  <strong>SYS_ADMIN</strong> user's avatar.


```csharp
Task<string> UploadUserAvatar(string userSlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userSlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string userSlug = "userSlug";

string result = await user.UploadUserAvatar(userSlug);

```


### <a name="update_user_settings"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.UserController.UpdateUserSettings") UpdateUserSettings

> Update the entries of a map of user setting key/values for a specific user identified by the user slug.
>  <p>


```csharp
Task<string> UpdateUserSettings(object mdynamic, string userSlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| userSlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string userSlug = "userSlug";

string result = await user.UpdateUserSettings(mdynamic, userSlug);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="log_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.LogController") LogController

### Get singleton instance

The singleton instance of the ``` LogController ``` class can be accessed from the API Client.

```csharp
LogController log = client.Log;
```

### <a name="get_level"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.LogController.GetLevel") GetLevel

> Retrieve the current log level for a given logger.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<string> GetLevel(string loggerName)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| loggerName |  ``` Required ```  | the name of the logger. |


#### Example Usage

```csharp
string loggerName = "loggerName";

string result = await log.GetLevel(loggerName);

```


### <a name="update_set_root_level"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.LogController.UpdateSetRootLevel") UpdateSetRootLevel

> Set the current log level for the root logger.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<dynamic> UpdateSetRootLevel(string levelName)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| levelName |  ``` Required ```  | the level to set the logger to. Either TRACE, DEBUG, INFO, WARN or ERROR |


#### Example Usage

```csharp
string levelName = "levelName";

dynamic result = await log.UpdateSetRootLevel(levelName);

```


### <a name="get_root_level"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.LogController.GetRootLevel") GetRootLevel

> Retrieve the current log level for the root logger.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<string> GetRootLevel()
```

#### Example Usage

```csharp

string result = await log.GetRootLevel();

```


### <a name="update_set_level"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.LogController.UpdateSetLevel") UpdateSetLevel

> Set the current log level for a given logger.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<dynamic> UpdateSetLevel(string levelName, string loggerName)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| levelName |  ``` Required ```  | the level to set the logger to. Either TRACE, DEBUG, INFO, WARN or ERROR |
| loggerName |  ``` Required ```  | the name of the logger. |


#### Example Usage

```csharp
string levelName = "levelName";
string loggerName = "loggerName";

dynamic result = await log.UpdateSetLevel(levelName, loggerName);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="admin_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.AdminController") AdminController

### Get singleton instance

The singleton instance of the ``` AdminController ``` class can be accessed from the API Client.

```csharp
AdminController admin = client.Admin;
```

### <a name="update_user_password"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.UpdateUserPassword") UpdateUserPassword

> Update a user's password.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource, and may not update
>  the password of a user with greater permissions than themselves.


```csharp
Task<string> UpdateUserPassword(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.UpdateUserPassword(mdynamic);

```


### <a name="add_user_to_groups"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.AddUserToGroups") AddUserToGroups

> Add a user to one or more groups.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> AddUserToGroups(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.AddUserToGroups(mdynamic);

```


### <a name="add_users_to_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.AddUsersToGroup") AddUsersToGroup

> Add multiple users to a group.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> AddUsersToGroup(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.AddUsersToGroup(mdynamic);

```


### <a name="get_groups"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetGroups") GetGroups

> Retrieve a page of groups.
>  <p>
>  The authenticated user must have <strong>LICENSED_USER</strong> permission or higher to call this resource.


```csharp
Task<string> GetGroups(string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string filter = "filter";

string result = await admin.GetGroups(filter);

```


### <a name="create_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.CreateGroup") CreateGroup

> Create a new group.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<string> CreateGroup(string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | Name of the group. |


#### Example Usage

```csharp
string name = "name";

string result = await admin.CreateGroup(name);

```


### <a name="create_rename_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.CreateRenameUser") CreateRenameUser

> Rename a user.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> CreateRenameUser(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.CreateRenameUser(mdynamic);

```


### <a name="update_user_details"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.UpdateUserDetails") UpdateUserDetails

> Update a user's details.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> UpdateUserDetails(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.UpdateUserDetails(mdynamic);

```


### <a name="get_users"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetUsers") GetUsers

> Retrieve a page of users.
>  <p>
>  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.


```csharp
Task<string> GetUsers(string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filter |  ``` Optional ```  | if specified only users with usernames, display name or email addresses containing the supplied
               string will be returned |


#### Example Usage

```csharp
string filter = "filter";

string result = await admin.GetUsers(filter);

```


### <a name="update_set_sender_address"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.UpdateSetSenderAddress") UpdateSetSenderAddress

> Updates the server email address
> 
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> UpdateSetSenderAddress(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.UpdateSetSenderAddress(mdynamic);

```


### <a name="get_sender_address"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetSenderAddress") GetSenderAddress

> Retrieves the server email address


```csharp
Task<dynamic> GetSenderAddress()
```

#### Example Usage

```csharp

dynamic result = await admin.GetSenderAddress();

```


### <a name="delete_clear_sender_address"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.DeleteClearSenderAddress") DeleteClearSenderAddress

> Clears the server email address.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<dynamic> DeleteClearSenderAddress()
```

#### Example Usage

```csharp

dynamic result = await admin.DeleteClearSenderAddress();

```


### <a name="update_set_mail_config"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.UpdateSetMailConfig") UpdateSetMailConfig

> Updates the mail configuration
> 
>  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.


```csharp
Task<string> UpdateSetMailConfig(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.UpdateSetMailConfig(mdynamic);

```


### <a name="get_mail_config"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetMailConfig") GetMailConfig

> Retrieves the current mail configuration.
> 
>  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.


```csharp
Task<dynamic> GetMailConfig()
```

#### Example Usage

```csharp

dynamic result = await admin.GetMailConfig();

```


### <a name="delete_mail_config"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.DeleteMailConfig") DeleteMailConfig

> Deletes the current mail configuration.
>  <p>
>  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.


```csharp
Task<dynamic> DeleteMailConfig()
```

#### Example Usage

```csharp

dynamic result = await admin.DeleteMailConfig();

```


### <a name="get_cluster_information"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetClusterInformation") GetClusterInformation

> Gets information about the nodes that currently make up the stash cluster.
>  <p>
>  The authenticated user must have the <strong>SYS_ADMIN</strong> permission to call this resource.


```csharp
Task<dynamic> GetClusterInformation()
```

#### Example Usage

```csharp

dynamic result = await admin.GetClusterInformation();

```


### <a name="update_license"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.UpdateLicense") UpdateLicense

> Decodes the provided encoded license and sets it as the active license. If no license was provided, a 400 is
>  returned. If the license cannot be decoded, or cannot be applied, a 409 is returned. Some possible reasons a
>  license may not be applied include:
>  <ul>
>      <li>It is for a different product</li>
>      <li>It is already expired</li>
>  </ul>
>  Otherwise, if the license is updated successfully, details for the new license are returned with a 200 response.
>  <p>
>  <b>Warning</b>: It is possible to downgrade the license during update, applying a license with a lower number
>  of permitted users. If the number of currently-licensed users exceeds the limits of the new license, pushing
>  will be disabled until the licensed user count is brought into compliance with the new license.
>  <p>
>  The authenticated user must have <b>SYS_ADMIN</b> permission. <b>ADMIN</b> users may <i>view</i> the current
>  license details, but they may not <i>update</i> the license.


```csharp
Task<string> UpdateLicense(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.UpdateLicense(mdynamic);

```


### <a name="get_users_without_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetUsersWithoutAnyPermission") GetUsersWithoutAnyPermission

> Retrieve a page of users that have no granted global permissions.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<string> GetUsersWithoutAnyPermission(string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filter |  ``` Optional ```  | if specified only user names containing the supplied string will be returned |


#### Example Usage

```csharp
string filter = "filter";

string result = await admin.GetUsersWithoutAnyPermission(filter);

```


### <a name="get_groups_with_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetGroupsWithAnyPermission") GetGroupsWithAnyPermission

> Retrieve a page of groups that have been granted at least one global permission.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<string> GetGroupsWithAnyPermission(string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string filter = "filter";

string result = await admin.GetGroupsWithAnyPermission(filter);

```


### <a name="update_set_permission_for_groups"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.UpdateSetPermissionForGroups") UpdateSetPermissionForGroups

> Promote or demote a user's global permission level. Available global permissions are:
>  <ul>
>      <li>LICENSED_USER</li>
>      <li>PROJECT_CREATE</li>
>      <li>ADMIN</li>
>      <li>SYS_ADMIN</li>
>  </ul>
>  See the <a href="https://confluence.atlassian.com/display/STASH/Global+permissions">Stash documentation</a> for
>  a detailed explanation of what each permission entails.
>  <p>
>  The authenticated user must have:
>  <ul>
>      <li><strong>ADMIN</strong> permission or higher; and</li>
>      <li>the permission they are attempting to grant or higher; and</li>
>      <li>greater or equal permissions than the current permission level of the group (a user may not demote the
>      permission level of a group with higher permissions than them)</li>
>  </ul>
>  to call this resource. In addition, a user may not demote a group's permission level if their own permission
>  level would be reduced as a result.


```csharp
Task<string> UpdateSetPermissionForGroups(string permission = null, string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| permission |  ``` Optional ```  | the permission to grant |
| name |  ``` Optional ```  | the names of the groups |


#### Example Usage

```csharp
string permission = "permission";
string name = "name";

string result = await admin.UpdateSetPermissionForGroups(permission, name);

```


### <a name="delete_revoke_permissions_for_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.DeleteRevokePermissionsForGroup") DeleteRevokePermissionsForGroup

> Revoke all global permissions for a group.
> 
>  <p>
>  The authenticated user must have:
>  <ul>
>      <li><strong>ADMIN</strong> permission or higher; and</li>
>      <li>greater or equal permissions than the current permission level of the group (a user may not demote the
>      permission level of a group with higher permissions than them)</li>
>  </ul>
>  to call this resource. In addition, a user may not revoke a group's permissions if their own permission level
>  would be reduced as a result.


```csharp
Task<string> DeleteRevokePermissionsForGroup(string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | the name of the group |


#### Example Usage

```csharp
string name = "name";

string result = await admin.DeleteRevokePermissionsForGroup(name);

```


### <a name="get_groups_without_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetGroupsWithoutAnyPermission") GetGroupsWithoutAnyPermission

> Retrieve a page of groups that have no granted global permissions.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<string> GetGroupsWithoutAnyPermission(string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string filter = "filter";

string result = await admin.GetGroupsWithoutAnyPermission(filter);

```


### <a name="get_users_with_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetUsersWithAnyPermission") GetUsersWithAnyPermission

> Retrieve a page of users that have been granted at least one global permission.
>  <p>
>  The authenticated user must have <strong>ADMIN</strong> permission or higher to call this resource.


```csharp
Task<string> GetUsersWithAnyPermission(string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filter |  ``` Optional ```  | if specified only user names containing the supplied string will be returned |


#### Example Usage

```csharp
string filter = "filter";

string result = await admin.GetUsersWithAnyPermission(filter);

```


### <a name="update_set_permission_for_users"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.UpdateSetPermissionForUsers") UpdateSetPermissionForUsers

> Promote or demote the global permission level of a user. Available global permissions are:
>  <ul>
>      <li>LICENSED_USER</li>
>      <li>PROJECT_CREATE</li>
>      <li>ADMIN</li>
>      <li>SYS_ADMIN</li>
>  </ul>
>  See the <a href="https://confluence.atlassian.com/display/STASH/Global+permissions">Stash documentation</a> for
>  a detailed explanation of what each permission entails.
>  <p>
>  The authenticated user must have:
>  <ul>
>      <li><strong>ADMIN</strong> permission or higher; and</li>
>      <li>the permission they are attempting to grant; and</li>
>      <li>greater or equal permissions than the current permission level of the user (a user may not demote the
>      permission level of a user with higher permissions than them)</li>
>  </ul>
>  to call this resource. In addition, a user may not demote their own permission level.


```csharp
Task<string> UpdateSetPermissionForUsers(string name = null, string permission = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | the names of the users |
| permission |  ``` Optional ```  | the permission to grant |


#### Example Usage

```csharp
string name = "name";
string permission = "permission";

string result = await admin.UpdateSetPermissionForUsers(name, permission);

```


### <a name="delete_revoke_permissions_for_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.DeleteRevokePermissionsForUser") DeleteRevokePermissionsForUser

> Revoke all global permissions for a user.
>  <p>
>  The authenticated user must have:
>  <ul>
>      <li><strong>ADMIN</strong> permission or higher; and</li>
>      <li>greater or equal permissions than the current permission level of the user (a user may not demote the
>      permission level of a user with higher permissions than them)</li>
>  </ul>
>  to call this resource. In addition, a user may not demote their own permission level.


```csharp
Task<string> DeleteRevokePermissionsForUser(string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | the name of the user |


#### Example Usage

```csharp
string name = "name";

string result = await admin.DeleteRevokePermissionsForUser(name);

```


### <a name="create_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.CreateUser") CreateUser

> Creates a new user from the assembled query parameters.
>  <p>
>  The default group can be used to control initial permissions for new users, such as granting users the ability
>  to login or providing read access to certain projects or repositories. If the user is not added to the default
>  group, they may not be able to login after their account is created until explicit permissions are configured.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> CreateUser(
        string name = null,
        string password = null,
        string displayName = null,
        string emailAddress = null,
        bool? addToDefaultGroup = true,
        string notify = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | the username for the new user |
| password |  ``` Optional ```  | the password for the new user |
| displayName |  ``` Optional ```  | the display name for the new user |
| emailAddress |  ``` Optional ```  | the e-mail address for the new user |
| addToDefaultGroup |  ``` Optional ```  ``` DefaultValue ```  | <code>true</code> to add the user to the default group, which can be used to grant them
                          a set of initial permissions; otherwise, <code>false</code> to not add them to a group |
| notify |  ``` Optional ```  | if present and not <code>false</code> instead of requiring a password,
                          the create user will be notified via email their account has been created and requires
                          a password to be reset. This option can only be used if a mail server has been configured |


#### Example Usage

```csharp
string name = "name";
string password = "password";
string displayName = "displayName";
string emailAddress = "emailAddress";
bool? addToDefaultGroup = true;
string notify = "notify";

string result = await admin.CreateUser(name, password, displayName, emailAddress, addToDefaultGroup, notify);

```


### <a name="delete_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.DeleteUser") DeleteUser

> Deletes the specified user, removing them from the system. This also removes any permissions that may have been
>  granted to the user.
>  <p>
>  A user may not delete themselves, and a user with <strong>ADMIN</strong> permissions may not delete a user with
>  <strong>SYS_ADMIN</strong>permissions.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> DeleteUser(string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | the username identifying the user to delete |


#### Example Usage

```csharp
string name = "name";

string result = await admin.DeleteUser(name);

```


### <a name="delete_clear_user_captcha_challenge"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.DeleteClearUserCaptchaChallenge") DeleteClearUserCaptchaChallenge

> Clears any CAPTCHA challenge that may constrain the user with the supplied username when they authenticate.
>  Additionally any counter or metric that contributed towards the user being issued the CAPTCHA challenge
>  (for instance too many consecutive failed logins) will also be reset.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource, and may not clear
>  the CAPTCHA of a user with greater permissions than themselves.


```csharp
Task<dynamic> DeleteClearUserCaptchaChallenge(string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string name = "name";

dynamic result = await admin.DeleteClearUserCaptchaChallenge(name);

```


### <a name="delete_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.DeleteGroup") DeleteGroup

> Deletes the specified group, removing them from the system. This also removes any permissions that may have been
>  granted to the group.
>  <p>
>  A user may not delete the last group that is granting them administrative permissions, or a group with greater
>  permissions than themselves.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> DeleteGroup(string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | the name identifying the group to delete |


#### Example Usage

```csharp
string name = "name";

string result = await admin.DeleteGroup(name);

```


### <a name="add_user_to_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.AddUserToGroup") AddUserToGroup

> <p><strong>Deprecated since 2.10 for removal in 4.0</strong>. Use {@code /rest/users/add-groups} instead.</p>
> 
>  Add a user to a group.
>  <p>
>  In the request entity, the <em>context</em> attribute is the group and the <em>itemName</em> is the user.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> AddUserToGroup(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.AddUserToGroup(mdynamic);

```


### <a name="add_group_to_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.AddGroupToUser") AddGroupToUser

> <p><strong>Deprecated since 2.10 for removal in 4.0</strong>. Use {@code /rest/users/add-groups} instead.</p>
> 
>  Add a user to a group. This is very similar to <code>groups/add-user</code>, but with the <em>context</em> and
>  <em>itemName</em> attributes of the supplied request entity reversed. On the face of it this may appear
>  redundant, but it facilitates a specific UI component in Stash.
>  <p>
>  In the request entity, the <em>context</em> attribute is the user and the <em>itemName</em> is the group.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> AddGroupToUser(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.AddGroupToUser(mdynamic);

```


### <a name="create_remove_user_from_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.CreateRemoveUserFromGroup") CreateRemoveUserFromGroup

> <p><strong>Deprecated since 2.10 for removal in 3.0</strong>. Use {@code /rest/users/remove-groups} instead.</p>
> 
>  Remove a user from a group.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.
>  <p>
>  In the request entity, the <em>context</em> attribute is the group and the <em>itemName</em> is the user.


```csharp
Task<string> CreateRemoveUserFromGroup(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.CreateRemoveUserFromGroup(mdynamic);

```


### <a name="create_remove_group_from_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.CreateRemoveGroupFromUser") CreateRemoveGroupFromUser

> Remove a user from a group. This is very similar to <code>groups/remove-user</code>, but with the <em>context</em>
>  and <em>itemName</em> attributes of the supplied request entity reversed. On the face of it this may appear
>  redundant, but it facilitates a specific UI component in Stash.
>  <p>
>  In the request entity, the <em>context</em> attribute is the user and the <em>itemName</em> is the group.
>  <p>
>  The authenticated user must have the <strong>ADMIN</strong> permission to call this resource.


```csharp
Task<string> CreateRemoveGroupFromUser(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await admin.CreateRemoveGroupFromUser(mdynamic);

```


### <a name="find_users_in_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.FindUsersInGroup") FindUsersInGroup

> Retrieves a list of users that are members of a specified group.
>  <p>
>  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.


```csharp
Task<string> FindUsersInGroup(string context = null, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | the group which should be used to locate members |
| filter |  ``` Optional ```  | if specified only users with usernames, display names or email addresses containing the
                  supplied string will be returned |


#### Example Usage

```csharp
string context = "context";
string filter = "filter";

string result = await admin.FindUsersInGroup(context, filter);

```


### <a name="find_users_not_in_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.FindUsersNotInGroup") FindUsersNotInGroup

> Retrieves a list of users that are <em>not</em> members of a specified group.
>  <p>
>  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.


```csharp
Task<string> FindUsersNotInGroup(string context = null, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | the group which should be used to locate non-members |
| filter |  ``` Optional ```  | if specified only users with usernames, display names or email addresses containing the
                  supplied string will be returned |


#### Example Usage

```csharp
string context = "context";
string filter = "filter";

string result = await admin.FindUsersNotInGroup(context, filter);

```


### <a name="find_groups_for_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.FindGroupsForUser") FindGroupsForUser

> Retrieves a list of groups the specified user is a member of.
>  <p>
>  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.


```csharp
Task<string> FindGroupsForUser(string context = null, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | the user which should be used to locate groups |
| filter |  ``` Optional ```  | if specified only groups with names containing the supplied string will be returned |


#### Example Usage

```csharp
string context = "context";
string filter = "filter";

string result = await admin.FindGroupsForUser(context, filter);

```


### <a name="find_other_groups_for_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.FindOtherGroupsForUser") FindOtherGroupsForUser

> Retrieves a list of groups the specified user is <em>not</em> a member of.
>  <p>
>  The authenticated user must have the <strong>LICENSED_USER</strong> permission to call this resource.


```csharp
Task<string> FindOtherGroupsForUser(string context = null, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | the user which should be used to locate groups |
| filter |  ``` Optional ```  | if specified only groups with names containing the supplied string will be returned |


#### Example Usage

```csharp
string context = "context";
string filter = "filter";

string result = await admin.FindOtherGroupsForUser(context, filter);

```


### <a name="get_license"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.AdminController.GetLicense") GetLicense

> Retrieves details about the current license, as well as the current status of the system with regards to the
>  installed license. The status includes the current number of users applied toward the license limit, as well
>  as any status messages about the license (warnings about expiry or user counts exceeding license limits).
>  <p>
>  The authenticated user must have <b>ADMIN</b> permission. Unauthenticated users, and non-administrators, are
>  not permitted to access license details.


```csharp
Task<string> GetLicense()
```

#### Example Usage

```csharp

string result = await admin.GetLicense();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="application_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.ApplicationController") ApplicationController

### Get singleton instance

The singleton instance of the ``` ApplicationController ``` class can be accessed from the API Client.

```csharp
ApplicationController application = client.Application;
```

### <a name="get_application_properties"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ApplicationController.GetApplicationProperties") GetApplicationProperties

> Retrieve version information and other application properties.
>  <p>
>  No authentication is required to call this resource.


```csharp
Task<string> GetApplicationProperties()
```

#### Example Usage

```csharp

string result = await application.GetApplicationProperties();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="group_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.GroupController") GroupController

### Get singleton instance

The singleton instance of the ``` GroupController ``` class can be accessed from the API Client.

```csharp
GroupController mgroup = client.Group;
```

### <a name="get_groups"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.GroupController.GetGroups") GetGroups

> Retrieve a page of group names.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission or higher to call this resource.


```csharp
Task<string> GetGroups(string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string filter = "filter";

string result = await mgroup.GetGroups(filter);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="project_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.ProjectController") ProjectController

### Get singleton instance

The singleton instance of the ``` ProjectController ``` class can be accessed from the API Client.

```csharp
ProjectController project = client.Project;
```

### <a name="get_project"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.GetProject") GetProject

> Retrieve the project matching the supplied <strong>projectKey</strong>.
>  <p>
>  The authenticated user must have <strong>PROJECT_VIEW</strong> permission for the specified project to call this
>  resource.


```csharp
Task<string> GetProject(string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";

string result = await project.GetProject(projectKey);

```


### <a name="delete_project"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.DeleteProject") DeleteProject

> Delete the project matching the supplied <strong>projectKey</strong>.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
>  resource.


```csharp
Task<string> DeleteProject(string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";

string result = await project.DeleteProject(projectKey);

```


### <a name="get_project_groups_with_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.GetProjectGroupsWithAnyPermission") GetProjectGroupsWithAnyPermission

> Retrieve a page of groups that have been granted at least one permission for the specified project.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource.


```csharp
Task<string> GetProjectGroupsWithAnyPermission(string projectKey, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string projectKey = "projectKey";
string filter = "filter";

string result = await project.GetProjectGroupsWithAnyPermission(projectKey, filter);

```


### <a name="update_set_project_permission_for_groups"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.UpdateSetProjectPermissionForGroups") UpdateSetProjectPermissionForGroups

> Promote or demote a group's permission level for the specified project. Available project permissions are:
>  <ul>
>      <li>PROJECT_READ</li>
>      <li>PROJECT_WRITE</li>
>      <li>PROJECT_ADMIN</li>
>  </ul>
>  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+project">Stash documentation</a>
>  for a detailed explanation of what each permission entails.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource. In addition, a user may not demote a group's permission level if their
>  own permission level would be reduced as a result.


```csharp
Task<string> UpdateSetProjectPermissionForGroups(string projectKey, string permission = null, string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| permission |  ``` Optional ```  | the permission to grant |
| name |  ``` Optional ```  | the names of the groups |


#### Example Usage

```csharp
string projectKey = "projectKey";
string permission = "permission";
string name = "name";

string result = await project.UpdateSetProjectPermissionForGroups(projectKey, permission, name);

```


### <a name="delete_revoke_project_permissions_for_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.DeleteRevokeProjectPermissionsForGroup") DeleteRevokeProjectPermissionsForGroup

> Revoke all permissions for the specified project for a group.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource.
>  <p>
>  In addition, a user may not revoke a group's permissions if it will reduce their own permission level.


```csharp
Task<string> DeleteRevokeProjectPermissionsForGroup(string projectKey, string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | the name of the group |


#### Example Usage

```csharp
string projectKey = "projectKey";
string name = "name";

string result = await project.DeleteRevokeProjectPermissionsForGroup(projectKey, name);

```


### <a name="get_project_groups_without_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.GetProjectGroupsWithoutAnyPermission") GetProjectGroupsWithoutAnyPermission

> Retrieve a page of groups that have no granted permissions for the specified project.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource.


```csharp
Task<string> GetProjectGroupsWithoutAnyPermission(string projectKey, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string projectKey = "projectKey";
string filter = "filter";

string result = await project.GetProjectGroupsWithoutAnyPermission(projectKey, filter);

```


### <a name="get_project_users_with_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.GetProjectUsersWithAnyPermission") GetProjectUsersWithAnyPermission

> Retrieve a page of users that have been granted at least one permission for the specified project.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource.


```csharp
Task<string> GetProjectUsersWithAnyPermission(string projectKey, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string projectKey = "projectKey";
string filter = "filter";

string result = await project.GetProjectUsersWithAnyPermission(projectKey, filter);

```


### <a name="update_set_project_permission_for_users"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.UpdateSetProjectPermissionForUsers") UpdateSetProjectPermissionForUsers

> Promote or demote a user's permission level for the specified project. Available project permissions are:
>  <ul>
>      <li>PROJECT_READ</li>
>      <li>PROJECT_WRITE</li>
>      <li>PROJECT_ADMIN</li>
>  </ul>
>  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+project">Stash documentation</a>
>  for a detailed explanation of what each permission entails.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource. In addition, a user may not reduce their own permission level unless
>  they have a global permission that already implies that permission.


```csharp
Task<string> UpdateSetProjectPermissionForUsers(string projectKey, string name = null, string permission = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | the names of the users |
| permission |  ``` Optional ```  | the permission to grant |


#### Example Usage

```csharp
string projectKey = "projectKey";
string name = "name";
string permission = "permission";

string result = await project.UpdateSetProjectPermissionForUsers(projectKey, name, permission);

```


### <a name="delete_revoke_project_permissions_for_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.DeleteRevokeProjectPermissionsForUser") DeleteRevokeProjectPermissionsForUser

> Revoke all permissions for the specified project for a user.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource.
>  <p>
>  In addition, a user may not revoke their own project permissions if they do not have a higher global permission.


```csharp
Task<string> DeleteRevokeProjectPermissionsForUser(string projectKey, string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | the name of the user |


#### Example Usage

```csharp
string projectKey = "projectKey";
string name = "name";

string result = await project.DeleteRevokeProjectPermissionsForUser(projectKey, name);

```


### <a name="get_project_users_without_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.GetProjectUsersWithoutPermission") GetProjectUsersWithoutPermission

> Retrieve a page of <i>licensed</i> users that have no granted permissions for the specified project.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource.


```csharp
Task<string> GetProjectUsersWithoutPermission(string projectKey, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string projectKey = "projectKey";
string filter = "filter";

string result = await project.GetProjectUsersWithoutPermission(projectKey, filter);

```


### <a name="get_has_project_all_user_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.GetHasProjectAllUserPermission") GetHasProjectAllUserPermission

> Check whether the specified permission is the default permission (granted to all users) for a project. Available
>  project permissions are:
>  <ul>
>      <li>PROJECT_READ</li>
>      <li>PROJECT_WRITE</li>
>      <li>PROJECT_ADMIN</li>
>  </ul>
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource.


```csharp
Task<string> GetHasProjectAllUserPermission(string projectKey, string permission)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| permission |  ``` Required ```  | the permission to grant |


#### Example Usage

```csharp
string projectKey = "projectKey";
string permission = "permission";

string result = await project.GetHasProjectAllUserPermission(projectKey, permission);

```


### <a name="modify_project_all_user_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.ModifyProjectAllUserPermission") ModifyProjectAllUserPermission

> Grant or revoke a project permission to all users, i.e. set the default permission. Available project permissions
>  are:
>  <ul>
>      <li>PROJECT_READ</li>
>      <li>PROJECT_WRITE</li>
>      <li>PROJECT_ADMIN</li>
>  </ul>
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project or a higher
>  global permission to call this resource.


```csharp
Task<string> ModifyProjectAllUserPermission(string projectKey, string permission, bool? allow = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| permission |  ``` Required ```  | the permission to grant |
| allow |  ``` Optional ```  | <em>true</em> to grant the specified permission to all users, or <em>false</em> to revoke it |


#### Example Usage

```csharp
string projectKey = "projectKey";
string permission = "permission";
bool? allow = false;

string result = await project.ModifyProjectAllUserPermission(projectKey, permission, allow);

```


### <a name="create_project"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.CreateProject") CreateProject

> Create a new project.
>  <p>
>  To include a custom avatar for the project, the project definition should contain an additional attribute with
>  the key <code>avatar</code> and the value a data URI containing Base64-encoded image data. The URI should be in
>  the following format:
>  <pre>
>      data:(content type, e.g. image/png);base64,(data)
>  </pre>
>  If the data is not Base64-encoded, or if a character set is defined in the URI, or the URI is otherwise invalid,
>  <em>project creation will fail</em>.
>  <p>
>  The authenticated user must have <strong>PROJECT_CREATE</strong> permission to call this resource.


```csharp
Task<string> CreateProject(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await project.CreateProject(mdynamic);

```


### <a name="get_projects"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.GetProjects") GetProjects

> Retrieve a page of projects.
>  <p>
>  Only projects for which the authenticated user has the <strong>PROJECT_VIEW</strong> permission will be returned.


```csharp
Task<string> GetProjects(string name = null, string permission = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | TODO: Add a parameter description |
| permission |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string name = "name";
string permission = "permission";

string result = await project.GetProjects(name, permission);

```


### <a name="update_project"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.UpdateProject") UpdateProject

> Update the project matching the <strong>projectKey</strong> supplied in the resource path.
>  <p>
>  To include a custom avatar for the updated project, the project definition should contain an additional attribute
>  with the key <code>avatar</code> and the value a data URI containing Base64-encoded image data. The URI should be
>  in the following format:
>  <code>
>      data:(content type, e.g. image/png);base64,(data)
>  </code>
>  If the data is not Base64-encoded, or if a character set is defined in the URI, or the URI is otherwise invalid,
>  <em>project creation will fail</em>.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
>  resource.


```csharp
Task<string> UpdateProject(object mdynamic, string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";

string result = await project.UpdateProject(mdynamic, projectKey);

```


### <a name="get_project_avatar"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.GetProjectAvatar") GetProjectAvatar

> Retrieve the avatar for the project matching the supplied <strong>projectKey</strong>.
>  <p>
>  The authenticated user must have <strong>PROJECT_VIEW</strong> permission for the specified project to call this
>  resource.


```csharp
Task<string> GetProjectAvatar(string projectKey, int? s = 0)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| s |  ``` Optional ```  ``` DefaultValue ```  | The desired size of the image. The server will return an image as close as possible to the specified
             size. |


#### Example Usage

```csharp
string projectKey = "projectKey";
int? s = 0;

string result = await project.GetProjectAvatar(projectKey, s);

```


### <a name="upload_project_avatar"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProjectController.UploadProjectAvatar") UploadProjectAvatar

> Update the avatar for the project matching the supplied <strong>projectKey</strong>.
>  <p>
>  This resource accepts POST multipart form data, containing a single image in a form-field named 'avatar'.
>  <p>
>  There are configurable server limits on both the dimensions (1024x1024 pixels by default) and uploaded file size
>  (1MB by default). Several different image formats are supported, but <strong>PNG</strong> and
>  <strong>JPEG</strong> are preferred due to the file size limit.
>  <p>
>  An example <a href="http://curl.haxx.se/">curl</a> request to upload an image name 'avatar.png' would be:
>  <pre>
>  curl -X POST -u username:password http://example.com/rest/api/1.0/projects/STASH/avatar.png -F avatar=@avatar.png
>  </pre>
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
>  resource.


```csharp
Task<string> UploadProjectAvatar(string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";

string result = await project.UploadProjectAvatar(projectKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="task_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.TaskController") TaskController

### Get singleton instance

The singleton instance of the ``` TaskController ``` class can be accessed from the API Client.

```csharp
TaskController task = client.Task;
```

### <a name="get_task"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.TaskController.GetTask") GetTask

> Retrieve a existing task.


```csharp
Task<string> GetTask(long taskId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| taskId |  ``` Required ```  | the id identifying the task to delete |


#### Example Usage

```csharp
long taskId = 109;

string result = await task.GetTask(taskId);

```


### <a name="create_task"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.TaskController.CreateTask") CreateTask

> Create a new task.


```csharp
Task<string> CreateTask(object mdynamic)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();

string result = await task.CreateTask(mdynamic);

```


### <a name="delete_task"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.TaskController.DeleteTask") DeleteTask

> Delete a task.
>  <p>
>  Note that only the task's creator, the context's author or an admin of the context's repository can delete a
>  task. (For a pull request task, those are the task's creator, the pull request's author or an admin on the
>  repository containing the pull request). Additionally a task cannot be deleted if it has already been resolved.


```csharp
Task<string> DeleteTask(long taskId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| taskId |  ``` Required ```  | the id identifying the task to delete |


#### Example Usage

```csharp
long taskId = 109;

string result = await task.DeleteTask(taskId);

```


### <a name="update_task"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.TaskController.UpdateTask") UpdateTask

> Update a existing task.
>  <p>
>  As of Stash 3.3, only the state and text of a task can be updated.
>  <p>
>  Updating the state of a task is allowed for any user having <em>READ</em> access to the repository.
>  However only the task's creator, the context's author or an admin of the context's repository can update the
>  task's text. (For a pull request task, those are the task's creator, the pull request's author or an admin on the
>  repository containing the pull request). Additionally the task's text cannot be updated if it has been resolved.


```csharp
Task<string> UpdateTask(object mdynamic, long taskId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| taskId |  ``` Required ```  | the id identifying the task to delete |


#### Example Usage

```csharp
object mdynamic = new object();
long taskId = 109;

string result = await task.UpdateTask(mdynamic, taskId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="pull_request_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.PullRequestController") PullRequestController

### Get singleton instance

The singleton instance of the ``` PullRequestController ``` class can be accessed from the API Client.

```csharp
PullRequestController pullRequest = client.PullRequest;
```

### <a name="delete_unwatch_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.DeleteUnwatchPullRequest") DeleteUnwatchPullRequest

> Make the authenticated user stop watching the specified pull request.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> DeleteUnwatchPullRequest(string projectKey, string repositorySlug, long pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;

string result = await pullRequest.DeleteUnwatchPullRequest(projectKey, repositorySlug, pullRequestId);

```


### <a name="create_watch_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.CreateWatchPullRequest") CreateWatchPullRequest

> Make the authenticated user watch the specified pull request.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> CreateWatchPullRequest(string projectKey, string repositorySlug, long pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;

string result = await pullRequest.CreateWatchPullRequest(projectKey, repositorySlug, pullRequestId);

```


### <a name="get_pull_request_diff"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequestDiff") GetPullRequestDiff

> Streams a diff within a pull request.
>  <p>
>  If the specified file has been copied, moved or renamed, the <code>srcPath</code> must also be specified to
>  produce the correct diff.
>  <p>
>  Note: This RESTful endpoint is currently <i>not paged</i>. The server will internally apply a hard cap to the
>  streamed lines, and it is not possible to request subsequent pages if that cap is exceeded.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> GetPullRequestDiff(
        string projectKey,
        string repositorySlug,
        string pullRequestId,
        int? contextLines = -1,
        string srcPath = null,
        string whitespace = null,
        bool? withComments = true)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |
| contextLines |  ``` Optional ```  ``` DefaultValue ```  | the number of context lines to include around added/removed lines in the diff |
| srcPath |  ``` Optional ```  | the previous path to the file, if the file has been copied, moved or renamed |
| whitespace |  ``` Optional ```  | optional whitespace flag which can be set to <code>ignore-all</code> |
| withComments |  ``` Optional ```  ``` DefaultValue ```  | <code>true</code> to embed comments in the diff (the default); otherwise, <code>false</code>
                     to stream the diff without comments |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string pullRequestId = "pullRequestId";
int? contextLines = -1;
string srcPath = "srcPath";
string whitespace = "whitespace";
bool? withComments = true;

string result = await pullRequest.GetPullRequestDiff(projectKey, repositorySlug, pullRequestId, contextLines, srcPath, whitespace, withComments);

```


### <a name="get_pull_request_diff_by_path"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequestDiffByPath") GetPullRequestDiffByPath

> Streams a diff within a pull request.
>  <p>
>  If the specified file has been copied, moved or renamed, the <code>srcPath</code> must also be specified to
>  produce the correct diff.
>  <p>
>  Note: This RESTful endpoint is currently <i>not paged</i>. The server will internally apply a hard cap to the
>  streamed lines, and it is not possible to request subsequent pages if that cap is exceeded.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> GetPullRequestDiffByPath(
        string projectKey,
        string repositorySlug,
        string pullRequestId,
        string path,
        int? contextLines = -1,
        string srcPath = null,
        string whitespace = null,
        bool? withComments = true)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Required ```  | the path to the file which should be diffed (optional) |
| contextLines |  ``` Optional ```  ``` DefaultValue ```  | the number of context lines to include around added/removed lines in the diff |
| srcPath |  ``` Optional ```  | the previous path to the file, if the file has been copied, moved or renamed |
| whitespace |  ``` Optional ```  | optional whitespace flag which can be set to <code>ignore-all</code> |
| withComments |  ``` Optional ```  ``` DefaultValue ```  | <code>true</code> to embed comments in the diff (the default); otherwise, <code>false</code>
                     to stream the diff without comments |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string pullRequestId = "pullRequestId";
string path = "path";
int? contextLines = -1;
string srcPath = "srcPath";
string whitespace = "whitespace";
bool? withComments = true;

string result = await pullRequest.GetPullRequestDiffByPath(projectKey, repositorySlug, pullRequestId, path, contextLines, srcPath, whitespace, withComments);

```


### <a name="get_pull_request_commits"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequestCommits") GetPullRequestCommits

> Retrieve changesets for the specified pull request.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> GetPullRequestCommits(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        bool? withCounts = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |
| withCounts |  ``` Optional ```  | if set to true, the service will add "authorCount" and "totalCount" at the end of the page.
                     "authorCount" is the number of different authors and "totalCount" is the total number of changesets. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
bool? withCounts = false;

string result = await pullRequest.GetPullRequestCommits(projectKey, repositorySlug, pullRequestId, withCounts);

```


### <a name="get_pull_request_tasks"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequestTasks") GetPullRequestTasks

> Retrieve the tasks associated with a pull request.


```csharp
Task<string> GetPullRequestTasks(string projectKey, string repositorySlug, string pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string pullRequestId = "pullRequestId";

string result = await pullRequest.GetPullRequestTasks(projectKey, repositorySlug, pullRequestId);

```


### <a name="get_count_pull_request_tasks"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetCountPullRequestTasks") GetCountPullRequestTasks

> Retrieve the total number of {@link com.atlassian.stash.task.TaskState#OPEN open} and
>  {@link com.atlassian.stash.task.TaskState#RESOLVED resolved} tasks associated with a pull request.


```csharp
Task<string> GetCountPullRequestTasks(string projectKey, string repositorySlug, string pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string pullRequestId = "pullRequestId";

string result = await pullRequest.GetCountPullRequestTasks(projectKey, repositorySlug, pullRequestId);

```


### <a name="create_pull_request_comment"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.CreatePullRequestComment") CreatePullRequestComment

> Add a new comment.
>  <p>
>  Comments can be added in a few places by setting different attributes:
>  <p>
>  General pull request comment:
> 
>  <pre>
>      {
>          "text": "An insightful general comment on a pull request."
>      }
>      </pre>
> 
>  Reply to a comment:
> 
>  <pre>
>      {
>          "text": "A measured reply.",
>          "parent": {
>              "id": 1
>          }
>      }
>      </pre>
> 
>  General file comment:
> 
>  <pre>
>      {
>          "text": "An insightful general comment on a file.",
>          "anchor": {
>              "path": "path/to/file",
>              "srcPath": "path/to/file"
>          }
>      }
>      </pre>
> 
>  File line comment:
> 
>  <pre>
>      {
>          "text": "A pithy comment on a particular line within a file.",
>          "anchor": {
>              "line": 1,
>              "lineType": "CONTEXT",
>              "fileType": "FROM"
>              "path": "path/to/file",
>              "srcPath": "path/to/file"
>          }
>      }
>      </pre>
>  <strong>Note: general file comments are an experimental feature and may change in the near future!</strong>
>  <p>
>  For file and line comments, 'path' refers to the path of the file to which the comment should be applied and
>  'srcPath' refers to the path the that file used to have (only required for copies and moves).
>  <p>
>  For line comments, 'line' refers to the line in the diff that the comment should apply to. 'lineType' refers to
>  the type of diff hunk, which can be:
>  <ul>
>      <li>'ADDED' - for an added line;</li>
>      <li>'REMOVED' - for a removed line; or</li>
>      <li>'CONTEXT' - for a line that was unmodified but is in the vicinity of the diff.</li>
>  </ul>
>  'fileType' refers to the file of the diff to which the anchor should be attached - which is of relevance when
>  displaying the diff in a side-by-side way. Currently the supported values are:
>  <ul>
>      <li>'FROM' - the source file of the diff</li>
>      <li>'TO' - the destination file of the diff</li>
>  </ul>
>  If the current user is not a participant the user is added as a watcher of the pull request.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> CreatePullRequestComment(
        object mdynamic,
        string projectKey,
        string repositorySlug,
        long pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;

string result = await pullRequest.CreatePullRequestComment(mdynamic, projectKey, repositorySlug, pullRequestId);

```


### <a name="get_pull_request_comments"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequestComments") GetPullRequestComments

> TODO: Add a method description


```csharp
Task<dynamic> GetPullRequestComments(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        string path = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
string path = "path";

dynamic result = await pullRequest.GetPullRequestComments(projectKey, repositorySlug, pullRequestId, path);

```


### <a name="update_pull_request_comment"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.UpdatePullRequestComment") UpdatePullRequestComment

> Update the text of a comment. Only the user who created a comment may update it.
>  <p>
>  <strong>Note:</strong> the supplied supplied JSON object must contain a <code>version</code> that must match the
>  server's version of the comment or the update will fail. To determine the current version of
>  the comment, the comment should be fetched from the server prior to the update. Look for the
>  'version' attribute in the returned JSON structure.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> UpdatePullRequestComment(
        object mdynamic,
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        long commentId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |
| commentId |  ``` Required ```  | the id of the comment to retrieve |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
long commentId = 109;

string result = await pullRequest.UpdatePullRequestComment(mdynamic, projectKey, repositorySlug, pullRequestId, commentId);

```


### <a name="delete_pull_request_comment"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.DeletePullRequestComment") DeletePullRequestComment

> Delete a pull request comment. Anyone can delete their own comment. Only users with <strong>REPO_ADMIN</strong>
>  and above may delete comments created by other users.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> DeletePullRequestComment(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        long commentId,
        int? version = -1)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |
| commentId |  ``` Required ```  | the id of the comment to retrieve |
| version |  ``` Optional ```  ``` DefaultValue ```  | The expected version of the comment. This must match the server's version of the comment or
                      the delete will fail. To determine the current version of the comment, the comment should be
                      fetched from the server prior to the delete. Look for the 'version' attribute in the
                      returned JSON structure. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
long commentId = 109;
int? version = -1;

string result = await pullRequest.DeletePullRequestComment(projectKey, repositorySlug, pullRequestId, commentId, version);

```


### <a name="get_pull_request_comment"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequestComment") GetPullRequestComment

> Retrieves a pull request comment.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> GetPullRequestComment(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        long commentId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |
| commentId |  ``` Required ```  | the id of the comment to retrieve |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
long commentId = 109;

string result = await pullRequest.GetPullRequestComment(projectKey, repositorySlug, pullRequestId, commentId);

```


### <a name="get_pull_request_changes"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequestChanges") GetPullRequestChanges

> Gets changes for the specified PullRequest.
>  <p>
>  Note: This resource is currently <i>not paged</i>. The server will return at most one page. The server will
>  truncate the number of changes to either the request's page limit or an internal maximum, whichever is smaller.
>  The start parameter of the page request is also ignored.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> GetPullRequestChanges(
        string projectKey,
        string repositorySlug,
        string pullRequestId,
        bool? withComments = true)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |
| withComments |  ``` Optional ```  ``` DefaultValue ```  | {@code true} to apply comment counts in the changes (the default); otherwise, {@code false}
                     to stream changes without comment counts |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string pullRequestId = "pullRequestId";
bool? withComments = true;

string result = await pullRequest.GetPullRequestChanges(projectKey, repositorySlug, pullRequestId, withComments);

```


### <a name="get_pull_requests"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequests") GetPullRequests

> Retrieve a page of pull requests to or from the specified repository.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call
>  this resource.
> 
>  Optionally clients can specify PR participant filters. Each filter has a mandatory {@code username.N}
>  parameter, and the optional {@code role.N} and {@code approved.N} parameters.
>  <ul>
>      <li>
>          {@code username.N} - the "root" of a single participant filter, where "N" is a natural number
>          starting from 1. This allows clients to specify multiple participant filters, by providing consecutive
>          filters as {@code username.1}, {@code username.2} etc. Note that the filters numbering has to start
>          with 1 and be continuous for all filters to be processed. The total allowed number of participant
>          filters is 10 and all filters exceeding that limit will be dropped.
>      </li>
>      <li>
>          {@code role.N}(optional) the role associated with {@code username.N}.
>          This must be one of {@code AUTHOR}, {@code REVIEWER}, or{@code PARTICIPANT}
>      </li>
>      <li>
>          {@code approved.N}(optional) the approved status associated with {@code username.N}.
>          That is whether {@code username.N} has approved the PR. Either {@code true}, or {@code false}
>      </li>
>  </ul>


```csharp
Task<string> GetPullRequests(
        string projectKey,
        string repositorySlug,
        string direction = "incoming",
        string at = null,
        string state = null,
        string order = null,
        bool? withAttributes = true,
        bool? withProperties = true)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| direction |  ``` Optional ```  ``` DefaultValue ```  | (optional, defaults to <strong>INCOMING</strong>) the direction relative to the specified
                  repository. Either <strong>INCOMING</strong> or <strong>OUTGOING</strong>. |
| at |  ``` Optional ```  | (optional) a <i>fully-qualified</i> branch ID to find pull requests to or from,
           such as {@code refs/heads/master} |
| state |  ``` Optional ```  | (optional, defaults to <strong>OPEN</strong>). Supply <strong>ALL</strong> to return pull request
               in any state. If a state is supplied only pull requests in the specified state will be returned.
               Either <strong>OPEN</strong>, <strong>DECLINED</strong> or <strong>MERGED</strong>. |
| order |  ``` Optional ```  | (optional) the order to return pull requests in, either <strong>OLDEST</strong> (as in: "oldest
              first") or <strong>NEWEST</strong>. |
| withAttributes |  ``` Optional ```  ``` DefaultValue ```  | (optional) defaults to true, whether to return additional pull request attributes |
| withProperties |  ``` Optional ```  ``` DefaultValue ```  | (optional) defaults to true, whether to return additional pull request properties |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string direction = "incoming";
string at = "at";
string state = "state";
string order = "order";
bool? withAttributes = true;
bool? withProperties = true;

string result = await pullRequest.GetPullRequests(projectKey, repositorySlug, direction, at, state, order, withAttributes, withProperties);

```


### <a name="create_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.CreatePullRequest") CreatePullRequest

> Create a new pull request between two branches. The branches may be in the same repository, or different ones.
>  When using different repositories, they must still be in the same {@link Repository#getHierarchyId() hierarchy}.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the "from" and "to"repositories to
>  call this resource.


```csharp
Task<string> CreatePullRequest(object mdynamic, string projectKey, string repositorySlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";

string result = await pullRequest.CreatePullRequest(mdynamic, projectKey, repositorySlug);

```


### <a name="create_decline_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.CreateDeclinePullRequest") CreateDeclinePullRequest

> Decline a pull request.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> CreateDeclinePullRequest(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        int? version = -1)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |
| version |  ``` Optional ```  ``` DefaultValue ```  | the current version of the pull request. If the server's version isn't the same as the specified
                version the operation will fail. To determine the current version of the pull request it should be
                fetched from the server prior to this operation. Look for the 'version' attribute in the returned
                JSON structure. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
int? version = -1;

string result = await pullRequest.CreateDeclinePullRequest(projectKey, repositorySlug, pullRequestId, version);

```


### <a name="get_pull_request_activities"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequestActivities") GetPullRequestActivities

> Retrieve a page of activity associated with a pull request.
>  <p>
>  Activity items include comments, approvals, rescopes (i.e. adding and removing of commits), merges and more.
>  <p>
>  Different types of activity items may be introduced in newer versions of Stash or by user installed plugins, so
>  clients should be flexible enough to handle unexpected entity shapes in the returned page.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> GetPullRequestActivities(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        long? fromId = null,
        string fromType = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |
| fromId |  ``` Optional ```  | (optional) the id of the activity item to use as the first item in the returned page |
| fromType |  ``` Optional ```  | (required if <strong>fromId</strong> is present) the type of the activity item specified by
                 <strong>fromId</strong> (either <strong>COMMENT</strong> or <strong>ACTIVITY</strong>) |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
long? fromId = 109;
string fromType = "fromType";

string result = await pullRequest.GetPullRequestActivities(projectKey, repositorySlug, pullRequestId, fromId, fromType);

```


### <a name="create_reopen_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.CreateReopenPullRequest") CreateReopenPullRequest

> Re-open a declined pull request.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> CreateReopenPullRequest(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        int? version = -1)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |
| version |  ``` Optional ```  ``` DefaultValue ```  | the current version of the pull request. If the server's version isn't the same as the specified
                version the operation will fail. To determine the current version of the pull request it should be
                fetched from the server prior to this operation. Look for the 'version' attribute in the returned
                JSON structure. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
int? version = -1;

string result = await pullRequest.CreateReopenPullRequest(projectKey, repositorySlug, pullRequestId, version);

```


### <a name="get_can_merge_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetCanMergePullRequest") GetCanMergePullRequest

> Test whether a pull request can be merged.
>  <p>
>  A pull request may not be merged if:
>  <ul>
>      <li>there are conflicts that need to be manually resolved before merging; and/or</li>
>      <li>one or more merge checks have vetoed the merge.</li>
>  </ul>
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> GetCanMergePullRequest(string projectKey, string repositorySlug, long pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;

string result = await pullRequest.GetCanMergePullRequest(projectKey, repositorySlug, pullRequestId);

```


### <a name="create_merge_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.CreateMergePullRequest") CreateMergePullRequest

> Merge the specified pull request.
>  <p>
>  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> CreateMergePullRequest(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        int? version = -1)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |
| version |  ``` Optional ```  ``` DefaultValue ```  | the current version of the pull request. If the server's version isn't the same as the specified
                version the operation will fail. To determine the current version of the pull request it should be
                fetched from the server prior to this operation. Look for the 'version' attribute in the returned
                JSON structure. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
int? version = -1;

string result = await pullRequest.CreateMergePullRequest(projectKey, repositorySlug, pullRequestId, version);

```


### <a name="get_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.GetPullRequest") GetPullRequest

> Retrieve a pull request.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> GetPullRequest(string projectKey, string repositorySlug, string pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string pullRequestId = "pullRequestId";

string result = await pullRequest.GetPullRequest(projectKey, repositorySlug, pullRequestId);

```


### <a name="update_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.UpdatePullRequest") UpdatePullRequest

> Update the title, description, reviewers or destination branch of an existing pull request.
>  <p>
>  <strong>Note:</strong> the <em>reviewers</em> list may be updated using this resource. However the
>  <em>author</em> and <em>participants</em> list may not.
>  <p>
>  The authenticated user must either:
>  <ul>
>      <li>be the author of the pull request and have the <strong>REPO_READ</strong> permission for the repository
>      that this pull request targets; or</li>
>      <li>have the <strong>REPO_WRITE</strong> permission for the repository that this pull request targets</li>
>  </ul>
>  to call this resource.


```csharp
Task<string> UpdatePullRequest(
        object mdynamic,
        string projectKey,
        string repositorySlug,
        string pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string pullRequestId = "pullRequestId";

string result = await pullRequest.UpdatePullRequest(mdynamic, projectKey, repositorySlug, pullRequestId);

```


### <a name="create_assign_pull_request_participant_role"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.CreateAssignPullRequestParticipantRole") CreateAssignPullRequestParticipantRole

> Assigns a participant to an explicit role in pull request. Currently only the REVIEWER role may be assigned.
>  <p>
>  If the user is not yet a participant in the pull request, they are made one and assigned the supplied role.
>  <p>
>  If the user is already a participant in the pull request, their previous role is replaced with the supplied role
>  unless they are already assigned the AUTHOR role which cannot be changed and will result in a Bad Request (400)
>  response code.
>  <p>
>  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> CreateAssignPullRequestParticipantRole(
        object mdynamic,
        string projectKey,
        string repositorySlug,
        long pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;

string result = await pullRequest.CreateAssignPullRequestParticipantRole(mdynamic, projectKey, repositorySlug, pullRequestId);

```


### <a name="delete_unassign_pull_request_participant_role"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.DeleteUnassignPullRequestParticipantRole") DeleteUnassignPullRequestParticipantRole

> Unassigns a participant from the REVIEWER role they may have been given in a pull request.
>  <p>
>  If the participant has no explicit role this method has no effect.
>  <p>
>  Afterwards, the user will still remain a participant in the pull request but their role will be reduced to
>  PARTICIPANT. This is because once made a participant of a pull request,
>  a user will forever remain a participant. Only their role may be altered.
>  <p>
>  The authenticated user must have <strong>REPO_WRITE</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> DeleteUnassignPullRequestParticipantRole(
        string projectKey,
        string repositorySlug,
        long pullRequestId,
        string username = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |
| username |  ``` Optional ```  | the participant's user name |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;
string username = "username";

string result = await pullRequest.DeleteUnassignPullRequestParticipantRole(projectKey, repositorySlug, pullRequestId, username);

```


### <a name="list_pull_request_participants"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.ListPullRequestParticipants") ListPullRequestParticipants

> Retrieves a page of the participants for a given pull request.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> ListPullRequestParticipants(string projectKey, string repositorySlug, long pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;

string result = await pullRequest.ListPullRequestParticipants(projectKey, repositorySlug, pullRequestId);

```


### <a name="create_approve_pull_request"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.CreateApprovePullRequest") CreateApprovePullRequest

> Approve a pull request as the current user. Implicitly adds the user as a participant if they are not already.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> CreateApprovePullRequest(string projectKey, string repositorySlug, long pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;

string result = await pullRequest.CreateApprovePullRequest(projectKey, repositorySlug, pullRequestId);

```


### <a name="delete_withdraw_pull_request_approval"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.PullRequestController.DeleteWithdrawPullRequestApproval") DeleteWithdrawPullRequestApproval

> Remove approval from a pull request as the current user. This does not remove the user as a participant.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that this pull request
>  targets to call this resource.


```csharp
Task<string> DeleteWithdrawPullRequestApproval(string projectKey, string repositorySlug, long pullRequestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| pullRequestId |  ``` Required ```  | the id of the pull request within the repository |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
long pullRequestId = 109;

string result = await pullRequest.DeleteWithdrawPullRequestApproval(projectKey, repositorySlug, pullRequestId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="hook_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.HookController") HookController

### Get singleton instance

The singleton instance of the ``` HookController ``` class can be accessed from the API Client.

```csharp
HookController hook = client.Hook;
```

### <a name="get_avatar"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.HookController.GetAvatar") GetAvatar

> Retrieve the avatar for the project matching the supplied <strong>moduleKey</strong>.


```csharp
Task<string> GetAvatar(string hookKey, string version = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| hookKey |  ``` Required ```  | the complete module key of the hook module |
| version |  ``` Optional ```  | optional version used for HTTP caching only - any non-blank version will result in a large max-age Cache-Control header.
                Note that this does not affect the Last-Modified header. |


#### Example Usage

```csharp
string hookKey = "hookKey";
string version = "version";

string result = await hook.GetAvatar(hookKey, version);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="repository_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.RepositoryController") RepositoryController

### Get singleton instance

The singleton instance of the ``` RepositoryController ``` class can be accessed from the API Client.

```csharp
RepositoryController repository = client.Repository;
```

### <a name="get_repository_compare_diff_by_path"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryCompareDiffByPath") GetRepositoryCompareDiffByPath

> Gets a diff of the changes available in the {@code from} changeset but not in the {@code to} changeset.
>  <p>
>  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
>  default branch of their containing repository.


```csharp
Task<string> GetRepositoryCompareDiffByPath(
        string projectKey,
        string repositorySlug,
        string path,
        string mfrom = null,
        string to = null,
        string fromRepo = null,
        string srcPath = null,
        int? contextLines = -1,
        string whitespace = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Required ```  | the path to the file to diff (optional) |
| mfrom |  ``` Optional ```  | the source changeset (can be a partial/full changeset id or qualified/unqualified ref name) |
| to |  ``` Optional ```  | the target changeset (can be a partial/full changeset id or qualified/unqualified ref name) |
| fromRepo |  ``` Optional ```  | an optional parameter specifying the source repository containing the source changeset
                 if that changeset is not present in the current repository; the repository can be specified
                 by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by
                 a slash: <em>fromRepo=projectKey/repoSlug</em> |
| srcPath |  ``` Optional ```  | TODO: Add a parameter description |
| contextLines |  ``` Optional ```  ``` DefaultValue ```  | an optional number of context lines to include around each added or removed lines in the diff |
| whitespace |  ``` Optional ```  | an optional whitespace flag which can be set to <code>ignore-all</code> |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string path = "path";
string mfrom = "from";
string to = "to";
string fromRepo = "fromRepo";
string srcPath = "srcPath";
int? contextLines = -1;
string whitespace = "whitespace";

string result = await repository.GetRepositoryCompareDiffByPath(projectKey, repositorySlug, path, mfrom, to, fromRepo, srcPath, contextLines, whitespace);

```


### <a name="get_repository_compare_changes"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryCompareChanges") GetRepositoryCompareChanges

> Gets the file changes available in the {@code from} changeset but not in the {@code to} changeset.
>  <p>
>  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
>  default branch of their containing repository.


```csharp
Task<string> GetRepositoryCompareChanges(
        string projectKey,
        string repositorySlug,
        string mfrom = null,
        string to = null,
        string fromRepo = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| mfrom |  ``` Optional ```  | the source changeset (can be a partial/full changeset id or qualified/unqualified ref name) |
| to |  ``` Optional ```  | the target changeset (can be a partial/full changeset id or qualified/unqualified ref name) |
| fromRepo |  ``` Optional ```  | an optional parameter specifying the source repository containing the source changeset
                 if that changeset is not present in the current repository; the repository can be specified
                 by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by
                 a slash: <em>fromRepo=projectKey/repoSlug</em> |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string mfrom = "from";
string to = "to";
string fromRepo = "fromRepo";

string result = await repository.GetRepositoryCompareChanges(projectKey, repositorySlug, mfrom, to, fromRepo);

```


### <a name="get_repository_compare_commits"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryCompareCommits") GetRepositoryCompareCommits

> Gets the commits accessible from the {@code from} changeset but not in the {@code to} changeset.
>  <p>
>  If either the {@code from} or {@code to} changeset are not specified, they will be replaced by the
>  default branch of their containing repository.


```csharp
Task<string> GetRepositoryCompareCommits(
        string projectKey,
        string repositorySlug,
        string mfrom = null,
        string to = null,
        string fromRepo = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| mfrom |  ``` Optional ```  | the source changeset (can be a partial/full changeset id or qualified/unqualified ref name) |
| to |  ``` Optional ```  | the target changeset (can be a partial/full changeset id or qualified/unqualified ref name) |
| fromRepo |  ``` Optional ```  | an optional parameter specifying the source repository containing the source changeset
                 if that changeset is not present in the current repository; the repository can be specified
                 by either its ID <em>fromRepo=42</em> or by its project key plus its repo slug separated by
                 a slash: <em>fromRepo=projectKey/repoSlug</em> |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string mfrom = "from";
string to = "to";
string fromRepo = "fromRepo";

string result = await repository.GetRepositoryCompareCommits(projectKey, repositorySlug, mfrom, to, fromRepo);

```


### <a name="get_repository_branches"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryBranches") GetRepositoryBranches

> Retrieve the branches matching the supplied <strong>filterText</strong> param.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryBranches(
        string projectKey,
        string repositorySlug,
        string mbase = null,
        bool? details = null,
        string filterText = null,
        string orderBy = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| mbase |  ``` Optional ```  | base branch or tag to compare each branch to (for the metadata providers that uses that information) |
| details |  ``` Optional ```  | whether to retrieve plugin-provided metadata about each branch |
| filterText |  ``` Optional ```  | the text to match on |
| orderBy |  ``` Optional ```  | ordering of refs either ALPHABETICAL (by name) or MODIFICATION (last updated) |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string mbase = "base";
bool? details = false;
string filterText = "filterText";
string orderBy = "orderBy";

string result = await repository.GetRepositoryBranches(projectKey, repositorySlug, mbase, details, filterText, orderBy);

```


### <a name="get_repository_default_branch"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryDefaultBranch") GetRepositoryDefaultBranch

> Get the default branch of the repository.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryDefaultBranch(string projectKey, string repositorySlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";

string result = await repository.GetRepositoryDefaultBranch(projectKey, repositorySlug);

```


### <a name="update_set_repository_default_branch"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.UpdateSetRepositoryDefaultBranch") UpdateSetRepositoryDefaultBranch

> Update the default branch of a repository.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> UpdateSetRepositoryDefaultBranch(object mdynamic, string projectKey, string repositorySlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";

string result = await repository.UpdateSetRepositoryDefaultBranch(mdynamic, projectKey, repositorySlug);

```


### <a name="update_set_repository_permission_for_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.UpdateSetRepositoryPermissionForGroup") UpdateSetRepositoryPermissionForGroup

> Promote or demote a group's permission level for the specified repository. Available repository permissions are:
>  <ul>
>      <li>REPO_READ</li>
>      <li>REPO_WRITE</li>
>      <li>REPO_ADMIN</li>
>  </ul>
>  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+repository">Stash documentation</a>
>  for a detailed explanation of what each permission entails.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
>  project or global permission to call this resource. In addition, a user may not demote a group's permission level if their
>  own permission level would be reduced as a result.


```csharp
Task<string> UpdateSetRepositoryPermissionForGroup(
        string projectKey,
        string repositorySlug,
        string permission = null,
        string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| permission |  ``` Optional ```  | the permission to grant |
| name |  ``` Optional ```  | the names of the groups |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string permission = "permission";
string name = "name";

string result = await repository.UpdateSetRepositoryPermissionForGroup(projectKey, repositorySlug, permission, name);

```


### <a name="get_repository_groups_with_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryGroupsWithAnyPermission") GetRepositoryGroupsWithAnyPermission

> Retrieve a page of groups that have been granted at least one permission for the specified repository.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
>  project or global permission to call this resource.


```csharp
Task<string> GetRepositoryGroupsWithAnyPermission(string projectKey, string repositorySlug, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string filter = "filter";

string result = await repository.GetRepositoryGroupsWithAnyPermission(projectKey, repositorySlug, filter);

```


### <a name="delete_revoke_repository_permissions_for_group"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.DeleteRevokeRepositoryPermissionsForGroup") DeleteRevokeRepositoryPermissionsForGroup

> Revoke all permissions for the specified repository for a group.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
>  project or global permission to call this resource.
>  <p>
>  In addition, a user may not revoke a group's permissions if it will reduce their own permission level.


```csharp
Task<string> DeleteRevokeRepositoryPermissionsForGroup(string projectKey, string repositorySlug, string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | the name of the group |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string name = "name";

string result = await repository.DeleteRevokeRepositoryPermissionsForGroup(projectKey, repositorySlug, name);

```


### <a name="update_set_repository_permission_for_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.UpdateSetRepositoryPermissionForUser") UpdateSetRepositoryPermissionForUser

> Promote or demote a user's permission level for the specified repository. Available repository permissions are:
>  <ul>
>      <li>REPO_READ</li>
>      <li>REPO_WRITE</li>
>      <li>REPO_ADMIN</li>
>  </ul>
>  See the <a href="https://confluence.atlassian.com/display/STASH/Managing+permissions+for+a+repository">Stash documentation</a>
>  for a detailed explanation of what each permission entails.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
>  project or global permission to call this resource. In addition, a user may not reduce their own permission level unless
>  they have a project or global permission that already implies that permission.


```csharp
Task<string> UpdateSetRepositoryPermissionForUser(
        string projectKey,
        string repositorySlug,
        string name = null,
        string permission = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | the names of the users |
| permission |  ``` Optional ```  | the permission to grant |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string name = "name";
string permission = "permission";

string result = await repository.UpdateSetRepositoryPermissionForUser(projectKey, repositorySlug, name, permission);

```


### <a name="get_repository_users_with_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryUsersWithAnyPermission") GetRepositoryUsersWithAnyPermission

> Retrieve a page of users that have been granted at least one permission for the specified repository.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
>  project or global permission to call this resource.


```csharp
Task<string> GetRepositoryUsersWithAnyPermission(string projectKey, string repositorySlug, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string filter = "filter";

string result = await repository.GetRepositoryUsersWithAnyPermission(projectKey, repositorySlug, filter);

```


### <a name="delete_revoke_repository_permissions_for_user"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.DeleteRevokeRepositoryPermissionsForUser") DeleteRevokeRepositoryPermissionsForUser

> Revoke all permissions for the specified repository for a user.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
>  project or global permission to call this resource.
>  <p>
>  In addition, a user may not revoke their own repository permissions if they do not have a higher
>  project or global permission.


```csharp
Task<string> DeleteRevokeRepositoryPermissionsForUser(string projectKey, string repositorySlug, string name = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| name |  ``` Optional ```  | the name of the user |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string name = "name";

string result = await repository.DeleteRevokeRepositoryPermissionsForUser(projectKey, repositorySlug, name);

```


### <a name="get_repository_groups_without_any_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryGroupsWithoutAnyPermission") GetRepositoryGroupsWithoutAnyPermission

> Retrieve a page of groups that have no granted permissions for the specified repository.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
>  project or global permission to call this resource.


```csharp
Task<string> GetRepositoryGroupsWithoutAnyPermission(string projectKey, string repositorySlug, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string filter = "filter";

string result = await repository.GetRepositoryGroupsWithoutAnyPermission(projectKey, repositorySlug, filter);

```


### <a name="get_repository_users_without_permission"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryUsersWithoutPermission") GetRepositoryUsersWithoutPermission

> Retrieve a page of <i>licensed</i> users that have no granted permissions for the specified repository.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository or a higher
>  project or global permission to call this resource.


```csharp
Task<string> GetRepositoryUsersWithoutPermission(string projectKey, string repositorySlug, string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| filter |  ``` Optional ```  | if specified only group names containing the supplied string will be returned |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string filter = "filter";

string result = await repository.GetRepositoryUsersWithoutPermission(projectKey, repositorySlug, filter);

```


### <a name="get_repository_commits"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryCommits") GetRepositoryCommits

> Retrieve a page of commits from a given starting commit or "between" two commits. If no explicit commit is
>  specified, the tip of the repository's default branch is assumed. commits may be identified by branch or tag
>  name or by ID. A path may be supplied to restrict the returned commits to only those which affect that path.
>  <p>
>  The authenticated user must have <b>REPO_READ</b> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryCommits(
        string projectKey,
        string repositorySlug,
        string path = null,
        string since = null,
        string until = null,
        bool? withCounts = false)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Optional ```  | an optional path to filter commits by |
| since |  ``` Optional ```  | the commit ID or ref (exclusively) to retrieve commits after |
| until |  ``` Optional ```  | the commit ID (SHA1) or ref (inclusively) to retrieve commits before |
| withCounts |  ``` Optional ```  ``` DefaultValue ```  | optionally include the total number of commits and total number of unique authors |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string path = "path";
string since = "since";
string until = "until";
bool? withCounts = false;

string result = await repository.GetRepositoryCommits(projectKey, repositorySlug, path, since, until, withCounts);

```


### <a name="get_repository_tags"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryTags") GetRepositoryTags

> Retrieve the tags matching the supplied <strong>filterText</strong> param.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the context repository to call this
>  resource.


```csharp
Task<string> GetRepositoryTags(
        string projectKey,
        string repositorySlug,
        string filterText = null,
        string orderBy = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| filterText |  ``` Optional ```  | the text to match on |
| orderBy |  ``` Optional ```  | ordering of refs either ALPHABETICAL (by name) or MODIFICATION (last updated) |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string filterText = "filterText";
string orderBy = "orderBy";

string result = await repository.GetRepositoryTags(projectKey, repositorySlug, filterText, orderBy);

```


### <a name="get_repositories"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositories") GetRepositories

> Retrieve a page of repositories based on query parameters that control the search. See the documentation of the
>  parameters for more details.
>  <p>
>  This resource is anonymously accessible.
>  <p>
>  <b>Note on permissions.</b> In absence of the {@code permission} query parameter the implicit 'read' permission
>  is assumed. Please note that this permission is lower than the REPO_READ permission rather than being equal to
>  it. The implicit 'read' permission for a given repository is assigned to any user that has any of the higher
>  permissions, such as <tt>REPO_READ</tt>, as well as to anonymous users if the repository is marked as public.
>  The important implication of the above is that an anonymous request to this resource with a permission level
>  <tt>REPO_READ</tt> is guaranteed to receive an empty list of repositories as a result. For anonymous requests
>  it is therefore recommended to not specify the <tt>permission</tt> parameter at all.


```csharp
Task<string> GetRepositories(
        string name = null,
        string projectname = null,
        string permission = null,
        string visibility = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Optional ```  | (optional) if specified, this will limit the resulting repository list to ones whose name
                    matches this parameter's value. The match will be done case-insensitive and any leading
                    and/or trailing whitespace characters on the <code>name</code> parameter will be stripped. |
| projectname |  ``` Optional ```  | (optional) if specified, this will limit the resulting repository list to ones whose project's
                    name matches this parameter's value. The match will be done case-insensitive and any leading
                    and/or trailing whitespace characters on the <code>projectname</code> parameter will
                    be stripped. |
| permission |  ``` Optional ```  | (optional) if specified, it must be a valid repository permission level name and will limit
                    the resulting repository list to ones that the requesting user has the specified permission
                    level to. If not specified, the default implicit 'read' permission level will be assumed. The
                    currently supported explicit permission values are <tt>REPO_READ</tt>, <tt>REPO_WRITE</tt>
                    and <tt>REPO_ADMIN</tt>. |
| visibility |  ``` Optional ```  | (optional) if specified, this will limit the resulting repository list based on the
                    repositories visibility. Valid values are <em>public</em> or <em>private</em>. |


#### Example Usage

```csharp
string name = "name";
string projectname = "projectname";
string permission = "permission";
string visibility = "visibility";

string result = await repository.GetRepositories(name, projectname, permission, visibility);

```


### <a name="list_repository_files"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.ListRepositoryFiles") ListRepositoryFiles

> Retrieve a page of files from particular directory of a repository. The search is done recursively, so all files
>  from any sub-directory of the specified directory will be returned.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> ListRepositoryFiles(string projectKey, string repositorySlug, string at = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| at |  ``` Optional ```  | the changeset id or ref (e.g. a branch or tag) to list the files at.
             If not specified the default branch will be used instead. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string at = "at";

string result = await repository.ListRepositoryFiles(projectKey, repositorySlug, at);

```


### <a name="list_repository_files_by_path"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.ListRepositoryFilesByPath") ListRepositoryFilesByPath

> Retrieve a page of files from particular directory of a repository. The search is done recursively, so all files
>  from any sub-directory of the specified directory will be returned.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> ListRepositoryFilesByPath(
        string projectKey,
        string repositorySlug,
        string path,
        string at = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Required ```  | the directory to list files for. |
| at |  ``` Optional ```  | the changeset id or ref (e.g. a branch or tag) to list the files at.
             If not specified the default branch will be used instead. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string path = "path";
string at = "at";

string result = await repository.ListRepositoryFilesByPath(projectKey, repositorySlug, path, at);

```


### <a name="create_repository"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.CreateRepository") CreateRepository

> Create a new repository. Requires an existing project in which this repository will be created.
>  The only parameters which will be used are name and scmId.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the context project to call this
>  resource.


```csharp
Task<string> CreateRepository(object mdynamic, string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | the parent project key |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";

string result = await repository.CreateRepository(mdynamic, projectKey);

```


### <a name="delete_repository"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.DeleteRepository") DeleteRepository

> Schedule the repository matching the supplied <strong>projectKey</strong> and <strong>repositorySlug</strong> to
>  be deleted. If the request repository is not present
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> DeleteRepository(string repositorySlug, string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| repositorySlug |  ``` Required ```  | the repository slug |
| projectKey |  ``` Required ```  | the parent project key |


#### Example Usage

```csharp
string repositorySlug = "repositorySlug";
string projectKey = "projectKey";

string result = await repository.DeleteRepository(repositorySlug, projectKey);

```


### <a name="create_fork_repository"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.CreateForkRepository") CreateForkRepository

> Create a new repository forked from an existing repository.
>  <p>
>  The JSON body for this {@code POST} is not required to contain <i>any</i> properties. Even the name may be
>  omitted. The following properties will be used, if provided:
>  <ul>
>      <li>{@code "name":"Fork name"} - Specifies the forked repository's name
>      <ul>
>          <li>Defaults to the name of the origin repository if not specified</li>
>      </ul>
>      </li>
>      <li>{@code "project":{"key":"TARGET_KEY"}} - Specifies the forked repository's target project by key
>      <ul>
>          <li>Defaults to the current user's personal project if not specified</li>
>      </ul>
>      </li>
>  </ul>
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository and
>  <strong>PROJECT_ADMIN</strong> on the target project to call this resource. Note that users <i>always</i>
>  have <b>PROJECT_ADMIN</b> permission on their personal projects.


```csharp
Task<string> CreateForkRepository(object mdynamic, string repositorySlug, string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | the repository slug |
| projectKey |  ``` Required ```  | the parent project key |


#### Example Usage

```csharp
object mdynamic = new object();
string repositorySlug = "repositorySlug";
string projectKey = "projectKey";

string result = await repository.CreateForkRepository(mdynamic, repositorySlug, projectKey);

```


### <a name="get_repository"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepository") GetRepository

> Retrieve the repository matching the supplied <strong>projectKey</strong> and <strong>repositorySlug</strong>.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepository(string repositorySlug, string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| repositorySlug |  ``` Required ```  | the repository slug |
| projectKey |  ``` Required ```  | the parent project key |


#### Example Usage

```csharp
string repositorySlug = "repositorySlug";
string projectKey = "projectKey";

string result = await repository.GetRepository(repositorySlug, projectKey);

```


### <a name="update_repository"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.UpdateRepository") UpdateRepository

> Update the repository matching the <strong>repositorySlug</strong> supplied in the resource path.
>  <p>
>  The repository's slug is derived from its name. If the name changes the slug may also change.
>  <p>
>  This API can be used to move the repository to a different project by setting the new project in the request,
>  example: {@code {"project":{"key":"NEW_KEY"}}} .
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> UpdateRepository(object mdynamic, string repositorySlug, string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | the repository slug |
| projectKey |  ``` Required ```  | the parent project key |


#### Example Usage

```csharp
object mdynamic = new object();
string repositorySlug = "repositorySlug";
string projectKey = "projectKey";

string result = await repository.UpdateRepository(mdynamic, repositorySlug, projectKey);

```


### <a name="get_forked_repositories"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetForkedRepositories") GetForkedRepositories

> Retrieve repositories which have been forked from this one. Unlike {@link #getRelatedRepositories(Repository,
>  PageRequest) related repositories}, this only looks at a given repository's direct forks. If those forks have
>  themselves been the origin of more forks, such "grandchildren" repositories will not be retrieved.
>  <p>
>  Only repositories to which the authenticated user has <b>REPO_READ</b> permission will be included, even
>  if other repositories have been forked from this one.


```csharp
Task<string> GetForkedRepositories(string projectKey, string repositorySlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";

string result = await repository.GetForkedRepositories(projectKey, repositorySlug);

```


### <a name="get_related_repositories"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRelatedRepositories") GetRelatedRepositories

> Retrieve repositories which are related to this one. Related repositories are from the same
>  {@link Repository#getHierarchyId() hierarchy} as this repository.
>  <p>
>  Only repositories to which the authenticated user has <b>REPO_READ</b> permission will be included, even
>  if more repositories are part of this repository's hierarchy.


```csharp
Task<string> GetRelatedRepositories(string projectKey, string repositorySlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";

string result = await repository.GetRelatedRepositories(projectKey, repositorySlug);

```


### <a name="create_retry_create_repository"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.CreateRetryCreateRepository") CreateRetryCreateRepository

> If a create or fork operation fails, calling this method will clean up the broken repository and try again. The
>  repository must be in an INITIALISATION_FAILED state.
>  <p>
>  The authenticated user must have <strong>PROJECT_ADMIN</strong> permission for the specified project to call this
>  resource.


```csharp
Task<string> CreateRetryCreateRepository(string projectKey, string repositorySlug)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";

string result = await repository.CreateRetryCreateRepository(projectKey, repositorySlug);

```


### <a name="get_repository_show_diff"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryShowDiff") GetRepositoryShowDiff

> Retrieve the diff for a specified file path between two provided revisions.
>  <p>
>  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
>  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
>  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
>  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryShowDiff(
        string projectKey,
        string repositorySlug,
        int? contextLines = -1,
        string since = null,
        string srcPath = null,
        string until = null,
        string whitespace = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| contextLines |  ``` Optional ```  ``` DefaultValue ```  | the number of context lines to include around added/removed lines in the diff |
| since |  ``` Optional ```  | the base revision to diff from. If omitted the parent revision of the until revision is used |
| srcPath |  ``` Optional ```  | the source path for the file, if it was copied, moved or renamed |
| until |  ``` Optional ```  | the target revision to diff to (required) |
| whitespace |  ``` Optional ```  | optional whitespace flag which can be set to <code>ignore-all</code> |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
int? contextLines = -1;
string since = "since";
string srcPath = "srcPath";
string until = "until";
string whitespace = "whitespace";

string result = await repository.GetRepositoryShowDiff(projectKey, repositorySlug, contextLines, since, srcPath, until, whitespace);

```


### <a name="get_repository_show_diff_by_path"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryShowDiffByPath") GetRepositoryShowDiffByPath

> Retrieve the diff for a specified file path between two provided revisions.
>  <p>
>  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
>  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
>  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
>  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryShowDiffByPath(
        string projectKey,
        string repositorySlug,
        string path,
        int? contextLines = -1,
        string since = null,
        string srcPath = null,
        string until = null,
        string whitespace = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Required ```  | the path to the file which should be diffed (required) |
| contextLines |  ``` Optional ```  ``` DefaultValue ```  | the number of context lines to include around added/removed lines in the diff |
| since |  ``` Optional ```  | the base revision to diff from. If omitted the parent revision of the until revision is used |
| srcPath |  ``` Optional ```  | the source path for the file, if it was copied, moved or renamed |
| until |  ``` Optional ```  | the target revision to diff to (required) |
| whitespace |  ``` Optional ```  | optional whitespace flag which can be set to <code>ignore-all</code> |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string path = "path";
int? contextLines = -1;
string since = "since";
string srcPath = "srcPath";
string until = "until";
string whitespace = "whitespace";

string result = await repository.GetRepositoryShowDiffByPath(projectKey, repositorySlug, path, contextLines, since, srcPath, until, whitespace);

```


### <a name="get_repository_content"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryContent") GetRepositoryContent

> Retrieve a page of content for a file path at a specified revision.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryContent(
        string projectKey,
        string repositorySlug,
        string at = null,
        bool? type = false,
        string blame = null,
        string noContent = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| at |  ``` Optional ```  | the changeset id or ref to retrieve the content for. |
| type |  ``` Optional ```  ``` DefaultValue ```  | if true only the type will be returned for the file path instead of the contents. |
| blame |  ``` Optional ```  | if present the blame will be returned for the file as well. |
| noContent |  ``` Optional ```  | if present and used with blame only the blame is retrieved instead of the contents. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string at = "at";
bool? type = false;
string blame = "blame";
string noContent = "noContent";

string result = await repository.GetRepositoryContent(projectKey, repositorySlug, at, type, blame, noContent);

```


### <a name="get_repository_content_by_path"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryContentByPath") GetRepositoryContentByPath

> Retrieve a page of content for a file path at a specified revision.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryContentByPath(
        string projectKey,
        string repositorySlug,
        string path,
        string at = null,
        bool? type = false,
        string blame = null,
        string noContent = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Required ```  | the file path to retrieve content from |
| at |  ``` Optional ```  | the changeset id or ref to retrieve the content for. |
| type |  ``` Optional ```  ``` DefaultValue ```  | if true only the type will be returned for the file path instead of the contents. |
| blame |  ``` Optional ```  | if present the blame will be returned for the file as well. |
| noContent |  ``` Optional ```  | if present and used with blame only the blame is retrieved instead of the contents. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string path = "path";
string at = "at";
bool? type = false;
string blame = "blame";
string noContent = "noContent";

string result = await repository.GetRepositoryContentByPath(projectKey, repositorySlug, path, at, type, blame, noContent);

```


### <a name="create_repository_commit_comment"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.CreateRepositoryCommitComment") CreateRepositoryCommitComment

> Add a new comment.
>  <p>
>  Comments can be added in a few places by setting different attributes:
>  <p>
>  General commit comment:
> 
>  <pre>
>      {
>          "text": "An insightful general comment on a commit."
>      }
>      </pre>
> 
>  Reply to a comment:
> 
>  <pre>
>      {
>          "text": "A measured reply.",
>          "parent": {
>              "id": 1
>          }
>      }
>      </pre>
> 
>  General file comment:
> 
>  <pre>
>      {
>          "text": "An insightful general comment on a file.",
>          "anchor": {
>              "path": "path/to/file",
>              "srcPath": "path/to/file"
>          }
>      }
>      </pre>
> 
>  File line comment:
> 
>  <pre>
>      {
>          "text": "A pithy comment on a particular line within a file.",
>          "anchor": {
>              "line": 1,
>              "lineType": "CONTEXT",
>              "fileType": "FROM"
>              "path": "path/to/file",
>              "srcPath": "path/to/file"
>      }
>      }
>      </pre>
>  <strong>Note: general file comments are an experimental feature and may change in the near future!</strong>
>  <p>
>  For file and line comments, 'path' refers to the path of the file to which the comment should be applied and
>  'srcPath' refers to the path the that file used to have (only required for copies and moves).
>  <p>
>  For line comments, 'line' refers to the line in the diff that the comment should apply to. 'lineType' refers to
>  the type of diff hunk, which can be:
>  <ul>
>      <li>'ADDED' - for an added line;</li>
>      <li>'REMOVED' - for a removed line; or</li>
>      <li>'CONTEXT' - for a line that was unmodified but is in the vicinity of the diff.</li>
>  </ul>
>  'fileType' refers to the file of the diff to which the anchor should be attached - which is of relevance when
>  displaying the diff in a side-by-side way. Currently the supported values are:
>  <ul>
>      <li>'FROM' - the source file of the diff</li>
>      <li>'TO' - the destination file of the diff</li>
>  </ul>
>  If the current user is not a participant the user is added as one and updated to watch the commit.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
>  is in to call this resource.


```csharp
Task<string> CreateRepositoryCommitComment(
        object mdynamic,
        string projectKey,
        string repositorySlug,
        string commitId,
        string since = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| commitId |  ``` Required ```  | TODO: Add a parameter description |
| since |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string commitId = "commitId";
string since = "since";

string result = await repository.CreateRepositoryCommitComment(mdynamic, projectKey, repositorySlug, commitId, since);

```


### <a name="get_repository_commit_comments"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryCommitComments") GetRepositoryCommitComments

> TODO: Add a method description


```csharp
Task<dynamic> GetRepositoryCommitComments(
        string projectKey,
        string repositorySlug,
        string commitId,
        string path = null,
        string since = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| commitId |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Optional ```  | TODO: Add a parameter description |
| since |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string commitId = "commitId";
string path = "path";
string since = "since";

dynamic result = await repository.GetRepositoryCommitComments(projectKey, repositorySlug, commitId, path, since);

```


### <a name="update_repository_commit_comment"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.UpdateRepositoryCommitComment") UpdateRepositoryCommitComment

> Update the text of a comment. Only the user who created a comment may update it.
>  <p>
>  <strong>Note:</strong> the supplied supplied JSON object must contain a <code>version</code> that must match
>  the server's version of the comment or the update will fail. To determine the current version of the comment,
>  the comment should be fetched from the server prior to the update. Look for the 'version' attribute in the
>  returned JSON structure.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
>  is in to call this resource.


```csharp
Task<string> UpdateRepositoryCommitComment(
        object mdynamic,
        string projectKey,
        string repositorySlug,
        string commitId,
        long commentId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| commitId |  ``` Required ```  | the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository |
| commentId |  ``` Required ```  | the ID of the comment to retrieve |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string commitId = "commitId";
long commentId = 67;

string result = await repository.UpdateRepositoryCommitComment(mdynamic, projectKey, repositorySlug, commitId, commentId);

```


### <a name="delete_repository_commit_comment"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.DeleteRepositoryCommitComment") DeleteRepositoryCommitComment

> Delete a commit comment. Anyone can delete their own comment. Only users with <strong>REPO_ADMIN</strong>
>  and above may delete comments created by other users. Comments which have replies <i>may not be deleted</i>,
>  regardless of the user's granted permissions.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
>  is in to call this resource.


```csharp
Task<string> DeleteRepositoryCommitComment(
        string projectKey,
        string repositorySlug,
        string commitId,
        long commentId,
        int? version = -1)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| commitId |  ``` Required ```  | the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository |
| commentId |  ``` Required ```  | the ID of the comment to retrieve |
| version |  ``` Optional ```  ``` DefaultValue ```  | The expected version of the comment. This must match the server's version of the comment or
                  the delete will fail. To determine the current version of the comment, the comment should be
                  fetched from the server prior to the delete. Look for the 'version' attribute in the returned
                  JSON structure. |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string commitId = "commitId";
long commentId = 67;
int? version = -1;

string result = await repository.DeleteRepositoryCommitComment(projectKey, repositorySlug, commitId, commentId, version);

```


### <a name="get_repository_commit_comment"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryCommitComment") GetRepositoryCommitComment

> Retrieves a commit discussion comment.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository that the commit
>  is in to call this resource.


```csharp
Task<string> GetRepositoryCommitComment(
        string projectKey,
        string repositorySlug,
        string commitId,
        long commentId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| commitId |  ``` Required ```  | the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository |
| commentId |  ``` Required ```  | the ID of the comment to retrieve |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string commitId = "commitId";
long commentId = 67;

string result = await repository.GetRepositoryCommitComment(projectKey, repositorySlug, commitId, commentId);

```


### <a name="get_repository_hooks"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryHooks") GetRepositoryHooks

> Retrieve a page of repository hooks for this repository.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryHooks(string projectKey, string repositorySlug, string type = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| type |  ``` Optional ```  | the optional type to filter by. Valid values are <code>PRE_RECEIVE</code> or <code>POST_RECEIVE</code> |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string type = "type";

string result = await repository.GetRepositoryHooks(projectKey, repositorySlug, type);

```


### <a name="update_set_repository_hook_settings"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.UpdateSetRepositoryHookSettings") UpdateSetRepositoryHookSettings

> Modify the settings for a repository hook for this repositories.
>  <p>
>  The service will reject any settings which are too large, the current limit is 32KB once serialized.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> UpdateSetRepositoryHookSettings(
        object mdynamic,
        string projectKey,
        string repositorySlug,
        string hookKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| hookKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string hookKey = "hookKey";

string result = await repository.UpdateSetRepositoryHookSettings(mdynamic, projectKey, repositorySlug, hookKey);

```


### <a name="get_repository_hook_settings"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryHookSettings") GetRepositoryHookSettings

> Retrieve the settings for a repository hook for this repositories.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryHookSettings(string projectKey, string repositorySlug, string hookKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| hookKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string hookKey = "hookKey";

string result = await repository.GetRepositoryHookSettings(projectKey, repositorySlug, hookKey);

```


### <a name="get_repository_hook"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryHook") GetRepositoryHook

> Retrieve a repository hook for this repositories.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryHook(string projectKey, string repositorySlug, string hookKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| hookKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string hookKey = "hookKey";

string result = await repository.GetRepositoryHook(projectKey, repositorySlug, hookKey);

```


### <a name="update_enable_repository_hook"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.UpdateEnableRepositoryHook") UpdateEnableRepositoryHook

> Enable a repository hook for this repositories and optionally applying new configuration.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> UpdateEnableRepositoryHook(
        string projectKey,
        string repositorySlug,
        string hookKey,
        int? contentLength = 0)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| hookKey |  ``` Required ```  | TODO: Add a parameter description |
| contentLength |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string hookKey = "hookKey";
int? contentLength = 0;

string result = await repository.UpdateEnableRepositoryHook(projectKey, repositorySlug, hookKey, contentLength);

```


### <a name="delete_disable_repository_hook"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.DeleteDisableRepositoryHook") DeleteDisableRepositoryHook

> Disable a repository hook for this repositories.
>  <p>
>  The authenticated user must have <strong>REPO_ADMIN</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> DeleteDisableRepositoryHook(string projectKey, string repositorySlug, string hookKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| hookKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string hookKey = "hookKey";

string result = await repository.DeleteDisableRepositoryHook(projectKey, repositorySlug, hookKey);

```


### <a name="get_repository_changes"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryChanges") GetRepositoryChanges

> Retrieve a page of changes made in a specified commit.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryChanges(
        string projectKey,
        string repositorySlug,
        string since = null,
        string until = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| since |  ``` Optional ```  | the commit to which <code>until</code> should be compared to produce a page of changes.
                     If not specified the commit's first parent is assumed (if one exists) |
| until |  ``` Optional ```  | the commit to retrieve changes for |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string since = "since";
string until = "until";

string result = await repository.GetRepositoryChanges(projectKey, repositorySlug, since, until);

```


### <a name="delete_unwatch_repository_commit"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.DeleteUnwatchRepositoryCommit") DeleteUnwatchRepositoryCommit

> Removes the authenticated user as a watcher for the specified commit.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository containing the commit
>  to call this resource.


```csharp
Task<string> DeleteUnwatchRepositoryCommit(string projectKey, string repositorySlug, string commitId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| commitId |  ``` Required ```  | the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string commitId = "commitId";

string result = await repository.DeleteUnwatchRepositoryCommit(projectKey, repositorySlug, commitId);

```


### <a name="create_watch_repository_commit"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.CreateWatchRepositoryCommit") CreateWatchRepositoryCommit

> Adds the authenticated user as a watcher for the specified commit.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the repository containing the commit
>  to call this resource.


```csharp
Task<string> CreateWatchRepositoryCommit(string projectKey, string repositorySlug, string commitId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| commitId |  ``` Required ```  | the <i>full {@link Changeset#getId() ID}</i> of the commit within the repository |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string commitId = "commitId";

string result = await repository.CreateWatchRepositoryCommit(projectKey, repositorySlug, commitId);

```


### <a name="get_repository_commit_diff"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryCommitDiff") GetRepositoryCommitDiff

> Retrieve the diff between two provided revisions.
>  <p>
>  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
>  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
>  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
>  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryCommitDiff(
        string projectKey,
        string repositorySlug,
        string commitId,
        int? contextLines = -1,
        string since = null,
        string srcPath = null,
        string whitespace = null,
        bool? withComments = true)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| commitId |  ``` Required ```  | TODO: Add a parameter description |
| contextLines |  ``` Optional ```  ``` DefaultValue ```  | the number of context lines to include around added/removed lines in the diff |
| since |  ``` Optional ```  | the base revision to diff from. If omitted the parent revision of the until revision is used |
| srcPath |  ``` Optional ```  | the source path for the file, if it was copied, moved or renamed |
| whitespace |  ``` Optional ```  | optional whitespace flag which can be set to <code>ignore-all</code> |
| withComments |  ``` Optional ```  ``` DefaultValue ```  | <code>true</code> to embed comments in the diff (the default); otherwise <code>false</code>
                     to stream the diff without comments |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string commitId = "commitId";
int? contextLines = -1;
string since = "since";
string srcPath = "srcPath";
string whitespace = "whitespace";
bool? withComments = true;

string result = await repository.GetRepositoryCommitDiff(projectKey, repositorySlug, commitId, contextLines, since, srcPath, whitespace, withComments);

```


### <a name="get_repository_commit_diff_by_path"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositoryCommitDiffByPath") GetRepositoryCommitDiffByPath

> Retrieve the diff between two provided revisions.
>  <p>
>  <strong>Note:</strong> This resource is currently <i>not paged</i>. The server will internally apply a hard cap
>  to the streamed lines, and it is not possible to request subsequent pages if that cap is exceeded. In the event
>  that the cap is reached, the diff will be cut short and one or more <code>truncated</code> flags will be set to
>  <code>true</code> on the segments, hunks and diffs substructures in the returned JSON response.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified repository to call this
>  resource.


```csharp
Task<string> GetRepositoryCommitDiffByPath(
        string projectKey,
        string repositorySlug,
        string path,
        string commitId,
        int? contextLines = -1,
        string since = null,
        string srcPath = null,
        string whitespace = null,
        bool? withComments = true)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | TODO: Add a parameter description |
| repositorySlug |  ``` Required ```  | TODO: Add a parameter description |
| path |  ``` Required ```  | the path to the file which should be diffed (optional) |
| commitId |  ``` Required ```  | TODO: Add a parameter description |
| contextLines |  ``` Optional ```  ``` DefaultValue ```  | the number of context lines to include around added/removed lines in the diff |
| since |  ``` Optional ```  | the base revision to diff from. If omitted the parent revision of the until revision is used |
| srcPath |  ``` Optional ```  | the source path for the file, if it was copied, moved or renamed |
| whitespace |  ``` Optional ```  | optional whitespace flag which can be set to <code>ignore-all</code> |
| withComments |  ``` Optional ```  ``` DefaultValue ```  | <code>true</code> to embed comments in the diff (the default); otherwise <code>false</code>
                     to stream the diff without comments |


#### Example Usage

```csharp
string projectKey = "projectKey";
string repositorySlug = "repositorySlug";
string path = "path";
string commitId = "commitId";
int? contextLines = -1;
string since = "since";
string srcPath = "srcPath";
string whitespace = "whitespace";
bool? withComments = true;

string result = await repository.GetRepositoryCommitDiffByPath(projectKey, repositorySlug, path, commitId, contextLines, since, srcPath, whitespace, withComments);

```


### <a name="get_repositories"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.RepositoryController.GetRepositories") GetRepositories

> Retrieve repositories from the project corresponding to the supplied <strong>projectKey</strong>.
>  <p>
>  The authenticated user must have <strong>REPO_READ</strong> permission for the specified project to call this
>  resource.


```csharp
Task<string> GetRepositories(string projectKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| projectKey |  ``` Required ```  | the parent project key |


#### Example Usage

```csharp
string projectKey = "projectKey";

string result = await repository.GetRepositories(projectKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="profile_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.ProfileController") ProfileController

### Get singleton instance

The singleton instance of the ``` ProfileController ``` class can be accessed from the API Client.

```csharp
ProfileController profile = client.Profile;
```

### <a name="get_profile_repositories_recently_accessed"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.ProfileController.GetProfileRepositoriesRecentlyAccessed") GetProfileRepositoriesRecentlyAccessed

> Retrieve a page of recently accessed repositories for the currently authenticated user.
>  <p>
>  Repositories are ordered from most recently to least recently accessed.
>  <p>
>  Only authenticated users may call this resource.


```csharp
Task<string> GetProfileRepositoriesRecentlyAccessed(string permission = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| permission |  ``` Optional ```  | (optional) if specified, it must be a valid repository permission level name and will limit
                   the resulting repository list to ones that the requesting user has the specified permission
                   level to. If not specified, the default <code>REPO_READ</code> permission level will be assumed. |


#### Example Usage

```csharp
string permission = "permission";

string result = await profile.GetProfileRepositoriesRecentlyAccessed(permission);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="markup_controller"></a>![Class: ](https://apidocs.io/img/class.png "StashAPI.PCL.Controllers.MarkupController") MarkupController

### Get singleton instance

The singleton instance of the ``` MarkupController ``` class can be accessed from the API Client.

```csharp
MarkupController markup = client.Markup;
```

### <a name="create_preview_markup"></a>![Method: ](https://apidocs.io/img/method.png "StashAPI.PCL.Controllers.MarkupController.CreatePreviewMarkup") CreatePreviewMarkup

> Preview the generated html for given markdown contents.
>  <p>
>  Only authenticated users may call this resource.


```csharp
Task<string> CreatePreviewMarkup(
        object mdynamic,
        string urlMode = null,
        bool? hardwrap = null,
        bool? htmlEscape = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mdynamic |  ``` Required ```  | TODO: Add a parameter description |
| urlMode |  ``` Optional ```  | TODO: Add a parameter description |
| hardwrap |  ``` Optional ```  | TODO: Add a parameter description |
| htmlEscape |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
object mdynamic = new object();
string urlMode = "urlMode";
bool? hardwrap = false;
bool? htmlEscape = false;

string result = await markup.CreatePreviewMarkup(mdynamic, urlMode, hardwrap, htmlEscape);

```


[Back to List of Controllers](#list_of_controllers)



