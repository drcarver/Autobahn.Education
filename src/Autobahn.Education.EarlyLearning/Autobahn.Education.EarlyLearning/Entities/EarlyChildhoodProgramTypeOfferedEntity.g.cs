//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IEarlyChildhoodProgramTypeOffered file
/// </summary>
[Table("EarlyChildhoodProgramTypeOffered", Schema = "EarlyLearning")]
public partial class EarlyChildhoodProgramTypeOfferedEntity : EntityBase, IEarlyChildhoodProgramTypeOffered
{
    #region "IEarlyChildhoodProgramTypeOffered Properties"
    /// <summary>
    /// Inclusive Setting Indicator
    /// <para>
    /// Indicates that services are provided to the child in a place where children of all abilities learn together.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Indicates that services are provided to the child in a place where children of all abilities learn together.")]
    public Boolean? InclusiveSettingIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Community-based Type
    /// <para>
    /// Non domestic residence in which the early learning setting is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20614">Community-based Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCommunityBasedType")]
    [Comment("Non domestic residence in which the early learning setting is located.")]
    public Guid? RefCommunityBasedTypeId { get; set; }

    /// <summary>
    /// Early Childhood Program Enrollment Type
    /// <para>
    /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefEarlyChildhoodProgramEnrollmentType")]
    [Comment("The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.")]
    public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefEarlyChildhoodProgramEnrollmentTypeEntity RefEarlyChildhoodProgramEnrollmentTypeEntity { get; set; }

    /// <summary>
    /// Non domestic residence in which the early learning setting is located.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20614">Community-based Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefCommunityBasedTypeEntity? RefCommunityBasedTypeEntity { get; set; }

    #endregion
}
