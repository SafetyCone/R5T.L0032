# R5T.L0032.T000
Strong types library for various project-related XElements.


## Notes

There are two types of strongly-typed types:

	1. Types deriving from N001.IProjectElement: these are the actual nodes of the project file. (Example: IProjectElement, IItemGroupElement)
	2. Attributed types that derive from ITypes<XElement>: these are adjective types that describe certain properties of the wrapped XElement.
