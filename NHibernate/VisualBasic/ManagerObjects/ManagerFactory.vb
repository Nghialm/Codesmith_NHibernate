
Imports System
Imports System.Collections.Generic
Imports System.Text

Imports NHibernate.Generated.Base

Namespace NHibernate.Generated.ManagerObjects
	Public Interface IManagerFactory
		' Get Methods
		Function GetMClientManager() As IMClientManager
		Function GetMClientManager(ByVal session As INHibernateSession) As IMClientManager
		Function GetMCurrencyManager() As IMCurrencyManager
		Function GetMCurrencyManager(ByVal session As INHibernateSession) As IMCurrencyManager
		Function GetMFigurenumberManager() As IMFigurenumberManager
		Function GetMFigurenumberManager(ByVal session As INHibernateSession) As IMFigurenumberManager
		Function GetMInventoryManager() As IMInventoryManager
		Function GetMInventoryManager(ByVal session As INHibernateSession) As IMInventoryManager
		Function GetMInventoryholderManager() As IMInventoryholderManager
		Function GetMInventoryholderManager(ByVal session As INHibernateSession) As IMInventoryholderManager
		Function GetMItemManager() As IMItemManager
		Function GetMItemManager(ByVal session As INHibernateSession) As IMItemManager
		Function GetMRateManager() As IMRateManager
		Function GetMRateManager(ByVal session As INHibernateSession) As IMRateManager
		Function GetMStaffManager() As IMStaffManager
		Function GetMStaffManager(ByVal session As INHibernateSession) As IMStaffManager
		Function GetMSupplierManager() As IMSupplierManager
		Function GetMSupplierManager(ByVal session As INHibernateSession) As IMSupplierManager
		Function GetMWarehouseManager() As IMWarehouseManager
		Function GetMWarehouseManager(ByVal session As INHibernateSession) As IMWarehouseManager
	End Interface

	Public Class ManagerFactory
		Implements IManagerFactory
		
#region "Constructors"
		Public Sub New()
		End Sub
#End Region

#region "Get Methods"

		Public Function GetMClientManager() As IMClientManager Implements IManagerFactory.GetMClientManager
			Return New MClientManager()
		End Function
		Public Function GetMClientManager(ByVal session As INHibernateSession) As IMClientManager Implements IManagerFactory.GetMClientManager
			Return New MClientManager(session)
		End Function
		Public Function GetMCurrencyManager() As IMCurrencyManager Implements IManagerFactory.GetMCurrencyManager
			Return New MCurrencyManager()
		End Function
		Public Function GetMCurrencyManager(ByVal session As INHibernateSession) As IMCurrencyManager Implements IManagerFactory.GetMCurrencyManager
			Return New MCurrencyManager(session)
		End Function
		Public Function GetMFigurenumberManager() As IMFigurenumberManager Implements IManagerFactory.GetMFigurenumberManager
			Return New MFigurenumberManager()
		End Function
		Public Function GetMFigurenumberManager(ByVal session As INHibernateSession) As IMFigurenumberManager Implements IManagerFactory.GetMFigurenumberManager
			Return New MFigurenumberManager(session)
		End Function
		Public Function GetMInventoryManager() As IMInventoryManager Implements IManagerFactory.GetMInventoryManager
			Return New MInventoryManager()
		End Function
		Public Function GetMInventoryManager(ByVal session As INHibernateSession) As IMInventoryManager Implements IManagerFactory.GetMInventoryManager
			Return New MInventoryManager(session)
		End Function
		Public Function GetMInventoryholderManager() As IMInventoryholderManager Implements IManagerFactory.GetMInventoryholderManager
			Return New MInventoryholderManager()
		End Function
		Public Function GetMInventoryholderManager(ByVal session As INHibernateSession) As IMInventoryholderManager Implements IManagerFactory.GetMInventoryholderManager
			Return New MInventoryholderManager(session)
		End Function
		Public Function GetMItemManager() As IMItemManager Implements IManagerFactory.GetMItemManager
			Return New MItemManager()
		End Function
		Public Function GetMItemManager(ByVal session As INHibernateSession) As IMItemManager Implements IManagerFactory.GetMItemManager
			Return New MItemManager(session)
		End Function
		Public Function GetMRateManager() As IMRateManager Implements IManagerFactory.GetMRateManager
			Return New MRateManager()
		End Function
		Public Function GetMRateManager(ByVal session As INHibernateSession) As IMRateManager Implements IManagerFactory.GetMRateManager
			Return New MRateManager(session)
		End Function
		Public Function GetMStaffManager() As IMStaffManager Implements IManagerFactory.GetMStaffManager
			Return New MStaffManager()
		End Function
		Public Function GetMStaffManager(ByVal session As INHibernateSession) As IMStaffManager Implements IManagerFactory.GetMStaffManager
			Return New MStaffManager(session)
		End Function
		Public Function GetMSupplierManager() As IMSupplierManager Implements IManagerFactory.GetMSupplierManager
			Return New MSupplierManager()
		End Function
		Public Function GetMSupplierManager(ByVal session As INHibernateSession) As IMSupplierManager Implements IManagerFactory.GetMSupplierManager
			Return New MSupplierManager(session)
		End Function
		Public Function GetMWarehouseManager() As IMWarehouseManager Implements IManagerFactory.GetMWarehouseManager
			Return New MWarehouseManager()
		End Function
		Public Function GetMWarehouseManager(ByVal session As INHibernateSession) As IMWarehouseManager Implements IManagerFactory.GetMWarehouseManager
			Return New MWarehouseManager(session)
		End Function
		
#End Region
	End Class
End Namespace
