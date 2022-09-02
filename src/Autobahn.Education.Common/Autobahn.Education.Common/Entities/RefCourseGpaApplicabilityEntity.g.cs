//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefCourseGpaApplicabilityEntity.g.cs
//* Name:       Course Grade Point Average Applicability
//* Definition: An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
//***************************************************************************

/// <summary>
/// Course Grade Point Average Applicability <see cref="RefCourseGpaApplicability"/>
/// <para>
/// An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19060">Course Grade Point Average Applicability</a>
/// </para>
/// </summary>
[Table("RefCourseGpaApplicability", Schema = "Common")]
[Comment("An indicator of whether or not this course being described is included in the computation of the student's Grade Point Average (GPA).")]
public partial class RefCourseGpaApplicabilityEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefCourseGpaApplicability Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefCourseGpaapplicability property is obsolete and will be removed in a later version")]
    [ForeignKey("RefCourseGpaapplicability")]
    public Guid RefCourseGpaapplicabilityId { get; set; }

    #endregion
}
