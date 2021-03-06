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
namespace Themis
{
	/// <summary>
	/// DomainRelationship MappingModelHasObjectElements
	/// MappingModel embeds ObjectElement
	/// </summary>
	[DslDesign::DisplayNameResource("Themis.MappingModelHasObjectElements.DisplayName", typeof(global::Themis.ThemisDomainModel), "Themis.Dsl.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Themis.MappingModelHasObjectElements.Description", typeof(global::Themis.ThemisDomainModel), "Themis.Dsl.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Themis.ThemisDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("b77b75b7-51c0-44ea-9079-41b7dac79efb")]
	public partial class MappingModelHasObjectElements : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// MappingModelHasObjectElements domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xb77b75b7, 0x51c0, 0x44ea, 0x90, 0x79, 0x41, 0xb7, 0xda, 0xc7, 0x9e, 0xfb);
	
				
		/// <summary>
		/// Constructor
		/// Creates a MappingModelHasObjectElements link in the same Partition as the given MappingModel
		/// </summary>
		/// <param name="source">MappingModel to use as the source of the relationship.</param>
		/// <param name="target">ObjectElement to use as the target of the relationship.</param>
		public MappingModelHasObjectElements(MappingModel source, ObjectElement target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(MappingModelHasObjectElements.MappingModelDomainRoleId, source), new DslModeling::RoleAssignment(MappingModelHasObjectElements.ElementDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public MappingModelHasObjectElements(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public MappingModelHasObjectElements(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public MappingModelHasObjectElements(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public MappingModelHasObjectElements(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region MappingModel domain role code
		
		/// <summary>
		/// MappingModel domain role Id.
		/// </summary>
		public static readonly global::System.Guid MappingModelDomainRoleId = new global::System.Guid(0x9d596b74, 0x0e65, 0x4717, 0x83, 0xd2, 0x55, 0x30, 0xe8, 0x24, 0xe9, 0xcf);
		
		/// <summary>
		/// DomainRole MappingModel
		/// </summary>
		[DslDesign::DisplayNameResource("Themis.MappingModelHasObjectElements/MappingModel.DisplayName", typeof(global::Themis.ThemisDomainModel), "Themis.Dsl.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Themis.MappingModelHasObjectElements/MappingModel.Description", typeof(global::Themis.ThemisDomainModel), "Themis.Dsl.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "ObjectElements", PropertyDisplayNameKey="Themis.MappingModelHasObjectElements/MappingModel.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("9d596b74-0e65-4717-83d2-5530e824e9cf")]
		public virtual MappingModel MappingModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (MappingModel)DslModeling::DomainRoleInfo.GetRolePlayer(this, MappingModelDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, MappingModelDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access MappingModel of a ObjectElement
		/// <summary>
		/// Gets MappingModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static MappingModel GetMappingModel(ObjectElement element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, ElementDomainRoleId) as MappingModel;
		}
		
		/// <summary>
		/// Sets MappingModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetMappingModel(ObjectElement element, MappingModel newMappingModel)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, ElementDomainRoleId, newMappingModel);
		}
		#endregion
		#region Element domain role code
		
		/// <summary>
		/// Element domain role Id.
		/// </summary>
		public static readonly global::System.Guid ElementDomainRoleId = new global::System.Guid(0x21434ba3, 0x795b, 0x4558, 0xa7, 0x3f, 0xe6, 0xac, 0x1e, 0x22, 0x3d, 0xdc);
		
		/// <summary>
		/// DomainRole Element
		/// </summary>
		[DslDesign::DisplayNameResource("Themis.MappingModelHasObjectElements/Element.DisplayName", typeof(global::Themis.ThemisDomainModel), "Themis.Dsl.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Themis.MappingModelHasObjectElements/Element.Description", typeof(global::Themis.ThemisDomainModel), "Themis.Dsl.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "MappingModel", PropertyDisplayNameKey="Themis.MappingModelHasObjectElements/Element.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("21434ba3-795b-4558-a73f-e6ac1e223ddc")]
		public virtual ObjectElement Element
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ObjectElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, ElementDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ElementDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access ObjectElements of a MappingModel
		/// <summary>
		/// Gets a list of ObjectElements.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ObjectElement> GetObjectElements(MappingModel element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ObjectElement>, ObjectElement>(element, MappingModelDomainRoleId);
		}
		#endregion
		#region MappingModel link accessor
		/// <summary>
		/// Get the list of MappingModelHasObjectElements links to a MappingModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Themis.MappingModelHasObjectElements> GetLinksToObjectElements ( global::Themis.MappingModel mappingModelInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Themis.MappingModelHasObjectElements>(mappingModelInstance, global::Themis.MappingModelHasObjectElements.MappingModelDomainRoleId);
		}
		#endregion
		#region Element link accessor
		/// <summary>
		/// Get the MappingModelHasObjectElements link to a ObjectElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Themis.MappingModelHasObjectElements GetLinkToMappingModel (global::Themis.ObjectElement elementInstance)
		{
			global::System.Collections.Generic.IList<global::Themis.MappingModelHasObjectElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Themis.MappingModelHasObjectElements>(elementInstance, global::Themis.MappingModelHasObjectElements.ElementDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Element not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region MappingModelHasObjectElements instance accessors
		
		/// <summary>
		/// Get any MappingModelHasObjectElements links between a given MappingModel and a ObjectElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Themis.MappingModelHasObjectElements> GetLinks( global::Themis.MappingModel source, global::Themis.ObjectElement target )
		{
			global::System.Collections.Generic.List<global::Themis.MappingModelHasObjectElements> outLinks = new global::System.Collections.Generic.List<global::Themis.MappingModelHasObjectElements>();
			global::System.Collections.Generic.IList<global::Themis.MappingModelHasObjectElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Themis.MappingModelHasObjectElements>(source, global::Themis.MappingModelHasObjectElements.MappingModelDomainRoleId);
			foreach ( global::Themis.MappingModelHasObjectElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one MappingModelHasObjectElements link between a given MappingModeland a ObjectElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Themis.MappingModelHasObjectElements GetLink( global::Themis.MappingModel source, global::Themis.ObjectElement target )
		{
			global::System.Collections.Generic.IList<global::Themis.MappingModelHasObjectElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Themis.MappingModelHasObjectElements>(source, global::Themis.MappingModelHasObjectElements.MappingModelDomainRoleId);
			foreach ( global::Themis.MappingModelHasObjectElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
