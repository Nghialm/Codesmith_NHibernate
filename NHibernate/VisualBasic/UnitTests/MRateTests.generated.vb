Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MRateTests
		Inherits UNuitTestBase
		
		Protected manager As IMRateManager

		Public Sub New()
			manager = managerFactory.GetMRateManager()
		End Sub

		Protected Function CreateNewMRate() As MRate
			Dim entity As New MRate()

			entity.StartDate = "Test Tes"
			entity.CurrencyCd = default(Byte)
			
			entity.TaxRate = 29
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Test Test"
			entity.EntryDate = "Tes"
			entity.EditStaffName = "Test Test Test Test"
			entity.EditDate = "Te"

			Return entity
		End Function
		Protected Function GetFirstMRate() As MRate
			Dim entityList As IList(Of MRate) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MRate = CreateNewMRate()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MRate = CreateNewMRate()
				manager.Save(entityA)

				Dim entityB As MRate = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MRate = GetFirstMRate()
				entityA.TaxRate = 52

				manager.Update(entityA)

				Dim entityB As MRate = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.TaxRate, entityB.TaxRate)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MRate = GetFirstMRate()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
