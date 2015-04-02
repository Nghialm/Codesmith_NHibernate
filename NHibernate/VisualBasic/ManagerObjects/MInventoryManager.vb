Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.ManagerObjects
	'Public Partial Interface IMInventoryManager
	'	Inherits IManagerBase(Of MInventory, System.String)
	'End Interface

	Partial Class MInventoryManager
		Inherits ManagerBase(Of MInventory, System.String)
		Implements IMInventoryManager
	End Class
End Namespace
