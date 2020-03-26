# 1481Repro
Repro of https://github.com/microsoft/ApplicationInsights-dotnet/issues/1481

1. Change the startup project to ConsoleApp1
2. Replace the value of the variable "conn" with a valid Azure Blob Storage connection string and run the program. This error will be thrown


System.IO.FileNotFoundException
  HResult=0x80070002
  Message=Could not load file or assembly 'System.Diagnostics.DiagnosticSource, Version=4.0.4.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51' or one of its dependencies. The system cannot find the file specified.
  Source=Azure.Storage.Blobs
  StackTrace:
   at Azure.Core.Pipeline.DiagnosticScopeFactory..ctor(String clientNamespace, String resourceProviderNamespace, Boolean isActivityEnabled)
   at Azure.Core.Pipeline.ClientDiagnostics..ctor(ClientOptions options)
   at Azure.Storage.StorageClientOptions.Build(ClientOptions options, HttpPipelinePolicy authentication, Uri geoRedundantSecondaryStorageUri)
   at Azure.Storage.Blobs.BlobServiceClient..ctor(String connectionString, BlobClientOptions options)
   at Azure.Storage.Blobs.BlobServiceClient..ctor(String connectionString)
   at ClassLibrary1.Class1.GetBlobClient(String connectionString) in C:\Dev\1481Repro\ClassLibrary1\Class1.cs:line 21
   at ClassLibrary1.Class1.Main() in C:\Dev\1481Repro\ClassLibrary1\Class1.cs:line 15
   at ConsoleApp1.Program.Main(String[] args) in C:\Dev\1481Repro\ConsoleApp1\Program.cs:line 14

