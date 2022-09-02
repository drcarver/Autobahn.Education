//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefInstructionalStaffContractLengthEntity.g.cs
//* Name:       Instructional Staff Contract Length
//* Definition: The contracted teaching period for faculty.
//***************************************************************************

/// <summary>
/// Instructional Staff Contract Length <see cref="RefInstructionalStaffContractLength"/>
/// <para>
/// The contracted teaching period for faculty.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19712">Instructional Staff Contract Length</a>
/// </para>
/// </summary>
[Table("RefInstructionalStaffContractLength", Schema = "Common")]
[Comment("The contracted teaching period for faculty.")]
public partial class RefInstructionalStaffContractLengthEntity : ReferenceBaseEntity, IReferenceBase
{
}
