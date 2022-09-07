//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonAllergyEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAllergy file
/// </summary>
public partial class PersonAllergyModel : AutobahnBaseModel, IPersonAllergy
{
    #region "IPersonAllergy Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
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
    public Guid RefAllergyTypeId { get; set; }

    #endregion
}
