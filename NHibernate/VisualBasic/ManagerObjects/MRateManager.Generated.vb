Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.ManagerObjects
	Public Interface IMRateManager
		Inherits IManagerBase(Of MRate, System.String)
		
		' Get Methods
		Overloads Function GetById(ByVal _startDate As System.String, ByVal _currencyCd As System.Byte) As MRate
		
	End Interface

	Partial Class MRateManager
		Inherits ManagerBase(Of MRate, System.String)
		Implements IMRateManager
#region "Constructors"

		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal session As INHibernateSession)
			MyBase.New(session)
		End Sub
#End Region

#region "Get Methods"

		Public Overloads Overrides Function GetById(ByVal id As String) As MRate
			Dim keys As String() = id.Split("^"C)
		
			If keys.Length <> 2 Then
				Throw New Exception("Invalid Id for MRateManager.GetById")
			End If
		
			Return GetById(System.String.Parse(keys(0)), System.Byte.Parse(keys(1)))
		End Function
		Public Overloads Function GetById(ByVal _startDate As System.String, ByVal _currencyCd As System.Byte) As MRate  Implements IMRateManager.GetById
			Dim criteria As ICriteria = Session.GetISession().CreateCriteria(GetType(MRate))
		
			criteria.Add(NHibernate.Criterion.Expression.Eq("StartDate", _startDate))
			criteria.Add(NHibernate.Criterion.Expression.Eq("CurrencyCd", _currencyCd))
			
			Dim result As MRate = DirectCast(criteria.UniqueResult(), MRate)
		
			If result Is Nothing Then
				Throw New NHibernate.ObjectDeletedException("", Nothing, Nothing)
			End If
		
			Return result
		End Function
		
#End Region
	End Class
End Namespace
