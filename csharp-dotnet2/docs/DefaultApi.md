# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://virtserver.swaggerhub.com/Afulki9/GetQuotes/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExampleServiceOperation**](DefaultApi.md#exampleserviceoperation) | **POST** /ExampleServiceOperation | Operation ExampleServiceOperation


<a name="exampleserviceoperation"></a>
# **ExampleServiceOperation**
> ExampleServiceOperationOutput ExampleServiceOperation (ExampleServiceOperationInput body, string contextid, string consumerId, string internalreferenceid, string firmId, string transactionid)

Operation ExampleServiceOperation

ExampleServiceOperation Rest API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExampleServiceOperationExample
    {
        public void main()
        {
            
            var apiInstance = new DefaultApi();
            var body = new ExampleServiceOperationInput(); // ExampleServiceOperationInput | 
            var contextid = contextid_example;  // string | 
            var consumerId = consumerId_example;  // string | 
            var internalreferenceid = internalreferenceid_example;  // string | 
            var firmId = firmId_example;  // string | 
            var transactionid = transactionid_example;  // string | 

            try
            {
                // Operation ExampleServiceOperation
                ExampleServiceOperationOutput result = apiInstance.ExampleServiceOperation(body, contextid, consumerId, internalreferenceid, firmId, transactionid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ExampleServiceOperation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExampleServiceOperationInput**](ExampleServiceOperationInput.md)|  | 
 **contextid** | **string**|  | 
 **consumerId** | **string**|  | 
 **internalreferenceid** | **string**|  | 
 **firmId** | **string**|  | 
 **transactionid** | **string**|  | 

### Return type

[**ExampleServiceOperationOutput**](ExampleServiceOperationOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

