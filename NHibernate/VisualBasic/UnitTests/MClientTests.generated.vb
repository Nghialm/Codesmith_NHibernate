Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MClientTests
		Inherits UNuitTestBase
		
		Protected manager As IMClientManager

		Public Sub New()
			manager = managerFactory.GetMClientManager()
		End Sub

		Protected Function CreateNewMClient() As MClient
			Dim entity As New MClient()

			' You may need to maually enter this key if there is a constraint violation.
			entity.Id = 48
			
			entity.ClientName = "Test Test "
			entity.ClientAbbreviation = "Test Test "
			entity.ClientKana = "Test Test "
			entity.Zipcode = "Test"
			entity.Addres = "Test Test "
			entity.Tel = "Test T"
			entity.Fax = "Test"
			entity.ClientDept = "Test Test Test Test Test Test Test Te"
			entity.ClientCP = "Test Test Test Test Test Test Test Test "
			entity.MailAddres = "Test Test Test Test Test Test Test Test Tes"
			entity.CloseingDate = default(Byte)
			entity.Note1 = "Test Test "
			entity.Note2 = "Test Test "
			entity.Note3 = "Test Test "
			entity.SalesStaffCd = 59
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Test"
			entity.EntryDate = "Test Test Test Te"
			entity.EditStaffName = "Test Test Test Tes"
			entity.EditDate = "Test Test Test"

			Return entity
		End Function
		Protected Function GetFirstMClient() As MClient
			Dim entityList As IList(Of MClient) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MClient = CreateNewMClient()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MClient = CreateNewMClient()
				manager.Save(entityA)

				Dim entityB As MClient = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MClient = GetFirstMClient()
				entityA.ClientName = "Test Test "

				manager.Update(entityA)

				Dim entityB As MClient = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.ClientName, entityB.ClientName)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MClient = GetFirstMClient()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
