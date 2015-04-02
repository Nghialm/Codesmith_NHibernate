Imports System
Imports System.Collections
Imports System.Collections.Generic

Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.BusinessObjects
	Public Partial Class MClient
		Inherits BusinessBase(Of System.Decimal)

		#region "Declarations"

		
		Private p__clientName As System.String = String.Empty
		Private p__clientAbbreviation As System.String = String.Empty
		Private p__clientKana As System.String = String.Empty
		Private p__zipcode As System.String = String.Empty
		Private p__addres As System.String = String.Empty
		Private p__tel As System.String = String.Empty
		Private p__fax As System.String = String.Empty
		Private p__clientDept As System.String = String.Empty
		Private p__clientCP As System.String = String.Empty
		Private p__mailAddres As System.String = String.Empty
		Private p__closeingDate As System.Byte = Nothing
		Private p__note1 As System.String = String.Empty
		Private p__note2 As System.String = String.Empty
		Private p__note3 As System.String = String.Empty
		Private p__salesStaffCd As System.Decimal = Nothing
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
			
			sb.Append(p__clientName)
			sb.Append(p__clientAbbreviation)
			sb.Append(p__clientKana)
			sb.Append(p__zipcode)
			sb.Append(p__addres)
			sb.Append(p__tel)
			sb.Append(p__fax)
			sb.Append(p__clientDept)
			sb.Append(p__clientCP)
			sb.Append(p__mailAddres)
			sb.Append(p__closeingDate)
			sb.Append(p__note1)
			sb.Append(p__note2)
			sb.Append(p__note3)
			sb.Append(p__salesStaffCd)
			sb.Append(p__delFlg)
			sb.Append(p__entryStaffName)
			sb.Append(p__entryDate)
			sb.Append(p__editStaffName)
			sb.Append(p__editDate)
			
			Return sb.ToString().GetHashCode()
		End Function

        #End Region

        #region "Properties"

		
		Public Overridable Property ClientName() As System.String
			Get
				Return p__clientName
			End Get
			Set
				OnClientNameChanging()
				p__clientName = value
				OnClientNameChanged()
			End Set
		End Property
		Partial Private Sub OnClientNameChanging()
		End Sub
		Partial Private Sub OnClientNameChanged()
		End Sub
		Public Overridable Property ClientAbbreviation() As System.String
			Get
				Return p__clientAbbreviation
			End Get
			Set
				OnClientAbbreviationChanging()
				p__clientAbbreviation = value
				OnClientAbbreviationChanged()
			End Set
		End Property
		Partial Private Sub OnClientAbbreviationChanging()
		End Sub
		Partial Private Sub OnClientAbbreviationChanged()
		End Sub
		Public Overridable Property ClientKana() As System.String
			Get
				Return p__clientKana
			End Get
			Set
				OnClientKanaChanging()
				p__clientKana = value
				OnClientKanaChanged()
			End Set
		End Property
		Partial Private Sub OnClientKanaChanging()
		End Sub
		Partial Private Sub OnClientKanaChanged()
		End Sub
		Public Overridable Property Zipcode() As System.String
			Get
				Return p__zipcode
			End Get
			Set
				OnZipcodeChanging()
				p__zipcode = value
				OnZipcodeChanged()
			End Set
		End Property
		Partial Private Sub OnZipcodeChanging()
		End Sub
		Partial Private Sub OnZipcodeChanged()
		End Sub
		Public Overridable Property Addres() As System.String
			Get
				Return p__addres
			End Get
			Set
				OnAddresChanging()
				p__addres = value
				OnAddresChanged()
			End Set
		End Property
		Partial Private Sub OnAddresChanging()
		End Sub
		Partial Private Sub OnAddresChanged()
		End Sub
		Public Overridable Property Tel() As System.String
			Get
				Return p__tel
			End Get
			Set
				OnTelChanging()
				p__tel = value
				OnTelChanged()
			End Set
		End Property
		Partial Private Sub OnTelChanging()
		End Sub
		Partial Private Sub OnTelChanged()
		End Sub
		Public Overridable Property Fax() As System.String
			Get
				Return p__fax
			End Get
			Set
				OnFaxChanging()
				p__fax = value
				OnFaxChanged()
			End Set
		End Property
		Partial Private Sub OnFaxChanging()
		End Sub
		Partial Private Sub OnFaxChanged()
		End Sub
		Public Overridable Property ClientDept() As System.String
			Get
				Return p__clientDept
			End Get
			Set
				OnClientDeptChanging()
				p__clientDept = value
				OnClientDeptChanged()
			End Set
		End Property
		Partial Private Sub OnClientDeptChanging()
		End Sub
		Partial Private Sub OnClientDeptChanged()
		End Sub
		Public Overridable Property ClientCP() As System.String
			Get
				Return p__clientCP
			End Get
			Set
				OnClientCPChanging()
				p__clientCP = value
				OnClientCPChanged()
			End Set
		End Property
		Partial Private Sub OnClientCPChanging()
		End Sub
		Partial Private Sub OnClientCPChanged()
		End Sub
		Public Overridable Property MailAddres() As System.String
			Get
				Return p__mailAddres
			End Get
			Set
				OnMailAddresChanging()
				p__mailAddres = value
				OnMailAddresChanged()
			End Set
		End Property
		Partial Private Sub OnMailAddresChanging()
		End Sub
		Partial Private Sub OnMailAddresChanged()
		End Sub
		Public Overridable Property CloseingDate() As System.Byte
			Get
				Return p__closeingDate
			End Get
			Set
				OnCloseingDateChanging()
				p__closeingDate = value
				OnCloseingDateChanged()
			End Set
		End Property
		Partial Private Sub OnCloseingDateChanging()
		End Sub
		Partial Private Sub OnCloseingDateChanged()
		End Sub
		Public Overridable Property Note1() As System.String
			Get
				Return p__note1
			End Get
			Set
				OnNote1Changing()
				p__note1 = value
				OnNote1Changed()
			End Set
		End Property
		Partial Private Sub OnNote1Changing()
		End Sub
		Partial Private Sub OnNote1Changed()
		End Sub
		Public Overridable Property Note2() As System.String
			Get
				Return p__note2
			End Get
			Set
				OnNote2Changing()
				p__note2 = value
				OnNote2Changed()
			End Set
		End Property
		Partial Private Sub OnNote2Changing()
		End Sub
		Partial Private Sub OnNote2Changed()
		End Sub
		Public Overridable Property Note3() As System.String
			Get
				Return p__note3
			End Get
			Set
				OnNote3Changing()
				p__note3 = value
				OnNote3Changed()
			End Set
		End Property
		Partial Private Sub OnNote3Changing()
		End Sub
		Partial Private Sub OnNote3Changed()
		End Sub
		Public Overridable Property SalesStaffCd() As System.Decimal
			Get
				Return p__salesStaffCd
			End Get
			Set
				OnSalesStaffCdChanging()
				p__salesStaffCd = value
				OnSalesStaffCdChanged()
			End Set
		End Property
		Partial Private Sub OnSalesStaffCdChanging()
		End Sub
		Partial Private Sub OnSalesStaffCdChanged()
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
