Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MInventoryholderTests
		Inherits UNuitTestBase
		
		Protected manager As IMInventoryholderManager

		Public Sub New()
			manager = managerFactory.GetMInventoryholderManager()
		End Sub

		Protected Function CreateNewMInventoryholder() As MInventoryholder
			Dim entity As New MInventoryholder()

			entity.ItemCd = 64
			entity.ClosedDate = "T"
			entity.StaffCd = 87
			
			entity.ArriveNum = 83
			entity.ArrivePrice = 39
			entity.ShippingNum = 46
			entity.ShippingPrice = 70
			entity.StockNum = 40
			entity.StockPrice = 1
			entity.DisposalNum = 84
			entity.DisposalPrice = 36
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Test Test Test "
			entity.EntryDate = "Test Tes"
			entity.EditStaffName = "Te"
			entity.EditDate = "Test Test Tes"

			Return entity
		End Function
		Protected Function GetFirstMInventoryholder() As MInventoryholder
			Dim entityList As IList(Of MInventoryholder) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MInventoryholder = CreateNewMInventoryholder()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MInventoryholder = CreateNewMInventoryholder()
				manager.Save(entityA)

				Dim entityB As MInventoryholder = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MInventoryholder = GetFirstMInventoryholder()
				entityA.ArriveNum = 62

				manager.Update(entityA)

				Dim entityB As MInventoryholder = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.ArriveNum, entityB.ArriveNum)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MInventoryholder = GetFirstMInventoryholder()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
