Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.ManagerObjects
	Public Interface IMStaffManager
		Inherits IManagerBase(Of MStaff, System.Decimal)
		
		' Get Methods
		
	End Interface

	Partial Class MStaffManager
		Inherits ManagerBase(Of MStaff, System.Decimal)
		Implements IMStaffManager
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
