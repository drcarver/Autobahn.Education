//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPsstudentProgram.g.cs
//***************************************************************************

/// <summary>
/// The IPsstudentProgram file
/// </summary>
public partial interface IPsstudentProgram
{
    #region "IPsstudentProgram Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPsProgram"/> model
    /// </summary>
    Guid? PsProgramId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCareerCluster"/> model
    /// </summary>
    Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCipUse"/> model
    /// </summary>
    Guid? RefCipUseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTransferOutIndicator"/> model
    /// </summary>
    Guid? RefTransferOutIndicatorId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
    /// </summary>
    Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    #endregion
}
