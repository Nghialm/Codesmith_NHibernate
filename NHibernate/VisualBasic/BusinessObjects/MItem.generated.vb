Imports System
Imports System.Collections
Imports System.Collections.Generic

Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.BusinessObjects
	Public Partial Class MItem
		Inherits BusinessBase(Of System.Decimal)

		#region "Declarations"

		
		Private p__itemName As System.String = String.Empty
		Private p__itemNumber As System.String = String.Empty
		Private p__makerCd As System.Decimal = Nothing
		Private p__priceInfo As System.String = String.Empty
		Private p__orderInfo As System.String = String.Empty
		Private p__shipInfo As System.String = String.Empty
		Private p__note1 As System.String = String.Empty
		Private p__note2 As System.String = String.Empty
		Private p__note3 As System.String = String.Empty
		Private p__leadTime As System.Byte = Nothing
		Private p__disFlg As System.Byte = Nothing
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
			
			sb.Append(p__itemName)
			sb.Append(p__itemNumber)
			sb.Append(p__makerCd)
			sb.Append(p__priceInfo)
			sb.Append(p__orderInfo)
			sb.Append(p__shipInfo)
			sb.Append(p__note1)
			sb.Append(p__note2)
			sb.Append(p__note3)
			sb.Append(p__leadTime)
			sb.Append(p__disFlg)
			sb.Append(p__delFlg)
			sb.Append(p__entryStaffName)
			sb.Append(p__entryDate)
			sb.Append(p__editStaffName)
			sb.Append(p__editDate)
			
			Return sb.ToString().GetHashCode()
		End Function

        #End Region

        #region "Properties"

		
		Public Overridable Property ItemName() As System.String
			Get
				Return p__itemName
			End Get
			Set
				OnItemNameChanging()
				p__itemName = value
				OnItemNameChanged()
			End Set
		End Property
		Partial Private Sub OnItemNameChanging()
		End Sub
		Partial Private Sub OnItemNameChanged()
		End Sub
		Public Overridable Property ItemNumber() As System.String
			Get
				Return p__itemNumber
			End Get
			Set
				OnItemNumberChanging()
				p__itemNumber = value
				OnItemNumberChanged()
			End Set
		End Property
		Partial Private Sub OnItemNumberChanging()
		End Sub
		Partial Private Sub OnItemNumberChanged()
		End Sub
		Public Overridable Property MakerCd() As System.Decimal
			Get
				Return p__makerCd
			End Get
			Set
				OnMakerCdChanging()
				p__makerCd = value
				OnMakerCdChanged()
			End Set
		End Property
		Partial Private Sub OnMakerCdChanging()
		End Sub
		Partial Private Sub OnMakerCdChanged()
		End Sub
		Public Overridable Property PriceInfo() As System.String
			Get
				Return p__priceInfo
			End Get
			Set
				OnPriceInfoChanging()
				p__priceInfo = value
				OnPriceInfoChanged()
			End Set
		End Property
		Partial Private Sub OnPriceInfoChanging()
		End Sub
		Partial Private Sub OnPriceInfoChanged()
		End Sub
		Public Overridable Property OrderInfo() As System.String
			Get
				Return p__orderInfo
			End Get
			Set
				OnOrderInfoChanging()
				p__orderInfo = value
				OnOrderInfoChanged()
			End Set
		End Property
		Partial Private Sub OnOrderInfoChanging()
		End Sub
		Partial Private Sub OnOrderInfoChanged()
		End Sub
		Public Overridable Property ShipInfo() As System.String
			Get
				Return p__shipInfo
			End Get
			Set
				OnShipInfoChanging()
				p__shipInfo = value
				OnShipInfoChanged()
			End Set
		End Property
		Partial Private Sub OnShipInfoChanging()
		End Sub
		Partial Private Sub OnShipInfoChanged()
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
		Public Overridable Property LeadTime() As System.Byte
			Get
				Return p__leadTime
			End Get
			Set
				OnLeadTimeChanging()
				p__leadTime = value
				OnLeadTimeChanged()
			End Set
		End Property
		Partial Private Sub OnLeadTimeChanging()
		End Sub
		Partial Private Sub OnLeadTimeChanged()
		End Sub
		Public Overridable Property DisFlg() As System.Byte
			Get
				Return p__disFlg
			End Get
			Set
				OnDisFlgChanging()
				p__disFlg = value
				OnDisFlgChanged()
			End Set
		End Property
		Partial Private Sub OnDisFlgChanging()
		End Sub
		Partial Private Sub OnDisFlgChanged()
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
