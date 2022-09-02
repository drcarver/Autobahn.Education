//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefElotherFederalFundingSourceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefElotherFederalFundingSource file
/// </summary>
[Table("RefElotherFederalFundingSource", Schema = "Common")]
public partial class RefElotherFederalFundingSourceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefElotherFederalFundingSource Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElotherFederalFundingSources"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefElotherFederalFundingSources property is obsolete and will be removed in a later version")]
    [ForeignKey("RefElotherFederalFundingSources")]
    public Guid RefElotherFederalFundingSourcesId { get; set; }

    #endregion
}
