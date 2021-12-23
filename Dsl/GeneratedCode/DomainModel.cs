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
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;
namespace UPM_IPS.RGRLLCAMSProyectoMDD
{
	/// <summary>
	/// DomainModel RGRLLCAMSProyectoMDDDomainModel
	/// Description for UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDD
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel.DisplayName", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel.Description", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("8aa86ac7-dec6-4c7b-ada0-1f00761f32ee")]
	public partial class RGRLLCAMSProyectoMDDDomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// RGRLLCAMSProyectoMDDDomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0x8aa86ac7, 0xdec6, 0x4c7b, 0xad, 0xa0, 0x1f, 0x00, 0x76, 0x1f, 0x32, 0xee);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public RGRLLCAMSProyectoMDDDomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(Tapiz),
				typeof(Window),
				typeof(MainWindow),
				typeof(SecondaryWindow),
				typeof(Menu),
				typeof(Button),
				typeof(Item),
				typeof(End),
				typeof(TapizHasWindow),
				typeof(SecondaryWindowReferencesTargetSecondaryWindow),
				typeof(WindowHasMenu),
				typeof(WindowHasButton),
				typeof(MenuHasItem),
				typeof(TapizHasEnd),
				typeof(EndReferencesButton),
				typeof(EndReferencesItem),
				typeof(MainWindowReferencesSecondaryWindow),
				typeof(RGRLLCAMSProyectoMDDDiagram),
				typeof(ConnectorEndItem),
				typeof(ConnectorEndButton),
				typeof(ConnectorMainSecondary),
				typeof(ConnectorSecondarySecondary),
				typeof(MetaforaWindow),
				typeof(MetaforaMainWindow),
				typeof(MetaforaSecondaryWindow),
				typeof(MetaforaMenu),
				typeof(MetaforaButton),
				typeof(MetaforaItem),
				typeof(MetaforaEnd),
				typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.FixUpDiagram),
				typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorRolePlayerChanged),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(Tapiz), "Solucion", Tapiz.SolucionDomainPropertyId, typeof(Tapiz.SolucionPropertyHandler)),
				new DomainMemberInfo(typeof(Window), "Name", Window.NameDomainPropertyId, typeof(Window.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Window), "SizeX", Window.SizeXDomainPropertyId, typeof(Window.SizeXPropertyHandler)),
				new DomainMemberInfo(typeof(Window), "SizeY", Window.SizeYDomainPropertyId, typeof(Window.SizeYPropertyHandler)),
				new DomainMemberInfo(typeof(Menu), "id", Menu.idDomainPropertyId, typeof(Menu.idPropertyHandler)),
				new DomainMemberInfo(typeof(Menu), "Title", Menu.TitleDomainPropertyId, typeof(Menu.TitlePropertyHandler)),
				new DomainMemberInfo(typeof(Menu), "Name", Menu.NameDomainPropertyId, typeof(Menu.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Button), "id", Button.idDomainPropertyId, typeof(Button.idPropertyHandler)),
				new DomainMemberInfo(typeof(Button), "Title", Button.TitleDomainPropertyId, typeof(Button.TitlePropertyHandler)),
				new DomainMemberInfo(typeof(Item), "Title", Item.TitleDomainPropertyId, typeof(Item.TitlePropertyHandler)),
				new DomainMemberInfo(typeof(Item), "Name", Item.NameDomainPropertyId, typeof(Item.NamePropertyHandler)),
				new DomainMemberInfo(typeof(End), "id", End.idDomainPropertyId, typeof(End.idPropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(TapizHasWindow), "Tapiz", TapizHasWindow.TapizDomainRoleId),
				new DomainRolePlayerInfo(typeof(TapizHasWindow), "Window", TapizHasWindow.WindowDomainRoleId),
				new DomainRolePlayerInfo(typeof(SecondaryWindowReferencesTargetSecondaryWindow), "SourceSecondaryWindow", SecondaryWindowReferencesTargetSecondaryWindow.SourceSecondaryWindowDomainRoleId),
				new DomainRolePlayerInfo(typeof(SecondaryWindowReferencesTargetSecondaryWindow), "TargetSecondaryWindow", SecondaryWindowReferencesTargetSecondaryWindow.TargetSecondaryWindowDomainRoleId),
				new DomainRolePlayerInfo(typeof(WindowHasMenu), "Window", WindowHasMenu.WindowDomainRoleId),
				new DomainRolePlayerInfo(typeof(WindowHasMenu), "Menu", WindowHasMenu.MenuDomainRoleId),
				new DomainRolePlayerInfo(typeof(WindowHasButton), "Window", WindowHasButton.WindowDomainRoleId),
				new DomainRolePlayerInfo(typeof(WindowHasButton), "Button", WindowHasButton.ButtonDomainRoleId),
				new DomainRolePlayerInfo(typeof(MenuHasItem), "Menu", MenuHasItem.MenuDomainRoleId),
				new DomainRolePlayerInfo(typeof(MenuHasItem), "Item", MenuHasItem.ItemDomainRoleId),
				new DomainRolePlayerInfo(typeof(TapizHasEnd), "Tapiz", TapizHasEnd.TapizDomainRoleId),
				new DomainRolePlayerInfo(typeof(TapizHasEnd), "End", TapizHasEnd.EndDomainRoleId),
				new DomainRolePlayerInfo(typeof(EndReferencesButton), "End", EndReferencesButton.EndDomainRoleId),
				new DomainRolePlayerInfo(typeof(EndReferencesButton), "Button", EndReferencesButton.ButtonDomainRoleId),
				new DomainRolePlayerInfo(typeof(EndReferencesItem), "End", EndReferencesItem.EndDomainRoleId),
				new DomainRolePlayerInfo(typeof(EndReferencesItem), "Item", EndReferencesItem.ItemDomainRoleId),
				new DomainRolePlayerInfo(typeof(MainWindowReferencesSecondaryWindow), "MainWindow", MainWindowReferencesSecondaryWindow.MainWindowDomainRoleId),
				new DomainRolePlayerInfo(typeof(MainWindowReferencesSecondaryWindow), "SecondaryWindow", MainWindowReferencesSecondaryWindow.SecondaryWindowDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(20);
				createElementMap.Add(typeof(Tapiz), 0);
				createElementMap.Add(typeof(Window), 1);
				createElementMap.Add(typeof(MainWindow), 2);
				createElementMap.Add(typeof(SecondaryWindow), 3);
				createElementMap.Add(typeof(Menu), 4);
				createElementMap.Add(typeof(Button), 5);
				createElementMap.Add(typeof(Item), 6);
				createElementMap.Add(typeof(End), 7);
				createElementMap.Add(typeof(RGRLLCAMSProyectoMDDDiagram), 8);
				createElementMap.Add(typeof(ConnectorEndItem), 9);
				createElementMap.Add(typeof(ConnectorEndButton), 10);
				createElementMap.Add(typeof(ConnectorMainSecondary), 11);
				createElementMap.Add(typeof(ConnectorSecondarySecondary), 12);
				createElementMap.Add(typeof(MetaforaWindow), 13);
				createElementMap.Add(typeof(MetaforaMainWindow), 14);
				createElementMap.Add(typeof(MetaforaSecondaryWindow), 15);
				createElementMap.Add(typeof(MetaforaMenu), 16);
				createElementMap.Add(typeof(MetaforaButton), 17);
				createElementMap.Add(typeof(MetaforaItem), 18);
				createElementMap.Add(typeof(MetaforaEnd), 19);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new Tapiz(partition, propertyAssignments);
				case 1: return new Window(partition, propertyAssignments);
				case 2: return new MainWindow(partition, propertyAssignments);
				case 3: return new SecondaryWindow(partition, propertyAssignments);
				case 4: return new Menu(partition, propertyAssignments);
				case 5: return new Button(partition, propertyAssignments);
				case 6: return new Item(partition, propertyAssignments);
				case 7: return new End(partition, propertyAssignments);
				case 8: return new RGRLLCAMSProyectoMDDDiagram(partition, propertyAssignments);
				case 9: return new ConnectorEndItem(partition, propertyAssignments);
				case 10: return new ConnectorEndButton(partition, propertyAssignments);
				case 11: return new ConnectorMainSecondary(partition, propertyAssignments);
				case 12: return new ConnectorSecondarySecondary(partition, propertyAssignments);
				case 13: return new MetaforaWindow(partition, propertyAssignments);
				case 14: return new MetaforaMainWindow(partition, propertyAssignments);
				case 15: return new MetaforaSecondaryWindow(partition, propertyAssignments);
				case 16: return new MetaforaMenu(partition, propertyAssignments);
				case 17: return new MetaforaButton(partition, propertyAssignments);
				case 18: return new MetaforaItem(partition, propertyAssignments);
				case 19: return new MetaforaEnd(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(9);
				createElementLinkMap.Add(typeof(TapizHasWindow), 0);
				createElementLinkMap.Add(typeof(SecondaryWindowReferencesTargetSecondaryWindow), 1);
				createElementLinkMap.Add(typeof(WindowHasMenu), 2);
				createElementLinkMap.Add(typeof(WindowHasButton), 3);
				createElementLinkMap.Add(typeof(MenuHasItem), 4);
				createElementLinkMap.Add(typeof(TapizHasEnd), 5);
				createElementLinkMap.Add(typeof(EndReferencesButton), 6);
				createElementLinkMap.Add(typeof(EndReferencesItem), 7);
				createElementLinkMap.Add(typeof(MainWindowReferencesSecondaryWindow), 8);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new TapizHasWindow(partition, roleAssignments, propertyAssignments);
				case 1: return new SecondaryWindowReferencesTargetSecondaryWindow(partition, roleAssignments, propertyAssignments);
				case 2: return new WindowHasMenu(partition, roleAssignments, propertyAssignments);
				case 3: return new WindowHasButton(partition, roleAssignments, propertyAssignments);
				case 4: return new MenuHasItem(partition, roleAssignments, propertyAssignments);
				case 5: return new TapizHasEnd(partition, roleAssignments, propertyAssignments);
				case 6: return new EndReferencesButton(partition, roleAssignments, propertyAssignments);
				case 7: return new EndReferencesItem(partition, roleAssignments, propertyAssignments);
				case 8: return new MainWindowReferencesSecondaryWindow(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return RGRLLCAMSProyectoMDDDomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (RGRLLCAMSProyectoMDDDomainModel.resourceManager == null)
				{
					RGRLLCAMSProyectoMDDDomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(RGRLLCAMSProyectoMDDDomainModel).Assembly);
				}
				return RGRLLCAMSProyectoMDDDomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return RGRLLCAMSProyectoMDDDomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return RGRLLCAMSProyectoMDDDomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (RGRLLCAMSProyectoMDDDomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new RGRLLCAMSProyectoMDDCopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					RGRLLCAMSProyectoMDDDomainModel.copyClosure = copyFilter;
				}
				return RGRLLCAMSProyectoMDDDomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (RGRLLCAMSProyectoMDDDomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new RGRLLCAMSProyectoMDDDeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					RGRLLCAMSProyectoMDDDomainModel.removeClosure = removeFilter;
				}
				return RGRLLCAMSProyectoMDDDomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorRolePlayerChanged));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorRolePlayerChanged));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class RGRLLCAMSProyectoMDDDeleteClosure : RGRLLCAMSProyectoMDDDeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public RGRLLCAMSProyectoMDDDeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class RGRLLCAMSProyectoMDDDeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public RGRLLCAMSProyectoMDDDeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::UPM_IPS.RGRLLCAMSProyectoMDD.TapizHasWindow.WindowDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.RGRLLCAMSProyectoMDD.WindowHasMenu.MenuDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.RGRLLCAMSProyectoMDD.WindowHasButton.ButtonDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.RGRLLCAMSProyectoMDD.MenuHasItem.ItemDomainRoleId, true);
			DomainRoles.Add(global::UPM_IPS.RGRLLCAMSProyectoMDD.TapizHasEnd.EndDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class RGRLLCAMSProyectoMDDCopyClosure : RGRLLCAMSProyectoMDDCopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public RGRLLCAMSProyectoMDDCopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class RGRLLCAMSProyectoMDDCopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public RGRLLCAMSProyectoMDDCopyClosureBase():base()
		{
		}
	}
	#endregion
		
}
namespace UPM_IPS.RGRLLCAMSProyectoMDD
{
	/// <summary>
	/// DomainEnumeration: DomainEnumeration1
	/// Description for UPM_IPS.RGRLLCAMSProyectoMDD.DomainEnumeration1
	/// </summary>
	[global::System.CLSCompliant(true)]
	public enum DomainEnumeration1
	{
	}
}

