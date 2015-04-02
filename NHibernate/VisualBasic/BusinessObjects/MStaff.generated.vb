Imports System
Imports System.Collections
Imports System.Collections.Generic

Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.BusinessObjects
	Public Partial Class MStaff
		Inherits BusinessBase(Of System.Decimal)

		#region "Declarations"

		
		Private p__staffName As System.String = String.Empty
		Private p__staffNameKana As System.String = String.Empty
		Private p__userID As System.String = String.Empty
		Private p__password As System.String = String.Empty
		Private p__mailAddres As System.String = String.Empty
		Private p__postCd As System.Decimal = Nothing
		Private p__note1 As System.String = String.Empty
		Private p__note2 As System.String = String.Empty
		Private p__note3 As System.String = String.Empty
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
			
			sb.Append(p__staffName)
			sb.Append(p__staffNameKana)
			sb.Append(p__userID)
			sb.Append(p__password)
			sb.Append(p__mailAddres)
			sb.Append(p__postCd)
			sb.Append(p__note1)
			sb.Append(p__note2)
			sb.Append(p__note3)
			sb.Append(p__delFlg)
			sb.Append(p__entryStaffName)
			sb.Append(p__entryDate)
			sb.Append(p__editStaffName)
			sb.Append(p__editDate)
			
			Return sb.ToString().GetHashCode()
		End Function

        #End Region

        #region "Properties"

		
		Public Overridable Property StaffName() As System.String
			Get
				Return p__staffName
			End Get
			Set
				OnStaffNameChanging()
				p__staffName = value
				OnStaffNameChanged()
			End Set
		End Property
		Partial Private Sub OnStaffNameChanging()
		End Sub
		Partial Private Sub OnStaffNameChanged()
		End Sub
		Public Overridable Property StaffNameKana() As System.String
			Get
				Return p__staffNameKana
			End Get
			Set
				OnStaffNameKanaChanging()
				p__staffNameKana = value
				OnStaffNameKanaChanged()
			End Set
		End Property
		Partial Private Sub OnStaffNameKanaChanging()
		End Sub
		Partial Private Sub OnStaffNameKanaChanged()
		End Sub
		Public Overridable Property UserID() As System.String
			Get
				Return p__userID
			End Get
			Set
				OnUserIDChanging()
				p__userID = value
				OnUserIDChanged()
			End Set
		End Property
		Partial Private Sub OnUserIDChanging()
		End Sub
		Partial Private Sub OnUserIDChanged()
		End Sub
		Public Overridable Property Password() As System.String
			Get
				Return p__password
			End Get
			Set
				OnPasswordChanging()
				p__password = value
				OnPasswordChanged()
			End Set
		End Property
		Partial Private Sub OnPasswordChanging()
		End Sub
		Partial Private Sub OnPasswordChanged()
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
		Public Overridable Property PostCd() As System.Decimal
			Get
				Return p__postCd
			End Get
			Set
				OnPostCdChanging()
				p__postCd = value
				OnPostCdChanged()
			End Set
		End Property
		Partial Private Sub OnPostCdChanging()
		End Sub
		Partial Private Sub OnPostCdChanged()
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
