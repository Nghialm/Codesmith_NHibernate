Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.ManagerObjects
	Public Interface IMInventoryholderManager
		Inherits IManagerBase(Of MInventoryholder, System.String)
		
		' Get Methods
		Overloads Function GetById(ByVal _itemCd As System.Decimal, ByVal _closedDate As System.String, ByVal _staffCd As System.Decimal) As MInventoryholder
		
	End Interface

	Partial Class MInventoryholderManager
		Inherits ManagerBase(Of MInventoryholder, System.String)
		Implements IMInventoryholderManager
#region "Constructors"

		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal session As INHibernateSession)
			MyBase.New(session)
		End Sub
#End Region

#region "Get Methods"

		Public Overloads Overrides Function GetById(ByVal id As String) As MInventoryholder
			Dim keys As String() = id.Split("^"C)
		
			If keys.Length <> 3 Then
				Throw New Exception("Invalid Id for MInventoryholderManager.GetById")
			End If
		
			Return GetById(System.Decimal.Parse(keys(0)), System.String.Parse(keys(1)), System.Decimal.Parse(keys(2)))
		End Function
		Public Overloads Function GetById(ByVal _itemCd As System.Decimal, ByVal _closedDate As System.String, ByVal _staffCd As System.Decimal) As MInventoryholder  Implements IMInventoryholderManager.GetById
			Dim criteria As ICriteria = Session.GetISession().CreateCriteria(GetType(MInventoryholder))
		
			criteria.Add(NHibernate.Criterion.Expression.Eq("ItemCd", _itemCd))
			criteria.Add(NHibernate.Criterion.Expression.Eq("ClosedDate", _closedDate))
			criteria.Add(NHibernate.Criterion.Expression.Eq("StaffCd", _staffCd))
			
			Dim result As MInventoryholder = DirectCast(criteria.UniqueResult(), MInventoryholder)
		
			If result Is Nothing Then
				Throw New NHibernate.ObjectDeletedException("", Nothing, Nothing)
			End If
		
			Return result
		End Function
		
#End Region
	End Class
End Namespace
