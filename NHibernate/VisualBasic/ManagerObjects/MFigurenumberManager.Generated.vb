Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.ManagerObjects
	Public Interface IMFigurenumberManager
		Inherits IManagerBase(Of MFigurenumber, System.String)
		
		' Get Methods
		Overloads Function GetById(ByVal _itemCd As System.Decimal, ByVal _fugureNumber As System.String) As MFigurenumber
		
	End Interface

	Partial Class MFigurenumberManager
		Inherits ManagerBase(Of MFigurenumber, System.String)
		Implements IMFigurenumberManager
#region "Constructors"

		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal session As INHibernateSession)
			MyBase.New(session)
		End Sub
#End Region

#region "Get Methods"

		Public Overloads Overrides Function GetById(ByVal id As String) As MFigurenumber
			Dim keys As String() = id.Split("^"C)
		
			If keys.Length <> 2 Then
				Throw New Exception("Invalid Id for MFigurenumberManager.GetById")
			End If
		
			Return GetById(System.Decimal.Parse(keys(0)), System.String.Parse(keys(1)))
		End Function
		Public Overloads Function GetById(ByVal _itemCd As System.Decimal, ByVal _fugureNumber As System.String) As MFigurenumber  Implements IMFigurenumberManager.GetById
			Dim criteria As ICriteria = Session.GetISession().CreateCriteria(GetType(MFigurenumber))
		
			criteria.Add(NHibernate.Criterion.Expression.Eq("ItemCd", _itemCd))
			criteria.Add(NHibernate.Criterion.Expression.Eq("FugureNumber", _fugureNumber))
			
			Dim result As MFigurenumber = DirectCast(criteria.UniqueResult(), MFigurenumber)
		
			If result Is Nothing Then
				Throw New NHibernate.ObjectDeletedException("", Nothing, Nothing)
			End If
		
			Return result
		End Function
		
#End Region
	End Class
End Namespace
