Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibernate.Generated.ManagerObjects
Imports NHibernate.Generated.BusinessObjects
Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class MCurrencyTests
		Inherits UNuitTestBase
		
		Protected manager As IMCurrencyManager

		Public Sub New()
			manager = managerFactory.GetMCurrencyManager()
		End Sub

		Protected Function CreateNewMCurrency() As MCurrency
			Dim entity As New MCurrency()

			' You may need to maually enter this key if there is a constraint violation.
			entity.Id = default(Byte)
			
			entity.CurrencyName = "Test"
			entity.DefaultFlg = default(Byte)
			entity.DelFlg = default(Byte)
			entity.EntryStaffName = "Test Test T"
			entity.EntryDate = "Test Test Test"
			entity.EditStaffName = "Test Test Test"
			entity.EditDate = "Test Test Tes"

			Return entity
		End Function
		Protected Function GetFirstMCurrency() As MCurrency
			Dim entityList As IList(Of MCurrency) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As MCurrency = CreateNewMCurrency()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As MCurrency = CreateNewMCurrency()
				manager.Save(entityA)

				Dim entityB As MCurrency = manager.GetById(entityA.Id)

				Assert.IsTrue(entityA.Equals(entityB))
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As MCurrency = GetFirstMCurrency()
				entityA.CurrencyName = "Test"

				manager.Update(entityA)

				Dim entityB As MCurrency = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.CurrencyName, entityB.CurrencyName)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As MCurrency = GetFirstMCurrency()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace
