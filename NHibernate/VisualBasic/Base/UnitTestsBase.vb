Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects

Namespace NHibernate.Generated.Base
	Public Class UNuitTestBase
		Protected managerFactory As IManagerFactory = New ManagerFactory()

		<SetUp()> _
		Public Sub SetUp()
			NHibernateSessionManager.Instance.Session.BeginTransaction()
		End Sub
		<TearDown()> _
		Public Sub TearDown()
			NHibernateSessionManager.Instance.Session.RollbackTransaction()
		End Sub
	End Class
End Namespace
