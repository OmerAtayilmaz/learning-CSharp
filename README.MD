# C# Basics

## Extensions
*.sln 
*.cs holds codes for console application or form application
*.csproj
*.resx
*.dll files contains compiled code.
*.exe Exectutable assemply file


## Directives
using directiove: The using directive can appear at the beginning of a source code file, before any namepace
or type definitions.
The <b>using</b> directive has three uses:
1. To allow the use of types in a namespace so that you do not have to qualify the use of a type in that namespace:
   2. using System.Text;
2. To allow you to access static members and nested types of a type without having to qualify the access with the type name.
   3. using static System.Console;
3. To create an aliaas for a namespace or a type. This is called a using alias directive. After that, "PC.MyCompany.Projects" will be called "Project" in the application.
   4. using Project= PC.MyCompany.Project;

namespace directive: Namespaces are not mandatory in a C# program. But, they do play an important role in writing cleaner
codes and managing larger projects. A namespace can have following types as its members

