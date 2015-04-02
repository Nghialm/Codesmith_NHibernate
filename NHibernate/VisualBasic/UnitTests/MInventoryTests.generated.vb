Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MInventoryTests
		Inherits UNuitTestBase
		
		Protected manager As IMInventoryManager

		Public Sub New()
			manager = managerFactory.GetMInventoryManager()
		End Sub

		Protected Function CreateNewMInventory() As MInventory
			Dim entity As New MInventory()

			entity.ItemCd = 12
			entity.ClosedDate = "Test Te"
			
			entity.ArriveNum = 51
			entity.ArrivePrice = 53
			entity.ShippingNum = 46
			entity.ShippingPrice = 62
			entity.StockNum = 60
			entity.StockPrice = 1
			entity.DisposalNum = 82
			entity.DisposalPrice = 26
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Test Test Test T"
			entity.EntryDate = "Test Test Test Te"
			entity.EditStaffName = "Test Test Te"
			entity.EditDate = "Test Te"

			Return entity
		End Function
		Protected Function GetFirstMInventory() As MInventory
			Dim entityList As IList(Of MInventory) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MInventory = CreateNewMInventory()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MInventory = CreateNewMInventory()
				manager.Save(entityA)

				Dim entityB As MInventory = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MInventory = GetFirstMInventory()
				entityA.ArriveNum = 49

				manager.Update(entityA)

				Dim entityB As MInventory = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.ArriveNum, entityB.ArriveNum)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MInventory = GetFirstMInventory()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
