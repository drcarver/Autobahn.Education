//***************************************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   RefCteNonTraditionalGenderStatusEntity.g.cs
//* Name:       Career Technical Education Nontraditional Gender Status
//* Definition: An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
//***************************************************************************

/// <summary>
/// Career Technical Education Nontraditional Gender Status <see cref="RefCteNonTraditionalGenderStatus"/>
/// <para>
/// An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19581">Career Technical Education Nontraditional Gender Status</a>
/// </para>
/// </summary>
[Table("RefCteNonTraditionalGenderStatus", Schema = "CTE")]
[Comment("An indication of whether CTE participants were members of an underrepresented gender group (where one gender comprises less than 25 percent of the persons employed in those occupations or field of work).")]
public partial class RefCteNonTraditionalGenderStatusEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefCteNonTraditionalGenderStatus Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtenonTraditionalGenderStatus"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefCtenonTraditionalGenderStatus property is obsolete and will be removed in a later version")]
    [ForeignKey("RefCtenonTraditionalGenderStatus")]
    public Guid RefCtenonTraditionalGenderStatusId { get; set; }

    #endregion
}
