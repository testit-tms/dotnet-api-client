# TestIT.ApiClient.Model.ProjectShortModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique ID of the project | 
**Description** | **string** | Description of the project | [optional] 
**Name** | **string** | Name of the project | 
**IsFavorite** | **bool** | Indicates if the project is marked as favorite | 
**TestCasesCount** | **int?** | Number of test cases in the project | [optional] 
**SharedStepsCount** | **int?** | Number of shared steps in the project | [optional] 
**CheckListsCount** | **int?** | Number of checklists in the project | [optional] 
**AutoTestsCount** | **int?** | Number of autotests in the project | [optional] 
**IsDeleted** | **bool** | Indicates if the project is deleted | 
**CreatedDate** | **DateTime** | Creation date of the project | 
**ModifiedDate** | **DateTime?** | Last modification date of the project | [optional] 
**CreatedById** | **Guid** | Unique ID of the project creator | 
**ModifiedById** | **Guid?** | Unique ID of the project last editor | [optional] 
**GlobalId** | **long** | Global ID of the project | 
**Type** | **ProjectTypeModel** | Type of the project | 
**IsFlakyAuto** | **bool** | Indicates if the status \&quot;Flaky/Stable\&quot; sets automatically | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

