//***************************************************************************
//* DomainName: Organization Models
//* FileName:   RefCharterSchoolManagementOrganizationTypeEntity.g.cs
//* Name:       Charter School Management Organization Type
//* Definition: The type of organization that is a separate legal entity that 1) contracts with one or more charter schools to manage, operate, and oversee the charter schools; or 2) holds a charter, or charters, to operate multiple charter schools.
//***************************************************************************

/// <summary>
/// Charter School Management Organization Type <see cref="RefCharterSchoolManagementOrganizationType"/>
/// <para>
/// The type of organization that is a separate legal entity that 1) contracts with one or more charter schools to manage, operate, and oversee the charter schools; or 2) holds a charter, or charters, to operate multiple charter schools.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20631">Charter School Management Organization Type</a>
/// </para>
/// </summary>
[Table("RefCharterSchoolManagementOrganizationType", Schema = "Autobahn.Core.Organization")]
[Comment("The type of organization that is a separate legal entity that 1) contracts with one or more charter schools to manage, operate, and oversee the charter schools; or 2) holds a charter, or charters, to operate multiple charter schools.")]
public partial class RefCharterSchoolManagementOrganizationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
