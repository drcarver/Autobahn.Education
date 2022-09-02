//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityMandateEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityMandate file
/// </summary>
[Table("FacilityMandate", Schema = "Facilities")]
public partial class FacilityMandateEntity : EntityBase, IFacilityMandate
{
    #region "IFacilityMandate Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility State or Local Mandate Name
    /// <para>
    /// The specific law, rule, regulation, or standard of a state or local government that pertains to public school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20787">Facility State or Local Mandate Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The specific law, rule, regulation, or standard of a state or local government that pertains to public school facilities.")]
    public System.String FacilityStateOrLocalMandateName { get; set; }

    /// <summary>
    /// Facilities Mandate Authority Type
    /// <para>
    /// The authority that mandates through law, regulation, or standard that pertains to a specific mandate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20866">Facilities Mandate Authority Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilitiesMandateAuthorityType")]
    [Comment("The authority that mandates through law, regulation, or standard that pertains to a specific mandate.")]
    public Guid? RefFacilitiesMandateAuthorityTypeId { get; set; }

    /// <summary>
    /// Facility Applicable Federal Mandate Type
    /// <para>
    /// The particular federal law, regulation, or standard that pertains to a school facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20777">Facility Applicable Federal Mandate Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityApplicableFederalMandateType")]
    [Comment("The particular federal law, regulation, or standard that pertains to a school facility.")]
    public Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

    /// <summary>
    /// Facility Federal Mandate Interest Type
    /// <para>
    /// The area of interest controlled by a federal law, regulation, or standard that pertains to a school facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20778">Facility Federal Mandate Interest Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityFederalMandateInterestType")]
    [Comment("The area of interest controlled by a federal law, regulation, or standard that pertains to a school facility.")]
    public Guid? RefFacilityFederalMandateInterestTypeId { get; set; }

    /// <summary>
    /// Facility State or Local Mandate Interest Type
    /// <para>
    /// The area of interest controlled by a law, rule, regulation, or standard of state and local governments that pertains to public school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20786">Facility State or Local Mandate Interest Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityStateOrLocalMandateInterestType")]
    [Comment("The area of interest controlled by a law, rule, regulation, or standard of state and local governments that pertains to public school facilities.")]
    public Guid? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> implementation
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual FacilityEntity FacilityEntity { get; set; }

    /// <summary>
    /// The authority that mandates through law, regulation, or standard that pertains to a specific mandate.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20866">Facilities Mandate Authority Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilitiesMandateAuthorityTypeEntity RefFacilitiesMandateAuthorityTypeEntity { get; set; }

    /// <summary>
    /// The particular federal law, regulation, or standard that pertains to a school facility.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20777">Facility Applicable Federal Mandate Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityApplicableFederalMandateTypeEntity RefFacilityApplicableFederalMandateTypeEntity { get; set; }

    /// <summary>
    /// The area of interest controlled by a federal law, regulation, or standard that pertains to a school facility.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20778">Facility Federal Mandate Interest Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityFederalMandateInterestTypeEntity RefFacilityFederalMandateInterestTypeEntity { get; set; }

    /// <summary>
    /// The area of interest controlled by a law, rule, regulation, or standard of state and local governments that pertains to public school facilities.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20786">Facility State or Local Mandate Interest Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Facilities domain
    /// </remarks>
    /// </summary>
    public virtual RefFacilityStateOrLocalMandateInterestTypeEntity RefFacilityStateOrLocalMandateInterestTypeEntity { get; set; }

    #endregion
}
