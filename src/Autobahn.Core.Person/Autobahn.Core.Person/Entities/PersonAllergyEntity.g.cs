//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonAllergyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAllergy file
/// </summary>
[Table("PersonAllergy", Schema = "Autobahn.Core.Person")]
public partial class PersonAllergyEntity : EntityBase, IPersonAllergy
{
    #region "IPersonAllergy Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Allergy Reaction Description
    /// <para>
    /// Describes symptoms know to be associated with a person's reaction to an allergen.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20247">Allergy Reaction Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(2000,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("Describes symptoms know to be associated with a person's reaction to an allergen.")]
    public System.String ReactionDescription { get; set; }

    /// <summary>
    /// Allergy Severity
    /// <para>
    /// The level of severity of a person's reaction to an allergen.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20248">Allergy Severity</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAllergySeverity")]
    [Comment("The level of severity of a person's reaction to an allergen.")]
    public Guid? RefAllergySeverityId { get; set; }

    /// <summary>
    /// Allergy Type
    /// <para>
    /// Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20249">Allergy Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefAllergyType")]
    [Comment("Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.")]
    public Guid RefAllergyTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20249">Allergy Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefAllergyTypeEntity RefAllergyTypeEntity { get; set; }

    /// <summary>
    /// The level of severity of a person's reaction to an allergen.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20248">Allergy Severity</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefAllergySeverityEntity? RefAllergySeverityEntity { get; set; }

    #endregion
}
