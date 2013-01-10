<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="3419a24a-ee35-4b03-8f92-f8c1a9615ef1" Description="Description for Themis.Themis" Name="Themis" DisplayName="Themis" Namespace="Themis" ProductName="Themis" CompanyName="Sławomir Aleksiuk" PackageGuid="1d69e8bc-61e7-44d0-9b8d-289c8b4afdfc" PackageNamespace="Themis" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="72207c91-5539-4593-a590-8b7953a6983e" Description="The root in which all other elements are embedded. Appears as a diagram." Name="MappingModel" DisplayName="Mapping Model" Namespace="Themis">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
          <Index>
            <DomainClassMoniker Name="ObjectElement" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>MappingModelHasObjectElements.ObjectElements</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="c94bc7c1-a602-415e-8fe1-43226d87451c" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="ObjectElement" DisplayName="Object Element" Namespace="Themis">
      <Properties>
        <DomainProperty Id="e57021e0-1110-47f5-bb6b-0304eaccce25" Description="Description for Themis.ObjectElement.Name" Name="Name" DisplayName="Name" DefaultValue="" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="b77b75b7-51c0-44ea-9079-41b7dac79efb" Description="MappingModel embeds ObjectElement" Name="MappingModelHasObjectElements" DisplayName="Mapping Model Has ObjectElements" Namespace="Themis" IsEmbedding="true">
      <Source>
        <DomainRole Id="9d596b74-0e65-4717-83d2-5530e824e9cf" Description="" Name="MappingModel" DisplayName="Mapping Model" PropertyName="ObjectElements" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Object Elements">
          <RolePlayer>
            <DomainClassMoniker Name="MappingModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="21434ba3-795b-4558-a73f-e6ac1e223ddc" Description="" Name="Element" DisplayName="Element" PropertyName="MappingModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Mapping Model">
          <RolePlayer>
            <DomainClassMoniker Name="ObjectElement" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
  </Types>
  <Shapes>
    <GeometryShape Id="5fd161dc-28e2-4201-be60-8b101247d1fb" Description="Shape used to represent objects on a Diagram." Name="Object" DisplayName="Object" Namespace="Themis" FixedTooltipText="Object" FillColor="242, 239, 229" OutlineColor="113, 111, 110" InitialWidth="2" InitialHeight="0.75" OutlineThickness="0.01" Geometry="Rectangle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
  </Shapes>
  <XmlSerializationBehavior Name="ThemisSerializationBehavior" Namespace="Themis">
    <ClassData>
      <XmlClassData TypeName="MappingModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="mappingModelMoniker" ElementName="mappingModel" MonikerTypeName="MappingModelMoniker">
        <DomainClassMoniker Name="MappingModel" />
        <ElementData>
          <XmlRelationshipData RoleElementName="objectElements">
            <DomainRelationshipMoniker Name="MappingModelHasObjectElements" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ObjectElement" MonikerAttributeName="name" SerializeId="true" MonikerElementName="objectElementMoniker" ElementName="objectElement" MonikerTypeName="ObjectElementMoniker">
        <DomainClassMoniker Name="ObjectElement" />
        <ElementData>
          <XmlPropertyData XmlName="name" IsMonikerKey="true">
            <DomainPropertyMoniker Name="ObjectElement/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="MappingModelHasObjectElements" MonikerAttributeName="" SerializeId="true" MonikerElementName="mappingModelHasObjectElementsMoniker" ElementName="mappingModelHasObjectElements" MonikerTypeName="MappingModelHasObjectElementsMoniker">
        <DomainRelationshipMoniker Name="MappingModelHasObjectElements" />
      </XmlClassData>
      <XmlClassData TypeName="Object" MonikerAttributeName="" SerializeId="true" MonikerElementName="objectMoniker" ElementName="object" MonikerTypeName="ObjectMoniker">
        <GeometryShapeMoniker Name="Object" />
      </XmlClassData>
      <XmlClassData TypeName="Diagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="diagramMoniker" ElementName="diagram" MonikerTypeName="DiagramMoniker">
        <DiagramMoniker Name="Diagram" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="ThemisExplorer" />
  <Diagram Id="d0d95359-76b7-4abf-a63f-53561f172dcb" Description="" Name="Diagram" DisplayName="Object Mapping Diagram" Namespace="Themis">
    <Class>
      <DomainClassMoniker Name="MappingModel" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="ObjectElement" />
        <ParentElementPath>
          <DomainPath>MappingModelHasObjectElements.MappingModel/!MappingModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="Object/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="ObjectElement/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="Object" />
      </ShapeMap>
    </ShapeMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="tmpd" EditorGuid="303d514b-71d6-4416-834c-801128e7880b">
    <RootClass>
      <DomainClassMoniker Name="MappingModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="ThemisSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="Themis">
      <ElementTool Name="Object" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="Object" Tooltip="Create an ObjectElement" HelpKeyword="CreateExampleClassF1Keyword">
        <DomainClassMoniker Name="ObjectElement" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="Diagram" />
  </Designer>
  <Explorer ExplorerGuid="3a1e3533-678b-4a06-965a-a35a748ac5fd" Title="Themis Explorer">
    <ExplorerBehaviorMoniker Name="Themis/ThemisExplorer" />
  </Explorer>
</Dsl>