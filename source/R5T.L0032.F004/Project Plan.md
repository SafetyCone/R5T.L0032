# R5T.L0032.F004
Common, strictly-platform project XElement-level functionality. (netstandard2.1)

A library of Visual Studio (MSBuild) XML project file XElement-level functionality, that uses only platform-level types (platform is the netstandard2.1 target framework).

The project can only depend on:

	* R5T.L0066 - The strictly framework-typed functionality library for the netstandard2.1 target framework.
	* R5T.L0032.F003 - The strictly framework-typed utility functionality library for Visual Studio (MSBuild) XML project file values. (netstandard2.1)
	* R5T.L0032.Y000 - The documentation library for Visual Studio project file XML elements. (Which is a strictly-framwork project.)
	* R5T.L0032.Z001 - The strictly framework-typed values library for Visual Studio (MSBuild) XML project values.
	* R5T.T0206 - The strictly framework-typed complex data types for Visual Studio (MSBuild) XML project file types library (like COMReference).
		These are just data types, not utility types so they are harmless.
		This is desirable because there many properties are required to specify a COM reference, and it's better to group those into a type.

No other project references are allowed to maintain dependence on strictly-platform types.


## How this library works

The IProjectXElementsOperation contains *all* operations first.
	This was done to allow a single intellisense listing of *all* operations related to project XElements, which is desirable because it makes finding *all* project XElement operations easy.

Those operations are then "retailed" via IProjectXElementOperator, IPropertyGroupXElementOperator, IItemGroupXElementOperator, etc.
	This was done to allow context-specific intellisense listings of context-specific operations related to project XElements, which is desirable because it makes it easy to find the right project XElement operation in a given context.
