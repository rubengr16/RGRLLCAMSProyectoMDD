<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="8aa86ac7-dec6-4c7b-ada0-1f00761f32ee" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDD" Name="RGRLLCAMSProyectoMDD" DisplayName="RGRLLCAMSProyectoMDD" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" ProductName="RGRLLCAMSProyectoMDD" CompanyName="UPM_IPS" PackageGuid="44324b7a-2a25-43bd-ad2e-364d605787ae" PackageNamespace="UPM_IPS.RGRLLCAMSProyectoMDD" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="00df83bb-a5b2-413a-a6d9-7693254598bb" Description="The root in which all other elements are embedded. Appears as a diagram." Name="Tapiz" DisplayName="Tapiz" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Properties>
        <DomainProperty Id="ccc53268-0bbb-4047-ad00-00380ceeaee6" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Tapiz.Solucion" Name="Solucion" DisplayName="Solucion">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Window" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>TapizHasWindow.Window</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="End" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>TapizHasEnd.End</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="06487186-6334-471b-b868-126ecfd51db3" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Window" Name="Window" DisplayName="Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Properties>
        <DomainProperty Id="08f304af-aa13-4b55-b87b-18863976d90f" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Window.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="2838e048-f192-43c0-b103-4de8e6721dcb" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Window.Size X" Name="SizeX" DisplayName="Size X">
          <Type>
            <ExternalTypeMoniker Name="/System/Int16" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="73b44115-a579-43a3-b9cc-2f279ab027a3" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Window.Size Y" Name="SizeY" DisplayName="Size Y">
          <Type>
            <ExternalTypeMoniker Name="/System/Int16" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Menu" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>WindowHasMenu.Menu</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Button" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>WindowHasButton.Button</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="493f9492-d5e2-4729-ba51-f8dedbb7e648" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MainWindow" Name="MainWindow" DisplayName="Main Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <BaseClass>
        <DomainClassMoniker Name="Window" />
      </BaseClass>
    </DomainClass>
    <DomainClass Id="09db71ac-e717-45f8-9a1b-5b1865b3da64" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.SecondaryWindow" Name="SecondaryWindow" DisplayName="Secondary Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <BaseClass>
        <DomainClassMoniker Name="Window" />
      </BaseClass>
    </DomainClass>
    <DomainClass Id="c2a7d042-efae-4f26-a454-4f73bc2eec5b" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Menu" Name="Menu" DisplayName="Menu" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Properties>
        <DomainProperty Id="3070849f-b578-440a-b740-66efd177fd99" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Menu.Id" Name="id" DisplayName="Id">
          <Type>
            <ExternalTypeMoniker Name="/System/Int16" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="a0cf9354-9791-4b43-a9e0-642e5217e476" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Menu.Title" Name="Title" DisplayName="Title">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="f7580e88-4a15-4d28-8c6a-57e81fe8152c" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Menu.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Item" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>MenuHasItem.Item</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="5ef2c0bd-3d61-4943-830e-b3d667747472" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Button" Name="Button" DisplayName="Button" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Properties>
        <DomainProperty Id="43bcbe3f-ea1b-48fc-918b-bb7c2db0503f" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Button.Id" Name="id" DisplayName="Id">
          <Type>
            <ExternalTypeMoniker Name="/System/Int16" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="282b8856-98ea-4d4c-a725-1f778e4cd35a" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Button.Title" Name="Title" DisplayName="Title">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="f088807a-4f48-4879-bed0-ae3bb2503a76" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Item" Name="Item" DisplayName="Item" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Properties>
        <DomainProperty Id="98f6f154-4359-488c-a19f-a51bea1283f8" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Item.Title" Name="Title" DisplayName="Title">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="1999bbbb-51b7-452c-9a57-d590e320382d" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.Item.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="fc724694-3a81-43a0-8b95-c78accbcb637" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.End" Name="End" DisplayName="End" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Properties>
        <DomainProperty Id="791757b1-a869-4d05-be51-d61549da57eb" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.End.Id" Name="id" DisplayName="Id">
          <Type>
            <ExternalTypeMoniker Name="/System/Int16" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="be424390-c05a-4e09-a2aa-b37c42c2996a" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.TapizHasWindow" Name="TapizHasWindow" DisplayName="Tapiz Has Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" IsEmbedding="true">
      <Source>
        <DomainRole Id="e40c86f3-e2de-4c4b-9745-6b85dba47b06" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.TapizHasWindow.Tapiz" Name="Tapiz" DisplayName="Tapiz" PropertyName="Window" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Window">
          <RolePlayer>
            <DomainClassMoniker Name="Tapiz" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="8438843d-f0e9-42ab-b933-afb990d3c5bb" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.TapizHasWindow.Window" Name="Window" DisplayName="Window" PropertyName="Tapiz" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Tapiz">
          <RolePlayer>
            <DomainClassMoniker Name="Window" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="6012798a-400b-47fd-b3b7-19002e8c3be8" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.SecondaryWindowReferencesTargetSecondaryWindow" Name="SecondaryWindowReferencesTargetSecondaryWindow" DisplayName="Secondary Window References Target Secondary Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Source>
        <DomainRole Id="6ab63a09-172b-4ddc-b7ce-3783291b20eb" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.SecondaryWindowReferencesTargetSecondaryWindow.SourceSecondaryWindow" Name="SourceSecondaryWindow" DisplayName="Source Secondary Window" PropertyName="TargetSecondaryWindow" PropertyDisplayName="Target Secondary Window">
          <RolePlayer>
            <DomainClassMoniker Name="SecondaryWindow" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="d663c383-9627-4988-96cc-31b8184ecf12" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.SecondaryWindowReferencesTargetSecondaryWindow.TargetSecondaryWindow" Name="TargetSecondaryWindow" DisplayName="Target Secondary Window" PropertyName="SourceSecondaryWindow" PropertyDisplayName="Source Secondary Window">
          <RolePlayer>
            <DomainClassMoniker Name="SecondaryWindow" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="3c187869-ba1a-4d83-b4a0-c3c4b30908a4" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.WindowHasMenu" Name="WindowHasMenu" DisplayName="Window Has Menu" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" IsEmbedding="true">
      <Source>
        <DomainRole Id="5003253b-6fa9-4f9d-b9b7-62bf9f268b21" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.WindowHasMenu.Window" Name="Window" DisplayName="Window" PropertyName="Menu" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Menu">
          <RolePlayer>
            <DomainClassMoniker Name="Window" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="074963f3-6ba3-411c-ad24-d7dddce54457" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.WindowHasMenu.Menu" Name="Menu" DisplayName="Menu" PropertyName="Window" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Window">
          <RolePlayer>
            <DomainClassMoniker Name="Menu" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="d4a21c5d-3b46-4447-a51c-d1c0851342ee" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.WindowHasButton" Name="WindowHasButton" DisplayName="Window Has Button" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" IsEmbedding="true">
      <Source>
        <DomainRole Id="42e7305d-e729-4ebb-a59a-d5003efc41ef" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.WindowHasButton.Window" Name="Window" DisplayName="Window" PropertyName="Button" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Button">
          <RolePlayer>
            <DomainClassMoniker Name="Window" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="419a1442-4a52-4435-8dcb-83b6337677e3" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.WindowHasButton.Button" Name="Button" DisplayName="Button" PropertyName="Window" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Window">
          <RolePlayer>
            <DomainClassMoniker Name="Button" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="d0322e66-48a1-467f-a4f9-40151627f767" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MenuHasItem" Name="MenuHasItem" DisplayName="Menu Has Item" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" IsEmbedding="true">
      <Source>
        <DomainRole Id="4333decc-d0b2-4dd2-89bd-be15ef0c7e5b" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MenuHasItem.Menu" Name="Menu" DisplayName="Menu" PropertyName="Item" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Item">
          <RolePlayer>
            <DomainClassMoniker Name="Menu" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="5299fbd8-1a97-432f-8da9-d5a02ee659d4" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MenuHasItem.Item" Name="Item" DisplayName="Item" PropertyName="Menu" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Menu">
          <RolePlayer>
            <DomainClassMoniker Name="Item" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="fa09e36e-917c-4b38-8318-6a1101647475" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.TapizHasEnd" Name="TapizHasEnd" DisplayName="Tapiz Has End" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" IsEmbedding="true">
      <Source>
        <DomainRole Id="2650324d-f3c2-4df1-afeb-71f1e551d6a5" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.TapizHasEnd.Tapiz" Name="Tapiz" DisplayName="Tapiz" PropertyName="End" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="End">
          <RolePlayer>
            <DomainClassMoniker Name="Tapiz" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="43a03c83-c8b3-4670-89ad-15b74eaa707f" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.TapizHasEnd.End" Name="End" DisplayName="End" PropertyName="Tapiz" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Tapiz">
          <RolePlayer>
            <DomainClassMoniker Name="End" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="bdf23d86-1890-42a2-8af5-ef8330b559f4" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.EndReferencesButton" Name="EndReferencesButton" DisplayName="End References Button" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Source>
        <DomainRole Id="f66a00e9-9493-443f-a915-781826c943ea" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.EndReferencesButton.End" Name="End" DisplayName="End" PropertyName="Button" PropertyDisplayName="Button">
          <RolePlayer>
            <DomainClassMoniker Name="End" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="1ebf65f2-9845-4d06-9797-0afb25a5959a" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.EndReferencesButton.Button" Name="Button" DisplayName="Button" PropertyName="End" PropertyDisplayName="End">
          <RolePlayer>
            <DomainClassMoniker Name="Button" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="b4eb92db-b44a-42d2-9dcf-8b293e43ae58" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.EndReferencesItem" Name="EndReferencesItem" DisplayName="End References Item" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Source>
        <DomainRole Id="4273bc8b-991d-4e49-a67f-d09b4dc5f89c" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.EndReferencesItem.End" Name="End" DisplayName="End" PropertyName="Item" PropertyDisplayName="Item">
          <RolePlayer>
            <DomainClassMoniker Name="End" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="a92327ba-8282-4649-93a5-f25651bbfb42" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.EndReferencesItem.Item" Name="Item" DisplayName="Item" PropertyName="End" PropertyDisplayName="End">
          <RolePlayer>
            <DomainClassMoniker Name="Item" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="792d7d47-28a0-44c0-880f-514846af8a9b" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MainWindowReferencesSecondaryWindow" Name="MainWindowReferencesSecondaryWindow" DisplayName="Main Window References Secondary Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
      <Source>
        <DomainRole Id="fe014544-a28d-4393-b93a-6e1b3bc36155" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MainWindowReferencesSecondaryWindow.MainWindow" Name="MainWindow" DisplayName="Main Window" PropertyName="SecondaryWindow" PropertyDisplayName="Secondary Window">
          <RolePlayer>
            <DomainClassMoniker Name="MainWindow" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="b11c492e-b3f4-45cc-bab2-51578a1f79ed" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MainWindowReferencesSecondaryWindow.SecondaryWindow" Name="SecondaryWindow" DisplayName="Secondary Window" PropertyName="MainWindow" Multiplicity="ZeroOne" PropertyDisplayName="Main Window">
          <RolePlayer>
            <DomainClassMoniker Name="SecondaryWindow" />
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
    <DomainEnumeration Name="DomainEnumeration1" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.DomainEnumeration1" />
  </Types>
  <Shapes>
    <GeometryShape Id="7165e692-301a-4cea-8c56-274d69e9e428" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MetaforaWindow" Name="MetaforaWindow" DisplayName="Metafora Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Metafora Window" InitialHeight="1" Geometry="Rectangle" />
    <GeometryShape Id="0629d681-35ab-4bfd-b880-6735b846b46c" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MetaforaMainWindow" Name="MetaforaMainWindow" DisplayName="Metafora Main Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Metafora Main Window" FillColor="LightCyan" InitialHeight="1" FillGradientMode="None" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="nombreDec" DisplayName="Nombre Dec" DefaultText="nombreDec" FontStyle="Bold" FontSize="50" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="889ea941-4607-47f7-9c77-a4c2d099e46d" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MetaforaSecondaryWindow" Name="MetaforaSecondaryWindow" DisplayName="Metafora Secondary Window" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Metafora Secondary Window" FillColor="LightSkyBlue" InitialHeight="1" FillGradientMode="None" Geometry="Rectangle" />
    <GeometryShape Id="66e544ef-406b-4906-82a9-4ade8aac1c2e" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MetaforaMenu" Name="MetaforaMenu" DisplayName="Metafora Menu" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Metafora Menu" FillColor="CadetBlue" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerMiddleLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="nombreMenu" DisplayName="Nombre Menu" DefaultText="" FontSize="25" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="6c9e28d6-2cf6-4deb-8847-16e304ce3fa6" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MetaforaButton" Name="MetaforaButton" DisplayName="Metafora Button" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Metafora Button" FillColor="SlateBlue" InitialHeight="1" FillGradientMode="None" Geometry="Rectangle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="nombreBoton" DisplayName="Nombre Boton" DefaultText="nombreBoton" FontSize="16" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="39c0001b-9274-4a6f-a41b-8421cac94a45" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MetaforaItem" Name="MetaforaItem" DisplayName="Metafora Item" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Metafora Item" FillColor="AliceBlue" InitialHeight="1" Geometry="RoundedRectangle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="nombreItem" DisplayName="Nombre Item" DefaultText="nombreItem" FontSize="18" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="a7d6e19a-8c57-41a1-957a-5fedf0569c63" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.MetaforaEnd" Name="MetaforaEnd" DisplayName="Metafora End" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Metafora End" FillColor="Red" InitialHeight="1" Geometry="Circle" />
  </Shapes>
  <Connectors>
    <Connector Id="fcd40498-ef98-4123-8419-e3dfa941ab69" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorEndItem" Name="ConnectorEndItem" DisplayName="Connector End Item" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Connector End Item" />
    <Connector Id="2ed7b8cd-eb3c-461c-b959-61ab693a07cd" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorEndButton" Name="ConnectorEndButton" DisplayName="Connector End Button" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Connector End Button" />
    <Connector Id="ca042f92-a551-4ff0-8186-5aa3af9807c6" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorMainSecondary" Name="ConnectorMainSecondary" DisplayName="Connector Main Secondary" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Connector Main Secondary" />
    <Connector Id="2ab37ae9-a707-4af2-b95f-f08d472ed954" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.ConnectorSecondarySecondary" Name="ConnectorSecondarySecondary" DisplayName="Connector Secondary Secondary" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FixedTooltipText="Connector Secondary Secondary" />
  </Connectors>
  <XmlSerializationBehavior Name="RGRLLCAMSProyectoMDDSerializationBehavior" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD">
    <ClassData>
      <XmlClassData TypeName="Tapiz" MonikerAttributeName="" SerializeId="true" MonikerElementName="tapizMoniker" ElementName="tapiz" MonikerTypeName="TapizMoniker">
        <DomainClassMoniker Name="Tapiz" />
        <ElementData>
          <XmlPropertyData XmlName="solucion">
            <DomainPropertyMoniker Name="Tapiz/Solucion" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="window">
            <DomainRelationshipMoniker Name="TapizHasWindow" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="end">
            <DomainRelationshipMoniker Name="TapizHasEnd" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="RGRLLCAMSProyectoMDDDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="rGRLLCAMSProyectoMDDDiagramMoniker" ElementName="rGRLLCAMSProyectoMDDDiagram" MonikerTypeName="RGRLLCAMSProyectoMDDDiagramMoniker">
        <DiagramMoniker Name="RGRLLCAMSProyectoMDDDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="Window" MonikerAttributeName="" SerializeId="true" MonikerElementName="windowMoniker" ElementName="window" MonikerTypeName="WindowMoniker">
        <DomainClassMoniker Name="Window" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Window/Name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="sizeX">
            <DomainPropertyMoniker Name="Window/SizeX" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="sizeY">
            <DomainPropertyMoniker Name="Window/SizeY" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="menu">
            <DomainRelationshipMoniker Name="WindowHasMenu" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="button">
            <DomainRelationshipMoniker Name="WindowHasButton" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="MainWindow" MonikerAttributeName="" SerializeId="true" MonikerElementName="mainWindowMoniker" ElementName="mainWindow" MonikerTypeName="MainWindowMoniker">
        <DomainClassMoniker Name="MainWindow" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="secondaryWindow">
            <DomainRelationshipMoniker Name="MainWindowReferencesSecondaryWindow" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="TapizHasWindow" MonikerAttributeName="" SerializeId="true" MonikerElementName="tapizHasWindowMoniker" ElementName="tapizHasWindow" MonikerTypeName="TapizHasWindowMoniker">
        <DomainRelationshipMoniker Name="TapizHasWindow" />
      </XmlClassData>
      <XmlClassData TypeName="SecondaryWindow" MonikerAttributeName="" SerializeId="true" MonikerElementName="secondaryWindowMoniker" ElementName="secondaryWindow" MonikerTypeName="SecondaryWindowMoniker">
        <DomainClassMoniker Name="SecondaryWindow" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="targetSecondaryWindow">
            <DomainRelationshipMoniker Name="SecondaryWindowReferencesTargetSecondaryWindow" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="SecondaryWindowReferencesTargetSecondaryWindow" MonikerAttributeName="" SerializeId="true" MonikerElementName="secondaryWindowReferencesTargetSecondaryWindowMoniker" ElementName="secondaryWindowReferencesTargetSecondaryWindow" MonikerTypeName="SecondaryWindowReferencesTargetSecondaryWindowMoniker">
        <DomainRelationshipMoniker Name="SecondaryWindowReferencesTargetSecondaryWindow" />
      </XmlClassData>
      <XmlClassData TypeName="MetaforaWindow" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaWindowMoniker" ElementName="metaforaWindow" MonikerTypeName="MetaforaWindowMoniker">
        <GeometryShapeMoniker Name="MetaforaWindow" />
      </XmlClassData>
      <XmlClassData TypeName="MetaforaMainWindow" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaMainWindowMoniker" ElementName="metaforaMainWindow" MonikerTypeName="MetaforaMainWindowMoniker">
        <GeometryShapeMoniker Name="MetaforaMainWindow" />
      </XmlClassData>
      <XmlClassData TypeName="MetaforaSecondaryWindow" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaSecondaryWindowMoniker" ElementName="metaforaSecondaryWindow" MonikerTypeName="MetaforaSecondaryWindowMoniker">
        <GeometryShapeMoniker Name="MetaforaSecondaryWindow" />
      </XmlClassData>
      <XmlClassData TypeName="Menu" MonikerAttributeName="" SerializeId="true" MonikerElementName="menuMoniker" ElementName="menu" MonikerTypeName="MenuMoniker">
        <DomainClassMoniker Name="Menu" />
        <ElementData>
          <XmlPropertyData XmlName="id">
            <DomainPropertyMoniker Name="Menu/id" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="title">
            <DomainPropertyMoniker Name="Menu/Title" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="item">
            <DomainRelationshipMoniker Name="MenuHasItem" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Menu/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="WindowHasMenu" MonikerAttributeName="" SerializeId="true" MonikerElementName="windowHasMenuMoniker" ElementName="windowHasMenu" MonikerTypeName="WindowHasMenuMoniker">
        <DomainRelationshipMoniker Name="WindowHasMenu" />
      </XmlClassData>
      <XmlClassData TypeName="MetaforaMenu" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaMenuMoniker" ElementName="metaforaMenu" MonikerTypeName="MetaforaMenuMoniker">
        <GeometryShapeMoniker Name="MetaforaMenu" />
      </XmlClassData>
      <XmlClassData TypeName="Button" MonikerAttributeName="" SerializeId="true" MonikerElementName="buttonMoniker" ElementName="button" MonikerTypeName="ButtonMoniker">
        <DomainClassMoniker Name="Button" />
        <ElementData>
          <XmlPropertyData XmlName="id">
            <DomainPropertyMoniker Name="Button/id" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="title">
            <DomainPropertyMoniker Name="Button/Title" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="WindowHasButton" MonikerAttributeName="" SerializeId="true" MonikerElementName="windowHasButtonMoniker" ElementName="windowHasButton" MonikerTypeName="WindowHasButtonMoniker">
        <DomainRelationshipMoniker Name="WindowHasButton" />
      </XmlClassData>
      <XmlClassData TypeName="MetaforaButton" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaButtonMoniker" ElementName="metaforaButton" MonikerTypeName="MetaforaButtonMoniker">
        <GeometryShapeMoniker Name="MetaforaButton" />
      </XmlClassData>
      <XmlClassData TypeName="Item" MonikerAttributeName="" SerializeId="true" MonikerElementName="itemMoniker" ElementName="item" MonikerTypeName="ItemMoniker">
        <DomainClassMoniker Name="Item" />
        <ElementData>
          <XmlPropertyData XmlName="title">
            <DomainPropertyMoniker Name="Item/Title" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Item/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="MetaforaItem" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaItemMoniker" ElementName="metaforaItem" MonikerTypeName="MetaforaItemMoniker">
        <GeometryShapeMoniker Name="MetaforaItem" />
      </XmlClassData>
      <XmlClassData TypeName="MenuHasItem" MonikerAttributeName="" SerializeId="true" MonikerElementName="menuHasItemMoniker" ElementName="menuHasItem" MonikerTypeName="MenuHasItemMoniker">
        <DomainRelationshipMoniker Name="MenuHasItem" />
      </XmlClassData>
      <XmlClassData TypeName="End" MonikerAttributeName="" SerializeId="true" MonikerElementName="endMoniker" ElementName="end" MonikerTypeName="EndMoniker">
        <DomainClassMoniker Name="End" />
        <ElementData>
          <XmlPropertyData XmlName="id">
            <DomainPropertyMoniker Name="End/id" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="button">
            <DomainRelationshipMoniker Name="EndReferencesButton" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="item">
            <DomainRelationshipMoniker Name="EndReferencesItem" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="TapizHasEnd" MonikerAttributeName="" SerializeId="true" MonikerElementName="tapizHasEndMoniker" ElementName="tapizHasEnd" MonikerTypeName="TapizHasEndMoniker">
        <DomainRelationshipMoniker Name="TapizHasEnd" />
      </XmlClassData>
      <XmlClassData TypeName="EndReferencesButton" MonikerAttributeName="" SerializeId="true" MonikerElementName="endReferencesButtonMoniker" ElementName="endReferencesButton" MonikerTypeName="EndReferencesButtonMoniker">
        <DomainRelationshipMoniker Name="EndReferencesButton" />
      </XmlClassData>
      <XmlClassData TypeName="EndReferencesItem" MonikerAttributeName="" SerializeId="true" MonikerElementName="endReferencesItemMoniker" ElementName="endReferencesItem" MonikerTypeName="EndReferencesItemMoniker">
        <DomainRelationshipMoniker Name="EndReferencesItem" />
      </XmlClassData>
      <XmlClassData TypeName="MetaforaEnd" MonikerAttributeName="" SerializeId="true" MonikerElementName="metaforaEndMoniker" ElementName="metaforaEnd" MonikerTypeName="MetaforaEndMoniker">
        <GeometryShapeMoniker Name="MetaforaEnd" />
      </XmlClassData>
      <XmlClassData TypeName="MainWindowReferencesSecondaryWindow" MonikerAttributeName="" SerializeId="true" MonikerElementName="mainWindowReferencesSecondaryWindowMoniker" ElementName="mainWindowReferencesSecondaryWindow" MonikerTypeName="MainWindowReferencesSecondaryWindowMoniker">
        <DomainRelationshipMoniker Name="MainWindowReferencesSecondaryWindow" />
      </XmlClassData>
      <XmlClassData TypeName="ConnectorEndItem" MonikerAttributeName="" SerializeId="true" MonikerElementName="connectorEndItemMoniker" ElementName="connectorEndItem" MonikerTypeName="ConnectorEndItemMoniker">
        <ConnectorMoniker Name="ConnectorEndItem" />
      </XmlClassData>
      <XmlClassData TypeName="ConnectorEndButton" MonikerAttributeName="" SerializeId="true" MonikerElementName="connectorEndButtonMoniker" ElementName="connectorEndButton" MonikerTypeName="ConnectorEndButtonMoniker">
        <ConnectorMoniker Name="ConnectorEndButton" />
      </XmlClassData>
      <XmlClassData TypeName="ConnectorMainSecondary" MonikerAttributeName="" SerializeId="true" MonikerElementName="connectorMainSecondaryMoniker" ElementName="connectorMainSecondary" MonikerTypeName="ConnectorMainSecondaryMoniker">
        <ConnectorMoniker Name="ConnectorMainSecondary" />
      </XmlClassData>
      <XmlClassData TypeName="ConnectorSecondarySecondary" MonikerAttributeName="" SerializeId="true" MonikerElementName="connectorSecondarySecondaryMoniker" ElementName="connectorSecondarySecondary" MonikerTypeName="ConnectorSecondarySecondaryMoniker">
        <ConnectorMoniker Name="ConnectorSecondarySecondary" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="RGRLLCAMSProyectoMDDExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="SecondaryWindowReferencesTargetSecondaryWindowBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="SecondaryWindowReferencesTargetSecondaryWindow" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="SecondaryWindow" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="SecondaryWindow" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="EndReferencesButtonBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="EndReferencesButton" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="End" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Button" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="EndReferencesItemBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="EndReferencesItem" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="End" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Item" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="MainWindowReferencesSecondaryWindowBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="MainWindowReferencesSecondaryWindow" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="MainWindow" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="SecondaryWindow" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="e0dfbf46-fe05-408a-a187-aed91d8f6a19" Description="Description for UPM_IPS.RGRLLCAMSProyectoMDD.RGRLLCAMSProyectoMDDDiagram" Name="RGRLLCAMSProyectoMDDDiagram" DisplayName="Minimal Language Diagram" Namespace="UPM_IPS.RGRLLCAMSProyectoMDD" FillColor="LightCyan">
    <Class>
      <DomainClassMoniker Name="Tapiz" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Window" />
        <ParentElementPath>
          <DomainPath>TapizHasWindow.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="MetaforaWindow" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="MainWindow" />
        <ParentElementPath>
          <DomainPath>TapizHasWindow.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="MetaforaMainWindow/nombreDec" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Window/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="MetaforaMainWindow" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="SecondaryWindow" />
        <ParentElementPath>
          <DomainPath>TapizHasWindow.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="MetaforaSecondaryWindow" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Menu" />
        <ParentElementPath>
          <DomainPath>WindowHasMenu.Window/!Window/TapizHasWindow.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="MetaforaMenu/nombreMenu" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Menu/Title" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="MetaforaMenu" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Button" />
        <ParentElementPath>
          <DomainPath>WindowHasButton.Window/!Window/TapizHasWindow.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="MetaforaButton/nombreBoton" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Button/Title" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="MetaforaButton" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Item" />
        <ParentElementPath>
          <DomainPath>MenuHasItem.Menu/!Menu/WindowHasMenu.Window/!Window/TapizHasWindow.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="MetaforaItem/nombreItem" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Item/Title" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="MetaforaItem" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="End" />
        <ParentElementPath>
          <DomainPath>TapizHasEnd.Tapiz/!Tapiz</DomainPath>
        </ParentElementPath>
        <GeometryShapeMoniker Name="MetaforaEnd" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="ConnectorEndItem" />
        <DomainRelationshipMoniker Name="EndReferencesItem" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="ConnectorEndButton" />
        <DomainRelationshipMoniker Name="EndReferencesButton" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="ConnectorMainSecondary" />
        <DomainRelationshipMoniker Name="MainWindowReferencesSecondaryWindow" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="ConnectorSecondarySecondary" />
        <DomainRelationshipMoniker Name="SecondaryWindowReferencesTargetSecondaryWindow" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="RGRLLCAMSProyectoMDD" EditorGuid="88636354-3665-4119-8c25-e47fcd1909c5">
    <RootClass>
      <DomainClassMoniker Name="Tapiz" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="RGRLLCAMSProyectoMDDSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="MainWindow">
      <ElementTool Name="MainWindowTool" ToolboxIcon="Resources\mainwindow.bmp" Caption="MainWindow" Tooltip="Create Main Window" HelpKeyword="MainWindowTool">
        <DomainClassMoniker Name="MainWindow" />
      </ElementTool>
    </ToolboxTab>
    <ToolboxTab TabText="SecondaryWindow">
      <ElementTool Name="SecondaryWindowTool" ToolboxIcon="Resources\newwindow.bmp" Caption="SecondaryWindow" Tooltip="Create Secondary Window " HelpKeyword="SecondaryWindowTool">
        <DomainClassMoniker Name="SecondaryWindow" />
      </ElementTool>
    </ToolboxTab>
    <ToolboxTab TabText="Button">
      <ElementTool Name="ButtonTool" ToolboxIcon="Resources\button.bmp" Caption="Button" Tooltip="Create Button " HelpKeyword="ButtonTool">
        <DomainClassMoniker Name="Button" />
      </ElementTool>
    </ToolboxTab>
    <ToolboxTab TabText="Menu">
      <ElementTool Name="MenuTool" ToolboxIcon="Resources\menu.bmp" Caption="Menu" Tooltip="Create Menu" HelpKeyword="MenuTool">
        <DomainClassMoniker Name="Menu" />
      </ElementTool>
    </ToolboxTab>
    <ToolboxTab TabText="Item">
      <ElementTool Name="ItemTool" ToolboxIcon="Resources\item.bmp" Caption="Item" Tooltip="Create Item " HelpKeyword="ItemTool">
        <DomainClassMoniker Name="Item" />
      </ElementTool>
    </ToolboxTab>
    <ToolboxTab TabText="End">
      <ElementTool Name="EndTool" ToolboxIcon="Resources\end.bmp" Caption="End" Tooltip="Create End " HelpKeyword="EndTool">
        <DomainClassMoniker Name="End" />
      </ElementTool>
    </ToolboxTab>
    <ToolboxTab TabText="Enlace">
      <ConnectionTool Name="EndButton" ToolboxIcon="Resources\flecha.bmp" Caption="EndButton" Tooltip="Create End Button" HelpKeyword="EndButtonTool">
        <ConnectionBuilderMoniker Name="RGRLLCAMSProyectoMDD/EndReferencesButtonBuilder" />
      </ConnectionTool>
      <ConnectionTool Name="EndItem" ToolboxIcon="Resources\flecha.bmp" Caption="EndItem" Tooltip="Create End Item" HelpKeyword="EndItemTool">
        <ConnectionBuilderMoniker Name="RGRLLCAMSProyectoMDD/EndReferencesItemBuilder" />
      </ConnectionTool>
      <ConnectionTool Name="MainSecondary" ToolboxIcon="Resources\flecha.bmp" Caption="MainSecondary" Tooltip="Create Main Secondary" HelpKeyword="MainSecondaryTools">
        <ConnectionBuilderMoniker Name="RGRLLCAMSProyectoMDD/MainWindowReferencesSecondaryWindowBuilder" />
      </ConnectionTool>
      <ConnectionTool Name="SecondarySecondary" ToolboxIcon="Resources\flecha.bmp" Caption="SecondarySecondary" Tooltip="Create Secondary Secondary" HelpKeyword="SecondarySecondaryTools">
        <ConnectionBuilderMoniker Name="RGRLLCAMSProyectoMDD/SecondaryWindowReferencesTargetSecondaryWindowBuilder" />
      </ConnectionTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="RGRLLCAMSProyectoMDDDiagram" />
  </Designer>
  <Explorer ExplorerGuid="6b57b3c7-1236-4bc2-939f-bc5b841ef1b2" Title="RGRLLCAMSProyectoMDD Explorer">
    <ExplorerBehaviorMoniker Name="RGRLLCAMSProyectoMDD/RGRLLCAMSProyectoMDDExplorer" />
  </Explorer>
</Dsl>