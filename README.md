# How to bind JSON data to Xamarin.Forms DataForm (SfDataForm) ?

You can bind the data from JSON (JavaScript Object Notation) in Xamarin.Forms SfDataForm.

You can refer the following article.

https://www.syncfusion.com/kb/11310/how-to-bind-json-data-to-xamarin-forms-dataform-sfdataform

Create a JSON data model.
``` c#
/// <summary>   
/// Represents custom data properties.   
/// </summary> 
public class JSONData
{
       public string UserName { get; set; }
       public string UserGender { get; set; }
       public string UserMail { get; set; }
       public string UserCountry { get; set; }
}
```
**Note:** Convert String type into DateTime type when adding items to the local collection from JSON data model, since JSON does not support DateTime type.

Create data for the data model.
``` c#
//// Add data for JSON data model
private string JsonData =
          "[{\"UserName\": \"Chan\",\"UserGender\": \"Male\",\"UserMail\": \"chan@yyy.com\",\"UserCountry\": \"Japan\", \"UserBirthDate\": \"05/01/1996\"}]";
``` 
Deserialize the JSON data as list of JSON data model.

``` c#
List<JSONData> jsonDataCollection = JsonConvert.DeserializeObject<List<JSONData>>(JsonData);
```

Load the JSON data list into the DataForm model.

``` c#
foreach (var data in jsonDataCollection)
{
                this.ContactsInfo.Name = data.UserName;
                this.ContactsInfo.Gender = data.UserGender;
                this.ContactsInfo.Email = data.UserMail;
                this.ContactsInfo.Country = data.UserCountry;
                this.ContactsInfo.DateOfBirth = Convert.ToDateTime(data.UserBirthDate);
}
```
**Output**

![DataFormJsonData](https://github.com/SyncfusionExamples/json-binding-dataform-xamarin/blob/master/Screenshots/JSONDataform.png)
