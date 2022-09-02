//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefEarlyChildhoodProgramEnrollmentTypeEntity.g.cs
//* Name:       Early Childhood Program Enrollment Type
//* Definition: The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
//***************************************************************************

/// <summary>
/// Early Childhood Program Enrollment Type <see cref="RefEarlyChildhoodProgramEnrollmentType"/>
/// <para>
/// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
/// </para>
/// </summary>
[Table("RefEarlyChildhoodProgramEnrollmentType", Schema = "EarlyLearning")]
[Comment("The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.")]
public partial class RefEarlyChildhoodProgramEnrollmentTypeEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefEarlyChildhoodProgramEnrollmentType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEarlyChildhoodProgramType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefEarlyChildhoodProgramType property is obsolete and will be removed in a later version")]
    [ForeignKey("RefEarlyChildhoodProgramType")]
    public Guid RefEarlyChildhoodProgramTypeId { get; set; }

    #endregion
}
