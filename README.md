# mystrom-api-csharp

Inofficial myStrom API C# implementation.

Usage:

```csharp
var uri = new System.Url("http://192.168.254.1");
var client = new MyStrom.Api.Client(uri);
client.RefreshAll();
```