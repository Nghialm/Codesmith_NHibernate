Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MStaffTests
		Inherits UNuitTestBase
		
		Protected manager As IMStaffManager

		Public Sub New()
			manager = managerFactory.GetMStaffManager()
		End Sub

		Protected Function CreateNewMStaff() As MStaff
			Dim entity As New MStaff()

			' You may need to maually enter this key if there is a constraint violation.
			entity.Id = 68
			
			entity.StaffName = "Test Test Test "
			entity.StaffNameKana = "Tes"
			entity.UserID = "Test Test T"
			entity.Password = "Test Test "
			entity.MailAddres = "Test Test Test Test Test"
			entity.PostCd = 83
			entity.Note1 = "Test Test "
			entity.Note2 = "Test Test "
			entity.Note3 = "Test Test "
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Test Te"
			entity.EntryDate = "Test Test "
			entity.EditStaffName = "Test Test Test Tes"
			entity.EditDate = "Test Te"

			Return entity
		End Function
		Protected Function GetFirstMStaff() As MStaff
			Dim entityList As IList(Of MStaff) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MStaff = CreateNewMStaff()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MStaff = CreateNewMStaff()
				manager.Save(entityA)

				Dim entityB As MStaff = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MStaff = GetFirstMStaff()
				entityA.StaffName = "Test Test Te"

				manager.Update(entityA)

				Dim entityB As MStaff = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.StaffName, entityB.StaffName)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MStaff = GetFirstMStaff()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
