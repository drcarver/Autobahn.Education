//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefApipInteractionTypeEntity.g.cs
//* Name:       Assessment Item Interaction Type
//* Definition: The assessment item body interaction type as defined by IMS Global specifications.
//***************************************************************************

/// <summary>
/// Assessment Item Interaction Type <see cref="RefApipInteractionType"/>
/// <para>
/// The assessment item body interaction type as defined by IMS Global specifications.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20117">Assessment Item Interaction Type</a>
/// </para>
/// </summary>
[Table("RefApipInteractionType", Schema = "Assessments")]
[Comment("The assessment item body interaction type as defined by IMS Global specifications.")]
public partial class RefApipInteractionTypeEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefApipInteractionType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefApipinteractionType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefApipinteractionType")]
    public Guid RefApipinteractionTypeId { get; set; }

    #endregion
}
