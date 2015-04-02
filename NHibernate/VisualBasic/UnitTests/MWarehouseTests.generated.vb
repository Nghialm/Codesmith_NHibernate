Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MWarehouseTests
		Inherits UNuitTestBase
		
		Protected manager As IMWarehouseManager

		Public Sub New()
			manager = managerFactory.GetMWarehouseManager()
		End Sub

		Protected Function CreateNewMWarehouse() As MWarehouse
			Dim entity As New MWarehouse()

			' You may need to maually enter this key if there is a constraint violation.
			entity.Id = default(Byte)
			
			entity.WareHouseName = "Test T"
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Test Test Test"
			entity.EntryDate = "Test Test Test Te"
			entity.EditStaffName = "Test Test "
			entity.EditDate = "Test "

			Return entity
		End Function
		Protected Function GetFirstMWarehouse() As MWarehouse
			Dim entityList As IList(Of MWarehouse) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MWarehouse = CreateNewMWarehouse()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MWarehouse = CreateNewMWarehouse()
				manager.Save(entityA)

				Dim entityB As MWarehouse = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MWarehouse = GetFirstMWarehouse()
				entityA.WareHouseName = "Test Test Te"

				manager.Update(entityA)

				Dim entityB As MWarehouse = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.WareHouseName, entityB.WareHouseName)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MWarehouse = GetFirstMWarehouse()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
