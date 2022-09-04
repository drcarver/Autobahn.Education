//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonReferralEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonReferral file
/// </summary>
[Table("PersonReferral", Schema = "Person")]
public partial class PersonReferralEntity : EntityBase, IPersonReferral
{
    #region "IPersonReferral Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Referral Reason
    /// <para>
    /// The reason for the referral.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20455">Referral Reason</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The reason for the referral.")]
    public System.String Reason { get; set; }

    /// <summary>
    /// Referral Date
    /// <para>
    /// The date of referral.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20453">Referral Date</a>
    /// </para>
    /// </summary>
    [Comment("The date of referral.")]
    public DateTime? ReferralDate { get; set; }

    /// <summary>
    /// Referral Type Received
    /// <para>
    /// A type of service that a child or family has received a referral for.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20457">Referral Type Received</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A type of service that a child or family has received a referral for.")]
    public System.String ReferralTypeReceived { get; set; }

    /// <summary>
    /// Referred To
    /// <para>
    /// The program or organization to which the child/family was referred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20458">Referred To</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The program or organization to which the child/family was referred.")]
    public System.String ReferredTo { get; set; }

    /// <summary>
    /// Referral Outcome
    /// <para>
    /// The outcome of the referral.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20454">Referral Outcome</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefReferralOutcome")]
    [Comment("The outcome of the referral.")]
    public Guid? RefReferralOutcomeId { get; set; }

    /// <summary>
    /// Referral Source
    /// <para>
    /// The person, program, or organization making the initial referral.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20456">Referral Source</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The person, program, or organization making the initial referral.")]
    public System.String Source { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The outcome of the referral.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20454">Referral Outcome</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefReferralOutcomeEntity? RefReferralOutcomeEntity { get; set; }

    #endregion
}
