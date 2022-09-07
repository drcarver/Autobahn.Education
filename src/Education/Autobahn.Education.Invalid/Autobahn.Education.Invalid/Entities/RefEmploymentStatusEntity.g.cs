//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefEmploymentStatusEntity.g.cs
//* Name:       Employment Status
//* Definition: The condition under which a person has agreed to serve as an employee.
//***************************************************************************

/// <summary>
/// Employment Status <see cref="RefEmploymentStatus"/>
/// <para>
/// The condition under which a person has agreed to serve as an employee.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19346">Employment Status</a>
/// </para>
/// </summary>
[Table("RefEmploymentStatus", Schema = "Invalid")]
[Comment("The condition under which a person has agreed to serve as an employee.")]
public partial class RefEmploymentStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
