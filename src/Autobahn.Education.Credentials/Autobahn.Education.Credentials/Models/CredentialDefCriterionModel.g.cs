//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCriterionEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefCriterion file
/// </summary>
public partial class CredentialDefCriterionModel : AutobahnBaseModel, ICredentialDefCriterion
{
    #region "ICredentialDefCriterion Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    public Guid? CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
    /// </summary>
    public Guid CredentialDefCriteriaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    public Guid CredentialDefinitionId { get; set; }

    public System.String Criteria { get; set; }

    public System.String CriteriaUrl { get; set; }

    public System.String EstimatedDuration { get; set; }

    public System.String MaximumDuration { get; set; }

    public Int32? MinimumAge { get; set; }

    public System.String MinimumDuration { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCredentialDefAssessMethodType"/> model
    /// </summary>
    public Guid? RefCredentialDefAssessMethodTypeId { get; set; }

    #endregion
}
