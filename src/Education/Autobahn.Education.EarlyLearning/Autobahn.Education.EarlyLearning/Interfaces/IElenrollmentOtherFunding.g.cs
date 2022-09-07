//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElenrollmentOtherFunding.g.cs
//***************************************************************************

/// <summary>
/// The IElenrollmentOtherFunding file
/// </summary>
public partial interface IElenrollmentOtherFunding
{
    #region "IElenrollmentOtherFunding Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElotherFederalFundingSources"/> model
    /// </summary>
    Guid RefElotherFederalFundingSourcesId { get; set; }

    #endregion
}
