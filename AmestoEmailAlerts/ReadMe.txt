# AmestoEmailAlerts

**AmestoEmailAlerts** is a library designed to simplify sending email as error. The SendEmailAlert method excepts Subject, List of ErrorEntry ,  List of ReceipentInformation and System Name
The ErrorEntry contains Severity, Message and TimeStamp
The ReceipentInformation contains Email and Name
If Subject is not set, then default value is “Error Messages”, if systemName is not set then default value is “Application from Amesto Solution”
On successful completion, the method returns Status as true or false.

---

## 📦 Installation

To install the package, use the NuGet Package Manager in Visual Studio or the .NET CLI:

### .NET CLI
```bash
dotnet add package AmestoEmailAlerts --version 1.0.0