//------------------------------------------------------------------------------
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
	/// DomainClass ConnectorEndItem
	/// Description for UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorEndItem
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorEndItem.DisplayName", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorEndItem.Description", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("fcd40498-ef98-4123-8419-e3dfa941ab69")]
	public partial class ConnectorEndItem : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ConnectorEndItem.
		/// </summary>
		public static DslDiagrams::Decorator FindConnectorEndItemDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ConnectorEndItem domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xfcd40498, 0xef98, 0x4123, 0x84, 0x19, 0xe3, 0xdf, 0xa9, 0x41, 0xab, 0x69);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConnectorEndItem(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConnectorEndItem(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace UPM_IPS.RGRLLCAMSProyectoMDD
{
	/// <summary>
	/// DomainClass ConnectorEndButton
	/// Description for UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorEndButton
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorEndButton.DisplayName", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorEndButton.Description", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("2ed7b8cd-eb3c-461c-b959-61ab693a07cd")]
	public partial class ConnectorEndButton : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ConnectorEndButton.
		/// </summary>
		public static DslDiagrams::Decorator FindConnectorEndButtonDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ConnectorEndButton domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x2ed7b8cd, 0xeb3c, 0x461c, 0xb9, 0x59, 0x61, 0xab, 0x69, 0x3a, 0x07, 0xcd);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConnectorEndButton(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConnectorEndButton(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace UPM_IPS.RGRLLCAMSProyectoMDD
{
	/// <summary>
	/// DomainClass ConnectorMainSecondary
	/// Description for UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorMainSecondary
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorMainSecondary.DisplayName", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorMainSecondary.Description", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("ca042f92-a551-4ff0-8186-5aa3af9807c6")]
	public partial class ConnectorMainSecondary : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ConnectorMainSecondary.
		/// </summary>
		public static DslDiagrams::Decorator FindConnectorMainSecondaryDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ConnectorMainSecondary domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xca042f92, 0xa551, 0x4ff0, 0x81, 0x86, 0x5a, 0xa3, 0xaf, 0x98, 0x07, 0xc6);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConnectorMainSecondary(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConnectorMainSecondary(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace UPM_IPS.RGRLLCAMSProyectoMDD
{
	/// <summary>
	/// DomainClass ConnectorSecondarySecondary
	/// Description for UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorSecondarySecondary
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorSecondarySecondary.DisplayName", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorSecondarySecondary.Description", typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel), "UPM_IPS.RGRLLCAMSProyectoMDD.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("2ab37ae9-a707-4af2-b95f-f08d472ed954")]
	public partial class ConnectorSecondarySecondary : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with ConnectorSecondarySecondary.
		/// </summary>
		public static DslDiagrams::Decorator FindConnectorSecondarySecondaryDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// ConnectorSecondarySecondary domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x2ab37ae9, 0xa707, 0x4af2, 0xb9, 0x5f, 0xf0, 0x8d, 0x47, 0x2e, 0xd9, 0x54);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConnectorSecondarySecondary(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConnectorSecondarySecondary(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
