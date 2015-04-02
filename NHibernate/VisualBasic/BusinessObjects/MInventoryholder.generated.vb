Imports System
Imports System.Collections
Imports System.Collections.Generic

Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.BusinessObjects
	Public Partial Class MInventoryholder
		Inherits BusinessBase(Of System.String)

		#region "Declarations"

		Private p__itemCd As System.Decimal = Nothing
		Private p__closedDate As System.String = String.Empty
		Private p__staffCd As System.Decimal = Nothing
		
		Private p__arriveNum As System.Int32 = Nothing
		Private p__arrivePrice As System.Decimal = Nothing
		Private p__shippingNum As System.Int32 = Nothing
		Private p__shippingPrice As System.Decimal = Nothing
		Private p__stockNum As System.Int32 = Nothing
		Private p__stockPrice As System.Decimal = Nothing
		Private p__disposalNum As System.Int32 = Nothing
		Private p__disposalPrice As System.Decimal = Nothing
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
			
			sb.Append(p__arriveNum)
			sb.Append(p__arrivePrice)
			sb.Append(p__shippingNum)
			sb.Append(p__shippingPrice)
			sb.Append(p__stockNum)
			sb.Append(p__stockPrice)
			sb.Append(p__disposalNum)
			sb.Append(p__disposalPrice)
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
		
				uniqueId.Append(p__itemCd.ToString())
				uniqueId.Append("^")
				uniqueId.Append(p__closedDate.ToString())
				uniqueId.Append("^")
				uniqueId.Append(p__staffCd.ToString())
		
				Return uniqueId.ToString()
			End Get
			Set(ByVal value As String)
            End Set
		End Property
		
		Public Overridable Property ItemCd() As System.Decimal
			Get
				Return p__itemCd
			End Get
			Set
				OnItemCdChanging()
				p__itemCd = value
				OnItemCdChanged()
			End Set
		End Property
		Partial Private Sub OnItemCdChanging()
		End Sub
		Partial Private Sub OnItemCdChanged()
		End Sub
		
		Public Overridable Property ClosedDate() As System.String
			Get
				Return p__closedDate
			End Get
			Set
				OnClosedDateChanging()
				p__closedDate = value
				OnClosedDateChanged()
			End Set
		End Property
		Partial Private Sub OnClosedDateChanging()
		End Sub
		Partial Private Sub OnClosedDateChanged()
		End Sub
		
		Public Overridable Property StaffCd() As System.Decimal
			Get
				Return p__staffCd
			End Get
			Set
				OnStaffCdChanging()
				p__staffCd = value
				OnStaffCdChanged()
			End Set
		End Property
		Partial Private Sub OnStaffCdChanging()
		End Sub
		Partial Private Sub OnStaffCdChanged()
		End Sub
		
		
		Public Overridable Property ArriveNum() As System.Int32
			Get
				Return p__arriveNum
			End Get
			Set
				OnArriveNumChanging()
				p__arriveNum = value
				OnArriveNumChanged()
			End Set
		End Property
		Partial Private Sub OnArriveNumChanging()
		End Sub
		Partial Private Sub OnArriveNumChanged()
		End Sub
		Public Overridable Property ArrivePrice() As System.Decimal
			Get
				Return p__arrivePrice
			End Get
			Set
				OnArrivePriceChanging()
				p__arrivePrice = value
				OnArrivePriceChanged()
			End Set
		End Property
		Partial Private Sub OnArrivePriceChanging()
		End Sub
		Partial Private Sub OnArrivePriceChanged()
		End Sub
		Public Overridable Property ShippingNum() As System.Int32
			Get
				Return p__shippingNum
			End Get
			Set
				OnShippingNumChanging()
				p__shippingNum = value
				OnShippingNumChanged()
			End Set
		End Property
		Partial Private Sub OnShippingNumChanging()
		End Sub
		Partial Private Sub OnShippingNumChanged()
		End Sub
		Public Overridable Property ShippingPrice() As System.Decimal
			Get
				Return p__shippingPrice
			End Get
			Set
				OnShippingPriceChanging()
				p__shippingPrice = value
				OnShippingPriceChanged()
			End Set
		End Property
		Partial Private Sub OnShippingPriceChanging()
		End Sub
		Partial Private Sub OnShippingPriceChanged()
		End Sub
		Public Overridable Property StockNum() As System.Int32
			Get
				Return p__stockNum
			End Get
			Set
				OnStockNumChanging()
				p__stockNum = value
				OnStockNumChanged()
			End Set
		End Property
		Partial Private Sub OnStockNumChanging()
		End Sub
		Partial Private Sub OnStockNumChanged()
		End Sub
		Public Overridable Property StockPrice() As System.Decimal
			Get
				Return p__stockPrice
			End Get
			Set
				OnStockPriceChanging()
				p__stockPrice = value
				OnStockPriceChanged()
			End Set
		End Property
		Partial Private Sub OnStockPriceChanging()
		End Sub
		Partial Private Sub OnStockPriceChanged()
		End Sub
		Public Overridable Property DisposalNum() As System.Int32
			Get
				Return p__disposalNum
			End Get
			Set
				OnDisposalNumChanging()
				p__disposalNum = value
				OnDisposalNumChanged()
			End Set
		End Property
		Partial Private Sub OnDisposalNumChanging()
		End Sub
		Partial Private Sub OnDisposalNumChanged()
		End Sub
		Public Overridable Property DisposalPrice() As System.Decimal
			Get
				Return p__disposalPrice
			End Get
			Set
				OnDisposalPriceChanging()
				p__disposalPrice = value
				OnDisposalPriceChanged()
			End Set
		End Property
		Partial Private Sub OnDisposalPriceChanging()
		End Sub
		Partial Private Sub OnDisposalPriceChanged()
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
