

# 配置52ABP-PRO的多语言
 
 
**请注意：**
- 从52ABP-PRO 2.5.0的版本开始默认采用json配置多语言
- 属性名和字段不能重复否则框架会验证失败，需要你删除重复的键名

## Json的配置方法如下

在dgCube.Core类库中，找到路径为 Localization->SourceFiles->Json文件夹下的对应文件

### 中文本地化的内容Chinese localized content

找到Json文件夹下的dgCube-zh-Hans.json文件，复制以下代码进入即可。

> 请注意防止键名重复，产生异常

```json
                    //的多语言配置==>中文
"Id": "Id",
                    
                     "ApplicationInfoApplicationName": "ApplicationName",
                    "ApplicationInfoApplicationNameInputDesc": "请输入ApplicationName",
                     
                    
                     "ApplicationInfoApplicationTitle": "ApplicationTitle",
                    "ApplicationInfoApplicationTitleInputDesc": "请输入ApplicationTitle",
                     
                    
                     "ApplicationInfoIntroduction": "Introduction",
                    "ApplicationInfoIntroductionInputDesc": "请输入Introduction",
                     
                    
                     "ApplicationInfoServiceProvider": "ServiceProvider",
                    "ApplicationInfoServiceProviderInputDesc": "请输入ServiceProvider",
                     
                    
                     "ApplicationInfoVersion": "Version",
                    "ApplicationInfoVersionInputDesc": "请输入Version",
                     
                    
                     "ApplicationInfoUrl": "Url",
                    "ApplicationInfoUrlInputDesc": "请输入Url",
                     
"Status": "Status",
                    
                     "ApplicationInfoIconUrl": "IconUrl",
                    "ApplicationInfoIconUrlInputDesc": "请输入IconUrl",
                     
                    
                     "ApplicationInfoImages": "Images",
                    "ApplicationInfoImagesInputDesc": "请输入Images",
                     
                    
                     "ApplicationInfoVideos": "Videos",
                    "ApplicationInfoVideosInputDesc": "请输入Videos",
                     
                    
                     "ApplicationInfoTags": "Tags",
                    "ApplicationInfoTagsInputDesc": "请输入Tags",
                     
                    
                     "ApplicationInfoContentRef": "ContentRef",
                    "ApplicationInfoContentRefInputDesc": "请输入ContentRef",
                     
                    
                     "ApplicationInfoContentType": "ContentType",
                    "ApplicationInfoContentTypeInputDesc": "请输入ContentType",
                     
                    
                     "ApplicationInfoEnterprisesCardJson": "EnterprisesCardJson",
                    "ApplicationInfoEnterprisesCardJsonInputDesc": "请输入EnterprisesCardJson",
                     
"CreatedTime": "CreatedTime",
					                     
                    "ApplicationInfo": "",
                    "ManageApplicationInfo": "管理",
                    "QueryApplicationInfo": "查询",
                    "CreateApplicationInfo": "添加",
                    "EditApplicationInfo": "编辑",
                    "DeleteApplicationInfo": "删除",
                    "BatchDeleteApplicationInfo": "批量删除",
                    "ExportApplicationInfo": "导出",
                    "ApplicationInfoList": "列表",
                     //的多语言配置==End
                    


```


### 英语本地化的内容English localized content
找到Json文件夹下的dgCube.json文件，复制以下代码进入即可。
```json
             //的多语言配置==>英文
"Id": "Id",
                    
                     "ApplicationInfoApplicationName": "ApplicationInfoApplicationName",
                    "ApplicationInfoApplicationNameInputDesc": "Please input your ApplicationInfoApplicationName",
                     
                    
                     "ApplicationInfoApplicationTitle": "ApplicationInfoApplicationTitle",
                    "ApplicationInfoApplicationTitleInputDesc": "Please input your ApplicationInfoApplicationTitle",
                     
                    
                     "ApplicationInfoIntroduction": "ApplicationInfoIntroduction",
                    "ApplicationInfoIntroductionInputDesc": "Please input your ApplicationInfoIntroduction",
                     
                    
                     "ApplicationInfoServiceProvider": "ApplicationInfoServiceProvider",
                    "ApplicationInfoServiceProviderInputDesc": "Please input your ApplicationInfoServiceProvider",
                     
                    
                     "ApplicationInfoVersion": "ApplicationInfoVersion",
                    "ApplicationInfoVersionInputDesc": "Please input your ApplicationInfoVersion",
                     
                    
                     "ApplicationInfoUrl": "ApplicationInfoUrl",
                    "ApplicationInfoUrlInputDesc": "Please input your ApplicationInfoUrl",
                     
"Status": "Status",
                    
                     "ApplicationInfoIconUrl": "ApplicationInfoIconUrl",
                    "ApplicationInfoIconUrlInputDesc": "Please input your ApplicationInfoIconUrl",
                     
                    
                     "ApplicationInfoImages": "ApplicationInfoImages",
                    "ApplicationInfoImagesInputDesc": "Please input your ApplicationInfoImages",
                     
                    
                     "ApplicationInfoVideos": "ApplicationInfoVideos",
                    "ApplicationInfoVideosInputDesc": "Please input your ApplicationInfoVideos",
                     
                    
                     "ApplicationInfoTags": "ApplicationInfoTags",
                    "ApplicationInfoTagsInputDesc": "Please input your ApplicationInfoTags",
                     
                    
                     "ApplicationInfoContentRef": "ApplicationInfoContentRef",
                    "ApplicationInfoContentRefInputDesc": "Please input your ApplicationInfoContentRef",
                     
                    
                     "ApplicationInfoContentType": "ApplicationInfoContentType",
                    "ApplicationInfoContentTypeInputDesc": "Please input your ApplicationInfoContentType",
                     
                    
                     "ApplicationInfoEnterprisesCardJson": "ApplicationInfoEnterprisesCardJson",
                    "ApplicationInfoEnterprisesCardJsonInputDesc": "Please input your ApplicationInfoEnterprisesCardJson",
                     
"CreatedTime": "CreatedTime",
					                     
                    "ApplicationInfo": "ApplicationInfo",
                    "ManageApplicationInfo": "ManageApplicationInfo",
                    "QueryApplicationInfo": "QueryApplicationInfo",
                    "CreateApplicationInfo": "CreateApplicationInfo",
                    "EditApplicationInfo": "EditApplicationInfo",
                    "DeleteApplicationInfo": "DeleteApplicationInfo",
                    "BatchDeleteApplicationInfo": "BatchDeleteApplicationInfo",
                    "ExportApplicationInfo": "ExportApplicationInfo",
                    "ApplicationInfoList": "ApplicationInfoList",
                     //的多语言配置==End
                    




```