Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MItemTests
		Inherits UNuitTestBase
		
		Protected manager As IMItemManager

		Public Sub New()
			manager = managerFactory.GetMItemManager()
		End Sub

		Protected Function CreateNewMItem() As MItem
			Dim entity As New MItem()

			' You may need to maually enter this key if there is a constraint violation.
			entity.Id = 55
			
			entity.ItemName = "Test Test "
			entity.ItemNumber = "Test Test "
			entity.MakerCd = 61
			entity.PriceInfo = "Test Test "
			entity.OrderInfo = "Test Test "
			entity.ShipInfo = "Test Test "
			entity.Note1 = "Test Test "
			entity.Note2 = "Test Test "
			entity.Note3 = "Test Test "
			entity.LeadTime = default(Byte)
			entity.DisFlg = default(Byte)
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Te"
			entity.EntryDate = "Test Test"
			entity.EditStaffName = "Test Test T"
			entity.EditDate = "Test Test Test "

			Return entity
		End Function
		Protected Function GetFirstMItem() As MItem
			Dim entityList As IList(Of MItem) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MItem = CreateNewMItem()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MItem = CreateNewMItem()
				manager.Save(entityA)

				Dim entityB As MItem = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MItem = GetFirstMItem()
				entityA.ItemName = "Test Test "

				manager.Update(entityA)

				Dim entityB As MItem = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.ItemName, entityB.ItemName)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MItem = GetFirstMItem()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
