Imports System
Imports System.Collections
Imports System.Collections.Generic

Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.BusinessObjects
	Public Partial Class MCurrency
		Inherits BusinessBase(Of System.Byte)

		#region "Declarations"

		
		Private p__currencyName As System.String = String.Empty
		Private p__defaultFlg As System.Byte = Nothing
		Private p__delFlg As System.Byte = Nothing
		Private p__entryStaffName As System.String = String.Empty
		Private p__entryDate As System.String = String.Empty
		Private p__editStaffName As System.String = String.Empty
		Private p__editDate As System.String = String.Empty
		
		
				
        #End Region

        #region "Constructors"

        Public Sub New()
		End Sub

        #End Region

        #region "Methods"

		Public Overloads Overrides Function GetHashCode() As Integer
			Dim sb As New System.Text.StringBuilder()

			sb.Append(Me.[GetType]().FullName)
			
			sb.Append(p__currencyName)
			sb.Append(p__defaultFlg)
			sb.Append(p__delFlg)
			sb.Append(p__entryStaffName)
			sb.Append(p__entryDate)
			sb.Append(p__editStaffName)
			sb.Append(p__editDate)
			
			Return sb.ToString().GetHashCode()
		End Function

        #End Region

        #region "Properties"

		
		Public Overridable Property CurrencyName() As System.String
			Get
				Return p__currencyName
			End Get
			Set
				OnCurrencyNameChanging()
				p__currencyName = value
				OnCurrencyNameChanged()
			End Set
		End Property
		Partial Private Sub OnCurrencyNameChanging()
		End Sub
		Partial Private Sub OnCurrencyNameChanged()
		End Sub
		Public Overridable Property DefaultFlg() As System.Byte
			Get
				Return p__defaultFlg
			End Get
			Set
				OnDefaultFlgChanging()
				p__defaultFlg = value
				OnDefaultFlgChanged()
			End Set
		End Property
		Partial Private Sub OnDefaultFlgChanging()
		End Sub
		Partial Private Sub OnDefaultFlgChanged()
		End Sub
		Public Overridable Property DelFlg() As System.Byte
			Get
				Return p__delFlg
			End Get
			Set
				OnDelFlgChanging()
				p__delFlg = value
				OnDelFlgChanged()
			End Set
		End Property
		Partial Private Sub OnDelFlgChanging()
		End Sub
		Partial Private Sub OnDelFlgChanged()
		End Sub
		Public Overridable Property EntryStaffName() As System.String
			Get
				Return p__entryStaffName
			End Get
			Set
				OnEntryStaffNameChanging()
				p__entryStaffName = value
				OnEntryStaffNameChanged()
			End Set
		End Property
		Partial Private Sub OnEntryStaffNameChanging()
		End Sub
		Partial Private Sub OnEntryStaffNameChanged()
		End Sub
		Public Overridable Property EntryDate() As System.String
			Get
				Return p__entryDate
			End Get
			Set
				OnEntryDateChanging()
				p__entryDate = value
				OnEntryDateChanged()
			End Set
		End Property
		Partial Private Sub OnEntryDateChanging()
		End Sub
		Partial Private Sub OnEntryDateChanged()
		End Sub
		Public Overridable Property EditStaffName() As System.String
			Get
				Return p__editStaffName
			End Get
			Set
				OnEditStaffNameChanging()
				p__editStaffName = value
				OnEditStaffNameChanged()
			End Set
		End Property
		Partial Private Sub OnEditStaffNameChanging()
		End Sub
		Partial Private Sub OnEditStaffNameChanged()
		End Sub
		Public Overridable Property EditDate() As System.String
			Get
				Return p__editDate
			End Get
			Set
				OnEditDateChanging()
				p__editDate = value
				OnEditDateChanged()
			End Set
		End Property
		Partial Private Sub OnEditDateChanging()
		End Sub
		Partial Private Sub OnEditDateChanged()
		End Sub
		
		
		
        #End Region

	End Class
End Namespace
