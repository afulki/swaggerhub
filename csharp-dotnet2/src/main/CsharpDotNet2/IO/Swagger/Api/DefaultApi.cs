using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        /// <summary>
        /// Operation ExampleServiceOperation ExampleServiceOperation Rest API
        /// </summary>
        /// <param name="body"></param>
        /// <param name="contextid"></param>
        /// <param name="consumerId"></param>
        /// <param name="internalreferenceid"></param>
        /// <param name="firmId"></param>
        /// <param name="transactionid"></param>
        /// <returns>ExampleServiceOperationOutput</returns>
        ExampleServiceOperationOutput ExampleServiceOperation (ExampleServiceOperationInput body, string contextid, string consumerId, string internalreferenceid, string firmId, string transactionid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Operation ExampleServiceOperation ExampleServiceOperation Rest API
        /// </summary>
        /// <param name="body"></param> 
        /// <param name="contextid"></param> 
        /// <param name="consumerId"></param> 
        /// <param name="internalreferenceid"></param> 
        /// <param name="firmId"></param> 
        /// <param name="transactionid"></param> 
        /// <returns>ExampleServiceOperationOutput</returns>            
        public ExampleServiceOperationOutput ExampleServiceOperation (ExampleServiceOperationInput body, string contextid, string consumerId, string internalreferenceid, string firmId, string transactionid)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ExampleServiceOperation");
            
            // verify the required parameter 'contextid' is set
            if (contextid == null) throw new ApiException(400, "Missing required parameter 'contextid' when calling ExampleServiceOperation");
            
            // verify the required parameter 'consumerId' is set
            if (consumerId == null) throw new ApiException(400, "Missing required parameter 'consumerId' when calling ExampleServiceOperation");
            
            // verify the required parameter 'internalreferenceid' is set
            if (internalreferenceid == null) throw new ApiException(400, "Missing required parameter 'internalreferenceid' when calling ExampleServiceOperation");
            
            // verify the required parameter 'firmId' is set
            if (firmId == null) throw new ApiException(400, "Missing required parameter 'firmId' when calling ExampleServiceOperation");
            
            // verify the required parameter 'transactionid' is set
            if (transactionid == null) throw new ApiException(400, "Missing required parameter 'transactionid' when calling ExampleServiceOperation");
            
    
            var path = "/ExampleServiceOperation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (contextid != null) headerParams.Add("Contextid", ApiClient.ParameterToString(contextid)); // header parameter
 if (consumerId != null) headerParams.Add("ConsumerId", ApiClient.ParameterToString(consumerId)); // header parameter
 if (internalreferenceid != null) headerParams.Add("Internalreferenceid", ApiClient.ParameterToString(internalreferenceid)); // header parameter
 if (firmId != null) headerParams.Add("FirmId", ApiClient.ParameterToString(firmId)); // header parameter
 if (transactionid != null) headerParams.Add("transactionid", ApiClient.ParameterToString(transactionid)); // header parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ExampleServiceOperation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExampleServiceOperation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ExampleServiceOperationOutput) ApiClient.Deserialize(response.Content, typeof(ExampleServiceOperationOutput), response.Headers);
        }
    
    }
}
