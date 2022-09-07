//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   RefAeStaffEmploymentStatusEntity.g.cs
//* Name:       Adult Education Staff Employment Status
//* Definition: The condition under which a person has agreed to serve as an employee.
//***************************************************************************

/// <summary>
/// Adult Education Staff Employment Status <see cref="RefAeStaffEmploymentStatus"/>
/// <para>
/// The condition under which a person has agreed to serve as an employee.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19771">Adult Education Staff Employment Status</a>
/// </para>
/// </summary>
[Table("RefAeStaffEmploymentStatus", Schema = "AdultEducation")]
[Comment("The condition under which a person has agreed to serve as an employee.")]
public partial class RefAeStaffEmploymentStatusEntity : ReferenceBaseEntity, IReferenceBase
{
}
