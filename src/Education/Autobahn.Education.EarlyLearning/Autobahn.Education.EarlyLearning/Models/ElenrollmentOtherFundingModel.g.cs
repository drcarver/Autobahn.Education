//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElenrollmentOtherFundingEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElenrollmentOtherFunding file
/// </summary>
public partial class ElenrollmentOtherFundingModel : AutobahnBaseModel, IElenrollmentOtherFunding
{
    #region "IElenrollmentOtherFunding Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElotherFederalFundingSources"/> model
    /// </summary>
    public Guid RefElotherFederalFundingSourcesId { get; set; }

    #endregion
}
