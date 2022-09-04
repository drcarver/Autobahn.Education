//***************************************************************************
//* DomainName: Person Models
//* FileName:   RefPersonStatusTypeEntity.g.cs
//* Name:       Economic Disadvantage Status
//* Definition: An indication that the student met the State criteria for classification as having an economic disadvantage.
//***************************************************************************

/// <summary>
/// Economic Disadvantage Status <see cref="RefPersonStatusType"/>
/// <para>
/// An indication that the student met the State criteria for classification as having an economic disadvantage.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19086">Economic Disadvantage Status</a>
/// </para>
/// </summary>
[Table("RefPersonStatusType", Schema = "Autobahn.Core.Person")]
[Comment("An indication that the student met the State criteria for classification as having an economic disadvantage.")]
public partial class RefPersonStatusTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
