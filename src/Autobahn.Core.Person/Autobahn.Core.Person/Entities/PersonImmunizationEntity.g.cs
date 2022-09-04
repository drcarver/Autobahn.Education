//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonImmunizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonImmunization file
/// </summary>
[Table("PersonImmunization", Schema = "Autobahn.Core.Person")]
public partial class PersonImmunizationEntity : EntityBase, IPersonImmunization
{
    #region "IPersonImmunization Properties"
    /// <summary>
    /// Immunization Date
    /// <para>
    /// The year, month and day of an immunization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19306">Immunization Date</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The year, month and day of an immunization.")]
    public System.DateTime ImmunizationDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Immunization Type
    /// <para>
    /// An indication of the type of immunization that an individual has satisfactorily received. (Note: The International Classification of Diseases (ICD) is maintained by the World Health Organization. The ICD is revised periodically to incorporate changes in the medical field, the most updated and detailed list of International Statistical Classification of Diseases and Related Health Problems can be found at http://www.who.int/classifications/apps/icd/icd10online).
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20214">Immunization Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefImmunizationType")]
    [Comment("An indication of the type of immunization that an individual has satisfactorily received. (Note: The International Classification of Diseases (ICD) is maintained by the World Health Organization. The ICD is revised periodically to incorporate changes in the medical field, the most updated and detailed list of International Statistical Classification of Diseases and Related Health Problems can be found at http://www.who.int/classifications/apps/icd/icd10online).")]
    public Guid RefImmunizationTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication of the type of immunization that an individual has satisfactorily received. (Note: The International Classification of Diseases (ICD) is maintained by the World Health Organization. The ICD is revised periodically to incorporate changes in the medical field, the most updated and detailed list of International Statistical Classification of Diseases and Related Health Problems can be found at http://www.who.int/classifications/apps/icd/icd10online).
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20214">Immunization Type</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Autobahn.Core.Person domain
    /// </remarks>
    /// </summary>
    public virtual RefImmunizationTypeEntity RefImmunizationTypeEntity { get; set; }

    #endregion
}
