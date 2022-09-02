//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCharterSchoolAuthorizerTypeEntity.g.cs
//* Name:       Charter School Authorizer Type
//* Definition: The type of agency that authorized the establishment or continuation of a charter school.
//***************************************************************************

/// <summary>
/// Charter School Authorizer Type <see cref="RefCharterSchoolAuthorizerType"/>
/// <para>
/// The type of agency that authorized the establishment or continuation of a charter school.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20258">Charter School Authorizer Type</a>
/// </para>
/// </summary>
[Table("RefCharterSchoolAuthorizerType", Schema = "Common")]
[Comment("The type of agency that authorized the establishment or continuation of a charter school.")]
public partial class RefCharterSchoolAuthorizerTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
