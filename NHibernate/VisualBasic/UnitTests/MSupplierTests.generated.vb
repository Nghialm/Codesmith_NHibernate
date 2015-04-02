Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MSupplierTests
		Inherits UNuitTestBase
		
		Protected manager As IMSupplierManager

		Public Sub New()
			manager = managerFactory.GetMSupplierManager()
		End Sub

		Protected Function CreateNewMSupplier() As MSupplier
			Dim entity As New MSupplier()

			' You may need to maually enter this key if there is a constraint violation.
			entity.Id = 18
			
			entity.SupplierName = "Test Test "
			entity.SupplierAbbreviation = "Test Test "
			entity.SupplierKana = "Test Test "
			entity.Zipcode = "T"
			entity.Addres = "Test Test "
			entity.Tel = "Test"
			entity.Fax = "Test T"
			entity.SupplierDept = "Test Test Test Test Test Test Test Test"
			entity.SupplierCP = "Test Test Test Test Test"
			entity.MailAddres = "Test Test Test Test Test T"
			entity.CloseingDate = default(Byte)
			entity.Note1 = "Test Test "
			entity.Note2 = "Test Test "
			entity.Note3 = "Test Test "
			entity.Segment = default(Byte)
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Tes"
			entity.EntryDate = "Test Tes"
			entity.EditStaffName = "Test Test "
			entity.EditDate = "Tes"

			Return entity
		End Function
		Protected Function GetFirstMSupplier() As MSupplier
			Dim entityList As IList(Of MSupplier) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MSupplier = CreateNewMSupplier()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MSupplier = CreateNewMSupplier()
				manager.Save(entityA)

				Dim entityB As MSupplier = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MSupplier = GetFirstMSupplier()
				entityA.SupplierName = "Test Test "

				manager.Update(entityA)

				Dim entityB As MSupplier = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.SupplierName, entityB.SupplierName)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MSupplier = GetFirstMSupplier()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
