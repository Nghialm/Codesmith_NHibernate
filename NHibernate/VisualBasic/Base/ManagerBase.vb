Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports NHibernate
Imports NHibernate.Criterion

Namespace NHibernate.Generated.Base
	Public Interface IManagerBase(Of T, TKey)
		' Get Methods
		Function GetById(ByVal Id As TKey) As T
		Function GetAll() As IList(Of T)
		Function GetAll(ByVal maxResults As Integer) As IList(Of T)
		Function GetByCriteria(ParamArray criterionList As ICriterion()) As IList(Of T)
		Function GetByCriteria(ByVal maxResults As Integer, ParamArray criterionList As ICriterion()) As IList(Of T)
		Function GetByExample(ByVal exampleObject As T, ParamArray excludePropertyList As String()) As IList(Of T)

		' CRUD Methods
		Function Save(ByVal entity As T) As Object
		Sub SaveOrUpdate(ByVal entity As T)
		Sub Delete(ByVal entity As T)
		Sub Update(ByVal entity As T)
		Sub Refresh(ByVal entity As T)

		' Properties
		ReadOnly Property Type() As System.Type
		ReadOnly Property Session() As INHibernateSession
	End Interface

	Public MustInherit Partial Class ManagerBase(Of T, TKey)
		Implements IManagerBase(Of T, TKey)
#region "Declarations"

		Protected _session As INHibernateSession
		Protected Const defaultMaxResults As Integer = 100
#End Region

#region "Constructors"

		Public Sub New()
			_session = NHibernateSessionManager.Instance.Session
		End Sub
		Public Sub New(ByVal session As INHibernateSession)
			Me._session = session
		End Sub
#End Region

#region "Get Methods"

		Public Overridable Function GetById(ByVal id As TKey) As T Implements IManagerBase(Of T, TKey).GetById
			Return DirectCast(Session.GetISession().[Get](GetType(T), id), T)
		End Function
		Public Function GetAll() As IList(Of T) Implements IManagerBase(Of T, TKey).GetAll
			Return GetByCriteria(defaultMaxResults)
		End Function
		Public Function GetAll(ByVal maxResults As Integer) As IList(Of T) Implements IManagerBase(Of T, TKey).GetAll
			Return GetByCriteria(maxResults)
		End Function
		Public Function GetByCriteria(ParamArray criterionList As ICriterion()) As IList(Of T) Implements IManagerBase(Of T, TKey).GetByCriteria
			Return GetByCriteria(defaultMaxResults, criterionList)
		End Function
		Public Function GetByCriteria(ByVal maxResults As Integer, ParamArray criterionList As ICriterion()) As IList(Of T) Implements IManagerBase(Of T, TKey).GetByCriteria
			Dim criteria As ICriteria = Session.GetISession().CreateCriteria(GetType(T)).SetMaxResults(maxResults)

			For Each criterion As ICriterion In criterionList
				criteria.Add(criterion)
			Next

			Return criteria.List(Of T)()
		End Function
		Public Function GetByExample(ByVal exampleObject As T, ParamArray excludePropertyList As String()) As IList(Of T) Implements IManagerBase(Of T, TKey).GetByExample
			Dim criteria As ICriteria = Session.GetISession().CreateCriteria(GetType(T))
			Dim example As Example = Example.Create(exampleObject)

			For Each excludeProperty As String In excludePropertyList
				example.ExcludeProperty(excludeProperty)
			Next

			criteria.Add(example)

			Return criteria.List(Of T)()
		End Function
#End Region

#region "CRUD Methods"

		Public Function Save(ByVal entity As T) As Object Implements IManagerBase(Of T, TKey).Save
			Return Session.GetISession().Save(entity)
		End Function
		Public Sub SaveOrUpdate(ByVal entity As T) Implements IManagerBase(Of T, TKey).SaveOrUpdate
			Session.GetISession().SaveOrUpdate(entity)
		End Sub
		Public Sub Delete(ByVal entity As T) Implements IManagerBase(Of T, TKey).Delete
			Session.GetISession().Delete(entity)
		End Sub
		Public Sub Update(ByVal entity As T) Implements IManagerBase(Of T, TKey).Update
			Session.GetISession().Update(entity)
		End Sub
		Public Sub Refresh(ByVal entity As T) Implements IManagerBase(Of T, TKey).Refresh
			Session.GetISession().Refresh(entity)
		End Sub
#End Region

#region "Properties"

		''' <summary>
		''' The NHibernate Session object is exposed only to the Manager class.
		''' It is recommended that you...
		''' ...use the the NHibernateSession methods to control Transactions (unless you specifically want nested transactions).
		''' ...do not directly expose the Flush method (to prevent open transactions from locking your DB).
		''' </summary>
		Public ReadOnly Property Type() As System.Type Implements IManagerBase(Of T, TKey).Type
			Get
				Return GetType(T)
			End Get
		End Property
		Public ReadOnly Property Session() As INHibernateSession Implements IManagerBase(Of T, TKey).Session
			Get
				Return _session
			End Get
		End Property
#End Region
	End Class
End Namespace
