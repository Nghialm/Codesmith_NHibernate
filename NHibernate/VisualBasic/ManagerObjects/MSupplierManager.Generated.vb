Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.ManagerObjects
	Public Interface IMSupplierManager
		Inherits IManagerBase(Of MSupplier, System.Decimal)
		
		' Get Methods
		
	End Interface

	Partial Class MSupplierManager
		Inherits ManagerBase(Of MSupplier, System.Decimal)
		Implements IMSupplierManager
#region "Constructors"

		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal session As INHibernateSession)
			MyBase.New(session)
		End Sub
#End Region

#region "Get Methods"

		
#End Region
	End Class
End Namespace
