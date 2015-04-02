Imports System
Imports System.Collections
Imports System.Collections.Generic

Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.BusinessObjects
	Public Partial Class MRate
		Inherits BusinessBase(Of System.String)

		#region "Declarations"

		Private p__startDate As System.String = String.Empty
		Private p__currencyCd As System.Byte = Nothing
		
		Private p__taxRate As System.Decimal = Nothing
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
			
			sb.Append(p__taxRate)
			sb.Append(p__delFlg)
			sb.Append(p__entryStaffName)
			sb.Append(p__entryDate)
			sb.Append(p__editStaffName)
			sb.Append(p__editDate)
			
			Return sb.ToString().GetHashCode()
		End Function

        #End Region

        #region "Properties"

		Public Overloads Overrides Property Id() As String
			Get
				Dim uniqueId As New System.Text.StringBuilder()
		
				uniqueId.Append(p__startDate.ToString())
				uniqueId.Append("^")
				uniqueId.Append(p__currencyCd.ToString())
		
				Return uniqueId.ToString()
			End Get
			Set(ByVal value As String)
            End Set
		End Property
		
		Public Overridable Property StartDate() As System.String
			Get
				Return p__startDate
			End Get
			Set
				OnStartDateChanging()
				p__startDate = value
				OnStartDateChanged()
			End Set
		End Property
		Partial Private Sub OnStartDateChanging()
		End Sub
		Partial Private Sub OnStartDateChanged()
		End Sub
		
		Public Overridable Property CurrencyCd() As System.Byte
			Get
				Return p__currencyCd
			End Get
			Set
				OnCurrencyCdChanging()
				p__currencyCd = value
				OnCurrencyCdChanged()
			End Set
		End Property
		Partial Private Sub OnCurrencyCdChanging()
		End Sub
		Partial Private Sub OnCurrencyCdChanged()
		End Sub
		
		
		Public Overridable Property TaxRate() As System.Decimal
			Get
				Return p__taxRate
			End Get
			Set
				OnTaxRateChanging()
				p__taxRate = value
				OnTaxRateChanged()
			End Set
		End Property
		Partial Private Sub OnTaxRateChanging()
		End Sub
		Partial Private Sub OnTaxRateChanged()
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
