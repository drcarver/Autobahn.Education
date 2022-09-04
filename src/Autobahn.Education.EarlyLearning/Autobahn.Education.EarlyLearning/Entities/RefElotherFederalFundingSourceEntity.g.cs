//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   RefElotherFederalFundingSourceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefElotherFederalFundingSource file
/// </summary>
[Table("RefElotherFederalFundingSource", Schema = "EarlyLearning")]
public partial class RefElotherFederalFundingSourceEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefElotherFederalFundingSource Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElotherFederalFundingSources"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefElotherFederalFundingSources")]
    public Guid RefElotherFederalFundingSourcesId { get; set; }

    #endregion
}
