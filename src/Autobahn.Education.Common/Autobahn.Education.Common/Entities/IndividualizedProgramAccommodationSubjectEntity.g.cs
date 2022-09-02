//***************************************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAccommodationSubjectEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIndividualizedProgramAccommodationSubject file
/// </summary>
[Table("IndividualizedProgramAccommodationSubject", Schema = "Common")]
public partial class IndividualizedProgramAccommodationSubjectEntity : EntityBase, IIndividualizedProgramAccommodationSubject
{
    #region "IIndividualizedProgramAccommodationSubject Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramAccommodation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("IndividualizedProgramAccommodation")]
    public Guid IndividualizedProgramAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefScedcourseSubjectArea")]
    public Guid RefScedcourseSubjectAreaId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IIndividualizedProgramAccommodation"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual IndividualizedProgramAccommodationEntity IndividualizedProgramAccommodationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefScedcourseSubjectArea"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefScedcourseSubjectAreaEntity RefScedcourseSubjectAreaEntity { get; set; }

    #endregion
}
