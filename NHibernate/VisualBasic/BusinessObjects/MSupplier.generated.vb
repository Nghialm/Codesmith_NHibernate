Imports System
Imports System.Collections
Imports System.Collections.Generic

Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.BusinessObjects
	Public Partial Class MSupplier
		Inherits BusinessBase(Of System.Decimal)

		#region "Declarations"

		
		Private p__supplierName As System.String = String.Empty
		Private p__supplierAbbreviation As System.String = String.Empty
		Private p__supplierKana As System.String = String.Empty
		Private p__zipcode As System.String = String.Empty
		Private p__addres As System.String = String.Empty
		Private p__tel As System.String = String.Empty
		Private p__fax As System.String = String.Empty
		Private p__supplierDept As System.String = String.Empty
		Private p__supplierCP As System.String = String.Empty
		Private p__mailAddres As System.String = String.Empty
		Private p__closeingDate As System.Byte = Nothing
		Private p__note1 As System.String = String.Empty
		Private p__note2 As System.String = String.Empty
		Private p__note3 As System.String = String.Empty
		Private p__segment As System.Byte = Nothing
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
			
			sb.Append(p__supplierName)
			sb.Append(p__supplierAbbreviation)
			sb.Append(p__supplierKana)
			sb.Append(p__zipcode)
			sb.Append(p__addres)
			sb.Append(p__tel)
			sb.Append(p__fax)
			sb.Append(p__supplierDept)
			sb.Append(p__supplierCP)
			sb.Append(p__mailAddres)
			sb.Append(p__closeingDate)
			sb.Append(p__note1)
			sb.Append(p__note2)
			sb.Append(p__note3)
			sb.Append(p__segment)
			sb.Append(p__delFlg)
			sb.Append(p__entryStaffName)
			sb.Append(p__entryDate)
			sb.Append(p__editStaffName)
			sb.Append(p__editDate)
			
			Return sb.ToString().GetHashCode()
		End Function

        #End Region

        #region "Properties"

		
		Public Overridable Property SupplierName() As System.String
			Get
				Return p__supplierName
			End Get
			Set
				OnSupplierNameChanging()
				p__supplierName = value
				OnSupplierNameChanged()
			End Set
		End Property
		Partial Private Sub OnSupplierNameChanging()
		End Sub
		Partial Private Sub OnSupplierNameChanged()
		End Sub
		Public Overridable Property SupplierAbbreviation() As System.String
			Get
				Return p__supplierAbbreviation
			End Get
			Set
				OnSupplierAbbreviationChanging()
				p__supplierAbbreviation = value
				OnSupplierAbbreviationChanged()
			End Set
		End Property
		Partial Private Sub OnSupplierAbbreviationChanging()
		End Sub
		Partial Private Sub OnSupplierAbbreviationChanged()
		End Sub
		Public Overridable Property SupplierKana() As System.String
			Get
				Return p__supplierKana
			End Get
			Set
				OnSupplierKanaChanging()
				p__supplierKana = value
				OnSupplierKanaChanged()
			End Set
		End Property
		Partial Private Sub OnSupplierKanaChanging()
		End Sub
		Partial Private Sub OnSupplierKanaChanged()
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
		Public Overridable Property SupplierDept() As System.String
			Get
				Return p__supplierDept
			End Get
			Set
				OnSupplierDeptChanging()
				p__supplierDept = value
				OnSupplierDeptChanged()
			End Set
		End Property
		Partial Private Sub OnSupplierDeptChanging()
		End Sub
		Partial Private Sub OnSupplierDeptChanged()
		End Sub
		Public Overridable Property SupplierCP() As System.String
			Get
				Return p__supplierCP
			End Get
			Set
				OnSupplierCPChanging()
				p__supplierCP = value
				OnSupplierCPChanged()
			End Set
		End Property
		Partial Private Sub OnSupplierCPChanging()
		End Sub
		Partial Private Sub OnSupplierCPChanged()
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
		Public Overridable Property Segment() As System.Byte
			Get
				Return p__segment
			End Get
			Set
				OnSegmentChanging()
				p__segment = value
				OnSegmentChanged()
			End Set
		End Property
		Partial Private Sub OnSegmentChanging()
		End Sub
		Partial Private Sub OnSegmentChanged()
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
