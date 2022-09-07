//***************************************************************************
//* DomainName: Autobahn.Core
//* FileName:   RefStateEntity.cs
//* Name:       State Abbreviation
//* Definition: The abbreviation for the state (within the United States)
//              or outlying area in which an address is located.
//***************************************************************************

/// <summary>
/// State Abbreviation <see cref="RefState"/>
/// <para>
/// The abbreviation for the state (within the United States) or outlying area in which an address is located.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19267">State Abbreviation</a>
/// </para>
/// </summary>
[Table("RefState", Schema = "Common")]
[Comment("The abbreviation for the state (within the United States) or outlying area in which an address is located.")]
public partial class RefStateEntity : ReferenceBaseEntity, IReferenceBase
{
}
