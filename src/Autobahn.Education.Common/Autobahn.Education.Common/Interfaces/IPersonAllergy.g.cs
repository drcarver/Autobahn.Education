//***************************************************************************
//* DomainName: Common Models
//* FileName:   IPersonAllergy.g.cs
//***************************************************************************

/// <summary>
/// The IPersonAllergy file
/// </summary>
public partial interface IPersonAllergy
{
    #region "IPersonAllergy Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Allergy Reaction Description
    /// <para>
    /// Describes symptoms know to be associated with a person's reaction to an allergen.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20247">Allergy Reaction Description</a>
    /// </para>
    /// </summary>
    System.String ReactionDescription { get; set; }

    /// <summary>
    /// Allergy Severity
    /// <para>
    /// The level of severity of a person's reaction to an allergen.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20248">Allergy Severity</a>
    /// </para>
    /// </summary>
    Guid? RefAllergySeverityId { get; set; }

    /// <summary>
    /// Allergy Type
    /// <para>
    /// Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20249">Allergy Type</a>
    /// </para>
    /// </summary>
    Guid RefAllergyTypeId { get; set; }

    #endregion
}
