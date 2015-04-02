Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.ManagerObjects
	Public Interface IMInventoryManager
		Inherits IManagerBase(Of MInventory, System.String)
		
		' Get Methods
		Overloads Function GetById(ByVal _itemCd As System.Decimal, ByVal _closedDate As System.String) As MInventory
		
	End Interface

	Partial Class MInventoryManager
		Inherits ManagerBase(Of MInventory, System.String)
		Implements IMInventoryManager
#region "Constructors"

		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal session As INHibernateSession)
			MyBase.New(session)
		End Sub
#End Region

#region "Get Methods"

		Public Overloads Overrides Function GetById(ByVal id As String) As MInventory
			Dim keys As String() = id.Split("^"C)
		
			If keys.Length <> 2 Then
				Throw New Exception("Invalid Id for MInventoryManager.GetById")
			End If
		
			Return GetById(System.Decimal.Parse(keys(0)), System.String.Parse(keys(1)))
		End Function
		Public Overloads Function GetById(ByVal _itemCd As System.Decimal, ByVal _closedDate As System.String) As MInventory  Implements IMInventoryManager.GetById
			Dim criteria As ICriteria = Session.GetISession().CreateCriteria(GetType(MInventory))
		
			criteria.Add(NHibernate.Criterion.Expression.Eq("ItemCd", _itemCd))
			criteria.Add(NHibernate.Criterion.Expression.Eq("ClosedDate", _closedDate))
			
			Dim result As MInventory = DirectCast(criteria.UniqueResult(), MInventory)
		
			If result Is Nothing Then
				Throw New NHibernate.ObjectDeletedException("", Nothing, Nothing)
			End If
		
			Return result
		End Function
		
#End Region
	End Class
End Namespace
