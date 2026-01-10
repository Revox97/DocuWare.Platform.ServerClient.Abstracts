# DocuWare.Platform.ServerClient.Abstracts
[![Release](https://img.shields.io/badge/Release-0.1.0.0-blue)](https://github.com/Revox97/DocuWare.Platform.ServerClient.Abstracts)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/Revox97/DocuWare.Platform.ServerClient.Abstracts/blob/master/LICENSE)

**DocuWare.Platform.ServerClient.Abstracts** is a wrapper for the [DocuWare.Platform.ServerClient](https://www.nuget.org/packages/DocuWare.Platform.ServerClient) library, which allows mocking its types for testing without additional boilerplate.

❗ The library is in pre-release. There might be bugs and missing features. If you should encounter any, please open an issue.

❗ If you have any issues with the SDK itself, please contact [DocuWare support](https://support.docuware.com)

## installation
Install the following NuGet package into your project: [NuGet](https://www.nuget.org)

## Usage
To start include the following namespace into your .cs file:
```csharp
using DocuWare.Platform.ServerClient.Abstracts;
```

Create a connection by using the RealDocuWare class. It contains all static methods from The ServiceConnection class of the DocuWare library. For mocking use IDocuWare interface.
```csharp
// Actual connection
IServiceConnection connection = new RealDocuWare().CreateServiceConnection(...);

// Mocked connection using Moq
Mock<IServiceConnection> mockConnection = new Mock<IServiceConnection>();
Mock<IDocuWare> mockDocuWare = new Mock<IDocuWare>();
mockDocuWare.Setup(d => d.CreateServiceConnection(...)).Returns(mockConnection.Object);
```

Afterwards the library can be used as if using the DocuWare.Platform.ServerClient library directly.

## Limitations
As this library is still in a pre-release state, not all types and methods of the DocuWare.Platform.ServerClient library are wrapped yet. If you are missing any functionality, please open an issue. Known limitations are as follows:
- Missing functionality for some Forms related types -> Will throw **NotSupportedException** when used
- Missing documentation comments
- Currently only **DocuWare.Platform.ServerClient** is available, **DocuWare.Platform.ServerClient.Extensions** functionality is currently missing

All missing functionality is planned to be added in a future release.

## Contribution
Your help is appreciated. If you are interested in contributing to this project, please refer to the [contribution guidelines](https://github.com/Revox97/DocuWare.Platform.ServerClient.Abstracts/blob/master/CONTRIBUTION.md).

## Disclaimer
DocuWare GmbH is not affiliated with this project. This project is not endorsed by DocuWare GmbH in any way. Use at your own risk.
