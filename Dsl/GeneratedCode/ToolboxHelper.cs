﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace UPM_IPS.RGRLLCAMSProyectoMDD
{
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	/// <remarks>
	/// Double-derived class to allow easier code customization.
	/// </remarks>
	public partial class RGRLLCAMSProyectoMDDToolboxHelper : RGRLLCAMSProyectoMDDToolboxHelperBase 
	{
		/// <summary>
		/// Constructs a new RGRLLCAMSProyectoMDDToolboxHelper.
		/// </summary>
		public RGRLLCAMSProyectoMDDToolboxHelper(global::System.IServiceProvider serviceProvider)
			: base(serviceProvider) { }
	}
	
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Justification = "The store is disposed on domain shut down")]
	public abstract class RGRLLCAMSProyectoMDDToolboxHelperBase
	{
		/// <summary>
		/// Toolbox item filter string used to identify RGRLLCAMSProyectoMDD toolbox items.  
		/// </summary>
		/// <remarks>
		/// See the MSDN documentation for the ToolboxItemFilterAttribute class for more information on toolbox
		/// item filters.
		/// </remarks>
		public const string ToolboxFilterString = "RGRLLCAMSProyectoMDD.1.0";
		/// <summary>
		/// Toolbox item filter string used to identify EndButton connector tool.
		/// </summary>
		public const string EndButtonFilterString = "EndButton.1.0";
		/// <summary>
		/// Toolbox item filter string used to identify EndItem connector tool.
		/// </summary>
		public const string EndItemFilterString = "EndItem.1.0";
		/// <summary>
		/// Toolbox item filter string used to identify MainSecondary connector tool.
		/// </summary>
		public const string MainSecondaryFilterString = "MainSecondary.1.0";
		/// <summary>
		/// Toolbox item filter string used to identify SecondarySecondary connector tool.
		/// </summary>
		public const string SecondarySecondaryFilterString = "SecondarySecondary.1.0";

	
		private global::System.Collections.Generic.Dictionary<string, DslDesign::ModelingToolboxItem> toolboxItemCache = new global::System.Collections.Generic.Dictionary<string, DslDesign::ModelingToolboxItem>();
		private DslModeling::Store toolboxStore;
		
		private global::System.IServiceProvider sp;
		
		/// <summary>
		/// Constructs a new RGRLLCAMSProyectoMDDToolboxHelperBase.
		/// </summary>
		protected RGRLLCAMSProyectoMDDToolboxHelperBase(global::System.IServiceProvider serviceProvider)
		{
			if(serviceProvider == null) throw new global::System.ArgumentNullException("serviceProvider");
			
			this.sp = serviceProvider;
		}
		
		/// <summary>
		/// Serivce provider used to access services from the hosting environment.
		/// </summary>
		protected global::System.IServiceProvider ServiceProvider
		{
			get
			{
				return this.sp;
			}
		}

		/// <summary>
		/// Returns the display name of the tab that should be opened by default when the editor is opened.
		/// </summary>
		public static string DefaultToolboxTabName
		{
			get
			{
				return global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel.SingletonResourceManager.GetString("MainWindowToolboxTab", global::System.Globalization.CultureInfo.CurrentUICulture);
			}
		}
		
		
		/// <summary>
		/// Returns the toolbox items count in the default tool box tab.
		/// </summary>
		public static int DefaultToolboxTabToolboxItemsCount
		{
			get
			{
				return 1;
			}
		}
		

		/// <summary>
		/// Returns a list of custom toolbox items to be added dynamically
		/// </summary>
		public virtual global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem> toolboxItems = new global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem>();
			return toolboxItems;
		}
		
		/// <summary>
		/// Creates an ElementGroupPrototype for the element tool corresponding to the given domain class id.
		/// Default behavior is to create a prototype containing an instance of the domain class.
		/// Derived classes may override this to add additional information to the prototype.
		/// </summary>
		protected virtual DslModeling::ElementGroupPrototype CreateElementToolPrototype(DslModeling::Store store, global::System.Guid domainClassId)
		{
			DslModeling::ModelElement element = store.ElementFactory.CreateElement(domainClassId);
			DslModeling::ElementGroup elementGroup = new DslModeling::ElementGroup(store.DefaultPartition);
			elementGroup.AddGraph(element, true);
			return elementGroup.CreatePrototype();
		}

		/// <summary>
		/// Returns instance of ModelingToolboxItem based on specified name.
		/// This method must be called from within a Transaction. Failure to do so will result in an exception
		/// </summary>
		/// <param name="itemId">unique name of desired ToolboxItem</param>
		/// <param name="store">Store to perform the operation against</param>
		/// <returns>An instance of ModelingToolboxItem if the itemId can be resolved, null otherwise</returns>
		public virtual DslDesign::ModelingToolboxItem GetToolboxItem(string itemId, DslModeling::Store store)
		{
			DslDesign::ModelingToolboxItem result = null;
			if (string.IsNullOrEmpty(itemId))
			{
				return null;
			}
			if (store == null)
			{
				return null;
			}
			global::System.Resources.ResourceManager resourceManager = global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel.SingletonResourceManager;
			global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;
			switch(itemId)
			{
				case "UPM_IPS.RGRLLCAMSProyectoMDD.MainWindowToolToolboxItem":
					// Add MainWindowTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.MainWindowToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("MainWindowToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("MainWindowToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"UPM_IPS.RGRLLCAMSProyectoMDD.MainWindowToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("MainWindowToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"MainWindowTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("MainWindowToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::UPM_IPS.RGRLLCAMSProyectoMDD.MainWindow.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.SecondaryWindowToolToolboxItem":
					// Add SecondaryWindowTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.SecondaryWindowToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("SecondaryWindowToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("SecondaryWindowToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"UPM_IPS.RGRLLCAMSProyectoMDD.SecondaryWindowToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("SecondaryWindowToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"SecondaryWindowTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("SecondaryWindowToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::UPM_IPS.RGRLLCAMSProyectoMDD.SecondaryWindow.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.ButtonToolToolboxItem":
					// Add ButtonTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.ButtonToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ButtonToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ButtonToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"UPM_IPS.RGRLLCAMSProyectoMDD.ButtonToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ButtonToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ButtonTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ButtonToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::UPM_IPS.RGRLLCAMSProyectoMDD.Button.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.MenuToolToolboxItem":
					// Add MenuTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.MenuToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("MenuToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("MenuToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"UPM_IPS.RGRLLCAMSProyectoMDD.MenuToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("MenuToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"MenuTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("MenuToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::UPM_IPS.RGRLLCAMSProyectoMDD.Menu.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.ItemToolToolboxItem":
					// Add ItemTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.ItemToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ItemToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ItemToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"UPM_IPS.RGRLLCAMSProyectoMDD.ItemToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ItemToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ItemTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ItemToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::UPM_IPS.RGRLLCAMSProyectoMDD.Item.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.EndToolToolboxItem":
					// Add EndTool shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.EndToolToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("EndToolToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("EndToolToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"UPM_IPS.RGRLLCAMSProyectoMDD.EndToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("EndToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"EndTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("EndToolToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::UPM_IPS.RGRLLCAMSProyectoMDD.End.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.EndButtonToolboxItem":

					// Add EndButton connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.EndButtonToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("EndButtonToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("EndButtonToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"UPM_IPS.RGRLLCAMSProyectoMDD.EnlaceToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("EnlaceToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"EndButtonTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("EndButtonToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(EndButtonFilterString)
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.EndItemToolboxItem":

					// Add EndItem connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.EndItemToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						2, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("EndItemToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("EndItemToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"UPM_IPS.RGRLLCAMSProyectoMDD.EnlaceToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("EnlaceToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"EndItemTool", // F1 help keyword for the toolbox item.
						resourceManager.GetString("EndItemToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(EndItemFilterString)
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.MainSecondaryToolboxItem":

					// Add MainSecondary connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.MainSecondaryToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						3, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("MainSecondaryToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("MainSecondaryToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"UPM_IPS.RGRLLCAMSProyectoMDD.EnlaceToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("EnlaceToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"MainSecondaryTools", // F1 help keyword for the toolbox item.
						resourceManager.GetString("MainSecondaryToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(MainSecondaryFilterString)
						});
					break;
				case "UPM_IPS.RGRLLCAMSProyectoMDD.SecondarySecondaryToolboxItem":

					// Add SecondarySecondary connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"UPM_IPS.RGRLLCAMSProyectoMDD.SecondarySecondaryToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						4, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("SecondarySecondaryToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("SecondarySecondaryToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"UPM_IPS.RGRLLCAMSProyectoMDD.EnlaceToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("EnlaceToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"SecondarySecondaryTools", // F1 help keyword for the toolbox item.
						resourceManager.GetString("SecondarySecondaryToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(SecondarySecondaryFilterString)
						});
					break;
				default:
					break;
			} // end switch
			
			return result;
		}
		

		/// <summary>
		/// The store toe be used for all the toolbox item creation
		/// </summary>
		protected DslModeling::Store ToolboxStore
		{
			get
			{ 
				if (toolboxStore==null)
				{
					toolboxStore = new DslModeling::Store(this.ServiceProvider);
					EventHandler StoreCleanUp = (o, e) =>
					{
						//Since Store implements IDisposable, we need to dispose it when we're finished
						if (this.toolboxStore != null)
						{
							this.toolboxStore.Dispose();
						}
						this.toolboxStore = null;
					};
					//There is no DomainUnload event for the default AppDomain, so we listen for both ProcessExit and DomainUnload
					AppDomain.CurrentDomain.ProcessExit += new EventHandler(StoreCleanUp);
					AppDomain.CurrentDomain.DomainUnload += new EventHandler(StoreCleanUp);
					
					//load the domain model
					toolboxStore.LoadDomainModels(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel));
					
				}
				return toolboxStore;
			}
		}
		
		/// <summary>
		/// Given a toolbox item "unique ID" returns the the toolbox item using cached dictionary
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve</param>
		private DslDesign::ModelingToolboxItem GetToolboxItem(string itemId)
		{
			DslDesign::ModelingToolboxItem item = null;

			if (!this.toolboxItemCache.TryGetValue(itemId, out item))
			{
				DslModeling::Store store = this.ToolboxStore;
				
				// Open transaction so we can create model elements corresponding to toolbox items.
				using (DslModeling::Transaction t = store.TransactionManager.BeginTransaction("CreateToolboxItems"))
				{
					// Retrieve the specified ToolboxItem from the DSL
					this.toolboxItemCache[itemId] = item = this.GetToolboxItem(itemId, store);
				}
			}

			return item;
		}
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		public virtual object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			DslDesign::ModelingToolboxItem item = null;

			global::System.Resources.ResourceManager resourceManager = global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel.SingletonResourceManager;
			global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;

			System.Windows.Forms.IDataObject tbxDataObj;

			//get the toolbox item
			item = GetToolboxItem(itemId);

			if (item != null)
			{
				ToolboxItemContainer container = new ToolboxItemContainer(item);
				tbxDataObj = container.ToolboxData;

				if (tbxDataObj.GetDataPresent(format.Name))
				{
					return tbxDataObj.GetData(format.Name);
				}
				else 
				{
					string invalidFormatString = resourceManager.GetString("UnsupportedToolboxFormat", resourceCulture);
					throw new InvalidOperationException(string.Format(resourceCulture, invalidFormatString, format.Name));
				}
			}

			string errorFormatString = resourceManager.GetString("UnresolvedToolboxItem", resourceCulture);
			throw new InvalidOperationException(string.Format(resourceCulture, errorFormatString, itemId));
		}		
	}
}