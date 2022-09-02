//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AuthorizationDocumentViewModel.cs
//***************************************************************************

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
/// The AuthorizationDocument View Model
/// </summary>
public partial class AuthorizationDocumentViewModel : ObservableValidator, IAuthorizationDocument
{
    #region "AuthorizationDocumentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider serviceProvider;

    /// <summary>
    /// AuthorizationDocumentViewModel Constructor
    /// </summary>
    public AuthorizationDocumentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAuthorizationDocumentViewModelConstruction();
    }

    /// <summary>
    /// AuthorizationDocumentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAuthorizationDocumentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AuthorizationDocument";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AcceptanceIndicator -- (backing property for Authorization Acceptance Indicator)
    private Boolean? acceptanceIndicator;

    // AuthorizationDate -- (backing property for Authorization Date)
    private DateTime? authorizationDate;

    // DecisionExplanation -- (backing property for Authorization Decision Explanation)
    private System.String decisionExplanation;

    #endregion

    #region "IAutobahnBase Properties"
    /// <summary>
    /// The title of the View Model
    /// </summary>
    public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

    /// <summary>
    /// The IsNew property is set if the view model has been created but not saved to the database
    /// </summary>
    public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

    /// <summary>
    /// The IsDeleted property is set if the view model is to be delted from the database
    /// </summary>
    public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

    /// <summary>
    /// The primary key of the view model
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// The view model is changed and needs to be save to the database.
    /// </summary>
    public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

    /// <summary>
    /// The view model is performing a long running task
    /// </summary>
    public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

    /// <summary>
    /// The view model's changes have been save so update its tracking properties
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
    #endregion

    #region "IAuthorizationDocument Properties"
    /// <summary>
    /// Authorization Acceptance Indicator
    /// <para>
    /// Indicates authorizer agreement to a document or plan, such as plan for delivery of student services, program, or improvement plan.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20702">Authorization Acceptance Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Authorization Acceptance Indicator")]
    public Boolean? AcceptanceIndicator { get => acceptanceIndicator; set => SetProperty(ref acceptanceIndicator, value, false); }

    /// <summary>
    /// Authorization Date
    /// <para>
    /// The date the authorization occurred.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20706">Authorization Date</a>
    /// </para>
    /// </summary>
    [DisplayName("Authorization Date")]
    public DateTime? AuthorizationDate { get => authorizationDate; set => SetProperty(ref authorizationDate, value, false); }

    /// <summary>
    /// Authorization Decision Explanation
    /// <para>
    /// Authorizer's explanation regarding the authorization decision.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20703">Authorization Decision Explanation</a>
    /// </para>
    /// </summary>
    [DisplayName("Authorization Decision Explanation")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String DecisionExplanation { get => decisionExplanation; set => SetProperty(ref decisionExplanation, value, true); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Authorizer Type
    /// <para>
    /// Type of person who authorized the decision or document.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20701">Authorizer Type</a>
    /// </para>
    /// </summary>
    [DisplayName("Authorizer Type")]
    public Guid? RefAuthorizerTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAuthorizationDocument model)
    {
        IsBusy = true;
        Id = model.Id;
        AcceptanceIndicator = model.AcceptanceIndicator; // Authorization Acceptance Indicator
        AuthorizationDate = model.AuthorizationDate; // Authorization Date
        DecisionExplanation = model.DecisionExplanation; // Authorization Decision Explanation
        OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
        RefAuthorizerTypeId = model.RefAuthorizerTypeId; // Authorizer Type
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
