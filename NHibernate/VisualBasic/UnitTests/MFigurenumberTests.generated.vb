Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MFigurenumberTests
		Inherits UNuitTestBase
		
		Protected manager As IMFigurenumberManager

		Public Sub New()
			manager = managerFactory.GetMFigurenumberManager()
		End Sub

		Protected Function CreateNewMFigurenumber() As MFigurenumber
			Dim entity As New MFigurenumber()

			entity.ItemCd = 82
			entity.FugureNumber = "Test Test Test Test Test Test Test Test Test "
			
			entity.PriceInfo = "Test Test Test Test Test Test Test Test Test Tes"
			entity.OrderInfo = "Test Test "
			entity.ShipInfo = "Test Test "
			entity.Note1 = "Test Test "
			entity.Note2 = "Test Test "
			entity.Note3 = "Test Test "
			entity.DisFlg = default(Byte)
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Test Test Tes"
			entity.EntryDate = "Test T"
			entity.EditStaffName = "Te"
			entity.EditDate = "T"

			Return entity
		End Function
		Protected Function GetFirstMFigurenumber() As MFigurenumber
			Dim entityList As IList(Of MFigurenumber) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MFigurenumber = CreateNewMFigurenumber()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MFigurenumber = CreateNewMFigurenumber()
				manager.Save(entityA)

				Dim entityB As MFigurenumber = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MFigurenumber = GetFirstMFigurenumber()
				entityA.PriceInfo = "Test Test Tes"

				manager.Update(entityA)

				Dim entityB As MFigurenumber = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.PriceInfo, entityB.PriceInfo)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MFigurenumber = GetFirstMFigurenumber()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
