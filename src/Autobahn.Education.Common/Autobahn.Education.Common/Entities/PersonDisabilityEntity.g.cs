//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDisability file
/// </summary>
[Table("PersonDisability", Schema = "Common")]
public partial class PersonDisabilityEntity : EntityBase, IPersonDisability
{
    #region "IPersonDisability Properties"
    /// <summary>
    /// Disability Status
    /// <para>
    /// An indication of whether a person is classified as disabled under the American's with Disability Act (ADA).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19569">Disability Status</a>
    /// </para>
    /// </summary>
    [Comment("An indication of whether a person is classified as disabled under the American's with Disability Act (ADA).")]
    public Boolean? DisabilityStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Primary Disability Type
    /// <para>
    /// The major or overriding disability condition that best describes a person's impairment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19218">Primary Disability Type</a>
    /// </para>
    /// </summary>
    [Obsolete("The PrimaryDisabilityType property is obsolete and will be removed in a later version")]
    [ForeignKey("PrimaryDisabilityType")]
    [Comment("The major or overriding disability condition that best describes a person's impairment.")]
    public Guid? PrimaryDisabilityTypeId { get; set; }

    /// <summary>
    /// Accommodations Needed Type
    /// <para>
    /// Codes identifying the set of health accommodations.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20243">Accommodations Needed Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAccommodationsNeededType")]
    [Comment("Codes identifying the set of health accommodations.")]
    public Guid? RefAccommodationsNeededTypeId { get; set; }

    /// <summary>
    /// Disability Condition Status Type
    /// <para>
    /// A code indicating the disability condition status.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20285">Disability Condition Status Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDisabilityConditionStatusCode")]
    [Comment("A code indicating the disability condition status.")]
    public Guid? RefDisabilityConditionStatusCodeId { get; set; }

    /// <summary>
    /// Disability Condition Type
    /// <para>
    /// Codes identifying the set of disability conditions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20286">Disability Condition Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDisabilityConditionType")]
    [Comment("Codes identifying the set of disability conditions.")]
    public Guid? RefDisabilityConditionTypeId { get; set; }

    /// <summary>
    /// Disability Determination Source Type
    /// <para>
    /// Codes identifying the set of disability determination sources.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20287">Disability Determination Source Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDisabilityDeterminationSourceType")]
    [Comment("Codes identifying the set of disability determination sources.")]
    public Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefeadisabilityType"/> model
    /// </summary>
    [Obsolete("The RefeadisabilityType property is obsolete and will be removed in a later version")]
    [ForeignKey("RefeadisabilityType")]
    public Guid? RefIdeadisabilityTypeId { get; set; }

    /// <summary>
    /// Significant Cognitive Disability Indicator
    /// <para>
    /// Student has an existing IDEA disability with cognitive impairments which may prevent him/her from attaining grade-level achievement standards.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20746">Significant Cognitive Disability Indicator</a>
    /// </para>
    /// </summary>
    [Comment("Student has an existing IDEA disability with cognitive impairments which may prevent him/her from attaining grade-level achievement standards.")]
    public Boolean? SignificantCognitiveDisabilityIndicator { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Codes identifying the set of health accommodations.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20243">Accommodations Needed Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefAccommodationsNeededTypeEntity RefAccommodationsNeededTypeEntity { get; set; }

    /// <summary>
    /// Codes identifying the set of disability conditions.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20286">Disability Condition Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefDisabilityConditionTypeEntity RefDisabilityConditionTypeEntity { get; set; }

    /// <summary>
    /// Codes identifying the set of disability determination sources.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20287">Disability Determination Source Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefDisabilityDeterminationSourceTypeEntity RefDisabilityDeterminationSourceTypeEntity { get; set; }

    /// <summary>
    /// A code indicating the disability condition status.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20285">Disability Condition Status Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefDisabilityConditionStatusCodeEntity RefDisabilityConditionStatusCodeEntity { get; set; }

    #endregion
}
